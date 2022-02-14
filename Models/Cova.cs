using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cemidex.Models
{
    internal class Cova
    {
        [Key]
        public int IdCova { get; set; }

        [Required, ForeignKey("Requerente")]
        public int IdRequerente { get; set; }
    }
}
