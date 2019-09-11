using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using OrBoard.Domain.Abstracts;

namespace OrBoard.Domain.Models
{
    public class Nurse : ADoctor
    {
        [Key]
        public int NurseId { get; set; }
    }
}