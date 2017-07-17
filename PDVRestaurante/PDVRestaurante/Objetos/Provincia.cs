using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading.Tasks;

namespace PDVRestaurante.Objetos
{
    public class Provincia
    {
        [Display(Name = "Id Provincia", Order = 0)]
        public int IdProvincia { get; set; }
        [Display(Name = "Descripcion", Order = 1)]
        public String Descripcion { get; set; }
    }
}
