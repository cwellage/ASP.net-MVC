using System;

namespace MyDataModel
{
    public class Employee
    {
        public int Id { get; set; }
        public int DepartmentId { get; set; }
        public string EmployeeName { get; set; }
        public Department Department { get; set; }
    }
}
