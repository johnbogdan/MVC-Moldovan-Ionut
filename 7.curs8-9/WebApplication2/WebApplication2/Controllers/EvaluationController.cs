using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class EvaluationController : Controller
    {
        public static List<ProjectEvaluation> listofproject = new List<ProjectEvaluation>()
        {
            new ProjectEvaluation() {id= 1 ,City= "Brasov" , Country = "Romania" , Name= "Mihai", Rating = 1},
              new ProjectEvaluation() {id=2, City= "Cluj-Napoca" , Country = "Romania" , Name= "Alin", Rating = 2},
                new ProjectEvaluation() {id=3, City= "Cluj-Napoca" , Country = "Romania" , Name= "Alex", Rating = 3},
        };
        // GET: Evaluation
        public ActionResult Index()
        {
            return View(listofproject);
        }

        // GET: Evaluation/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Evaluation/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Evaluation/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                var evaluation = listofproject.Single(e =>e.Id == id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Evaluation/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Evaluation/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Evaluation/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Evaluation/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
