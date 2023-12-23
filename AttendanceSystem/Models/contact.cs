using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace projev2.Models
{
    public class contact
    {
        [Required(ErrorMessage ="Please enter your name")]
        public string Name { set; get; }

        [Required(ErrorMessage = "Please enter your surname")]
        public string SurName { set; get; }
        [Required(ErrorMessage = "Please enter your mail address")]
        [RegularExpression(".+\\@.+\\..+",ErrorMessage ="Please enter a correct address")]
        public string Email{ set; get; }
        public string Tel { set; get; }
        [Required(ErrorMessage = "Please enter subject")]
        public string Subject { set; get; }
        [Required(ErrorMessage = "Please enter your message")]
        public string Message { set; get; }




    }
}