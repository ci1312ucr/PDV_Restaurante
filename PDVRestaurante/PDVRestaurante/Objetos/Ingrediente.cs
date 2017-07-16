using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using PDVRestaurante.BaseDatos;

namespace PDVRestaurante.Objetos
{
    public class Ingrediente
    {
        [Display(Name = "ID", Order = 0)]
        public int IdIngrediente { get; set; }

        [Display(Name = "Nombre", Order = 1)]
        public string Nombre { get; set; }
    }
}
