using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using OrBoard.Domain.Abstracts;

namespace OrBoard.Domain.Models
{
    public class Surgeon : ADoctor
    {
        [Key]
        public int SurgeonId { get; set; }

    }
}