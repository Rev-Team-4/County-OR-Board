using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrBoard.Domain.Models
{
    public class OperatingRoom
    {
        [Key]
        public int OperatingRoomId { get; set; }

        [ForeignKey("HospitalId")]
        [Required]
        public int HospitalId { get; set; }

        [Required]
        public string HospitalName { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name = "Date and Time")]
        public DateTime DateTimeAvailable { get; set; }

        [Required]
        public string OpRoomStatus { get; set; }



    }
}