using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OrBoard.Client.Models;
using OrBoard.Data;
using OrBoard.Domain.Models;

namespace OrBoard.Client.Controllers
{
    public class NewCasesController : Controller
    {
        public OrBoardDbContext _db = new OrBoardDbContext();
        public NewCaseViewModel ncm = new NewCaseViewModel();
        
        public int SiD { get; set; }

        [HttpGet]
        public IActionResult Index()
        {
            // foreach (var item in _db.Surgeons.ToList())
            // {
            //     if(item.LoginId == LoginController.LoggedInUser)
            //     {
            //         SiD = item.SurgeonId;
            //     }
            // }

            foreach (var item in _db.Anesthetists.ToList())
            {
                ncm.Anesthetist.Add(item);
            }

            foreach (var item in _db.Hospitals.ToList())
            {
                ncm.Hospital.Add(item);
            }

            foreach (var item in _db.OperatingRooms.ToList())
            {
                ncm.OperatingRoom.Add(item);
            }

            foreach (var item in ncm.OperatingRoom)
            {
                foreach (var x in ncm.Hospital)
                {
                    if(item.HospitalId == x.HospitalId)
                    {
                        item.HospitalName = x.Name;
                    }
                }
            }

            return View(ncm);
        }

        [HttpPost]
        public IActionResult Index(NewCaseViewModel ncm2)
        {
            if(ModelState.IsValid)
            {
                DateTime date = new DateTime();

                foreach (var item in _db.Surgeons.ToList())
                {
                    if(item.LoginId == LoginController.LoggedInUser)
                    {
                        SiD = item.SurgeonId;
                    }
                }

                foreach (var item in _db.OperatingRooms.ToList())
                {
                    if(ncm2.Procedure.OperatingRoomId == item.OperatingRoomId)
                    {
                        ncm2.Procedure.HospitalId = item.HospitalId;
                        date = item.DateTimeAvailable;
                    }
                }

                _db.Procedures.Add(new Procedure()
                {
                    ScheduledDateTime = date,
                    SurgeonId = SiD,
                    AnesthetistId = ncm2.Procedure.AnesthetistId,
                    OperatingRoomId = ncm2.Procedure.OperatingRoomId,
                    HospitalId = ncm2.Procedure.HospitalId,
                    ProcedureName = ncm2.Procedure.ProcedureName,
                    EstimatedProcedureLength = ncm2.Procedure.EstimatedProcedureLength,
                    Status = ncm2.Procedure.Status,
                    NurseId = null
                });

                _db.SaveChanges();
            }

            return RedirectToAction("Index", "Cases");
        }
    }
}