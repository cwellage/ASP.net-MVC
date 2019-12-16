using MyDataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Infastructure;
using WebApplication2.Models.Employee;

namespace WebApplication2.Controllers
{
    public class EmployeeController : Controller
    {
        private MyDB db;
        public EmployeeController()
        {
            db = new MyDB();
        }

        [HttpGet]
        public ActionResult Create()
        {
            ViewData ["Departments"] = db.GetAllDepartments();

            return View();
        }

        [HttpPost]
        public ActionResult Create(Employee emp)
        {
            ViewData["Departments"] = db.GetAllDepartments();

            if (ModelState.IsValid)
            {
                db.Employees.Add(emp);
                db.SaveChanges();
                return View("index", db.Employees.ToList());
            }

            return View(emp);
        }

        [HttpGet]
        public ActionResult Index()
        {
           // var emps = db.Employees.ToList();
        //  var deps = db.GetAllDepartments();
            var emps = db.Employees.Include("Department").ToList();
            return View(emps);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var emp = db.Employees.Where(a=>a.Id== id).FirstOrDefault();
            EmployeeEditViewModel model = new EmployeeEditViewModel { Id = id };
            model.DepartmentId = emp.DepartmentId;
            model.EmployeeName = emp.EmployeeName;
            model.Departments = db.GetAllDepartments();
            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(EmployeeEditViewModel model)
        {
            if (ModelState.IsValid)
            {
                var emp = db.Employees.Where(a => a.Id == model.Id).FirstOrDefault();
                emp.DepartmentId = model.DepartmentId;
                emp.EmployeeName = model.EmployeeName;
                db.SaveChanges();
                return View("index", db.Employees.ToList());
            }
            
            return View(model);
        }

        public ActionResult Delete(int id)
        {
            if (ModelState.IsValid)
            {
                var emp = db.Employees.Where(a => a.Id == id).FirstOrDefault();
                db.Employees.Remove(emp);
                db.SaveChanges();
                return RedirectToAction("index", db.Employees.ToList());
            }

            return View();
        }
    }
}