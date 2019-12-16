using MyDataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Models.Employee
{
    public class EmployeeEditViewModel
    {
        public int Id { get; set; }
        public int DepartmentId { get; set; }
        public string EmployeeName { get; set; }

        public Department Department { get; set; }
        public IEnumerable<Department> Departments { get; set; }
    }
}