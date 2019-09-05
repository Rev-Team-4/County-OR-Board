using System.ComponentModel.DataAnnotations;
using County_OR_Board.Domain.Abstracts;

namespace County_OR_Board.Domain.Models
{
    class Nurse : User
    {
        [Key]
        public int NurseId { get; set; }
    }
}