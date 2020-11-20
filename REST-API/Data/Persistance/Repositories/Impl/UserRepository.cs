using System.Collections.Generic;
using System.Linq;
using Exercise1.Models;

namespace Hand_In_2.Data.Persistance
{
    public class UserRepository :IUserRepository
    {
        private ExampleDBContext _applicationContext;

        public UserRepository(ExampleDBContext applicationContext)
        {
            _applicationContext = applicationContext;
        }

        public User logInUser(string userName, string password)
        {
            User user = _applicationContext.User.FirstOrDefault(n => n.UserName.Equals(userName) && n.Password.Equals(password));
            _applicationContext.SaveChanges();
            return user;
        }

        public IList<User> getAllUsers()
        {
          IList<User> users = _applicationContext.User.ToList();
          _applicationContext.SaveChanges();
          return users;
        }

        public void RegisterUser(User user)
        {
            _applicationContext.User.Add(user);
            _applicationContext.SaveChanges();
        }
    }
}