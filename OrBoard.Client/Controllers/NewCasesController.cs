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
                ncm.Hospital.Add(new Hospital(){Name = item.Name, HospitalId = item.HospitalId});
            }

            foreach (var item in _db.OperatingRooms.ToList())
            {
                ncm.OperatingRoom.Add(new OperatingRoom(){OperatingRoomId = item.OperatingRoomId, OperatingnRoomStatus = item.OperatingnRoomStatus});
            }
            return View(ncm);
        }

        [HttpPost]
        public IActionResult Index(NewCaseViewModel ncm2, string date, string time)
        {

                date = Convert.ToDateTime(date).ToString("yyyy-MM-dd");
                TimeSpan ts = TimeSpan.Parse(ncm2.Procedure.EstimatedProcedureLength);
                _db.Procedures.Add(new Procedure()
                {
                    ScheduledDateTime = DateTime.Parse(date + " " + time),
                    SurgeonId = LoginController.LoggedInUser,
                    AnesthetistId = ncm2.Procedure.AnesthetistId,
                    OperatingRoomId = ncm2.Procedure.OperatingRoomId,
                    HospitalId = ncm2.Procedure.HospitalId,
                    ProcedureName = ncm2.Procedure.ProcedureName,
                    EstimatedProcedureLength = ncm2.Procedure.EstimatedProcedureLength,
                    Status = ncm2.Procedure.Status,
                    NurseId = null
                });

                _db.SaveChanges();

                return RedirectToAction("Index", "NewCases");

        }
    }
}