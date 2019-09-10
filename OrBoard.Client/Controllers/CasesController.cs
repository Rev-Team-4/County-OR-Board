using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OrBoard.Client.Models;

namespace OrBoard.Client.Controllers
{
    public class CasesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}