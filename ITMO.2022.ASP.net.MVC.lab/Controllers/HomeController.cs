using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ITMO._2022.ASP.net.MVC.lab.Models;



namespace ITMO._2022.ASP.net.MVC.lab.Controllers
{

    public class MyController : Controller
    {
        //public string Index(string hel)
        //{

        //    string Greeting = ModelClass.ModelHello() + ", " + hel;
        //    return Greeting;

        //}



        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Доброе утро" :
           "Добрый день";
            ViewData["Mes"] = "хорошего настроения";
            return View();

        }
        [HttpGet]
        public ViewResult InputData()
        {
            return View();
        }
        [HttpPost]
        public ViewResult InputData(Person p)
        {
            db.AddResponse(p);
            return View("Hello", p);
        }
        private static PersonRepository db = new PersonRepository();

        public ViewResult OutputData()
        {
            ViewBag.Pers = db.GetAllResponses;
            ViewBag.Count = db.NumberOfPerson;
            return View("ListPerson");
        }
    }
}