using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace PDVRestaurante.Ayudantes
{
    public static class InterpreteSQL
    {
        private static string ConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["RestauranteConn"].ConnectionString;
        }

        public static bool Insertar(string tabla, string columnas, params object[] parametros)
        {
            try
            {
                using (var conn = new SqlConnection(ConnectionString()))
                {
                    conn.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = conn;
                        command.CommandText = "INSERT INTO " + tabla + " (" + columnas.Replace("|", ",") + ")";
                        command.CommandText += " VALUES (@" + columnas.Replace("|", ", @") + ")";
                        int i = 0;
                        foreach (var s in columnas.Split('|'))
                        {
                            command.Parameters.AddWithValue("@" + s, parametros[i]);
                            i++;
                        }
                        command.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                ManejoExcepciones.LogearExcepcion(ex);
                return false;
            }
        }

        public static bool Modificar(string tabla, string columnas, string nombreLlavesPrincipales, string valorLlavesPrincipales, params object[] parametros)
        {
            try
            {
                using (var conn = new SqlConnection(ConnectionString()))
                {
                    conn.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = conn;
                        command.CommandText = "UPDATE " + tabla;
                        command.CommandText += " SET ";
                        int i = 0;
                        foreach (var s in columnas.Split('|'))
                        {
                            command.CommandText += s + " = @" + s + ", ";
                            command.Parameters.AddWithValue("@" + s, parametros[i]);
                            i++;
                        }
                        command.CommandText = command.CommandText.TrimEnd(' ', ',');
                        command.CommandText += " WHERE ";
                        var nombresLlavePrincipal = nombreLlavesPrincipales.Split('|');
                        var valoresLlavePrincipal = valorLlavesPrincipales.Split('|');
                        for (int j = 0; j < nombresLlavePrincipal.Count(); j++)
                        {
                            command.CommandText += nombresLlavePrincipal[j] + " = " + valoresLlavePrincipal[j];
                            command.CommandText += (j < nombresLlavePrincipal.Count() - 1) ? " AND " : "";
                        }
                        command.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                ManejoExcepciones.LogearExcepcion(ex);
                return false;
            }
        }

        public static DataSet Obtener(string tabla, string columnas, string columnasFiltro = null,
                                      string valoresFiltro = null, string criteriosFiltro = null, string concatenadoresFiltro = "AND")
        {
            var returnDS = new DataSet();
            try
            {
                using (var conn = new SqlConnection(ConnectionString()))
                {
                    conn.Open();
                    using (var dataAdapter = new SqlDataAdapter())
                    {
                        using (var command = new SqlCommand())
                        {
                            command.Connection = conn;
                            command.CommandText = "SELECT " + columnas.Replace('|', ',') + " FROM " + tabla;
                            if (columnasFiltro != null && valoresFiltro != null)
                            {
                                command.CommandText += " WHERE ";
                                var columnasFiltroArray = columnasFiltro.Split('|');
                                var valoresFiltroArray = valoresFiltro.Split('|');
                                var criteriosFiltroArray = criteriosFiltro.Split('|');
                                var concatenadoresFiltroArray = concatenadoresFiltro.Split('|');
                                for (int j = 0; j < columnasFiltroArray.Count(); j++)
                                {
                                    command.CommandText += columnasFiltroArray[j] + " " + criteriosFiltroArray[j] + " " + valoresFiltroArray[j];
                                    command.CommandText += (j < columnasFiltroArray.Count() - 1) ? " " + concatenadoresFiltroArray[j] + " " : "";
                                }
                            }
                            dataAdapter.SelectCommand = command;
                            dataAdapter.Fill(returnDS);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ManejoExcepciones.LogearExcepcion(ex);
            }
            return returnDS;
        }

        public static int ObtenerSiguienteId(string tabla, string columna)
        {
            var returnVal = 0;
            try
            {
                using (var conn = new SqlConnection(ConnectionString()))
                {
                    conn.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = conn;
                        command.CommandText = "SELECT max(" + columna + ")+1 FROM " + tabla;
                        var tempVal = command.ExecuteScalar();
                        if (tempVal == DBNull.Value)
                        {
                            returnVal = 1;
                        } else
                        {
                            returnVal = (int)tempVal;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ManejoExcepciones.LogearExcepcion(ex);
            }
            return returnVal;
        }
    }
}
