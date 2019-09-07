using System.ComponentModel.DataAnnotations;
using OrBoard.Domain.Abstracts;

namespace OrBoard.Domain.Models
{
    class Nurse : AUser
    {
        [Key]
        public int NurseId { get; set; }

        [Required]
        [Range(0, int.MaxValue)]
        [MinLength(8)]
        [MaxLength(8)]
        public int LicenseNumber { get; set; }

        [Required]
        [Range(0, int.MaxValue)]
        public bool LicenseStatus { get; set; }
    }
}