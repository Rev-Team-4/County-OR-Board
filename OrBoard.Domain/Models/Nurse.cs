using System.ComponentModel.DataAnnotations;
using OrBoard.Domain.Abstracts;

namespace OrBoard.Domain.Models
{
    class Nurse : AUser
    {
        [Key]
        public int NurseId { get; set; }
    }
}