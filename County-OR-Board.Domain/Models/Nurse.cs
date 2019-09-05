using System.ComponentModel.DataAnnotations;
using County_OR_Board.Domain.Abstracts;

namespace County_OR_Board.Domain.Models
{
    class Nurse : AUser
    {
        [Key]
        public int NurseId { get; set; }
    }
}