using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UMS.Models;

namespace UMS_Core.Models
{
    public class CourseRegistration
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int DepartmentId { get; set; }
        public int FacultyId { get; set; }
        public int CourseId { get; set; }
    }
}
