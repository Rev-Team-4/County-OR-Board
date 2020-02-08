using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrBoard.Domain.Models
{
    public class Login
    {
        [Key]
        public int LoginId { get; set; }

        [Required]
        public string UserName { get; set; }
        
        [Required]
        public string Password { get; set; }

        [Required]
        public DateTime CreationDateTime { get; set; }

        public DateTime UpdatedDateTime { get; set; } //Testing user secrets

        [NotMapped]
        public List<Login> LoginList { get; set; }

        public Login()
        {
            LoginList = new List<Login>();
        }

        public bool CheckLogin(string user, string pass)
        {
            foreach (var item in LoginList)
            {
                if(user == item.UserName && pass == item.Password)
                {
                    LoginId = item.LoginId;
                    return true;
                }
            }            
            return false;
        }
    }
}