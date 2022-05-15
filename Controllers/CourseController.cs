using System.Collections.Generic;
using System.Linq;
using CourseApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CourseApp.Controllers
{
    // http://localhost:5000/course
    public class CourseController:Controller
    {
        // course/index
        public IActionResult Index(){
            return View();
        }
        // course/list
        public IActionResult List(){
            var students = Repository.Students.Where(student=>student.Confirm==true);
            return View(students);
        }
        public IActionResult Details(){
            // course adında bir Course nesnesi oluşturduk
            var course = new Course();
            // nesnenin içeriğini ekleyelim
            course.Name = "AspDotNet Mvc Yapısı ile Backend Development";
            course.Description = "Her yaştan insana hitap eden bir kurs";
            course.IsPublished = true;
            // nesnemizi View yapısı ile html sayfamıza gönderiyoruz.
            return View("MyView",course);
        }
        // Formumuzun içinde bulunacağı bir apply actionu oluşturduk
        // localhost:5000/course/apply method: GET
        [HttpGet]
        public IActionResult Apply()
        {
          
          return View();
        }
        // localhost:5000/course/apply method : POST
        [HttpPost]
        public IActionResult Apply(Student student)
        {
            if(ModelState.IsValid)
            {
                Repository.AddStudent(student);
                return View("Thanks",student);
            }
            else
            {
                return View();
            }
        }
        
    }
}