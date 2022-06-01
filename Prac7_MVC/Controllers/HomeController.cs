using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Prac7_MVC.Models;

namespace Prac7_MVC.Controllers
{
    public class HomeController : Controller
    {

        PersonContext db = new PersonContext();

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Form()
        {
            return View(new Person());
        }

        [HttpPost]
        public ActionResult Form(Person model)
        {
            if (ModelState.IsValid)
            {
                db.People.Add(model);
                db.SaveChanges();
                if (model.WillCome.Equals("Yes"))
                {
                    ViewBag.Result = "Спасибо за ответ. Приятно, что вы придете.";
                }
                else
                {
                    ViewBag.Result = "Спасибо за ответ. Жаль, что вас не будет";
                }

                return View("Result");
            }
            else
            {
                return View();
            }
           
        }

        [HttpGet]
        public ActionResult CheckAll()
        {
            return View(db.People);
        }

    }
}