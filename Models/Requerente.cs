using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cemidex.Models
{
    internal class Requerente
    {
        [Key]
        public int IdRequerente { get; set; }

        [Required, MaxLength(11), MinLength(11)]
        public string Cpf { get; set; }

        [Required, MaxLength(100)]
        public string Nome { get; set; }

        [Required, MaxLength(500)]
        public string Endereco { get; set; }

        [Required, MaxLength(20)]
        public string Telefone { get; set; }
    }
}
