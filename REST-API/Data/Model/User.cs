﻿using System.ComponentModel.DataAnnotations;
 using System.ComponentModel.DataAnnotations.Schema;
 using System.Diagnostics.CodeAnalysis;

 namespace Exercise1.Models
{
    public class User
    {
        public static string Path { get; set; }

        static User()
        {
            Path = "users.json";
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }
        
        [Required, MinLength(3), NotNull]
        public string UserName { get; set; }
        [Required, NotNull]
        public string City { get; set; }
        [Required, NotNull]
        public string Password { get; set; }

    }
}