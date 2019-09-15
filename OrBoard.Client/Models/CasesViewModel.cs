using System.Collections.Generic;
using System.Linq;
using OrBoard.Client.Controllers;
using OrBoard.Data;
using OrBoard.Domain.Models;

namespace OrBoard.Client.Models
{
    public class CasesViewModel
    {
        public List<Procedure> ProcedureList { get; set; }
        public List<Anesthetist> AnesthetistList { get; set; }
        public List<Nurse> NurseList { get; set; }
        public int SiD { get; set; }

        public OrBoardDbContext _db = new OrBoardDbContext();
        
        public CasesViewModel()
        {
            ProcedureList = new List<Procedure>();
            AnesthetistList = new List<Anesthetist>();
            NurseList = new List<Nurse>();
        }

        public void Read()
        {
            foreach (var item in _db.Surgeons.ToList())
            {
                if(item.LoginId == LoginController.LoggedInUser)
                {
                    SiD = item.SurgeonId;
                }
            }
            
            foreach (var item in _db.Procedures)
            {
                if(SiD == item.SurgeonId)
                {
                    ProcedureList.Add(item);
                }
            }

            foreach (var item in _db.Anesthetists)
            {
                AnesthetistList.Add(item);
            }

            foreach (var item in _db.Nurses)
            {
                NurseList.Add(item);
            }
        }
    }
}