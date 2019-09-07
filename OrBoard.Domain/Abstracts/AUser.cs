using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrBoard.Domain.Abstracts
{
    public abstract class AUser
    {
        [ForeignKey("LoginId")]
        public int LoginId { get; set; }

        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }

        [Phone]
        [Required]
        public string Phone { get; set; }

        [EmailAddress]
        [Required]
        public string Email { get; set; }

        [Required]
        [MaxLength(50)]
        public string StreetAddress { get; set; }

        [Required]
        [MaxLength(50)]
        public string City { get; set; }

        [Required]
        [MaxLength(50)]
        public string State { get; set; }

        [Required]
        [DataType(DataType.PostalCode)]
        public int Zip { get; set; }
    }
}