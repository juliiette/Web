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
    public class FirmController : ControllerBase
    {
        private readonly IFirmService _firmService;

        public FirmController(IFirmService firmService)
        {
            _firmService = firmService;
        }
        
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FirmModel>>> GetAll()
        {
            return Ok(_firmService.GetAll());
        }
        
        
        [HttpGet("{department}")]
        public async Task<ActionResult<FirmModel>> GetByDepartment(string department)
        {
            var firm = _firmService.FindByDepartment(department);

            return Ok(firm);
        }
        
        [HttpGet("{dateTime:datetime}")]
        public async Task<ActionResult<IEnumerable<FirmModel>>> GetByCreationDate(DateTime dateTime)
        {
            var firm = _firmService.FindByCreationDate(dateTime);

            return Ok(firm);
        }
        
        [HttpGet("{employeesQuantity}")]
        public async Task<ActionResult<IEnumerable<FirmModel>>> GetByQuantity(int employeesQuantity)
        {
            var firm = _firmService.FindByEmployeesQuantity(employeesQuantity);

            return Ok(firm);
        }
        
        [HttpPost]
        public async Task<ActionResult> AddDetachment(string detachment, FirmModel firm)
        {
            _firmService.AddDetachment(detachment, firm);

            return Ok();
        }
    }
}