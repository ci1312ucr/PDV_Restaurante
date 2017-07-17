using PDVRestaurante.Ayudantes;
using PDVRestaurante.BaseDatos;
using PDVRestaurante.Constantes;
using PDVRestaurante.Objetos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PDVRestaurante.Pantallas.Mantenimiento.Facturas;

namespace PDVRestaurante.Pantallas.Consultas
{
    public partial class ConsultaFacturas : Form
    {
        private List<Propiedad> _columnas;
        private List<Factura> _facturas;
        private string _ordenActual = "IdFactura";

        public ConsultaFacturas()
        {
            InitializeComponent();

            InicializaListView();

            // Llenar el ListView con todas las facturas 
            CargarListView(TablaFactura.ObtenerFacturas());

            //Carga la lista de posibles filtros para búsqueda
            comboBoxBuscar.Items.AddRange(_columnas.ToArray());
            comboBoxBuscar.DisplayMember = "DisplayName";

            //Carga la lista de posibles filtros para ordenar
            comboBoxOrdenar.Items.AddRange(_columnas.ToArray());
            comboBoxOrdenar.DisplayMember = "DisplayName";

            buttonBuscar.Enabled = false;
        }

        private void listViewFacturas_Ajuste(object sender, EventArgs e)
        {
            listViewFacturas.AjustarColumnas();
        }

        private void textBuscar_TextChanged(object sender, EventArgs e)
        {
            //Para realizar una búsqueda por filtro tiene que haber algo escrito en el campo del valor del filtro
            buttonBuscar.Enabled = textBuscar.Text.Length > 0;
        }

        private void comboBoxOrdenar_SelectedIndexChanged(object sender, EventArgs e)
        {
            var columna = (Propiedad)comboBoxOrdenar.SelectedItem;
            _ordenActual = columna.Name;
            CargarListView(_facturas);
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            //Realiza una búsqueda de empleado(s) basado en el filtro seleccionado
            var columna = (Propiedad)comboBoxBuscar.SelectedItem;
            var valor = textBuscar.Text;

            //Define el criterio de comparación para enviar la consulta SQL adecuada
            var criterio = CriterioSQL.IgualA;
            if (columna.ValueType == typeof(string))
            {
                criterio = CriterioSQL.Contiene;
                valor = "'%" + valor + "%'";
            }
            if (columna.ValueType == typeof(DateTime))
            {
                valor = "'" + valor + "'";
            }

            /*Para el filtro de sucursal, debe hacer la búsqueda según el Id de Sucursal
            if (columna.Name == "NombreSucursal")
            {
                criterio = CriterioSQL.IgualA;
                columna.Name = "IdSucursal";
                var sucursal = TablaSucursal.ObtenerSucursal("Detalle", valor);
                valor = sucursal == null ? "NULL" : sucursal.IdSucursal.ToString();
            }*/
            CargarListView(TablaFactura.ObtenerFacturas(columna.Name, valor, criterio));
        }

        private void buttonLimpiarFiltro_Click(object sender, EventArgs e)
        {
            //Limpia el filtro de búsqueda y carga el Grid de nuevo con todos los empleados
            comboBoxBuscar.ResetText();
            textBuscar.Clear();
            CargarListView(TablaFactura.ObtenerFacturas());
        }

        private void buttonCrear_Click(object sender, EventArgs e)
        {
            this.CambiarPantalla("Mantenimiento.Facturas","CrearFactura");
        }

        #region Funciones
        private void InicializaListView()
        {
            listViewFacturas.DoubleBuffer();
            var properties = typeof(Factura).GetProperties().
                                  Select(p => new Propiedad
                                  {
                                      Name = p.Name,
                                      ValueType = p.PropertyType,
                                      DisplayName = p.CustomAttributes.First().NamedArguments.Where(n => n.MemberName == "Name").Select(n => n.TypedValue.Value).First().ToString(),
                                      Order = (int)p.CustomAttributes.First().NamedArguments.Where(n => n.MemberName == "Order").Select(n => n.TypedValue.Value).First()
                                  }).ToList();
            _columnas = properties.Where(p => p.Order > 0).OrderBy(p => p.Order).ToList();
            foreach (var columna in _columnas)
            {
                listViewFacturas.Columns.Add(columna.DisplayName);
            }
        }

        private void CargarListView(List<Factura> facturas)
        {
            _facturas = facturas.OrderBy(e => e.GetType().GetProperty(_ordenActual).GetValue(e)).ToList();
            var newListView = new List<ListViewItem>();
            foreach (Factura factura in _facturas)
            {
                var row = "";
                foreach (var columna in _columnas)
                {
                    if (columna.Name.Contains("Fecha"))
                    {
                        var valor = (DateTime)factura.GetType().GetProperty(columna.Name).GetValue(factura);
                        row += valor.ToString("dd-MM-yyyy") + ",";
                    }
                    else
                    {
                        row += factura.GetType().GetProperty(columna.Name).GetValue(factura).ToString() + ",";
                    }
                }
                row = row.TrimEnd(',');
                newListView.Add(new ListViewItem(row.Split(',')));
            }
            listViewFacturas.Items.Clear();
            listViewFacturas.Items.AddRange(newListView.ToArray());
            listViewFacturas.View = View.Details;
            listViewFacturas.AjustarColumnas();
        }
        #endregion

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
