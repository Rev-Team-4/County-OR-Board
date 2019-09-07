using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace County_OR_Board.Domain.Models
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
        public string OperatingnRoomStatus { get; set; }
    }
}