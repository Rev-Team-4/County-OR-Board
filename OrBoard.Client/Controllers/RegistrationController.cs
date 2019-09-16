using OrBoard.Domain.Abstracts;
using Microsoft.AspNetCore.Mvc;
using OrBoard.Data;
using OrBoard.Domain.Models;
using OrBoard.Client.Models;

namespace OrBoard.Client.Controllers
{

  public class RegistrationController : Controller
  {
    private OrBoardDbContext _db = new OrBoardDbContext();
    
    [HttpGet] //GET is required. 
    public IActionResult Provider()
    {
      return View();
    }

    [HttpPost] //Then, once GET is done, 
    public IActionResult Provider(ProviderRegisterViewModel Register)
    {
      if(ModelState.IsValid) 
      {
        Login newuser = Register; //Every provider must have login regardless of specialty.
        _db.Logins.Add(newuser);

          if(Register.Specialty=="Nurse")
          {
            Nurse newNurse = Register;
            newNurse.LoginId = newuser.LoginId;
            _db.Nurses.Add(newNurse);
            //_db.SaveChanges();
          }
          else if(Register.Specialty=="Anesthetist")
          {
            Anesthetist newAnesthetist = Register;
            newAnesthetist.LoginId = newuser.LoginId;
            _db.Anesthetists.Add(newAnesthetist);
            //_db.SaveChanges();
          }
          else if(Register.Specialty=="Surgeon")
          {
            Surgeon newSurgeon = Register;
            newSurgeon.LoginId = newuser.LoginId;
            _db.Surgeons.Add(newSurgeon);
            //_db.SaveChanges();
          }
        _db.SaveChanges();  
        //return RedirectToAction("Provider");
      }
      return RedirectToAction("Index", "Login");
    }
  
    [HttpGet]
    public IActionResult Facility()
    {
      return View();
    }

     [HttpPost]
     public IActionResult Facility(HospitalRegisterViewModel hospitalRegister)
     {
       if(ModelState.IsValid)
       {
        //Add the user information.
        Login newUser = hospitalRegister;
        _db.Logins.Add(newUser);

        Hospital newHospital = hospitalRegister;
        newHospital.LoginId = newUser.LoginId;
         _db.Hospitals.Add(newHospital);
         _db.SaveChanges();
       }
       return RedirectToAction("Index", "Login");
     }
    
  }
}