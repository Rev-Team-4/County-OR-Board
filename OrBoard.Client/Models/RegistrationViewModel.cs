using OrBoard.Domain.Abstracts;
using OrBoard.Domain.Models;

namespace OrBoard.Client.Models
{
  public class RegistrationViewModel : ADoctor
  {
    //Inherit all the properties from ADoctor. 
    public string Specialty {get; set;} //Specify type of specialty. 

    public static implicit operator Nurse(RegistrationViewModel NewProvider)
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

       public static implicit operator Anesthetist(RegistrationViewModel NewProvider)
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

      public static implicit operator Surgeon(RegistrationViewModel NewProvider)
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