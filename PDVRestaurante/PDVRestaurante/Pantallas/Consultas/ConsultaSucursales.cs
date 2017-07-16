using PDVRestaurante.Ayudantes;
using PDVRestaurante.BaseDatos;
using PDVRestaurante.Objetos;
using System;
using System.Collections.Generic;
using PDVRestaurante.Pantallas.Mantenimiento.Sucursales;
using System.ComponentModel;
using PDVRestaurante.Constantes;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDVRestaurante.Pantallas.Consultas
{
    public partial class ConsultaSucursales : Form
    { 
        private List<Propiedad> _columnas;
        private List<Sucursal> _sucursales;
        private string _ordenActual = "IdSucursal";
        public ConsultaSucursales()
        {
            InitializeComponent();
            InicializaListView();

            //Carga la lista de todos los usuarios            
            CargarListView(TablaSucursal.ObtenerSucursales());

            //Carga la lista de posibles filtros para búsqueda
            comboBox1.Items.AddRange(_columnas.ToArray());
            comboBox1.DisplayMember = "DisplayName";

            //Carga la lista de posibles filtros para ordenar
            comboBoxOrdenar.Items.AddRange(_columnas.ToArray());
            comboBoxOrdenar.DisplayMember = "DisplayName";

            buttonBuscar.Enabled = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e) //Modificar Sucursal
        {
     
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void ConsultaSucursales_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

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
            CargarListView(_sucursales);
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            //Realiza una búsqueda de empleado(s) basado en el filtro seleccionado
            var columna = (Propiedad)comboBox1.SelectedItem;
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
            CargarListView(TablaSucursal.ObtenerSucursales(columna.Name, valor, criterio));
        }

        private void listViewSucursales_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void listViewSucursales_Ajuste(object sender, EventArgs e)
        {
            listViewSucursales.AjustarColumnas();
        }

        private void buttonLimpiarFiltro_Click(object sender, EventArgs e)
        {
            //Limpia el filtro de búsqueda y carga el Grid de nuevo con todos los empleados
            comboBox1.ResetText();
            textBuscar.Clear();
            CargarListView(TablaSucursal.ObtenerSucursales());
        }
        private void InicializaListView()
        {
            listViewSucursales.DoubleBuffer();
            var properties = typeof(Sucursal).GetProperties().
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
                listViewSucursales.Columns.Add(columna.DisplayName);
            }
        }

        private void CargarListView(List<Sucursal> sucursales)
        {
            _sucursales = sucursales.OrderBy(e => e.GetType().GetProperty(_ordenActual).GetValue(e)).ToList();
            var newListView = new List<ListViewItem>();
            foreach (Sucursal sucursal in _sucursales)
            {
                var row = "";
                foreach (var columna in _columnas)
                {
                    if (columna.Name.Contains("Fecha"))
                    {
                        var valor = (DateTime)sucursal.GetType().GetProperty(columna.Name).GetValue(sucursal);
                        row += valor.ToString("dd-MM-yyyy") + ",";
                    }
                    else
                    {
                        row += sucursal.GetType().GetProperty(columna.Name).GetValue(sucursal).ToString() + ",";
                    }
                }
                row = row.TrimEnd(',');
                newListView.Add(new ListViewItem(row.Split(',')));
            }
            listViewSucursales.Items.Clear();
            listViewSucursales.Items.AddRange(newListView.ToArray());
            listViewSucursales.View = View.Details;
            listViewSucursales.AjustarColumnas();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e) //Crear Sucursal
        {
            var crearSucursalForm = this.ParentForm.MdiChildren.ToList().Find(f => f.Name == "CrearSucursal");
            if (crearSucursalForm == null)
            {
                var pantallaCrearEmpleado = new CrearSucursal();
                pantallaCrearEmpleado.MdiParent = this.ParentForm;
                pantallaCrearEmpleado.Dock = DockStyle.Fill;
                pantallaCrearEmpleado.Show();
            }
            else
            {
                crearSucursalForm.Show();
            }
        }
    }
}
