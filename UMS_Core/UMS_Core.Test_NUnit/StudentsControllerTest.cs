using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using UMS_Core.Controllers;
using UMS_Core.Data;
using UMS_Core.Models;
using UMS_Core.Reporsitory;

namespace UMS_Core.Test_NUnit
{
    public class StudentsControllerTest
    {
        private readonly ICourseRegistrationReporsitory _repository;

        public StudentsControllerTest(ICourseRegistrationReporsitory reporsitory)
        {
            _repository = reporsitory;
        }
        private StudentContext studentContext;
        StudentsController studentController;
        [SetUp]
        public void Setup()
        {
            studentController = new StudentsController(studentContext);
            //Debug.WriteLine(ans);
            //Console.WriteLine(ans);
        }

        [Test]
        public void getDetails()
        {
            List<Student> students = new List<Student>();
            Student student = new Student();
            student.Id = 071;
            student.FirstName = "Abdur";
            student.LastName = "Rahman";
            student.Email = "ar@gmail.com";
            student.Phone = "01717627896";
            student.Address = "Fulbaria, Mymensingh";
            students.Add(student);
            Student student1 = new Student();
            student1.Id = 072;
            student1.FirstName = "dsfds";
            student1.LastName = "Rahfdsman";
            student1.Email = "ar@gmail.com";
            student1.Phone = "01717627896";
            student1.Address = "Fulbaria, Mymensingh";
            students.Add(student1);


            var courses = _repository.GetRegisterdStudents();
            Assert.courses

        }
    }
}