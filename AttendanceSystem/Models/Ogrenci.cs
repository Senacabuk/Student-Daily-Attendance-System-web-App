using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace projev2.Models
{
    public class Ogrenci
    {
        [Key]
        public int studentID { get; set; }
        public String studentName { get; set; }
        
    }
}