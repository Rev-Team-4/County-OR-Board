using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using OrBoard.Domain.Abstracts;

namespace OrBoard.Domain.Models
{
    public class Surgeon : AUser
    {
        [Key]
        public int SurgeonId { get; set; }

        [ForeignKey("SpecialtyId")]
        public int SpecialtyId { get; set; }

        [Required]
        public int LicenseNumber { get; set; }

        [Required]
        public string LicenseState { get; set; }

        [Required]
        public bool LicenseStatus { get; set; }

        [Required]
        public int NPINumber { get; set; }

        [Required]
        public int NPIStatus { get; set; }
        
    }
}