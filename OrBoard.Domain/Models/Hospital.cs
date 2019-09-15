using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrBoard.Domain.Models
{
    public class Hospital
    {
        [Key]
        public int HospitalId {get; set;}

        [ForeignKey("LoginId")]
        public int LoginId { get; set; }
        public Login Login { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name {get; set;}

        [Required]
        [MaxLength(50)]
        public string Address {get; set;}

        [Required]
        [MaxLength(50)]
        public string FacilityOwnership {get; set;}

        [Required]
        [MaxLength(50)]
        public string ORManager {get; set;}

        [Required]
        [MaxLength(50)]
        public string ManagerEmail {get; set;}

        [Required]
        [Range(0, int.MaxValue)]
        public int LicenseNumber {get; set;}

        [Required]
        public bool LicenseStatus {get; set;}

        [Required]
        [Range(0, int.MaxValue)]
        public int EINNumber {get; set;}

        [Required]
        public bool EINStatus {get; set;}

        [Required]
        [MaxLength(50)]
        public string FacilityType {get; set;}

        [Required]
        [MaxLength(50)]
        public string City {get; set;}

        [Required]
        [MaxLength(50)]
        public string State {get; set;}

        [Required]
        [DataType(DataType.PhoneNumber)]
        public string Telephone {get; set;}

        [Required]
        [DataType(DataType.PhoneNumber)]
        public string Fax {get; set;}

        [Required]
        [DataType(DataType.PostalCode)]
        public string ZipCode {get; set;}
    }
}
