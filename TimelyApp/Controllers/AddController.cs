using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimelyApp.Models;
using TimelyApp.Services.Interfaces;

namespace TimelyApp.Controllers
{
    public class AddLogController : Controller
    {
        private readonly IService _service;

        public AddLogController(IService service)
        {
            _service = service;
        }

        [Route("AddLogController/AddLog")]
        [HttpPost]
        public async Task<ActionResult> AddNewContact([FromBody] LogDTO newLog)
        {
            if (newLog == null)
                return BadRequest();

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

        [Route("AddLog/AddLogPartialView")]
        public PartialViewResult AddLogPartialView()
        {
            return PartialView();
        }
    }
}
