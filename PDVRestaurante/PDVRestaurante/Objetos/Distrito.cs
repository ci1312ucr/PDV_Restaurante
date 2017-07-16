using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDVRestaurante.Objetos
{
    public class Distrito
    {
        [Display(Name = "Id Provincia", Order = 0)]
        public int IdProvincia { get; set; }
        [Display(Name = "Id Canton", Order = 0)]
        public int IdCanton { get; set; }
        [Display(Name = "Id Distrito", Order = 0)]
        public int IdDistrito { get; set; }
        [Display(Name = "Descripcion", Order = 1)]
        public String Descripcion { get; set; }
    }
}
