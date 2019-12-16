using System;
using System.Collections.Generic;
using System.Text;

namespace MyDataModel
{
    public class Department
    {
        public int Id { get; set; }

        public string DepartmentName { get; set; }

        public ICollection<Employee> Employees { get; set; }
    }
   
}
