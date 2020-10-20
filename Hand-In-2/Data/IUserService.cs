using Exercise1.Models;

namespace Hand_In_2.Data
{
    public interface IUserService
    {
        User LogInUser(string userName, string password);
        User RegisterUser(string userName, string city, string password);
    }
}