using System;
using System.ComponentModel.DataAnnotations;

namespace County_OR_Board.Domain.Models
{
    class Login
    {
        [Key]
        public int LoginId { get; set; }

        [Required]
        public string UserName { get; set; }
        
        [Required]
        public string Password { get; set; }

        [Required]
        public DateTime CreationDateTime { get; set; }
    }
}