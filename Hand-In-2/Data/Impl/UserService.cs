using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Exercise1.Models;
using Microsoft.AspNetCore.Components;

namespace Hand_In_2.Data.Impl
{
    public class UserService : IUserService
    {
        private HttpClient _httpClient;
        public UserService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<User> LogInUser(string userName, string password)
        {
            return await _httpClient.GetJsonAsync<User>("Users/?username=" + userName + "&password=" + password);
        }

        public async Task<User> RegisterUser(string userName, string city, string password)
        {
            User user = new User {UserName = userName, City = city, Password = password};
            string userSerialized = JsonSerializer.Serialize(user);
            StringContent content = new StringContent(userSerialized, Encoding.UTF8, "application/json");
            try
            {
                HttpResponseMessage responseMessage = await _httpClient.PostAsync("Users", content);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return user;
        }
    }
}