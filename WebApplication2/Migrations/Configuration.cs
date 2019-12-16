namespace WebApplication2.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<WebApplication2.Infastructure.MyDB>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            
        }

        protected override void Seed(WebApplication2.Infastructure.MyDB context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            context.Departments.AddOrUpdate(a => a.DepartmentName, new MyDataModel.Department { DepartmentName = "HR" },
               new MyDataModel.Department { DepartmentName = "IT" },
               new MyDataModel.Department { DepartmentName = "Finance" },
               new MyDataModel.Department { DepartmentName = "Sales" });
        }
    }
}
