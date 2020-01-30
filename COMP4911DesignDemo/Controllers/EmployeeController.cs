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
        private readonly IDataRepository<Credential> _credentialRepository;
        public EmployeeController(IDataRepository<Employee> employeeRepository, IDataRepository<Credential> credentialRepository)
        {
            this._employeeRepository = employeeRepository;
            this._credentialRepository = credentialRepository;
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

        // POST: api/Employee
        [HttpPost]
        public IActionResult Post(RegisteringEmployee newEmployee)
        {
            
            Employee emp = new Employee(newEmployee.JobTitleId, newEmployee.EmpFirstName, newEmployee.EmpLastName, (int?)newEmployee.TimesheetApproverId, 
                (int?)newEmployee.SupervisorId);
            _employeeRepository.Add(emp);

            Credential credential = new Credential(newEmployee.EmpUsername, newEmployee.EmpPassword, emp.EmployeeId);
            _credentialRepository.Add(credential);

            return new OkObjectResult(200);
        }

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
