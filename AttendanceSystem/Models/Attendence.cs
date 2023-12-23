using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace projev2.Models
{
    public class Attendence
    {
        public int attendenceId { get; set; }
        public int studentId { get; set; }
        public int courseId { get; set; }
        public string semester { get; set; }
        public string date { get; set; }
    }
}