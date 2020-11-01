﻿namespace Exercise1.Models
{
    public class User
    {
        public static string Path { get; set; }

        static User()
        {
            Path = "users.json";
        }

        public int UserId { get; set; }
        
        public string UserName { get; set; }
        public string City { get; set; }
        public string Password { get; set; }

    }
}