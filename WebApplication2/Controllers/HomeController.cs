using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Infastructure;
using MyDataModel;
using System.Web.Routing;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
       
        public ActionResult Index()
        {
            return View();
        }

        [Route("CustomAction"),Route("default")]
        public ActionResult Default()
        {
            return Content("Default content");
        }

        //public ActionResult Department()
        //{
        //    List<Department> dep = new MyDB().GetAllDepartments();
        //    return View(dep);
        //}

        public ActionResult About()
        {
            ViewBag.Message = "Employee details";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

    }
}