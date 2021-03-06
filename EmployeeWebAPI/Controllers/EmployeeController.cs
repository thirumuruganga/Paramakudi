﻿using EmployeeWebAPI.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace EmployeeWebAPI.Controllers
{
	[EnableCors("http://localhost:4200","*","*")]
    // commit changes it good
    public class EmployeeController : ApiController
    {
        public IHttpActionResult GetDetails()
        {
			try
			{
				var employeeDetails = new APPContext().GetEmployees();
				return Ok(employeeDetails);
			}
			catch (Exception ex)
			{
				return BadRequest(ex.Message+"test");
			}
			
        }
    }
}