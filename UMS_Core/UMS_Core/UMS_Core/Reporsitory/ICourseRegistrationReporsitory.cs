using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UMS_Core.Models;

namespace UMS_Core.Reporsitory
{
    public interface ICourseRegistrationReporsitory
    {
        Task<List<CourseRegistration>> GetRegisterdStudents();
        CourseRegistration getRegisteredStudentByID(int stdID);
        void UpdateRegisteredStudent(int stdID);

    }
}
