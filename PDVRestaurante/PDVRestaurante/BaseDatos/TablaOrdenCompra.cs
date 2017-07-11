using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDVRestaurante.BaseDatos
{
    public static class TablaOrdenCompra
    {
        private static string ConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["RestauranteConn"].ConnectionString;
        }

        private static string Tabla()
        {
            return "OrdenCompra";
        }

        private static string Columnas()
        {
            return "IdCompra|Fecha|CedulaEmpleado|CedulaProveedor";
        }

        private static string LlavePrincipal()
        {
            return "IdCompra";
        }
    }
}
