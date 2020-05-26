using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Office.MVC.Controllers
{
    public class FirmController : Controller
    {
        private readonly IFirmService _firmService;

        public FirmController(IFirmService firmService)
        {
            _firmService = firmService;
        }
        
        [Authorize]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FirmModel>>> GetAll()
        {
            return View(_firmService.GetAll());
        }
        
        
        [HttpGet("{department}")]
        public async Task<ActionResult<FirmModel>> GetByDepartment(string department)
        {
            var firm = _firmService.FindByDepartment(department);

            return View(firm);
        }
        
        
        public async Task<ActionResult<IEnumerable<FirmModel>>> GetByCreationDate(DateTime dateTime)
        {
            var firm = _firmService.FindByCreationDate(dateTime);

            return View(firm);
        }
        
        public async Task<ActionResult<IEnumerable<FirmModel>>> GetByQuantity(int employeesQuantity)
        {
            var firm = _firmService.FindByEmployeesQuantity(employeesQuantity);

            return View(firm);
        }
        
        public async Task<ActionResult> AddDetachment(string detachment, FirmModel firm)
        {
            _firmService.AddDetachment(detachment, firm);

            return View();
        }
    }
}