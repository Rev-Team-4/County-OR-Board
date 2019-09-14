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
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        //Creating an opRoom.
        [HttpGet]
        public IActionResult CreateNew()
        {
            return View();
        }

        //POST: OperatingRooms/AddNew
        [HttpPost]
        public IActionResult FloatOr(OperatingRoom opRoom)
        {
            if (ModelState.IsValid)
            {
                _db.OperatingRooms.Add(opRoom);
                _db.SaveChanges();
            }
            return RedirectToAction("FindAll");

        }
        //GET: OperatingRooms/FindAll
        [HttpGet]
        public IActionResult FindAll()
        {
            var opRoom = _db.OperatingRooms.ToList();
            return View(opRoom);
        }
        //GET: OperatingRooms/FindById
        [HttpGet]
        public IActionResult FindById()
        {
            return View();
        }

        //PUT: OperatingRooms/UpdateById
        [HttpPut]
        public IActionResult UpdateById()
        {
            return View();
        }
        //GET: OperatingRooms/DeleteById
        [HttpDelete]
        public IActionResult DeleteById()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}