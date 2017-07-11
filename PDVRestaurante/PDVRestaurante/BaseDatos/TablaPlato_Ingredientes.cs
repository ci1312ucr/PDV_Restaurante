using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDVRestaurante.BaseDatos
{
    public static class TablaPlato_Ingredientes
    {
        private static string ConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["RestauranteConn"].ConnectionString;
        }

        private static string Tabla()
        {
            return "Plato_Ingredientes";
        }

        private static string Columnas()
        {
            return "IdPlato,IdIngrediente,Cantidad";
        }

        private static string LlavePrincipal()
        {
            return "IdPlato|IdIngrediente";
        }
    }
}
