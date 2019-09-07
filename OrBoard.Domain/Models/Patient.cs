using System.ComponentModel.DataAnnotations;
using OrBoard.Domain.Abstracts;

namespace OrBoard.Domain.Models
{
    public class Patient : AUser
    {
        [Required]
        public int PatientId { get; set; }

        [Required]
        public string Gender { get; set; }
    }
}