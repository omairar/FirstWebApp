using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FirstWebApp.Models;

namespace FirstWebApp.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            List<Student> studentsList = new List<Student>() {
                new Student() {StudentId = 1, StudentName ="omair", StudentMarks = 70},
                new Student() {StudentId = 2, StudentName ="arqum", StudentMarks = 40},
                new Student() {StudentId = 3, StudentName ="asif", StudentMarks = 80}
            };

            ViewBag.studentsL = studentsList;
            return View();
        }
    }
}