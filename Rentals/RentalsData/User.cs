using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalsData
{
    [Table("Users")] // table cannot be named User
    public class User
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter a username.")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Please enter a password.")]
        
        public string Password { get; set; }
        public string FullName { get; set; }
        public string Role { get; set; }

        //relatvant for users who are owners
        public int? OwnerId { get; set; }
        public Owner Owner { get; set; } //navigation property
    }
}
