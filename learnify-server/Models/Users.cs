using System;
using System.ComponentModel.DataAnnotations;

namespace learnify.Models
{
    public class User
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string? Role { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }

    }
}