using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using WebApplication1.Models;

namespace WebApplication1.Test_MSTest_
{
    [TestClass]
    public class StudentTest
    {
        [TestMethod]
        public void addition()
        {
            int expected = 10;
            int actual = Controllers.StudentController.add(5, 5);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void getNameTest()
        {
            String name = "Hello";
            String s = Controllers.StudentController.getName();
            Console.WriteLine(s);
            Assert.IsTrue(name == s ? true : false);
        }

        [TestMethod]
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
