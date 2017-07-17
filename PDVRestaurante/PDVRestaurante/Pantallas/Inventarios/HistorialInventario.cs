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

namespace PDVRestaurante.Pantallas.Inventarios
{
    public partial class HistorialInventario : Form
    {
        private Sucursal _sucursalActual;
        private List<Propiedad> _columnas;
        private List<Inventario> _inventarios;
        private string _ordenActual = "IdSucursal";

        public HistorialInventario()
        {
            InitializeComponent();
            InicializaListView();
        }

        private void HistorialInventario_Load(object sender, EventArgs e)
        {
            Principal principal = (Principal)this.ParentForm;
            _sucursalActual = principal.SucursalActual();

            comboBoxSucursales.DataSource = TablaSucursal.ObtenerSucursales();
            comboBoxSucursales.DisplayMember = "Detalle";
            comboBoxSucursales.ValueMember = "IdSucursal";
            comboBoxSucursales.SelectedValue = _sucursalActual.IdSucursal;

            CargarInventariosSucursalActual();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            _sucursalActual = TablaSucursal.ObtenerSucursal("IdSucursal", comboBoxSucursales.SelectedValue.ToString());
            CargarInventariosSucursalActual();
        }

        private void buttonDetalleInventario_Click(object sender, EventArgs e)
        {
            int idInventario = 0;
            //this.CambiarPantalla("Inventarios", "DetalleInventario", idInventario);
        }


        #region Funciones
        private void InicializaListView()
        {
            listView.DoubleBuffer();
            var properties = typeof(Inventario).GetProperties().
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

        private void CargarListView(List<Inventario> inventarios)
        {
            _inventarios = inventarios.OrderBy(e => e.GetType().GetProperty(_ordenActual).GetValue(e)).ToList();
            var newListView = new List<ListViewItem>();
            foreach (Inventario inventario in _inventarios)
            {
                var row = "";
                foreach (var columna in _columnas)
                {
                    if (columna.Name.Contains("Fecha"))
                    {
                        var valor = (DateTime)inventario.GetType().GetProperty(columna.Name).GetValue(inventario);
                        row += valor.ToString("dd-MM-yyyy") + "|";
                    }
                    else
                    {
                        row += inventario.GetType().GetProperty(columna.Name).GetValue(inventario).ToString() + "|";
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

        private void CargarInventariosSucursalActual()
        {
            var inventarios = TablaInventario.ObtenerInventarios("i.IdSucursal", _sucursalActual.IdSucursal.ToString(), CriterioSQL.IgualA);
            CargarListView(inventarios);
        }
        #endregion

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
