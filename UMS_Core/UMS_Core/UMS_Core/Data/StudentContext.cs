using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UMS_Core.Models;
using UMS.Models;

namespace UMS_Core.Data
{
    public class StudentContext : DbContext
    {
        public StudentContext (DbContextOptions<StudentContext> options)
            : base(options)
        {
        }

        public DbSet<UMS_Core.Models.Student> Student { get; set; }

        public DbSet<UMS.Models.Course> Course { get; set; }

        public DbSet<UMS.Models.Department> Department { get; set; }

        public DbSet<UMS.Models.Faculty> Faculty { get; set; }

        public DbSet<UMS_Core.Models.CourseRegistration> CourseRegistration { get; set; }
    }
}
