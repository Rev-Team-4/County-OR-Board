using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrBoard.Domain.Models
{
    public class Procedure
    {
        [Key]
        public int ProcedureId { get; set; }

        [ForeignKey("Surgeon")]
        public int SurgeonId { get; set; }
        public Surgeon Surgeon { get; set; }

        [ForeignKey("Anesthetist")]
        public int AnesthetistId { get; set; }
        public Anesthetist Anesthetist { get; set; }

        [ForeignKey("OperatingRoom")]
        public int OperatingRoomId { get; set; }
        public OperatingRoom OperatingRoom { get; set; }

        [ForeignKey("Hospital")]
        public int HospitalId { get; set; }
        public Hospital Hospital { get; set; }

        [ForeignKey("Nurse")]
        public int? NurseId { get; set; }
        public Nurse Nurse { get; set; }

        [Required]
        public DateTime ScheduledDateTime { get; set; }
        
        [Required(ErrorMessage = "Please Enter a Name")]
        public string ProcedureName { get; set; }
       
        [Required]
        public string Status { get; set; }
       
        [Required]
        [DataType(DataType.Time)]
        public string EstimatedProcedureLength { get; set; }
      
        [DataType(DataType.DateTime)]
        public DateTime ActualStart { get; set; }
       
        [DataType(DataType.DateTime)]
        public DateTime ActualFinish { get; set; }
        
        public string AnesthetistStatus { get; set; }

        public void AddProcedure()
        {
            SurgeonId = 0;
            AnesthetistId = 0;
            HospitalId = 0;
            OperatingRoomId = 0;
            NurseId = 0;
        }
    }
}