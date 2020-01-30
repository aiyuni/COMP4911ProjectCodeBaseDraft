using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using COMP4911DesignDemo.Models;
using COMP4911DesignDemo.Repository;
using COMP4911DesignDemo.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace COMP4911DesignDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IDataRepository<Employee> _employeeRepository;
        public EmployeeController(IDataRepository<Employee> employeeRepository)
        {
            this._employeeRepository = employeeRepository;
        }

        //GET: api/Employee/AllEmployees
        [HttpGet("AllEmployees")]
        public IActionResult GetAllEmployees()
        {
            //List<Employee> employeeList = new List<Employee>();
            //foreach (Employee e in _employeeRepository.GetAll())
            //{

            //}
            return Ok(_employeeRepository.GetAll());
        }


        //// GET: api/Employee
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET: api/Employee/5
        //[HttpGet("{id}", Name = "Get")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST: api/Employee
        //[HttpPost]
        //public IActionResult Post(RegisteringEmployee newEmployee)
        //{
        //    Employee emp = new Employee();
        //    _employeeRepository.Add(emp);
        //    return new OkObjectResult(200);
        //}

        // PUT: api/Employee/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
