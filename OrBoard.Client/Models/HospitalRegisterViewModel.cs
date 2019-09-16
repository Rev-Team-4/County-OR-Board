using System;
using OrBoard.Domain.Models;

namespace OrBoard.Client.Models
{
  public class HospitalRegisterViewModel
  {
        //Hospital Login Information
        public string UserName { get; set; }
        
        public string Password { get; set; }

        public DateTime CreationDateTime { get; set; }

        //Hospital Registration Information
        public string Name {get; set;}

        public string Address {get; set;}

        public string FacilityOwnership {get; set;}

        public string ORManager {get; set;}

        public string ManagerEmail {get; set;}

        public string Telephone {get; set;}

        public string Fax {get; set;}

        public int LicenseNumber {get; set;}

        public bool LicenseStatus {get; set;}

        public int EINNumber {get; set;}

        public bool EINStatus {get; set;}

        public string FacilityType {get; set;}

        public string City {get; set;}

        public string State {get; set;}
        public string ZipCode {get; set;}

        //Map the viewmodel to the model. 
        public static implicit operator Login(HospitalRegisterViewModel newHospital)
        {
          return new Login
          {
            UserName = newHospital.UserName,
            Password = newHospital.Password,
            CreationDateTime = newHospital.CreationDateTime
          };
        }

        public static implicit operator Hospital(HospitalRegisterViewModel newHospital)
        {
          return new Hospital
          {
            Name = newHospital.Name,
            Address = newHospital.Address,
            FacilityOwnership = newHospital.FacilityOwnership,
            ORManager = newHospital.ORManager,
            ManagerEmail = newHospital.ManagerEmail,
            LicenseNumber = newHospital.LicenseNumber,
            LicenseStatus = newHospital.LicenseStatus,
            EINNumber = newHospital.EINNumber,
            EINStatus = newHospital.EINStatus,
            FacilityType = newHospital.FacilityType,
            City = newHospital.City,
            State = newHospital.State,
            Fax = newHospital.Fax,
            Telephone = newHospital.Telephone,
            ZipCode = newHospital.ZipCode
          };
        }
  }
}