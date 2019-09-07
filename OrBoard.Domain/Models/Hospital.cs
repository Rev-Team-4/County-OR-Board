using System;
using System.ComponentModel.DataAnnotations;

namespace County_OR_Board.Domain
{
    public class Hospital
    {
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
    }
}
