using System;
using System.ComponentModel.DataAnnotations;

namespace OrBoard.Domain.Models
{
    public class Hospital
    {
<<<<<<< HEAD
        [Key]
        public int HospitalId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string FacilityOwnership { get; set; }
        public string ORManager { get; set; }
        public string ManagerEmail { get; set; }
        public int LicenseNumber { get; set; }
        public bool LicenseStatus { get; set; }
        public int EINNumber { get; set; }
        public bool EINStatus { get; set; }
        public string FacilityType { get; set; }
        public string City { get; set; }
        public string State { get; set; }
=======
      [Key]
      public int HospitalId {get; set;}

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
>>>>>>> 8995f272230766b07a0fb0811444c3e0d6715f11
    }
}
