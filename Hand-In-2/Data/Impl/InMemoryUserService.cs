using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.RegularExpressions;
using Exercise1.Models;
using Hand_In_2.Data.Persistance;

namespace Hand_In_2.Data.Impl
{
    public class InMemoryUserService : IUserService
    {
        private IReadAndWriteData<User> _readAndWriteData;
        private IList<User> users;

        public InMemoryUserService(IReadAndWriteData<User> readAndWriteData)
        {
            _readAndWriteData = readAndWriteData;
            users = _readAndWriteData.ReadData();
        }

        private void WriteToFile()
        {
            string json = JsonSerializer.Serialize(users);
            _readAndWriteData.SaveChanges(json);
            users = _readAndWriteData.ReadData();
        }

        public User LogInUser(string userName, string password)
        {
            User first = users.FirstOrDefault(user => user.UserName.Equals(userName));
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

        public User RegisterUser(string userName, string city, string password)
        {
            Regex userNameAndCityRegex = new Regex(@"^[a-zA-Z ]+$"),
                passwordRegex = new Regex(@"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,}$");

            if (!userNameAndCityRegex.IsMatch(userName))
            {
                throw new Exception("Username should contain only latin letters or spaces. Registration failed");
            }

            if (!userNameAndCityRegex.IsMatch(city))
            {
                throw new Exception("City should contain only latin letters or spaces. Registration failed");
            }

            if (!passwordRegex.IsMatch(password))
            {
                throw new Exception(
                    "The password must be at least 8 characters, at least one letter, one number and one special character. Registration failed");
            }

            User user = new User {UserName = userName, City = city, Password = password};
            if (users == null)
            {
                users = new List<User>();
                user.UserId = 0;
            }
            else if (users.FirstOrDefault(x => x.UserName.Equals(user.UserName)) != null)
            {
                throw new Exception("User " + user.UserName + " already exists");
            }
            else
            {
                user.UserId = users.Count;
            }

            users.Add(user);
            WriteToFile();
            return user;
        }
    }
}