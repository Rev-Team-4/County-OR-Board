using System.ComponentModel.DataAnnotations;

namespace OrBoard.Domain.Abstracts
{
    public abstract class ADoctor : AUser
    {
        [Required]
        [Range(0, int.MaxValue)]
        [MinLength(4)]
        [MaxLength(10)]
        public int LicenseNumber { get; set; }

        [Required]
        [Range(0, int.MaxValue)]
        public bool LicenseStatus { get; set; }

        [Required]
        [Range(0, int.MaxValue)]
        [MinLength(10)]
        [MaxLength(10)]
        public int NPINumber { get; set; }

        [Required]
        [Range(0, int.MaxValue)]
        public int NPIStatus { get; set; }
    }
}