using PDVRestaurante.Ayudantes;
using PDVRestaurante.Constantes;
using PDVRestaurante.Objetos;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDVRestaurante.BaseDatos
{
    public static class TablaSucursal
    {
        private static string ConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["RestauranteConn"].ConnectionString;
        }

        private static string Tabla()
        {
            return "Sucursal";
        }

        private static string Columnas()
        {
            return "IdSucursal,FechaApertura,IdDistrito,IdCanton,IdProvincia,IdGerente,FechaInicio,Detalle";
        }

        private static string LlavePrincipal()
        {
            return "IdSucursal";
        }

        public static bool InsertarSucursal(params object[] parametros)
        {
            if (parametros.Count() == Columnas().Split(',').Count())
            {
                InterpreteSQL.Insertar(ConnectionString(), Tabla(), Columnas(), parametros);
            }
            return true;
        }

        public static bool ModificarSucursal(int idSucursal, params object[] parametros)
        {
            if (parametros.Count() == Columnas().Split(',').Count())
            {
                InterpreteSQL.Modificar(ConnectionString(), Tabla(), Columnas(), LlavePrincipal(), idSucursal.ToString(), parametros);
            }
            return true;
        }

        public static Sucursal ObtenerSucursal(string columnaBusqueda, string valorBusqueda)
        {
            Sucursal sucursal = null;
            var dataSet = InterpreteSQL.Obtener(ConnectionString(), Tabla(), Columnas(), columnaBusqueda, valorBusqueda, CriterioSQL.IgualA);

            if (dataSet.Tables.Count > 0)
            {
                try
                {
                    var dataRow = dataSet.Tables[0].Rows[0];
                    sucursal = new Sucursal();
                    sucursal.IdSucursal = (int)dataRow["IdSucursal"];
                    sucursal.FechaApertura = (DateTime)dataRow["FechaApertura"];
                    sucursal.IdDistrito = (int)dataRow["IdDistrito"];
                    sucursal.IdCanton = (int)dataRow["IdCanton"];
                    sucursal.IdProvincia = (int)dataRow["IdProvincia"];
                    sucursal.IdGerente = dataRow["IdGerente"] == DBNull.Value ? "" : dataRow["IdGerente"].ToString();
                    sucursal.FechaInicio = dataRow["FechaInicio"] == DBNull.Value ? null : (DateTime?)dataRow["FechaInicio"];
                    sucursal.Detalle = dataRow["Detalle"] == DBNull.Value ? "" : dataRow["Detalle"].ToString();
                }
                catch (Exception ex)
                {
                    ManejoExcepciones.LogearExcepcion(ex);
                }
            }
            return sucursal;
        }

        public static List<Sucursal> ObtenerSucursales()
        {
            var sucursales = new List<Sucursal>();
            var dataSet = InterpreteSQL.Obtener(ConnectionString(), Tabla(), Columnas());

            if (dataSet.Tables.Count > 0)
            {
                try
                {
                    foreach(DataRow r in dataSet.Tables[0].Rows)
                    {
                        var sucursal = new Sucursal();
                        sucursal.IdSucursal = (int)r["IdSucursal"];
                        sucursal.FechaApertura = (DateTime)r["FechaApertura"];
                        sucursal.IdDistrito = (int)r["IdDistrito"];
                        sucursal.IdCanton = (int)r["IdCanton"];
                        sucursal.IdProvincia = (int)r["IdProvincia"];
                        sucursal.IdGerente = r["IdGerente"] == DBNull.Value ? "" : r["IdGerente"].ToString();
                        sucursal.FechaInicio = r["FechaInicio"] == DBNull.Value ? null : (DateTime?)r["FechaInicio"];
                        sucursal.Detalle = r["Detalle"] == DBNull.Value ? "" : r["Detalle"].ToString();
                        sucursales.Add(sucursal);
                    }
                }
                catch (Exception ex)
                {
                    ManejoExcepciones.LogearExcepcion(ex);
                }
            }
            return sucursales;
        }
    }
}
