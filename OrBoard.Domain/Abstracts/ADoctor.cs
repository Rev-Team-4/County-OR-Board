using System.ComponentModel.DataAnnotations;

namespace OrBoard.Domain.Abstracts
{
    public abstract class ADoctor : AUser
    {
        [Required]
        [Range(4,10, ErrorMessage = "The license number must be 4 to 10 digits long.")]
        public int LicenseNumber { get; set; }

        [Required]
        public bool LicenseStatus { get; set; }

        [Required]
        [Range(10,10, ErrorMessage = "The NPI Number must be 10 digit long.")]
        public int NPINumber { get; set; }

        [Required]
        public bool NPIStatus { get; set; }
    }
}