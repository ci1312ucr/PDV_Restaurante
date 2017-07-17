using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDVRestaurante.Objetos
{
    public class Mesa_Facturas
    {
        [Display(Name = "IdFactura", Order = 1)]
        public int IdFactura { get; set; }
        [Display(Name = "Numero de Mesa", Order = 2)]
        public int NumeroMesa { get; set; }
        [Display(Name = "Fecha", Order = 3)]
        public DateTime Fecha { get; set; }
        [Display(Name = "Monto", Order = 4)]
        public decimal Monto { get; set; }
        [Display(Name = "Cedula de cliente", Order = 5)]
        public string CedulaCliente { get; set; }
    }
}
