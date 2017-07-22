using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace StudentApp.Models
{
    public class Student
    {
        [Key]
        public int id { get; set; }
        public string StudName { get; set; }
        public string Address { get; set; }
        public int Phone { get; set; }
        public string Standard { get; set; }
    }
}