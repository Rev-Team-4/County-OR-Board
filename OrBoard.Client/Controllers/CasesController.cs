using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OrBoard.Client.Models;
using OrBoard.Data;
using OrBoard.Domain.Models;

namespace OrBoard.Client.Controllers
{    
    public class CasesController : Controller
    {   
        CasesViewModel cvm = new CasesViewModel();
        
        public IActionResult Index()
        {
            cvm.Read();
            return View(cvm);
        }

        public IActionResult EditCases(int editid)
        {
            return RedirectToAction("Index", "EditCases", new {id = editid});
        }
    }
}