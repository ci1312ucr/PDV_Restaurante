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
    public partial class GenerarInventario : Form
    {
        private Sucursal _sucursalActual;
        private List<Propiedad> _columnas;
        private List<InventarioIngrediente> _inventarioIngredientes;
        private string _ordenActual = "IdIngrediente";

        public GenerarInventario()
        {
            InitializeComponent();
            InicializaListView();
            comboBoxSucursales.DataSource = TablaSucursal.ObtenerSucursales();
            buttonGenerar.Enabled = false;
        }
        private void GenerarInventario_Load(object sender, EventArgs e)
        {
            Principal principal = (Principal)this.ParentForm;
            _sucursalActual = principal.SucursalActual();

            comboBoxSucursales.DataSource = TablaSucursal.ObtenerSucursales();
            comboBoxSucursales.DisplayMember = "Detalle";
            comboBoxSucursales.ValueMember = "IdSucursal";
            comboBoxSucursales.SelectedValue = _sucursalActual.IdSucursal;

            comboBoxIngrediente.DataSource = TablaIngrediente.ObtenerIngredientes();
            comboBoxIngrediente.DisplayMember = "Nombre";
            comboBoxIngrediente.ValueMember = "IdIngrediente";

            CargarInventarioTiempoRealSucursalActual();
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            var inventario = TablaInventario.ObtenerInventarios("i.IdSucursal|TiempoReal", _sucursalActual.IdSucursal.ToString() + "|1",
                                                                 CriterioSQL.IgualA + "|" + CriterioSQL.IgualA).FirstOrDefault();
            if (inventario == null)
            {
                var id = TablaInventario.ObtenerSiguienteId();
                TablaInventario.InsertarInventario(id, DateTime.Now, _sucursalActual.IdSucursal, 1);
                inventario = TablaInventario.ObtenerInventarios("i.IdSucursal|TiempoReal", _sucursalActual.IdSucursal.ToString() + "|1",
                                                                 CriterioSQL.IgualA + "|" + CriterioSQL.IgualA).FirstOrDefault();
            }
            TablaInventario_Ingredientes.InsertarInventarioIngrediente(inventario.IdInventario, comboBoxIngrediente.SelectedValue, Convert.ToInt32(numericUpDownCantidad.Value));
        }

        private void buttonGenerarInventario_Click(object sender, EventArgs e)
        {

        }



        #region Funciones
        private void InicializaListView()
        {
            listView.DoubleBuffer();
            var properties = typeof(InventarioIngrediente).GetProperties().
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

        private void CargarListView(List<InventarioIngrediente> inventarioIngredientes)
        {
            _inventarioIngredientes = inventarioIngredientes.OrderBy(e => e.GetType().GetProperty(_ordenActual).GetValue(e)).ToList();
            var newListView = new List<ListViewItem>();
            foreach (InventarioIngrediente inventario in _inventarioIngredientes)
            {
                var row = "";
                foreach (var columna in _columnas)
                {
                    if (columna.Name.Contains("Fecha"))
                    {
                        var valor = (DateTime)inventario.GetType().GetProperty(columna.Name).GetValue(inventario);
                        row += valor.ToString("dd-MM-yyyy") + ",";
                    }
                    else
                    {
                        row += inventario.GetType().GetProperty(columna.Name).GetValue(inventario).ToString() + ",";
                    }
                }
                row = row.TrimEnd(',');
                newListView.Add(new ListViewItem(row.Split(',')));
            }
            listView.Items.Clear();
            listView.Items.AddRange(newListView.ToArray());
            listView.View = View.Details;
            listView.AjustarColumnas();
        }

        private void CargarInventarioTiempoRealSucursalActual()
        {
            var inventario = TablaInventario.ObtenerInventarios("i.IdSucursal|TiempoReal", _sucursalActual.IdSucursal.ToString() + "|1",
                                                                 CriterioSQL.IgualA + "|" + CriterioSQL.IgualA).FirstOrDefault();
            var inventarioIngredientes = new List<InventarioIngrediente>();
            if (inventario != null)
            {
                inventarioIngredientes = TablaInventario_Ingredientes.ObtenerInventarioIngredientes("IdInventario", inventario.IdInventario.ToString(), CriterioSQL.IgualA);
            }
            CargarListView(inventarioIngredientes);
        }
        #endregion

    }
}
