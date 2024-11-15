using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Web1.Models;

namespace Web1.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            //create new Student object
            Student student1 = new Student();
            student1.Name = "tuan anh";
            student1.Age = 20;
            student1.Email = "tuananh@gmail.com";

            //create another Student object
            Student student2 = new Student
            {
                Name = "Phuong Linh",
                Age = 19,
                Email = "phuonglinh@gmail.com"
            };
            
            //add 2 objects to a List
            List<Student> students = new List<Student>();
            students.Add(student1);
            students.Add(student2);

            //add 1 more student to List
            students.Add(
                new Student
                {
                    Name = "Hoang Tuan",
                    Age = 22,
                    Email = "hoangtuan@gmail.com"
                }
            );

            //pass data to view using model
            return View(students);
        }
    }
}
