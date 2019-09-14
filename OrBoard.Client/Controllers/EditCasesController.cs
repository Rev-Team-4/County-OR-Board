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
        public int SiD { get; set; }
        public static int pId { get; set; }

        public IActionResult Index(int id)
        {
            ecvm.Read(id);
            return View(ecvm);
        }

        [HttpPost]
        public IActionResult Index(EditCasesViewModel e)
        {
            if(ModelState.IsValid)
            {
                e.Write();
            }
            return RedirectToAction("Index", "Cases");
        }
    }
}