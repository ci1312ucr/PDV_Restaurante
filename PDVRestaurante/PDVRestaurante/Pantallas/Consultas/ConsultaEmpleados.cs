using PDVRestaurante.Ayudantes;
using PDVRestaurante.BaseDatos;
using PDVRestaurante.Constantes;
using PDVRestaurante.Objetos;
using PDVRestaurante.Pantallas.Mantenimiento.Empleados;
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
    public partial class ConsultaEmpleados : Form
    {
        private List<Propiedad> _columnas;
        private List<Empleado> _empleados;
        private string _ordenActual = "Cedula";

        public ConsultaEmpleados()
        {
            InitializeComponent();

            InicializaListView();

            //Carga la lista de todos los empleados            
            CargarListView(TablaEmpleado.ObtenerEmpleados());

            //Carga la lista de posibles filtros para búsqueda
            comboBoxBuscar.Items.AddRange(_columnas.ToArray());
            comboBoxBuscar.DisplayMember = "DisplayName";

            //Carga la lista de posibles filtros para ordenar
            comboBoxOrdenar.Items.AddRange(_columnas.ToArray());
            comboBoxOrdenar.DisplayMember = "DisplayName";

            buttonBuscar.Enabled = false;
        }

        private void listViewEmpleados_Ajuste(object sender, EventArgs e)
        {
            listViewEmpleados.AjustarColumnas();
        }

        private void buttonBuscarEmpleado_Click(object sender, EventArgs e)
        {
            //Realiza una búsqueda de empleado(s) basado en el filtro seleccionado
            var columna = (Propiedad)comboBoxBuscar.SelectedItem;
            var valor = textBoxBuscar.Text;

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

            //Para el filtro de sucursal, debe hacer la búsqueda según el Id de Sucursal
            if (columna.Name == "NombreSucursal")
            {
                criterio = CriterioSQL.IgualA;
                columna.Name = "IdSucursal";
                var sucursal = TablaSucursal.ObtenerSucursal("Detalle", valor);
                valor = sucursal == null ? "NULL" : sucursal.IdSucursal.ToString();
            }
            CargarListView(TablaEmpleado.ObtenerEmpleados(columna.Name, valor, criterio));
        }

        private void buttonLimpiarFiltro_Click(object sender, EventArgs e)
        {
            //Limpia el filtro de búsqueda y carga el Grid de nuevo con todos los empleados
            comboBoxBuscar.ResetText();
            textBoxBuscar.Clear();
            CargarListView(TablaEmpleado.ObtenerEmpleados());
        }

        private void textBoxBuscarEmpleado_TextChanged(object sender, EventArgs e)
        {
            //Para realizar una búsqueda por filtro tiene que haber algo escrito en el campo del valor del filtro
            buttonBuscar.Enabled = textBoxBuscar.Text.Length > 0;
        }

        private void comboBoxOrdenar_SelectedIndexChanged(object sender, EventArgs e)
        {
            var columna = (Propiedad)comboBoxOrdenar.SelectedItem;
            _ordenActual = columna.Name;
            CargarListView(_empleados);
        }

        private void buttonModificarEmpleado_Click(object sender, EventArgs e)
        {
            var modificarEmpleadoForm = this.ParentForm.MdiChildren.ToList().Find(f => f.Name == "ModificarEmpleado");
            if (modificarEmpleadoForm == null)
            {
                var pantallaModificarEmpleado = new ModificarEmpleado(listViewEmpleados.SelectedItems[0].Text);
                pantallaModificarEmpleado.MdiParent = this.ParentForm;
                pantallaModificarEmpleado.Dock = DockStyle.Fill;
                pantallaModificarEmpleado.Show();
            }
            else
            {
                modificarEmpleadoForm.Show();
            }
        }

        private void buttonEliminarEmpleado_Click(object sender, EventArgs e)
        {

        }

        private void buttonCrearEmpleado_Click(object sender, EventArgs e)
        {
            var crearEmpleadoForm = this.ParentForm.MdiChildren.ToList().Find(f => f.Name == "CrearEmpleado");
            if (crearEmpleadoForm == null)
            {
                var pantallaCrearEmpleado = new CrearEmpleado();
                pantallaCrearEmpleado.MdiParent = this.ParentForm;
                pantallaCrearEmpleado.Dock = DockStyle.Fill;
                pantallaCrearEmpleado.Show();
            }
            else
            {
                crearEmpleadoForm.Show();
            }
        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }



        #region Funciones
        private void InicializaListView()
        {
            listViewEmpleados.DoubleBuffer();
            var properties = typeof(Empleado).GetProperties().
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
                listViewEmpleados.Columns.Add(columna.DisplayName);
            }
        }

        private void CargarListView(List<Empleado> empleados)
        {
            _empleados = empleados.OrderBy(e => e.GetType().GetProperty(_ordenActual).GetValue(e)).ToList();
            var newListView = new List<ListViewItem>();
            foreach (Empleado empleado in _empleados)
            {
                var row = "";
                foreach (var columna in _columnas)
                {
                    if (columna.Name.Contains("Fecha"))
                    {
                        var valor = (DateTime)empleado.GetType().GetProperty(columna.Name).GetValue(empleado);
                        row += valor.ToString("ddMMyyyy") + ",";
                    } else
                    {
                        row += empleado.GetType().GetProperty(columna.Name).GetValue(empleado).ToString() + ",";
                    }
                }
                row = row.TrimEnd(',');
                newListView.Add(new ListViewItem(row.Split(',')));
            }
            listViewEmpleados.Items.Clear();
            listViewEmpleados.Items.AddRange(newListView.ToArray());
            listViewEmpleados.View = View.Details;
            listViewEmpleados.AjustarColumnas();
        }
        #endregion

        private void comboBoxBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
