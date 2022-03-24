using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimelyApp.Models;
using TimelyApp.Services.Interfaces;

namespace TimelyApp.Controllers
{
    public class EditController : Controller
    {
        private readonly IService _service;

        public EditController(IService service)
        {
            _service = service;
        }

        [HttpPut]
        public async Task<ActionResult> EditLog([FromBody]Log log)
        {          
            try
            {
                await _service.editLog(log);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
            return Ok();
        }      
    }
}
