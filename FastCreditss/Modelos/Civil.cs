using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastCreditss.Modelos
{
    public class Civil
    {
        [Key]
        public int IdCivil { get; set; }

        [ForeignKey("Persona")]
        public int IdPersona { get; set; }
        public Persona? Persona { get; set; }

        [Required]
        //"SI" marque el casillero "NO" deje el casillero en blanco
        public Boolean Casado { get; set; }

        [AllowNull]
        [Range(0, 10)]
        public int? Hijos { get; set; }
    }
}
