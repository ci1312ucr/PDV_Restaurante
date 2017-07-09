using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDVRestaurante.BaseDatos
{
    public static class TablaTelefonoSucursal
    {
        private static string ConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["RestauranteConn"].ConnectionString;
        }

        private static string Tabla()
        {
            return "TelefonoSucursal";
        }

        private static string Columnas()
        {
            return "";
        }

        private static string LlavePrincipal()
        {
            return "";
        }
    }
}
