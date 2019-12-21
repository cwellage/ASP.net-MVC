using MyDataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Infastructure;

namespace WebApplication2.Controllers
{
    public class DepartmentController : Controller
    {
        // GET: Department
        public ActionResult Index()
        {
                List<Department> dep = new MyDB().GetAllDepartments();
                return View("Department", dep);
        }
    }
}