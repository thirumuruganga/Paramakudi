using EmployeeWebAPI.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EmployeeWebAPI.Data
{
    public class APPContext: DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public APPContext():base("DBConnectionString")
        {
           
        }
        public List<Employee> GetEmployees()
        {
             return this.Employees.ToList<Employee>();
        }
    }
    
}