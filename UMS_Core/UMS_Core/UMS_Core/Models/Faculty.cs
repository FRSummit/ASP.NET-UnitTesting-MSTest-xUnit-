using System;
using System.ComponentModel.DataAnnotations;

namespace UMS.Models
{
    public class Faculty
    {
        [Key]
        public int Id { get; set; }
        public String Name { get; set; }
        public String Designation { get; set; }
    }
}
