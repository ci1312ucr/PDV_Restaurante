using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PDVRestaurante.Objetos
{
    public class Plato
    {
        [Display(Name = "ID", Order = 0)]
        public int IdPlato { get; set; }
        [Display(Name = "Nombre", Order = 1)]
        public string Nombre { get; set; }
        [Display(Name = "Descripción", Order = 2)]
        public string Descripcion { get; set; }
        [Display(Name = "Precio", Order = 3)]
        public decimal Precio { get; set; }
    }
}