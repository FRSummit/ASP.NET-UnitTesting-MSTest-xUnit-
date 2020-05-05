using System;
using System.ComponentModel.DataAnnotations;
using UMS.Models;

namespace UMS_Core.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Email { get; set; }
        public String Phone { get; set; }
        public String Address { get; set; }
        //public Course CourseId { get; set; }
        //public Faculty FacultyId { get; set; }
        //public Department DepartmentId { get; set; }
    }
}
