using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using County_OR_Board.Domain.Abstracts;

namespace County_OR_Board.Domain.Models
{
    public class Surgeon : User
    {
        [Key]
        public int SurgeonId { get; set; }

        [ForeignKey("SpecialtyId")]
        public int SpecialtyId { get; set; }

        [Required]
        public int LicenseNumber { get; set; }

        [Required]
        public bool LicenseStatus { get; set; }

        [Required]
        public int NPINumber { get; set; }

        [Required]
        public int NPIStatus { get; set; }
        
    }
}