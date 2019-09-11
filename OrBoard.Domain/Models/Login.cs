using System;
using System.ComponentModel.DataAnnotations;

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

        

        public bool CheckLogin()
        {

            return false;
        }
    }
}