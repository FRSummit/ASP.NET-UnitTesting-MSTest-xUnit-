using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class StudentController : Controller
    {
        //public List<Student> Index()
        public Student Index()
        {
            List<Student> studentList = new List<Student>();
            //Student student = new Student(071, "FRSummit", "Mymensingh", "frsummit@gmail.com", "01687858300");
            Student student = new Student();
            student.Id = 071;
            student.Name = "FRSummit";
            student.Address = "Mymensingh";
            student.Email = "frsummit@gmail.com";
            student.Phone = "01687858300";
            studentList.Add(student);
            Debug.WriteLine("Hellooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooo");
            //return studentList;
            Debug.WriteLine(student.Name);
            return student;
        }

        public static int add(int i, int j)
        {
            return i + j;
        }

        public static String getName()
        {
            Student student = new Student(071, "FRSummit", "Mymensingh", "frsummit@gmail.com", "01687858300");
            //return student.Name;
            return "Hello";
        }

        public static Student student()
        {
            Student student = new Student();
            student.Id = 071;
            student.Name = "FRSummit";
            student.Address = "Mymensingh";
            student.Email = "frsummit@gmail.com";
            student.Phone = "01687858300";
            return student;
        }
    }
}