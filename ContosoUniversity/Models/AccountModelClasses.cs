using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace ContosoUniversity.Models
{
    public class UsersContext : DbContext
    {
        public UsersContext() : base("SchoolContext")
        {
        }

        public class Login
        {
            [Required] 
            [Display(Name = "User name")]
            public string UserName { get; set; }

            [Required]
            [DataType(DataType.Password)]
            public string Password { get; set; }

            [Display(Name="Remember me?")]
            public bool RememberMe { get; set; }
        }

        public class Register
        {
            [Required]
            [Display(Name = "Username")]
            public string UserName { get; set; }

            [Required]
            [DataType(DataType.Password)]
            public string Password { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Confirm Password?")]
            [Compare("Password", ErrorMessage = "Password do not match.")]
            public string ConfirmPassword { get; set; }
        }

        
    }
}