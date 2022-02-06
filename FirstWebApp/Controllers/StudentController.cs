using System.Collections.Generic;
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
            return View(studentsList);
        }

        public ActionResult GetDetails(int? id)
        {
            List<Student> studentsList = new List<Student>() {
                new Student() {StudentId = 1, StudentName ="omair", StudentMarks = 70},
                new Student() {StudentId = 2, StudentName ="arqum", StudentMarks = 40},
                new Student() {StudentId = 3, StudentName ="asif", StudentMarks = 80}
            };

            Student stud = null;

            foreach(var student in studentsList)
            {
                if(student.StudentId == id)
                {
                    stud = student;
                }
            }

            return View(stud);
        }
    }
}