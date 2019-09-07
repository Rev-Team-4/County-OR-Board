using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrBoard.Domain.Abstracts
{
    public abstract class AUser
    {
        [ForeignKey("LoginId")]
        public int LoginId { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Phone]
        [Required]
        public string Phone { get; set; }

        [EmailAddress]
        [Required]
        public string Email { get; set; }

        [Required]
        public string StreetAddress { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string State { get; set; }

        [Required]
        public string Zip { get; set; }
    }
}