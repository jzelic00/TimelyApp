using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimelyApp.Models;
using TimelyApp.Services.Interfaces;

namespace TimelyApp.Controllers
{
    public class AddController : Controller
    {
        private readonly IService _service;

        public AddController(IService service)
        {
            _service = service;
        }

        [Route("AddLog/AddLog")]
        [HttpPost]
        public async Task<ActionResult> AddNewContact([FromBody] LogDTO newLog)
        {           
            try
            {
                await _service.addNewLogAsync(newLog);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return Ok();
        }
       
    }
}
