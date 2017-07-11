using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDVRestaurante.Objetos
{
    public class ClienteFisico : PersonaFisica
    {
        [Display(Name = "Frecuente", Order = 15)]
        public bool Frecuente { get; set; }
    }
}
