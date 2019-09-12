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
        OrBoardDbContext _db = new OrBoardDbContext();
        NewCaseViewModel ncm = new NewCaseViewModel();
        
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult NewCase()
        {
            foreach (var item in _db.Anesthetists.ToList())
            {
                ncm.Anesthetist.Add(new Anesthetist(){FirstName = item.FirstName, LastName = item.LastName});
            }

            foreach (var item in _db.Hospitals.ToList())
            {
                ncm.Hospital.Add(new Hospital(){Name = item.Name});
            }

            foreach (var item in _db.OperatingRooms.ToList())
            {
                ncm.OperatingRoom.Add(new OperatingRoom(){});
            }
            return View(ncm);
        }

        [HttpPost]
        public IActionResult NewCase(Procedure p, string date, string time)
        {
            if(ModelState.IsValid)
            {
                string pname = p.ProcedureName;
                date = Convert.ToDateTime(date).ToString("yyyy-MM-dd");
                p.ScheduledDateTime = DateTime.Parse(date + " " + time);
                TimeSpan ts = TimeSpan.Parse(p.EstimatedProcedureLength);
                p.SurgeonId = LoginController.LoggedInUser;
            }
            
            return View();
        }
    }
}