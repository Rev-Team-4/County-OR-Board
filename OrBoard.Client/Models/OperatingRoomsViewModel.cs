using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OrBoard.Domain.Models;
using OrBoard.Data;
using OrBoard.Client.Controllers;

namespace OrBoard.Client.Models
{
    public class OperatingRoomsViewModel
    {
      public List<OperatingRoom> OpRooms { get; set; }
      public Hospital Hospital { get; set; }
      public OperatingRoom OperatingRoom { get; set; }
      public List<Hospital> Hospitals { get; set; }
      public Procedure Procedure { get; set; }
      public List<Procedure> Procedures { get; set; } 
      public int hId = 0;
      public string date;
      public string time;

      OrBoardDbContext _db = new OrBoardDbContext();

      public OperatingRoomsViewModel()
        {
            OpRooms = new List<OperatingRoom>();
            Hospitals = new List<Hospital>();
            Procedures = new List<Procedure>();
            Hospital = new Hospital();
            Procedure = new Procedure();
            OperatingRoom = new OperatingRoom();
        }

        public void ReadFromDb()
        {
            foreach (var item in _db.Hospitals)
            {
                if(item.LoginId == LoginController.LoggedInUser)
                {
                    hId = item.HospitalId;
                }
            }

            foreach (var opRoomItem in _db.OperatingRooms.ToList())
            {
                if(hId == opRoomItem.HospitalId)
                {
                    OpRooms.Add(opRoomItem);
                }
            }

            foreach (var hospitalItem in _db.Hospitals.ToList())
            {
                Hospitals.Add(hospitalItem);
            }

            foreach (var item in OpRooms)
            {
                foreach (var x in Hospitals)
                {
                    if (item.HospitalId == x.HospitalId)
                    {
                        item.HospitalName = x.Name;
                    }
                }
            }

            foreach (var procedureItem in _db.Procedures.ToList())
            {
                Procedures.Add(procedureItem);
            }
        }

        public void ReadOr(int id)
        {
            foreach (var item in _db.OperatingRooms)
            {
                if(item.OperatingRoomId == id)
                {
                    OperatingRoom = item;
                    string[] sa = item.DateTimeAvailable.ToString("MM/dd/yyyy HH:MM").Split(" ");
                    date = sa.ElementAt(0);
                    time = sa.ElementAt(1);
                }
            }
        }

        public void WriteToDb()
        {
             
        }
      
    }
     
}