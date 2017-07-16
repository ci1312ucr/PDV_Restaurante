using PDVRestaurante.Ayudantes;
using PDVRestaurante.Objetos;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDVRestaurante.BaseDatos
{
    public static class TablaCanton
    {
        private static string Tabla()
        {
            return "Canton";
        }

        private static string Columnas()
        {
            return "IdProvincia|IdCanton|Descripcion";
        }

        private static string LlavePrincipal()
        {
            return "IdProvincia|IdCanton";
        }

        public static List<Canton> ObtenerCantones(string columnasFiltro = null, string valoresFiltro = null, string criteriosFiltro = null)
        {
            var canton = new List<Canton>();
            var dataSet = InterpreteSQL.Obtener(Tabla(), Columnas(), columnasFiltro, valoresFiltro, criteriosFiltro);

            if (dataSet.Tables.Count > 0)
            {
                canton = Convertidor.DataSetAObjecto<Canton>(dataSet);
            }
            return canton;
        }

        internal static object ObtenerCantones(string v1, string v2, object igualA)
        {
            throw new NotImplementedException();
        }
    }
}
