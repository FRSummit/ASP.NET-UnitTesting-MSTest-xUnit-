using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using UMS.Models;
using UMS_Core.Data;
using UMS_Core.Models;
using UMS_Core.Reporsitory;

namespace UMS_Core.Controllers
{
    public class CourseRegistrationsController : Controller
    {
        private readonly StudentContext _context;
        private readonly ICourseRegistrationReporsitory _repository;

        public CourseRegistrationsController(ICourseRegistrationReporsitory reporsitory, StudentContext context)
        {
            _repository = reporsitory;
            _context = context;
        }

        // GET: CourseRegistrations
        public async Task<IActionResult> Index()
        {
            return View(await _repository.GetRegisterdStudents());
        }

        // GET: CourseRegistrations/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var courseRegistration = await _context.CourseRegistration
                .FirstOrDefaultAsync(m => m.Id == id);
            if (courseRegistration == null)
            {
                return NotFound();
            }

            return View(courseRegistration);
        }

        // GET: CourseRegistrations/Create
        public IActionResult Create()
        {
            List<Student> student = new List<Student>();
            student = (from students in _context.Student select students).ToList();
            ViewBag.Student = student;
            Debug.WriteLine(student[0].FirstName);

            List<Department> dept = new List<Department>();
            dept = (from department in _context.Department select department).ToList();
            ViewBag.Department = dept;

            List<Course> course = new List<Course>();
            course = (from courses in _context.Course select courses).ToList();
            ViewBag.Course = course;

            List<Faculty> faculty = new List<Faculty>();
            faculty = (from faculties in _context.Faculty select faculties).ToList();
            ViewBag.Faculty = faculty;
            Debug.WriteLine("Hellooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooo");

            return View();
        }

        // POST: CourseRegistrations/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,StudentId,DepartmentId,FacultyId,CourseId")] CourseRegistration courseRegistration)
        {
            if (ModelState.IsValid)
            {
                _context.Add(courseRegistration);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(courseRegistration);
        }

        // GET: CourseRegistrations/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var courseRegistration = await _context.CourseRegistration.FindAsync(id);
            if (courseRegistration == null)
            {
                return NotFound();
            }
            return View(courseRegistration);
        }

        // POST: CourseRegistrations/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,StudentId,DepartmentId,FacultyId,CourseId")] CourseRegistration courseRegistration)
        {
            if (id != courseRegistration.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(courseRegistration);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CourseRegistrationExists(courseRegistration.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(courseRegistration);
        }

        // GET: CourseRegistrations/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var courseRegistration = await _context.CourseRegistration
                .FirstOrDefaultAsync(m => m.Id == id);
            if (courseRegistration == null)
            {
                return NotFound();
            }

            return View(courseRegistration);
        }

        // POST: CourseRegistrations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var courseRegistration = await _context.CourseRegistration.FindAsync(id);
            _context.CourseRegistration.Remove(courseRegistration);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CourseRegistrationExists(int id)
        {
            return _context.CourseRegistration.Any(e => e.Id == id);
        }
    }
}
