using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDVRestaurante.BaseDatos
{
    public static class TablaTelefonosPersona
    {
        private static string Tabla()
        {
            return "TelefonosPersona";
        }

        private static string Columnas()
        {
            return "Cedula|Tipo|Numero";
        }

        private static string LlavePrincipal()
        {
            return "Cedula|Tipo";
        }
    }
}
