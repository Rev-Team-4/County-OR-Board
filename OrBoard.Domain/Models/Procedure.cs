using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrBoard.Domain.Models
{
    public class Procedure
    {
        [Key]
        public int ProcedureId { get; set; }

        [ForeignKey("SurgeonId")]
        public int SurgeonId { get; set; }

        [ForeignKey("AnesthetistId")]
        public int AnesthetistId { get; set; }

        [ForeignKey("OperatingRoomId")]
        public int OperatingRoomId { get; set; }

        [ForeignKey("HospitalId")]
        public int HospitalId { get; set; }

        [ForeignKey("NurseId")]
        public int NurseId { get; set; }

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
    }
}