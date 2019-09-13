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

        [MaxLength(50)]
        [Required]
        public string OpRoomStatus { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime DateTimeAvailable { get; set; }

        [NotMapped]
        public string HospitalName { get; set; }
    }
}