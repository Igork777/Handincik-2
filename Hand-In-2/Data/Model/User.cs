﻿namespace Exercise1.Models
{
    public class User
    {
        public string Path { get; set; }

        public User()
        {
            Path = "users.json";
        }

        public int UserId { get; set; }
        
        public string UserName { get; set; }
        public string City { get; set; }
        public string Password { get; set; }

    }
}