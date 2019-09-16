using System.ComponentModel.DataAnnotations;

namespace OrBoard.Domain.Abstracts
{
    public abstract class ADoctor : AUser
    {
        [Required]
        //[Range(0, int.MaxValue)]
        [Range(4,10, ErrorMessage = "The license number must be 4 to 10 digits long.")]
        //[MinLength(4)] //For a string? Not for number. 
        //[MaxLength(10)]
        public int LicenseNumber { get; set; }

        [Required]
        public bool LicenseStatus { get; set; }

        [Required]
        //[Range(0, int.MaxValue)]
        [Range(10,10, ErrorMessage = "The NPI Number must be 10 digit long.")]
        //[MinLength(10)]
        //[MaxLength(10)]
        public int NPINumber { get; set; }

        [Required]
        public bool NPIStatus { get; set; }
    }
}