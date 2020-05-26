using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Office.MVC.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [Authorize]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EmployeeModel>>> GetAll()
        {
            return View(_employeeService.GetAll());
        }

        [HttpGet("{dateTime:datetime}")]
        public async Task<ActionResult<IEnumerable<EmployeeModel>>> GetByBirthday(DateTime dateTime)
        {
            var employee = _employeeService.FindByDateOfBirth(dateTime);

            return View(employee);
        }

        [HttpGet("{employeeName}")]
        public async Task<ActionResult<EmployeeModel>> GetByName(string employeeName)
        {
            var employee = _employeeService.FindByName(employeeName);

            return View(employee);
        }

        [HttpGet("{detachment}")]
        public async Task<ActionResult<EmployeeModel>> GetByDetachment(string detachment)
        {
            var employee = _employeeService.FindByDetachment(detachment);

            return View(employee);
        }
        
        public async Task<ActionResult<IEnumerable<EmployeeModel>>> GetByEmploymentDate(DateTime dateTime)
        {
            var employee = _employeeService.FindByEmploymentDate(dateTime);

            return View(employee);
        }

        [HttpDelete("{detailId}")]
        public async Task<ActionResult> Delete(EmployeeModel employeeModel)
        {
            _employeeService.Delete(employeeModel);

            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Create(EmployeeModel employeeModel)
        {
            _employeeService.Create(employeeModel);

            return View(employeeModel);
        }

        
    }
}