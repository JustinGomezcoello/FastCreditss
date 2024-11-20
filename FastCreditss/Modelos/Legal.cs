using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastCreditss.Modelos
{
    public class Legal
    {
        [Key]
        public int IdLegal { get; set; }

        [ForeignKey("Persona")]
        public int IdPersona { get; set; }
        public Persona? Persona { get; set; }

        [Required]
        //"SI" marque el casillero "NO" deje el casillero en blanco
        public Boolean Denuncias { get; set; }

        [Required]
        //"SI" marque el casillero "NO" deje el casillero en blanco
        public Boolean Antecedentes_Penales { get; set; }

        [Required]
        //"SI" marque el casillero "NO" deje el casillero en blanco
        public Boolean Fraudes { get; set; }
    }
}
