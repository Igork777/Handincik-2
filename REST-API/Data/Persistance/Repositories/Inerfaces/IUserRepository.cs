using System.Collections;
using System.Collections.Generic;
using Exercise1.Models;

namespace Hand_In_2.Data.Persistance
{
    public interface IUserRepository
    {
        User logInUser(string userName, string password);
        IList<User> getAllUsers();
        void RegisterUser(User user);
    }
}