using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDVRestaurante.Objetos
{
    public class Inventario
    {
        [Display(Name = "Id Inventario", Order = 0)]
        public int IdInventario { get; set; }
        [Display(Name = "Fecha", Order = 2)]
        public DateTime Fecha { get; set; }
        [Display(Name = "Id Sucursal", Order = 0)]
        public int IdSucursal { get; set; }
        [Display(Name = "Tiempo Real", Order = 0)]
        public bool TiempoReal { get; set; }
        [Display(Name = "Sucursal", Order = 1)]
        public int NombreSucursal { get; set; }
        [Display(Name = "Ingredientes", Order = 0)]
        public List<KeyValuePair<Ingrediente, int>> Ingredientes { get; set; }
    }
}
