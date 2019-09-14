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
        public NewCaseViewModel ncm = new NewCaseViewModel();
        public int SiD { get; set; }
        public static int pId { get; set; }

        public IActionResult Index(int id)
        {
            pId = id;
            foreach (var item in _db.Surgeons.ToList())
            {
                if (item.LoginId == LoginController.LoggedInUser)
                {
                    SiD = item.SurgeonId;
                }
            }

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
                    if (item.HospitalId == x.HospitalId)
                    {
                        item.HospitalName = x.Name;
                    }
                }
            }

            foreach (var item in _db.Procedures.ToList())
            {
                if(id == item.ProcedureId)
                {
                    ncm.Procedure.ProcedureName = item.ProcedureName;
                    ncm.Procedure.EstimatedProcedureLength = item.EstimatedProcedureLength;
                    ncm.Procedure.ActualStart = item.ActualStart;
                    ncm.Procedure.ActualFinish = item.ActualFinish;
                    ncm.Procedure.Status = item.Status;
                }
            }

            return View(ncm);
        }

        [HttpPost]
        public IActionResult Index(NewCaseViewModel ncvm)
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
                    if(ncvm.Procedure.OperatingRoomId == item.OperatingRoomId)
                    {
                        ncvm.Procedure.HospitalId = item.HospitalId;
                        date = item.DateTimeAvailable;
                    }
                }
                
                var update = _db.Procedures.SingleOrDefault(p => p.ProcedureId == pId);
                if(update != null)
                {
                    update.ScheduledDateTime = date;
                    update.SurgeonId = SiD;
                    update.AnesthetistId = ncvm.Procedure.AnesthetistId;
                    update.OperatingRoomId = ncvm.Procedure.OperatingRoomId;
                    update.HospitalId = ncvm.Procedure.HospitalId;
                    update.ProcedureName = ncvm.Procedure.ProcedureName;
                    update.EstimatedProcedureLength = ncvm.Procedure.EstimatedProcedureLength;
                    update.Status = ncvm.Procedure.Status;
                    update.NurseId = ncvm.Procedure.NurseId;
                    update.ActualStart = ncvm.Procedure.ActualStart;
                    update.ActualFinish = ncvm.Procedure.ActualFinish;
                    _db.SaveChanges();
                }
            }
            return RedirectToAction("Index", "Cases");
        }
    }
}