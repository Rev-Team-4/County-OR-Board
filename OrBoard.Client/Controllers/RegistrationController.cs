using Microsoft.AspNetCore.Mvc;

namespace OrBoard.Client.Controllers
{
  public class RegistrationController : Controller
  {
    public IActionResult Provider_Index()
    {
      return View();
    }
  }
}