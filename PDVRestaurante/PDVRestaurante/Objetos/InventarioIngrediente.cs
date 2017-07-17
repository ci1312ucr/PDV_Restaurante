using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDVRestaurante.Objetos
{
    public class InventarioIngrediente
    {
        [Display(Name = "Id Inventario", Order = 0)]
        public int IdInventario { get; set; }
        [Display(Name = "Id Ingrediente", Order = 1)]
        public int IdIngrediente { get; set; }
        [Display(Name = "Existencias", Order = 2)]
        public int Existencias { get; set; }
    }
}
