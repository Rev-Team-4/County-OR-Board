using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OrBoard.Domain.Models;
using OrBoard.Data;



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
            foreach (var opRoomItem in _db.OperatingRooms.ToList())
            {
                OpRooms.Add(opRoomItem);
            }

            foreach (var hospitalItem in _db.Hospitals.ToList())
            {
                Hospitals.Add(hospitalItem);
            }
            foreach (var procedureItem in _db.Procedures.ToList())
            {
                Procedures.Add(procedureItem);
            }

        }

        public void WriteToDb()
        {
             
        }
      
    }
     
}