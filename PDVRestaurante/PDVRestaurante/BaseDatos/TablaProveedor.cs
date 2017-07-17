using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDVRestaurante.BaseDatos
{
    public static class TablaProveedor
    {
        private static string Tabla()
        {
            return "Proveedor";
        }

        private static string Columnas()
        {
            return "Cedula|Descripcion";
        }

        private static string LlavePrincipal()
        {
            return "Cedula";
        }
    }
}
