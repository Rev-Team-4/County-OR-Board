using System.Linq;
using Microsoft.AspNetCore.Mvc;
using OrBoard.Data;
using OrBoard.Domain.Models;

namespace OrBoard.Client.Controllers
{
    public class LoginController : Controller
    {
        public static int LoggedInUser;
        //private OrBoardDbContext _db = new OrBoardDbContext();

        //Since we use AddDbContext, need to inject db into controller. 
        private OrBoardDbContext _db;
        public LoginController(OrBoardDbContext db)
        {
          _db = db; 
        }

        public static Login Login { get; set; }

        public IActionResult Index()
        {
            Login = new Login();
             foreach (var item in _db.Logins.ToList())
             {
                 Login.LoginList.Add(item);
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
                    foreach (var item in _db.Surgeons)
                    {
                        if(LoggedInUser == item.LoginId)
                        {
                            return RedirectToAction("Index", "Cases");
                        }
                    }
                    
                    foreach (var item in _db.Anesthetists)
                    {
                        if(LoggedInUser == item.LoginId)
                        {
                            return RedirectToAction("Index", "AnesthCases");
                        }                        
                    }

                    foreach (var item in _db.Hospitals)
                    {
                        if(LoggedInUser == item.LoginId)
                        {
                            return RedirectToAction("ViewRooms", "OperatingRooms");
                        }
                    }
                }
            }
            return View();
        }
    }
}