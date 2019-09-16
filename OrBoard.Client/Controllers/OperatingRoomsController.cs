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
            hId = OperatingRoomsViewModel.hId;
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

        [HttpGet]
        public IActionResult FloatOr(int orid, string date, string time)
        {
            OperatingRoomsViewModel.orId = orid;
            orvm.ReadOr(orid);
            return View(orvm);
        }

        [HttpPost]
        public IActionResult FloatOr(OperatingRoomsViewModel ovm, string date, string time)
        {
            ovm.WriteToDb(date, time);
            return RedirectToAction("ViewRooms");
        }
    

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}