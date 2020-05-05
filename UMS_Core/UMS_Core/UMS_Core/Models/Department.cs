using System;
using System.ComponentModel.DataAnnotations;

namespace UMS.Models
{
    public class Department
    {
        [Key]
        public int Id { get; set; }
        public String Name { get; set; }
    }
}
