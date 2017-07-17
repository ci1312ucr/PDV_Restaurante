using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PDVRestaurante.Ayudantes;
using PDVRestaurante.Constantes;
using PDVRestaurante.Objetos;

namespace PDVRestaurante.BaseDatos
{
    public static class TablaPlato
    {
        private static string Tabla()
        {
            return "Plato";
        }

        private static string Columnas()
        {
            return "IdPlato|Nombre|Descripcion|Precio";
        }

        private static string LlavePrincipal()
        {
            return "IdPlato";
        }

        public static bool InsertarPlato(params object[] parametros)
        {
            if (parametros.Count() == Columnas().Split('|').Count())
            {
                InterpreteSQL.Insertar(Tabla(), Columnas(), parametros);
            }
            return true;
        }

        public static bool ModificarPlato(int id, params object[] parametros)
        {
            if (parametros.Count() == Columnas().Split('|').Count())
            {
                InterpreteSQL.Modificar(Tabla(), Columnas(), LlavePrincipal(), id.ToString(), parametros);
            }
            return true;
        }

        public static Plato ObtenerPlato(int id)
        {
            Plato plato = null;
            var dataSet = InterpreteSQL.Obtener(Tabla(), Columnas(), "c.IdPlato", id.ToString(), CriterioSQL.IgualA);

            if (dataSet.Tables.Count > 0)
            {
                plato = Convertidor.DataSetAObjecto<Plato>(dataSet).FirstOrDefault();
            }
            return plato;
        }

        public static List<Plato> ObtenerPlatos(string columnasFiltro = null, string valoresFiltro = null, string criteriosFiltro = null)
        {
            var platos = new List<Plato>();
            var dataSet = InterpreteSQL.Obtener(Tabla(), Columnas(), columnasFiltro, valoresFiltro, criteriosFiltro);

            if (dataSet.Tables.Count > 0)
            {
                platos = Convertidor.DataSetAObjecto<Plato>(dataSet);
            }
            return platos;
        }
    }
}
