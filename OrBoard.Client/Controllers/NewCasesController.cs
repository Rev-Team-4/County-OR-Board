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
    public class NewCasesController : Controller
    {
        public OrBoardDbContext _db = new OrBoardDbContext();
        public NewCaseViewModel ncm = new NewCaseViewModel();

        [HttpGet]
        public IActionResult Index()
        {
            foreach (var item in _db.Anesthetists.ToList())
            {
                ncm.Anesthetist.Add(new Anesthetist(){FirstName = item.FirstName, LastName = item.LastName, AnesthetistId = item.AnesthetistId});
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
        public IActionResult Index(Procedure p, string date, string time)
        {
            if(ModelState.IsValid)
            {
                date = Convert.ToDateTime(date).ToString("yyyy-MM-dd");
                TimeSpan ts = TimeSpan.Parse(p.EstimatedProcedureLength);
                _db.Procedures.Add(new Procedure()
                {
                    ScheduledDateTime = DateTime.Parse(date + " " + time),
                    SurgeonId = LoginController.LoggedInUser,
                    AnesthetistId = p.AnesthetistId,
                    OperatingRoomId = p.OperatingRoomId,
                    HospitalId = p.HospitalId,
                    ProcedureName = p.ProcedureName,
                    EstimatedProcedureLength = p.EstimatedProcedureLength
                });

                _db.SaveChanges();

                return RedirectToAction("Index", "Cases");
            }
            
            return View();
        }
    }
}