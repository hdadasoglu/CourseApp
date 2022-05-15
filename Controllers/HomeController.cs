using System;
using Microsoft.AspNetCore.Mvc;

namespace CourseApp.Controllers
{
    public class HomeController:Controller
    {
        public IActionResult Index(){
            // ViewBag kullanarak değişken oluşturuduk bu değişkenleri html sayfasında yazdırabiliriz.
            ViewBag.Greeting = DateTime.Now.Hour>12? "İyi Günler" : "Günaydın";
            ViewBag.UserName = "Sadık";
            return View();
        }
        public IActionResult About(){
            return View();
        }
    }
}