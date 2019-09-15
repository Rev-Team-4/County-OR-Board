using OrBoard.Domain.Abstracts;
using Microsoft.AspNetCore.Mvc;
using OrBoard.Data;
using OrBoard.Domain.Models;
using OrBoard.Client.Models;

namespace OrBoard.Client.Controllers
{

  public class RegistrationController : Controller
  {
    public OrBoardDbContext _db = new OrBoardDbContext();
    
    [HttpGet] //GET is required. 
    public IActionResult Provider()
    {
      return View();
    }

    [HttpPost] //Then, once GET is done, 
    public IActionResult Provider(RegistrationViewModel Register)
    {
      if(ModelState.IsValid) //Simple NurseID 
      {
        if(Register.Specialty=="Nurse")
        {
          Nurse newNurse  = Register;
        _db.Nurses.Add(newNurse);
        _db.SaveChanges();
        }
        else if(Register.Specialty=="Anesthetist")
        {
          Anesthetist newAnesthetist = Register;
          _db.Anesthetists.Add(newAnesthetist);
          _db.SaveChanges();
        }
        else if(Register.Specialty=="Surgeon")
        {
          Surgeon newSurgeon = Register;
          _db.Surgeons.Add(newSurgeon);
          _db.SaveChanges();
        }
        return RedirectToAction("Provider");
      }
      return RedirectToAction("Provider");
    }
  
    [HttpGet]
    public IActionResult Facility()
    {
      return View();
    }

     [HttpPost]
     public IActionResult Facility(Hospital newHospital)
     {
       if(ModelState.IsValid)
       {
         _db.Hospitals.Add(newHospital);
         _db.SaveChanges();
         return RedirectToAction("Index", "Login");
       }
       return RedirectToAction("Facility");
     }
    
  }
}