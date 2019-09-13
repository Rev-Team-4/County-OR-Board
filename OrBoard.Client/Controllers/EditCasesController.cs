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
        public Procedure p = new Procedure();
        public int SiD { get; set; }

        public IActionResult Index()
        {
            int test = p.ProcedureId;
            foreach (var item in _db.Surgeons.ToList())
            {
                if(item.LoginId == LoginController.LoggedInUser)
                {
                    SiD = item.SurgeonId;
                }
            }

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
                ncm.OperatingRoom.Add(new OperatingRoom()
                {
                    OperatingRoomId = item.OperatingRoomId, 
                    OperatingRoomStatus = item.OperatingRoomStatus, 
                    HospitalId = item.HospitalId, 
                    DateTimeAvailable = item.DateTimeAvailable
                });
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
    }
}