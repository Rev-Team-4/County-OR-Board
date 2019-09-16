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
      public IEnumerable<OperatingRoom> OpRooms { get; set; }
      public Hospital Hospital { get; set; }
      public OperatingRoom OperatingRoom { get; set; }
      public IEnumerable<Hospital> Hospitals { get; set; }
      public Procedure Procedure { get; set; }
      public IEnumerable<Procedure> Procedures { get; set; } 

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


      
    }
     
}