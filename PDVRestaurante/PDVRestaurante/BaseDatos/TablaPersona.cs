using PDVRestaurante.Objetos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using PDVRestaurante.Constantes;
using PDVRestaurante.Ayudantes;

namespace PDVRestaurante.Objetos
{
    public static class TablaPersona
    {
        private static string Tabla()
        {
            return "Persona";
        }

        private static string Columnas()
        {
            return "Cedula|TipoP";
        }

        private static string LlavePrincipal()
        {
            return "Cedula";
        }

        public static bool InsertarPersona(params object[] parametros)
        {
            if (parametros.Count() == Columnas().Split('|').Count())
            {
                InterpreteSQL.Insertar(Tabla(), Columnas(), parametros);
            }
            return true;
        }

        public static bool ModificarPersona(string cedula, params object[] parametros)
        {
            if (parametros.Count() == Columnas().Split('|').Count())
            {
                InterpreteSQL.Modificar(Tabla(), Columnas(), LlavePrincipal(), cedula, parametros);
            }
            return true;
        }

        public static Persona ObtenerPersona(string cedula)
        {
            Persona persona = null;
            var dataSet = InterpreteSQL.Obtener(Tabla(), Columnas(), "Cedula", cedula, CriterioSQL.IgualA);

            if (dataSet.Tables.Count > 0)
            {
                persona = Convertidor.DataSetAObjecto<Persona>(dataSet).FirstOrDefault();
            }
            return persona;
        }

        public static List<Persona> ObtenerPersonas(string columnasFiltro = null, string valoresFiltro = null, string criteriosFiltro = null)
        {
            var personas = new List<Persona>();
            var dataSet = InterpreteSQL.Obtener(Tabla(), Columnas(), columnasFiltro, valoresFiltro, criteriosFiltro);

            if (dataSet.Tables.Count > 0)
            {
                personas = Convertidor.DataSetAObjecto<Persona>(dataSet);
            }
            return personas;
        }
    }
}
