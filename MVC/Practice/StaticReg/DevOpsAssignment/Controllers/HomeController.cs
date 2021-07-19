using DevOpsAssignment.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DevOpsAssignment.Controllers
{
    public class HomeController : Controller
    {
        Random r = new Random();
        
        static IList<StudentModel> studentList = new List<StudentModel> {
           new StudentModel() {StudnetId=1,StudentRoll="123", StudentName="Student 1",StudentEmail="xy1@gmail.com",StudentBatch="CSE",StudentCourse="B-Tech" },
           new StudentModel() {StudnetId=2,StudentRoll="124", StudentName="Student 2",StudentEmail="xy2@gmail.com",StudentBatch="CSE",StudentCourse="B-Tech" },
           new StudentModel() {StudnetId=3,StudentRoll="125", StudentName="Student 3",StudentEmail="xy3@gmail.com",StudentBatch="CSE",StudentCourse="B-Tech" },
           new StudentModel() {StudnetId=4,StudentRoll="126", StudentName="Student 4",StudentEmail="xy4@gmail.com",StudentBatch="CSE",StudentCourse="B-Tech" },

        };


        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(StudentModel student)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    TempData["successMesg"] = "Data Addes succesfully";

                    int genRand = r.Next(5, 500);
                    studentList.Add(
                        new StudentModel() { StudnetId = genRand, StudentRoll = student.StudentRoll, StudentName = student.StudentName, StudentEmail = student.StudentEmail, StudentBatch = student.StudentBatch, StudentCourse = student.StudentCourse }
                        );
                    return RedirectToAction("ViewList");
                }
                else
                {
                    return View();
                }

            }catch(Exception e)
            {
                TempData["errMsg"] = "Something Went Wrong";
                return RedirectToAction("ViewList");
            }

        }

        public IActionResult ViewList()
        {
            return View(studentList);
        }

        public IActionResult Edit(int id)
        {
            foreach(var student in studentList.ToList())
            {
                if (student.StudnetId == id)
                {
                    return View(student);
                }
            }
            return RedirectToAction("ViewList");
        }

        [HttpPost]
        public IActionResult Edit(StudentModel tempStudent)
        {
            foreach (StudentModel student in studentList.ToList())
            {
                if (student.StudnetId == tempStudent.StudnetId)
                {
                    /* studentList.Remove(student);
                     studentList.Add(tempStudent);*/

                    student.StudentRoll = tempStudent.StudentRoll;
                    student.StudentName = tempStudent.StudentName;
                    student.StudentEmail = tempStudent.StudentEmail;
                    student.StudentBatch = tempStudent.StudentBatch;
                    student.StudentCourse = tempStudent.StudentCourse;

                }
                else
                {
                    continue;
                }
            }
            return RedirectToAction("ViewList");
        }


        public IActionResult Delete(int id)
        {
            int index = 0;
            foreach (var student in studentList.ToList())
            {
                index++;
                if (student.StudnetId == id)
                {
                    studentList.Remove(student);
                    index++;
                }
                else
                {
                    continue;
                }
            }
            return RedirectToAction("ViewList");
        }


        public IActionResult Details(int id)
        {

            foreach (var student in studentList.ToList())
            {
                if (student.StudnetId == id)
                {
                    return View(student);
                }
            }
            return RedirectToAction("ViewList");
            
        }




        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
