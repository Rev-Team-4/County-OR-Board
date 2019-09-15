using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using OrBoard.Client.Models;
using OrBoard.Data;
using OrBoard.Domain.Models;

namespace OrBoard.Client.Controllers
{
    public class EditCasesController : Controller
    {
        public OrBoardDbContext _db = new OrBoardDbContext();
        public EditCasesViewModel ecvm = new EditCasesViewModel();
        public static int pId { get; set; }

        public IActionResult Index(int id)
        {
            pId = id;
            ecvm.Read(id);
            return View(ecvm);
        }

        [HttpPost]
        public IActionResult Index(EditCasesViewModel e, string startdate, string starttime, string enddate, string endtime)
        {
            if(ModelState.IsValid)
            {
                e.Write(startdate,starttime,enddate,endtime);
            }
            return RedirectToAction("Index", "Cases");
        }
    }
}