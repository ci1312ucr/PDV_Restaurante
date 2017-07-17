using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDVRestaurante.Objetos
{
    public class PersonaJuridica : Persona
    {
        [Display(Name = "Nombre", Order = 2)]
        public string Nombre { get; set; }
        [Display(Name = "Fecha de Apertura", Order = 9)]
        public DateTime FechaApertura { get; set; }
    }
}
