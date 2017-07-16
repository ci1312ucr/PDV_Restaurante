using System;
using System.Collections.Generic;
using System.Configuration;
using PDVRestaurante.Ayudantes;
using PDVRestaurante.Constantes;
using PDVRestaurante.Objetos;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDVRestaurante.BaseDatos
{
    public static class TablaProvincia
    {
        private static string ConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["RestauranteConn"].ConnectionString;
        }

        private static string Tabla()
        {
            return "Provincia";
        }

        private static string Columnas()
        {
            return "IdProvincia|Descripcion";
        }

        private static string LlavePrincipal()
        {
            return "IdProvincia";
        }

        public static List<Provincia> ObtenerProvincias(string columnasFiltro = null, string valoresFiltro = null, string criteriosFiltro = null)
        {
            var provincias = new List<Provincia>();
            var dataSet = InterpreteSQL.Obtener(Tabla(), Columnas(), columnasFiltro, valoresFiltro, criteriosFiltro);

            if (dataSet.Tables.Count > 0)
            {
                provincias = Convertidor.DataSetAObjecto<Provincia>(dataSet);
            }
            return provincias;
        }
    }
}
