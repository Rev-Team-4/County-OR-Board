using System.ComponentModel.DataAnnotations;
using OrBoard.Domain.Abstracts;

namespace OrBoard.Domain.Models
{
    public class Patient : AUser
    {
        [Key]
        public int PatientId { get; set; }

        [Required]
        [Range(0,int.MaxValue)]
        public int Age { get; set; }

        [Required]
        [MaxLength(10)]
        public string Gender { get; set; }
    }
}