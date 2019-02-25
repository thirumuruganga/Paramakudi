namespace EmployeeWebAPI.Migrations
{
    using System;
	using System.Collections.Generic;
	using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
	using EmployeeWebAPI.Model;


	internal sealed class Configuration : DbMigrationsConfiguration<EmployeeWebAPI.Data.APPContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "EmployeeWebAPI.Data.APPContext";
        }

        protected override void Seed(EmployeeWebAPI.Data.APPContext context)
        {
			//  This method will be called after migrating to the latest version.

			//  You can use the DbSet<T>.AddOrUpdate() helper extension method 
			//  to avoid creating duplicate seed data.
			List<Employee> employeeList = new List<Employee>
			{
				new Employee { FirstName="Thiru",LastName="Murugan",City="Macon",Address="Bass Road",IsWorking=true},
				new Employee { FirstName="Raj",LastName="Mani",City="Atlanta",Address="Near Sams",IsWorking=false}
			};
			employeeList.ForEach(s => {
				context.Employees.Add(s);
				context.SaveChanges();
				}
			);	
        }
    }
}
