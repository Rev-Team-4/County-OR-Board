using System;
using System.Collections.Generic;
using System.Linq;
using OrBoard.Client.Controllers;
using OrBoard.Data;
using OrBoard.Domain.Models;

namespace OrBoard.Client.Models
{
    public class EditCasesViewModel
    {
        public int EditId { get; set; }
        public Procedure Procedure { get; set; }
        public List<Anesthetist> Anesthetist { get; set; }
        public List<Hospital> Hospital { get; set; }
        public List<OperatingRoom> OperatingRoom { get; set; }

        public OrBoardDbContext _db = new OrBoardDbContext();
        public int SiD { get; set; }
        public static int pId { get; set; }


        public EditCasesViewModel()
        {
            Procedure = new Procedure();
            Anesthetist = new List<Anesthetist>(){};
            Hospital = new List<Hospital>(){};
            OperatingRoom = new List<OperatingRoom>(){};
            EditId = 0;
        }

        public void Read(int id)
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

            foreach (var item in _db.Procedures.ToList())
            {
                if(id == item.ProcedureId)
                {
                    Procedure.ProcedureName = item.ProcedureName;
                    Procedure.EstimatedProcedureLength = item.EstimatedProcedureLength;
                    Procedure.ActualStart = item.ActualStart;
                    Procedure.ActualFinish = item.ActualFinish;
                    Procedure.Status = item.Status;
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
            
            var update = _db.Procedures.SingleOrDefault(p => p.ProcedureId == pId);
            if(update != null)
            {
                update.ScheduledDateTime = date;
                update.SurgeonId = SiD;
                update.AnesthetistId = Procedure.AnesthetistId;
                update.OperatingRoomId = Procedure.OperatingRoomId;
                update.HospitalId = Procedure.HospitalId;
                update.ProcedureName = Procedure.ProcedureName;
                update.EstimatedProcedureLength = Procedure.EstimatedProcedureLength;
                update.Status = Procedure.Status;
                update.NurseId = Procedure.NurseId;
                update.ActualStart = Procedure.ActualStart;
                update.ActualFinish = Procedure.ActualFinish;
                _db.SaveChanges();
            }
        }
    }
}