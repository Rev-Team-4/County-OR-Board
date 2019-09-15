using System.Collections.Generic;
using System.Linq;
using OrBoard.Client.Controllers;
using OrBoard.Data;
using OrBoard.Domain.Models;

namespace OrBoard.Client.Models
{
    public class AnesthCasesViewModel
    {
        public List<Procedure> ProcedureList { get; set; }
        public List<Anesthetist> AnesthetistList { get; set; }
        public List<Nurse> NurseList { get; set; }
        public int SiD { get; set; }


        public OrBoardDbContext _db = new OrBoardDbContext();
        
        public AnesthCasesViewModel()
        {
            ProcedureList = new List<Procedure>();
            AnesthetistList = new List<Anesthetist>();
            NurseList = new List<Nurse>();
        }

        public void Read()
        {
            foreach (var item in _db.Anesthetists.ToList())
            {
                if(item.LoginId == LoginController.LoggedInUser)
                {
                    SiD = item.AnesthetistId;
                }
            }
            
            foreach (var item in _db.Procedures)
            {
                if(SiD == item.AnesthetistId)
                {
                    ProcedureList.Add(item);
                }
            }
        }

        public void Write(int pId, string avail)
        {
            var update = _db.Procedures.SingleOrDefault(p => p.ProcedureId == pId);
            if(update != null)
            {
                update.AnesthetistStatus = avail;
                _db.SaveChanges();
            }
        }
    }
}