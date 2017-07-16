using PDVRestaurante.Objetos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using PDVRestaurante.Ayudantes;
using PDVRestaurante.Constantes;

namespace PDVRestaurante.BaseDatos
{
    public static class TablaPersonaFisica
    {
        private static string ConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["RestauranteConn"].ConnectionString;
        }

        private static string Tabla()
        {
            return "PersonaFisica";
        }

        private static string Columnas()
        {
            return "CodPerFisica|Nombre1|Nombre2|Apellido1|Apellido2|Sexo|EstadoCivil|FechaNacimiento";
        }

        private static string LlavePrincipal()
        {
            return "CodPerFisica";
        }

        public static bool InsertarPersonaFisica(params object[] parametros)
        {
            if (parametros.Count() == Columnas().Split('|').Count())
            {
                InterpreteSQL.Insertar(Tabla(), Columnas(), parametros);
            }
            return true;
        }

        public static bool ModificarPersonaFisica(string cedula, params object[] parametros)
        {
            if (parametros.Count() == Columnas().Split('|').Count())
            {
                InterpreteSQL.Modificar(Tabla(), Columnas(), LlavePrincipal(), cedula, parametros);
            }
            return true;
        }

        public static PersonaFisica ObtenerPersonaFisica(string cedula)
        {
            PersonaFisica personaFisica = null;
            var dataSet = InterpreteSQL.Obtener(Tabla(), Columnas(), "CodPerFisica", cedula, CriterioSQL.IgualA);

            if (dataSet.Tables.Count > 0)
            {
                personaFisica = Convertidor.DataSetAObjecto<PersonaFisica>(dataSet).FirstOrDefault();
            }
            return personaFisica;
        }

        public static List<PersonaFisica> ObtenerPersonasFisicas(string columnasFiltro = null, string valoresFiltro = null, string criteriosFiltro = null)
        {
            var personasFisicas = new List<PersonaFisica>();
            var dataSet = InterpreteSQL.Obtener(Tabla(), Columnas(), columnasFiltro, valoresFiltro, criteriosFiltro);

            if (dataSet.Tables.Count > 0)
            {
                personasFisicas = Convertidor.DataSetAObjecto<PersonaFisica>(dataSet);
            }
            return personasFisicas;
        }
    }
}
