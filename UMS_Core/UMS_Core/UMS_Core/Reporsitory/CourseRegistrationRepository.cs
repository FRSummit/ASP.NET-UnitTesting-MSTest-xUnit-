using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UMS_Core.Data;
using UMS_Core.Models;

namespace UMS_Core.Reporsitory
{
    public class CourseRegistrationRepository : ICourseRegistrationReporsitory
    {
        private readonly StudentContext _context;

        public CourseRegistrationRepository(StudentContext context)
        {
            _context = context;
        }
        async Task<List<CourseRegistration>> ICourseRegistrationReporsitory.GetRegisterdStudents()
        {
            return await _context.CourseRegistration.ToListAsync();
        }

        public CourseRegistration getRegisteredStudentByID(int stdID)
        {
            CourseRegistration students = _context.CourseRegistration.Where(o => o.Id == stdID).SingleOrDefault();
            return students;
        }

        public void UpdateRegisteredStudent(int stdID)
        {
            CourseRegistration students = _context.CourseRegistration.Where(o => o.Id == stdID).SingleOrDefault();
            _context.Update(students);
        }

        
    }
}
