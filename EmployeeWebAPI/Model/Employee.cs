using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeWebAPI.Model
{
	public class Employee : IEmployee
	{
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Address { get; set; }
		public string City { get; set; }
		public bool? IsWorking { get; set; } = false;
	}
}