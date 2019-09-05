using System.ComponentModel.DataAnnotations;
using County_OR_Board.Domain.Abstracts;

namespace County_OR_Board.Domain.Models
{
    public class Patient : AUser
    {
        [Required]
        public string Gender { get; set; }
    }
}