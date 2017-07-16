using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDVRestaurante.Objetos
{
    public class Platos_Factura
    {
        public int IdFactura { get; set; }
        public int IdPlato { get; set; }
        public int cantidad { get; set; }
    }
}
