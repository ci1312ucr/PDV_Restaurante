using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDVRestaurante.Objetos
{
    public class Platos_Factura
    {
        [Display(Name = "Id Factura", Order = 0)]
        public int IdFactura { get; set; }
        [Display(Name = "Id Plato", Order = 0)]
        public int IdPlato { get; set; }
        [Display(Name = "Cantidad", Order = 1)]
        public int Cantidad { get; set; }
        [Display(Name = "Descripción", Order = 2)]
        public string Nombre { get; set; }
        [Display(Name = "Valor Unitario", Order = 3)]
        public decimal Precio { get; set; }
    }
}
