using PDVRestaurante.Objetos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDVRestaurante.Ayudantes
{
    public static class Convertidor
    {
        public static List<TipoObjeto> DataSetAObjecto<TipoObjeto>(DataSet dataSet)
        {
            var listaObjetos = new List<TipoObjeto>();
            try
            {
                var tipo = typeof(TipoObjeto);
                var objeto = (TipoObjeto)Activator.CreateInstance(tipo);
                var propiedades = objeto.GetType().GetProperties();
                foreach (DataRow row in dataSet.Tables[0].Rows)
                {
                    var nuevoObjeto = (TipoObjeto)Activator.CreateInstance(tipo);
                    foreach (var propiedad in propiedades)
                    {
                        if (row.Table.Columns.Contains(propiedad.Name))
                        {
                            var tipoPropiedad = propiedad.PropertyType;
                            if (tipoPropiedad == typeof(string) || tipoPropiedad == typeof(DateTime) || tipoPropiedad == typeof(char))
                            {
                                var value = row[propiedad.Name] == DBNull.Value ? "" : row[propiedad.Name];
                                nuevoObjeto.GetType().GetProperty(propiedad.Name).SetValue(nuevoObjeto, tipoPropiedad == typeof(char) ? Convert.ToChar(value) : value);
                            }
                            else
                            {
                                var value = row[propiedad.Name] == DBNull.Value ? null : row[propiedad.Name];
                                nuevoObjeto.GetType().GetProperty(propiedad.Name).SetValue(nuevoObjeto, value);
                            }
                        }
                    }
                    listaObjetos.Add(nuevoObjeto);
                }
            }
            catch (Exception ex)
            {
                ManejoExcepciones.LogearExcepcion(ex);
            }
            return listaObjetos;
        } 
    }
}
