using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using OrBoard.Domain.Abstracts;

namespace OrBoard.Domain.Models
{
  public class Anesthetist : AUser
  {
        [Key]
        public int AnesthetistId { get; set; }
  }
}