using MyDataModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication2.Infastructure
{
    public class MyDB : DbContext
    {
        public MyDB() : base("Data Source = localhost; Initial Catalog = chatura; Integrated Security = True")
        {
            
        }
        public DbSet<Employee> Employees { get; set; }

        public DbSet<Department> Departments { get; set; }

        public List<Department> GetAllDepartments()
        {
            return Departments.ToList();
        }
    }
}