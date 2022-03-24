using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimelyApp.Models;
using TimelyApp.Services.Interfaces;

namespace TimelyApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IService _service;

        public HomeController (IService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            return View();
        }

        [Route("Home/GetAllLogs")]
        [HttpGet]
        public async Task<ActionResult> GetAllLogs()
        {       
            return Ok(await _service.getAllLogs());
        }

        [Route("Home/delete")]
        [HttpDelete]
        public async Task<ActionResult> DeleteLog(int? logId)
        {          
            try
            {
                await _service.deleteLog(logId);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

            return Ok();
        }

        public ActionResult logsPartialView()
        {
            return PartialView();
        }       
    }
}
