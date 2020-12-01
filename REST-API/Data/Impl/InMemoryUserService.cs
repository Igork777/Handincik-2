using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Exercise1.Models;
using Hand_In_2.Data.Persistance;

namespace Hand_In_2.Data.Impl
{
    public class InMemoryUserService : IUserService
    {
        private UnitOfWork _unitOfWork;

        public InMemoryUserService(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

     

        public async Task<User> LogInUser(string userName, string password)
        {
            User first = _unitOfWork.UserRepo.logInUser(userName, password);
            _unitOfWork.Save();
            if (first == null)
            {
                throw new Exception("User not found");
            }

            if (!first.Password.Equals(password))
            {
                throw new Exception("Incorrect password");
            }

            return first;
        }

        public async Task<User> RegisterUser(User user)
        {
            Regex userNameAndCityRegex = new Regex(@"^[a-zA-Z ]+$"),
                passwordRegex = new Regex(@"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,}$");

            if (!userNameAndCityRegex.IsMatch(user.UserName))
            {
                throw new Exception("Username should contain only latin letters or spaces. Registration failed");
            }

            if (!userNameAndCityRegex.IsMatch(user.City))
            {
                throw new Exception("City should contain only latin letters or spaces. Registration failed");
            }

            if (!passwordRegex.IsMatch(user.Password))
            {
                throw new Exception(
                    "The password must be at least 8 characters, at least one letter, one number and one special character. Registration failed");
            }
            
           

            IList<User> users = _unitOfWork.UserRepo.getAllUsers();
            _unitOfWork.Save();
             if (users.FirstOrDefault(x => x.UserName.Equals(user.UserName)) != null)
            {
                throw new Exception("User " + user.UserName + " already exists");
            }

             _unitOfWork.UserRepo.RegisterUser(user);
             _unitOfWork.Save();
            return user;
        }
    }
}