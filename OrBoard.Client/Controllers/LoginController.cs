using Microsoft.AspNetCore.Mvc;
using OrBoard.Domain.Models;

namespace OrBoard.Client.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CheckLogin(Login l)
        {
            if(ModelState.IsValid)
            {
                
            }
            return View();
        }
    }
}