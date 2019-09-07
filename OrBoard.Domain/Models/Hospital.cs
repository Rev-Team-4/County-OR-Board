using System;

namespace County_OR_Board.Domain
{
    public class Hospital
    {
      [Key]
      public int HospitalId {get; set;}
      public string Name {get; set;}
      public string Address {get; set;}
      public string FacilityOwnership {get; set;}
      public string ORManager {get; set;}
      public string ManagerEmail {get; set;}
      public int LicenseNumber {get; set;}
      public bool LicenseStatus {get; set;}
      public int EINNumber {get; set;}
      public bool EINStatus {get; set;}
      public string FacilityType {get; set;}
      public string City {get; set;}
      public string State {get; set;}
    }
}
