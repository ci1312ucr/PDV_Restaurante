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
        public string Cedula { get; set; }
        [DisplayName("Tipo de Persona")]
        public char? TipoP { get; set; }
    }
}
