using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using OrBoard.Domain.Abstracts;

namespace OrBoard.Domain.Models
{
<<<<<<< HEAD
    public class Anesthetist : ADoctor

    {
=======
  public class Anesthetist : ADoctor
  {
>>>>>>> cac1a43868e1769ece60eabb1649dfc14e412d48
        [Key]
        public int AnesthetistId { get; set; }
    }
}