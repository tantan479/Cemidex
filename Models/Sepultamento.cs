using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cemidex.Models
{
    internal class Sepultamento
    {
        [Key]
        public int IdSepultamento { get; set; }

        [Required, ForeignKey("Falecido")]
        public string IdFalecido { get; set; }

        [Required, ForeignKey("Cova")]
        public string IdCova { get; set; }


        [Required, ForeignKey("Falecido")]
        public DateTime DataSepultamento { get; set; }

        public DateTime DataExumacao{ get; set; }

    }
}
