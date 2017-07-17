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

namespace PDVRestaurante.Pantallas.Restaurante
{
    public partial class PagarMesaFactura : Form
    {
        private List<Propiedad> _columnas;
        private List<Mesa_Facturas> _facturas;
        private string _ordenActual = "IdFactura";

        public PagarMesaFactura()
        {
            InitializeComponent();
            InicializaListView();
        }

        private void textBuscar_TextChanged(object sender, EventArgs e)
        {
            buttonBuscar.Enabled = textBuscar.Text.Length > 0;
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            var facturas = TablaMesa_Factura.ObtenerMesa_Facturas("NumeroMesa|Cancelada", textBuscar.Text + "|0", CriterioSQL.IgualA + "|" + CriterioSQL.IgualA);
            CargarListView(facturas);
        }

        private void buttonVerDetalle_Click(object sender, EventArgs e)
        {
            this.CambiarPantalla("Restaurante", "DetalleFactura", Convert.ToInt32(listView.SelectedItems[0].Text));
        }

        private void buttonPagar_Click(object sender, EventArgs e)
        {
            this.CambiarPantalla("Restaurante", "PagoFactura", Convert.ToInt32(listView.SelectedItems[0].Text));
        }

        #region Funciones
        private void InicializaListView()
        {
            listView.DoubleBuffer();
            var properties = typeof(Mesa_Facturas).GetProperties().
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
                listView.Columns.Add(columna.DisplayName);
            }
        }

        private void CargarListView(List<Mesa_Facturas> facturas)
        {
            _facturas = facturas.OrderBy(e => e.GetType().GetProperty(_ordenActual).GetValue(e)).ToList();
            var newListView = new List<ListViewItem>();
            foreach (Mesa_Facturas factura in _facturas)
            {
                var row = "";
                foreach (var columna in _columnas)
                {
                    if (columna.Name.Contains("Fecha"))
                    {
                        var valor = (DateTime)factura.GetType().GetProperty(columna.Name).GetValue(factura);
                        row += valor.ToString("dd-MM-yyyy") + "|";
                    }
                    else
                    {
                        row += factura.GetType().GetProperty(columna.Name).GetValue(factura).ToString() + "|";
                    }
                }
                row = row.TrimEnd(',');
                newListView.Add(new ListViewItem(row.Split('|')));
            }
            listView.Items.Clear();
            listView.Items.AddRange(newListView.ToArray());
            listView.View = View.Details;
            listView.AjustarColumnas();
        }
        #endregion

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
