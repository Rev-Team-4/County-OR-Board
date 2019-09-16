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
    public class OperatingRoomsController : Controller
    {
        OrBoardDbContext _db = new OrBoardDbContext();
        OperatingRoomsViewModel orvm = new OperatingRoomsViewModel();

        public static int hId;

        [HttpGet]
        public IActionResult ViewRooms()
        {   
            orvm.ReadFromDb();
            hId = orvm.hId;
            return View(orvm);
        }

        [HttpGet]
        public IActionResult ViewHospitals()
        {   
            var hospitals =  _db.Hospitals.ToList();
            return View(hospitals);
        }

        [HttpGet]
        public IActionResult AddNewRoom()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddNewRoom(OperatingRoom operatingRoom )
        {   
             if(ModelState.IsValid)
            {
                operatingRoom.HospitalId = hId;
                _db.OperatingRooms.Add(operatingRoom);
                _db.SaveChanges();
            }           
            return RedirectToAction("ViewRooms");
        }

        public IActionResult FloatOr(int orid, string date, string time)
        {
            orvm.ReadOr(orid);
            return View(orvm);
        }
    

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}