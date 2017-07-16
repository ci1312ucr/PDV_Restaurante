using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PDVRestaurante.Objetos
{
    public class Factura
    {
        [Display(Name = "ID", Order = 0)]
        public int IdFactura { get; set; }

        [Display(Name = "Cédula del cliente", Order = 1)]
        public string CedulaCliente { get; set; }

        [Display(Name = "Fecha", Order = 2)]
        public DateTime Fecha { get; set; }

        [Display(Name = "Monto", Order = 4)]
        public decimal Monto { get; set; }

        [Display(Name = "Tipo de Pago", Order = 3)]
        public string TipoPago { get; set; }
    }
}
