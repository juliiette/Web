using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Office.API.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<EmployeeModel>>> GetAll()
        {
            return Ok(_employeeService.GetAll());
        }

        [HttpGet("{dateTime:datetime}")]
        public async Task<ActionResult<IEnumerable<EmployeeModel>>> GetByBirthday(DateTime dateTime)
        {
            var employee = _employeeService.FindByDateOfBirth(dateTime);

            return Ok(employee);
        }

        [HttpGet("{employeeName}")]
        public async Task<ActionResult<EmployeeModel>> GetByName(string employeeName)
        {
            var employee = _employeeService.FindByName(employeeName);

            return Ok(employee);
        }

        [HttpGet("{detachment}")]
        public async Task<ActionResult<EmployeeModel>> GetByDetachment(string detachment)
        {
            var employee = _employeeService.FindByDetachment(detachment);

            return Ok(employee);
        }
        
        /*
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EmployeeModel>>> GetByEmploymentDate(DateTime dateTime)
        {
            var employee = _employeeService.FindByEmploymentDate(dateTime);

            return Ok(employee);
        }*/

        [HttpDelete("{detailId}")]
        public async Task<ActionResult> Delete(EmployeeModel employeeModel)
        {
            _employeeService.Delete(employeeModel);

            return Ok();
        }

        [HttpPost]
        public async Task<ActionResult> Create(EmployeeModel employeeModel)
        {
            _employeeService.Create(employeeModel);

            return Ok(employeeModel);
        }

        
    }
}