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
using System.Windows.Forms;

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
            return "IdSucursal|FechaApertura|IdDistrito|IdCanton|IdProvincia|IdGerente|FechaInicio|Detalle";
        }

        private static string Columnas2()
        {
            return "IdSucursal|FechaApertura|IdDistrito|IdCanton|IdProvincia|Detalle";
        }

        private static string LlavePrincipal()
        {
            return "IdSucursal";
        }

        private static string TablaSucursalDistritoProvinciaCantonGerente()
        {
            return "Sucursal s INNER JOIN Distrito d ON s.IdDistrito = d.IdDistrito and d.IdCanton = s.IdCanton and d.IdProvincia = s.IdProvincia INNER JOIN Canton c ON s.IdCanton = c.IdCanton and c.IdProvincia = s.IdProvincia INNER JOIN Provincia p ON s.IdProvincia = p.IdProvincia INNER JOIN PersonaFisica pf ON s.IdGerente = pf.CodPerFisica";
        }

        private static string ColumnasSucursalDistritooProvinciaCantonGerente()
        {
            return "d.Descripcion AS Distrito|c.Descripcion AS Canton|p.Descripcion AS Provincia|pf.Nombre1 + ' ' + pf.Apellido1 AS Gerente|s.Detalle|s.FechaApertura|s.FechaInicio|pf.CodPerFisica AS IdGerente";
        }

        public static bool InsertarSucursal(params object[] parametros)
        {
            MessageBox.Show("1");
            if (parametros.Count() == Columnas2().Split('|').Count())
            {
                MessageBox.Show("2");
                InterpreteSQL.Insertar(Tabla(), Columnas2(), parametros);
            }
            return true;
        }

        public static bool ModificarSucursal(int idSucursal, params object[] parametros)
        {
            if (parametros.Count() == Columnas().Split('|').Count())
            {
                InterpreteSQL.Modificar(Tabla(), Columnas(), LlavePrincipal(), idSucursal.ToString(), parametros);
            }
            return true;
        }

        public static Sucursal ObtenerSucursal(string columnaBusqueda, string valorBusqueda)
        {
            Sucursal sucursal = null;
            var dataSet = InterpreteSQL.Obtener(Tabla(), Columnas(), columnaBusqueda, valorBusqueda, CriterioSQL.IgualA);

            if (dataSet.Tables.Count > 0)
            {
                sucursal = Convertidor.DataSetAObjecto<Sucursal>(dataSet).FirstOrDefault();
            }
            return sucursal;
        }

        public static List<Sucursal> ObtenerSucursales(string columnasFiltro = null, string valoresFiltro = null, string criteriosFiltro = null)
        {
            var sucursales = new List<Sucursal>();
            var dataSet = InterpreteSQL.Obtener(TablaSucursalDistritoProvinciaCantonGerente(), ColumnasSucursalDistritooProvinciaCantonGerente(), columnasFiltro, valoresFiltro, criteriosFiltro);

            if (dataSet.Tables.Count > 0)
            {
                sucursales = Convertidor.DataSetAObjecto<Sucursal>(dataSet);
            }
            return sucursales;
        }

        public static int ObtenerIdSucursal()
        {
            int idSucursal = 0;
            try
            {
                using (var conn = new SqlConnection(ConnectionString()))
                {
                    conn.Open();

                        using (var command = new SqlCommand())
                        {
                            command.Connection = conn;
                            command.CommandText = "select max(IdSucursal) from Sucursal";
                            idSucursal = (int)command.ExecuteScalar();
                            idSucursal = idSucursal + 1;
                        }
                }

            }
            catch (Exception ex)
            {
                ManejoExcepciones.LogearExcepcion(ex);
            }
            return idSucursal;
        }
    }
}
