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
        public Procedure p = new Procedure();
        public OrBoardDbContext _db = new OrBoardDbContext();
        
        public IActionResult Index()
        {
            p.ProcedureList = new List<Procedure>();
            foreach (var item in _db.Procedures.ToList())
            {
                p.ProcedureList.Add(item);
            }
            return View(p);
        }

        public IActionResult EditCases(int editid)
        {
            return RedirectToAction("Index", "EditCases", new {id = editid});
        }
    }
}