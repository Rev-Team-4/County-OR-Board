using System.Collections.Generic;
using OrBoard.Domain.Models;

namespace OrBoard.Client.Models
{
    public class NewCaseViewModel
    {
        public Procedure Procedure { get; set; }
        public List<Anesthetist> Anesthetist { get; set; }
        public List<Hospital> Hospital { get; set; }
        public List<OperatingRoom> OperatingRoom { get; set; }

        public NewCaseViewModel()
        {
            Procedure = new Procedure();
            Anesthetist = new List<Anesthetist>(){};
            Hospital = new List<Hospital>(){};
            OperatingRoom = new List<OperatingRoom>(){};
        }
    }
}