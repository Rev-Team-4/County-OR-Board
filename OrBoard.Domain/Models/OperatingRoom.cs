using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrBoard.Domain.Models
{
    public class OperatingRoom
    {
        [Key]
        public int OperatingRoomId { get; set; }

        [ForeignKey("Hospital")]
        [Required]
        public int HospitalId { get; set; }
        [Required]
        [Display(Name = "Room Name")]
        public string OrName { get; set; }

        [Required]
        [NotMapped]
        public string HospitalName { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name = "Date and Time")]
        public DateTime DateTimeAvailable { get; set; }

        [Required]
        public string OpRoomStatus { get; set; }



    }
}