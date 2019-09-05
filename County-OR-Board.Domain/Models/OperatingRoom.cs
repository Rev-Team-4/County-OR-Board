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
        public int HospitalId { get; set; }
        public bool OperatingnRoomStatus { get; set; }
    }
}