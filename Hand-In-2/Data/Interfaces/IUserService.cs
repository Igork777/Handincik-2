using System.Collections.Generic;
using System.Threading.Tasks;
using Exercise1.Models;

namespace Hand_In_2.Data
{
    public interface IUserService
    {
       Task<User> LogInUser(string userName, string password);
        Task<User> RegisterUser(string userName, string city, string password);
    }
}