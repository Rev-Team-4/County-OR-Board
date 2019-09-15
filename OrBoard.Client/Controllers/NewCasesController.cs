using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OrBoard.Client.Models;
using OrBoard.Data;
using OrBoard.Domain.Models;

namespace OrBoard.Client.Controllers
{
    public class NewCasesController : Controller
    {
        public OrBoardDbContext _db = new OrBoardDbContext();
        public NewCaseViewModel ncm = new NewCaseViewModel();

        public int SiD { get; set; }

        [HttpGet]   
        public IActionResult Index()
        {
            ncm.Read();
            return View(ncm);
        }

        [HttpPost]
        public IActionResult Index(NewCaseViewModel ncm2)
        {
            if(ModelState.IsValid)
            {
                ncm2.Write();
            }

            return RedirectToAction("Index", "Cases");
        }
    }
}