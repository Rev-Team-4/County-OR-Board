using System;
using OrBoard.Domain.Abstracts;
using OrBoard.Domain.Models;

namespace OrBoard.Client.Models
{

  public class ProviderRegisterViewModel 
  {
    //Properties of ADoctor. 
      public string FirstName { get; set; }
      public string LastName { get; set; } 
      public string Phone { get; set; }
      public string Email { get; set; }
      public string StreetAddress { get; set; }
      public string City { get; set; }
      public string State { get; set; }
      public int Zip { get; set; }
        
      //Specify type of specialty. 
      public string Specialty {get; set;} 

      public int LicenseNumber { get; set; }

      public bool LicenseStatus { get; set; }
      public int NPINumber { get; set; }
      public bool NPIStatus { get; set; }

      //Hospital Login Information
      public string UserName { get; set; }
      public string Password { get; set; }
      public DateTime CreationDateTime { get; set; }

    //Perform implicit casting. 
    public static implicit operator Login(ProviderRegisterViewModel NewProvider)
    {
       return new Login
      {
        UserName = NewProvider.UserName,
        Password = NewProvider.Password,
        CreationDateTime = NewProvider.CreationDateTime
      };
    }
    public static implicit operator Nurse(ProviderRegisterViewModel NewProvider)
    {
      return new Nurse
      {
        FirstName = NewProvider.FirstName,
        LastName = NewProvider.LastName,
        Phone = NewProvider.Phone,
        Email = NewProvider.Email,
        StreetAddress = NewProvider.StreetAddress,
        City = NewProvider.City,
        State = NewProvider.State,
        Zip = NewProvider.Zip,
        LicenseNumber = NewProvider.LicenseNumber,
        LicenseStatus = NewProvider.LicenseStatus,
        NPINumber = NewProvider.NPINumber,
        NPIStatus = NewProvider.NPIStatus
      };
    }

       public static implicit operator Anesthetist(ProviderRegisterViewModel NewProvider)
      {
        return new Anesthetist
        {
          FirstName = NewProvider.FirstName,
          LastName = NewProvider.LastName,
          Phone = NewProvider.Phone,
          Email = NewProvider.Email,
          StreetAddress = NewProvider.StreetAddress,
          City = NewProvider.City,
          State = NewProvider.State,
          Zip = NewProvider.Zip,
          LicenseNumber = NewProvider.LicenseNumber,
          LicenseStatus = NewProvider.LicenseStatus,
          NPINumber = NewProvider.NPINumber,
          NPIStatus = NewProvider.NPIStatus
        };
      }

      public static implicit operator Surgeon(ProviderRegisterViewModel NewProvider)
      {
      return new Surgeon
      {
        FirstName = NewProvider.FirstName,
        LastName = NewProvider.LastName,
        Phone = NewProvider.Phone,
        Email = NewProvider.Email,
        StreetAddress = NewProvider.StreetAddress,
        City = NewProvider.City,
        State = NewProvider.State,
        Zip = NewProvider.Zip,
        LicenseNumber = NewProvider.LicenseNumber,
        LicenseStatus = NewProvider.LicenseStatus,
        NPINumber = NewProvider.NPINumber,
        NPIStatus = NewProvider.NPIStatus
      };
    }
  }
}