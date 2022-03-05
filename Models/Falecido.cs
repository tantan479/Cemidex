using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cemidex.Models
{
    internal class Falecido
    {
        [Key]
        public int IdFalecido { get; set; }

        [Required, /*ForeignKey("Cova")*/]
        public int IdCova { get; set; }

        [Required, ForeignKey("Requerente")]
        public int IdRequerente { get; set; }

        [Required, MaxLength(11), MinLength(11)]
        public string Cpf { get; set; }

        [Required, MaxLength(100)]
        public string Nome { get; set; }

        [Required, MaxLength(100)]
        public string NomeMae { get; set; }

        [Required, MaxLength(100)]
        public string NomePai { get; set; }

        public string Idade { get; set; }

        [MaxLength(1), MinLength(1)]
        public string Sexo { get; set; }

        public string EstadoCivil { get; set; }
        public DateTime DataObito { get; set; }
        //public DateTime DataEnterro { get; set; }
        // public string RegistroObito { get; set; }
        //public Boolean CertidaoObito { get; set; }


    }
}