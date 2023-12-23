using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace projev2.Models
{
    public class Yoklama
    {
        [Key]
        public int attendenceID { get; set; }
        [Required]
        [ForeignKey("Ogrenci")]
        public int studentID { get; set; }
        public string tarih { get; set; }
        public type durum { get ;set;}
    }
    public enum durum
    {
        absent,
        exist,
        late
    }
}