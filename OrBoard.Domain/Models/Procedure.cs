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

        [ForeignKey("Patient")]
        public int PatientId { get; set; }

        [ForeignKey("NurseId")]
        public int NurseId { get; set; }

        [Required]
        public DateTime ScheduledDateTime { get; set; }

        [Required]
        public string ProcedureName { get; set; }

        [Required]
        public string Status { get; set; }

        [Required]
        public DateTime EstimatedProcedureLength { get; set; }

        [Required]
        public DateTime ActualStart { get; set; }

        [Required]
        public DateTime ActualFinish { get; set; }

    }
}