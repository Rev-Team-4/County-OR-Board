using Microsoft.AspNetCore.Mvc;
using OrBoard.Client.Models;

namespace OrBoard.Client.Controllers
{
    public class AnesthCasesController : Controller
    {
        AnesthCasesViewModel acvm = new AnesthCasesViewModel();
        
        public IActionResult Index()
        {
            acvm.Read();
            return View(acvm);
        }

        public IActionResult SetStatus(int pId, string avail)
        {
            acvm.Write(pId, avail);
            return RedirectToAction("Index", "AnesthCases");
        }
    }
}