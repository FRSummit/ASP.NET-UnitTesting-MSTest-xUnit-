using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
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
        public Address PresentAddress { get; set; }
        public Address PermanentAddress { get; set; }
        public Faculty FacultyId { get; set; }
        public Department DepartmentId { get; set; }
        public Course CourseId { get; set; }
    }
}
