using ProjectManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectManagement.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            ViewBag.Author = "Ionut";

            var model = new AboutModel();
            model.Message = "Hello user";
            model.Author = "Ionut";
            return View(model);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        // curs 6 exercitiul 3
        public double Average()
        {
            var list = new List<int> { 1, 5, 9, 2, 4, 6, 7, 8 , 10, 11 };
            int sum = 0;
            foreach (int x in list)
                sum += x;
            return sum / list.Count;
        }

        // curs 6 exercitiul 4
        public ActionResult HelloWorld()
        {
            return Content("Hello World");
        }

        // curs 6 exercitiul 9
        public ActionResult RedirectToRoute()
        {
            return Content("");
        }

    }
}