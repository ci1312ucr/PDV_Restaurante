using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDVRestaurante.BaseDatos
{
    public static class TablaFactura
    {
        private static string ConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["RestauranteConn"].ConnectionString;
        }

        private static string Tabla()
        {
            return "Factura";
        }

        private static string Columnas()
        {
            return "IdFactura|Fecha|Monto|TipoPago|CedulaCliente";
        }

        private static string LlavePrincipal()
        {
            return "IdFactura";
        }
    }
}
