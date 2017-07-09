using PDVRestaurante.Ayudantes;
using PDVRestaurante.Constantes;
using PDVRestaurante.Objetos;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDVRestaurante.BaseDatos
{
    public static class TablaCliente
    {
        private static string ConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["RestauranteConn"].ConnectionString;
        }

        private static string Tabla()
        {
            return "Cliente";
        }

        private static string TablaClienteFisico()
        {
            return "PersonaFisica a INNER JOIN Cliente b ON a.CodPerFisica = b.Cedula";
        }

        private static string Columnas()
        {
            return "Cedula,Frecuente";
        }

        private static string ColumnasClienteFisico()
        {
            return "CodPerFisica,Nombre1,Nombre2,Apellido1,Apellido2,Sexo,EstadoCivil,FechaNacimiento,Frecuente ";
        }

        private static string LlavePrincipal()
        {
            return "Cedula";
        }

        public static bool InsertarCliente(params object[] parametros)
        {
            if (parametros.Count() == Columnas().Split(',').Count())
            {
                InterpreteSQL.Insertar(ConnectionString(), Tabla(), Columnas(), parametros);
            }
            return true;
        }

        public static bool ModificarCliente(string cedula, params object[] parametros)
        {
            if (parametros.Count() == Columnas().Split(',').Count())
            {
                InterpreteSQL.Modificar(ConnectionString(), Tabla(), Columnas(), LlavePrincipal(), cedula, parametros);
            }
            return true;
        }

        public static ClienteFisico ObtenerClienteFisico(string cedula)
        {
            ClienteFisico cliente = null;
            var dataSet = InterpreteSQL.Obtener(ConnectionString(), TablaClienteFisico(), ColumnasClienteFisico(), "b.CodPerFisica", cedula, CriterioSQL.IgualA);

            if (dataSet.Tables.Count > 0)
            {
                try
                {
                    var dataRow = dataSet.Tables[0].Rows[0];
                    cliente = new ClienteFisico();
                    cliente.Cedula = dataRow["CodPerFisica"].ToString();
                    cliente.Nombre1 = dataRow["Nombre1"].ToString();
                    cliente.Nombre2 = dataRow["Nombre2"] == DBNull.Value ? "" : dataRow["Nombre2"].ToString();
                    cliente.Apellido1 = dataRow["Apellido1"].ToString();
                    cliente.Apellido2 = dataRow["Apellido2"] == DBNull.Value ? "" : dataRow["Apellido2"].ToString();
                    cliente.Sexo = dataRow["Sexo"].ToString()[0];
                    cliente.EstadoCivil = dataRow["EstadoCivil"] == DBNull.Value ? "" : dataRow["EstadoCivil"].ToString();
                    cliente.FechaNacimiento = (DateTime)dataRow["FechaNacimiento"];
                    cliente.Frecuente = (bool)dataRow["Frecuente"];
                }
                catch (Exception ex)
                {
                    ManejoExcepciones.LogearExcepcion(ex);
                }
            }
            return cliente;
        }

        public static List<ClienteFisico> ObtenerClientesFisicos()
        {
            var clientes = new List<ClienteFisico>();
            var dataSet = InterpreteSQL.Obtener(ConnectionString(), TablaClienteFisico(), ColumnasClienteFisico());

            if (dataSet.Tables.Count > 0)
            {
                try
                {
                    foreach (DataRow r in dataSet.Tables[0].Rows)
                    {
                        var cliente = new ClienteFisico();
                        cliente.Cedula = r["CodPerFisica"].ToString();
                        cliente.Nombre1 = r["Nombre1"].ToString();
                        cliente.Nombre2 = r["Nombre2"] == DBNull.Value ? "" : r["Nombre2"].ToString();
                        cliente.Apellido1 = r["Apellido1"].ToString();
                        cliente.Apellido2 = r["Apellido2"] == DBNull.Value ? "" : r["Apellido2"].ToString();
                        cliente.Sexo = r["Sexo"].ToString()[0];
                        cliente.EstadoCivil = r["EstadoCivil"] == DBNull.Value ? "" : r["EstadoCivil"].ToString();
                        cliente.FechaNacimiento = (DateTime)r["FechaNacimiento"];
                        cliente.Frecuente = (bool)r["Frecuente"];
                        clientes.Add(cliente);
                    }
                }
                catch (Exception ex)
                {
                    ManejoExcepciones.LogearExcepcion(ex);
                }
            }
            return clientes;
        }
    }
}
