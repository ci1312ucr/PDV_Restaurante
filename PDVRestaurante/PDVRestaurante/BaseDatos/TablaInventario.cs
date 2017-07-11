using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDVRestaurante.BaseDatos
{
    public static class TablaInventario
    {
        private static string ConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["RestauranteConn"].ConnectionString;
        }

        private static string Tabla()
        {
            return "Inventario";
        }

        private static string Columnas()
        {
            return "IdInventario|Fecha|IdSucursal";
        }

        private static string LlavePrincipal()
        {
            return "IdInventario";
        }
    }
}
