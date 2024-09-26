using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ICTBD_MVC_Project_1.models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ICTBD_MVC_Project_1.Controllers
{
    public class StudentsController : Controller
    {
        public Students students { get; set; }
        // Assigning Students
        public StudentsController()
        {
            students = new Students();
        }
        public List<Students> info()
        {
            return students.GetStudents();
        }
        public Students search(int id)
        {
            if (id <= 0) return new Students();
            else
            {
                return students.GetStudents().Where(single => single.Id == id).FirstOrDefault();
            }
        }
        public List<Students> add(int id, string name, int age)
        {
            Students std = new Students();
            std.Id = id;
            std.Name = name;
            std.Age = age;

            List<Students> students1 = students.GetStudents();
            students1.Add(std);
            return students1;
        }
        public List<Students> remove(int id)
        {
            if (id <= 0) return students.GetStudents();

            List<Students> studentLists = students.GetStudents();
            if(studentLists.Exists(a => a.Id == id))
            {
                studentLists.RemoveAll(a => a.Id == id);
            }
            return studentLists;

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}