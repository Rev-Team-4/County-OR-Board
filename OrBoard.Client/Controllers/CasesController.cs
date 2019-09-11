using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OrBoard.Client.Models;
using OrBoard.Domain.Models;

namespace OrBoard.Client.Controllers
{
    public class CasesController : Controller
    {


        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult NewCase()
        {
            return View();
        }

        [HttpPost]
        public IActionResult NewCase(Procedure p, string date, string time)
        {
            if(ModelState.IsValid)
            {
                string pname = p.ProcedureName;
                date = Convert.ToDateTime(date).ToString("yyyy-MM-dd");
                p.ScheduledDateTime = DateTime.Parse(date + " " + time);
                TimeSpan ts = TimeSpan.Parse(p.EstimatedProcedureLength);
            }
            
            return View();
        }
    }
}