using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace County_OR_Board.Domain
{
    class Surgeon
    {
        [Key]
        public int SurgeonId { get; set; }

        [ForeignKey("LoginId")]
        public int LoginId { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [ForeignKey("SpecialtyId")]
        public int SpecialtyId { get; set; }

        [Phone]
        [Required]
        public string Phone { get; set; }

        [EmailAddress]
        [Required]
        public string Email { get; set; }

        [Required]
        public string PracticeStreetAddress { get; set; }

        [Required]
        public string PracticeCity { get; set; }

        [Required]
        public string PracticeState { get; set; }

        [Required]
        public string PracticeZip { get; set; }

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