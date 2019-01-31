using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Model;
using Service;

namespace CoreAPIUsingDapper.Controllers
{
    [Produces("application/json")]
    [Route("api/Employee")]
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _service;

        public EmployeeController(IEmployeeService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<Employee> GetByID(string id)
        {
            return await _service.GetEmployeeByID(id);
        }

        [HttpGet]
        [Route("dob/{dateOfBirth}")]
        public async Task<IEnumerable<Employee>> GetByID(DateTime dateOfBirth)
        {
            return await _service.GetEmployeeByDateOfBirth(dateOfBirth);
        }
    }
}