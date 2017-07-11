using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDVRestaurante.BaseDatos
{
    public static class TablaMesa_Factura
    {
        private static string ConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["RestauranteConn"].ConnectionString;
        }

        private static string Tabla()
        {
            return "Mesa_Factura";
        }

        private static string Columnas()
        {
            return "IdFactura|NumeroMesa";
        }

        private static string LlavePrincipal()
        {
            return "IdFactura|NumeroMesa";
        }
    }
}
