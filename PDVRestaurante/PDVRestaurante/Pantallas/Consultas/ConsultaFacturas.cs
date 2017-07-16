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

namespace PDVRestaurante.Pantallas.Consultas
{
    public partial class ConsultaFacturas : Form
    {
        private List<Propiedad> _columnas;
        private List<Factura> _facturas;
        private string _ordenActual = "IdIngrediente";

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
                        row += valor.ToString("ddMMyyyy") + ",";
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
    }
}
