using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace TrybeApp.Controllers
{
    public class StudentController : Controller
    {
        var studentsList = new List<Student>() { 
            new Student() { Id = 1, Name = "John", Age = 18, ClassNumber = 8 } ,
            new Student() { Id = 2, Name = "Steve",  Age = 21, ClassNumber = 8 } 
        };
        public IActionResult Index()
        {
            // recuperar do banco aqui
            return View("StudentsView", studentsList); // Aqui é a view que será retornada
        }
    }
}
