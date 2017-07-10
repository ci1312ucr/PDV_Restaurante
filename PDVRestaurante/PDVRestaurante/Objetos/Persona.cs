using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PDVRestaurante.Objetos
{
    public class Persona
    {
        [Display(Name = "Cedula", Order = 1)]
        public string Cedula { get; set; }
        [Display(Name = "Tipo de Persona", Order = 0)]
        public char? TipoP { get; set; }
    }
}
