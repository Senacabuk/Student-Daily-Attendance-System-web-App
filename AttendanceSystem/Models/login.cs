using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace projev2.Models
{
    public class login
    {
        public type LoginType { get; set; }

        [Required(ErrorMessage ="Username is required")]
        [Key]
        public string username { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string password { get; set; } 
    
    }

    
    public enum type 
        {
           Teacher,
            Student
        }
    
}