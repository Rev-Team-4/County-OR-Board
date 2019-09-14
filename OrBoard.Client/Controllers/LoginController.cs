using System.Linq;
using Microsoft.AspNetCore.Mvc;
using OrBoard.Data;
using OrBoard.Domain.Models;

namespace OrBoard.Client.Controllers
{
    public class LoginController : Controller
    {
        public static int LoggedInUser;
        private OrBoardDbContext _db = new OrBoardDbContext();
        public static Login Login { get; set; }
        public IActionResult Index()
        {
            if(Login == null)
            {
                Login = new Login();
                foreach (var item in _db.Logins.ToList())
                {
                    Login.LoginList.Add(new Login(){ UserName = item.UserName, Password = item.Password, LoginId = item.LoginId});
                }
            }
            return View();
        }

        [HttpPost]
        public IActionResult Index(Login l)
        {
            if(ModelState.IsValid)
            {
                if(Login.CheckLogin(l.UserName, l.Password))
                {
                    LoggedInUser = Login.LoginId;
                    return RedirectToAction("Index", "Cases");
                }
            }
            return View();
        }
    }
}