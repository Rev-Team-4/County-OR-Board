using System;
using System.Collections.Generic;
using System.Linq;
using OrBoard.Client.Controllers;
using OrBoard.Data;
using OrBoard.Domain.Models;

namespace OrBoard.Client.Models
{
    public class NewCaseViewModel
    {
        public Procedure Procedure { get; set; }
        public List<Anesthetist> Anesthetist { get; set; }
        public List<Hospital> Hospital { get; set; }
        public List<OperatingRoom> OperatingRoom { get; set; }
        public OrBoardDbContext _db = new OrBoardDbContext();
        public int SiD { get; set; }

        public NewCaseViewModel()
        {
            Procedure = new Procedure();
            Anesthetist = new List<Anesthetist>(){};
            Hospital = new List<Hospital>(){};
            OperatingRoom = new List<OperatingRoom>(){};
        }

        public void Read()
        {
            foreach (var item in _db.Anesthetists.ToList())
            {
                Anesthetist.Add(item);
            }

            foreach (var item in _db.Hospitals.ToList())
            {
                Hospital.Add(item);
            }

            foreach (var item in _db.OperatingRooms.ToList())
            {
                OperatingRoom.Add(item);
            }

            foreach (var item in OperatingRoom)
            {
                foreach (var x in Hospital)
                {
                    if (item.HospitalId == x.HospitalId)
                    {
                        item.HospitalName = x.Name;
                    }
                }
            }
        }

        public void Write()
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
                if(Procedure.OperatingRoomId == item.OperatingRoomId)
                {
                    Procedure.HospitalId = item.HospitalId;
                    date = item.DateTimeAvailable;
                }
            }

            _db.Procedures.Add(new Procedure()
            {
                ScheduledDateTime = date,
                SurgeonId = SiD,
                AnesthetistId = Procedure.AnesthetistId,
                OperatingRoomId = Procedure.OperatingRoomId,
                HospitalId = Procedure.HospitalId,
                ProcedureName = Procedure.ProcedureName,
                EstimatedProcedureLength = Procedure.EstimatedProcedureLength,
                Status = Procedure.Status,
                NurseId = null
            });

            _db.SaveChanges();
        }
    }
}