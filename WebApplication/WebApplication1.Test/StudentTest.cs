using System;
using WebApplication1.Models;
using Xunit;

namespace WebApplication1.Test
{
    public class StudentTest
    {
        [Fact]
        public void addition()
        {
            int expected = 10;
            int actual = WebApplication1.Controllers.StudentController.add(5, 5);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void getNameTest()
        {
            String name = "Hello";
            String s = Controllers.StudentController.getName();
            Console.WriteLine(s);
            Assert.True(name == s ? true : false);
        }

        [Fact]
        public void getStudent()
        {
            Student student = new Student();
            student.Id = 071;
            student.Name = "FRSummit";
            student.Address = "Mymensingh";
            student.Email = "frsummit@gmail.com";
            student.Phone = "01687858300";
            //Student student = new Student(071, "FRSummit", "Mymensingh", "frsummit@gmail.com", "01687858300");

            Student s = Controllers.StudentController.student();
            int id = student.Id;
            int idA = s.Id;

            bool flag = student == s ? true : false;
            Console.WriteLine(student.Id);
            Console.WriteLine(s.Id);
            Console.WriteLine(flag);
            //Assert.IsFalse(flag2);
        }
    }
}
