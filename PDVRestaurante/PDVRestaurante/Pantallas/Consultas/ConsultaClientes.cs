using PDVRestaurante.Ayudantes;
using PDVRestaurante.BaseDatos;
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
    public partial class ConsultaClientes : Form
    {
        private List<Propiedad> _columnas;
        private List<ClienteFisico> _clientes;
        private string _ordenActual = "Cedula";


        public ConsultaClientes()
        {
            InitializeComponent();
            
            //buttonBuscarCliente.Enabled = false;
            InicializaListView();

            //Carga la lista de todos los clientes            
            CargarListView(TablaCliente.ObtenerClientesFisicos());

            //Carga la lista de posibles filtros para búsqueda
            comboBoxBuscar.Items.AddRange(_columnas.ToArray());
            comboBoxBuscar.DisplayMember = "DisplayName";

            //Carga la lista de posibles filtros para ordenar
            comboBoxOrdenar.Items.AddRange(_columnas.ToArray());
            comboBoxOrdenar.DisplayMember = "DisplayName";

            buttonBuscar.Enabled = false;
        }

        private void listViewClientes_Ajuste(object sender, EventArgs e)
        {
            listViewClientes.AjustarColumnas();
        }

        private void comboBoxBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {

        }

        private void buttonLimpiarFiltro_Click(object sender, EventArgs e)
        {

        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {

        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {

        }

        private void buttonCrear_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxOrdenar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


        #region Funciones
        private void InicializaListView()
        {
            listViewClientes.DoubleBuffer();
            var properties = typeof(ClienteFisico).GetProperties().
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
                listViewClientes.Columns.Add(columna.DisplayName);
            }
        }

        private void CargarListView(List<ClienteFisico> clientes)
        {
            _clientes = clientes.OrderBy(e => e.GetType().GetProperty(_ordenActual).GetValue(e)).ToList();
            var newListView = new List<ListViewItem>();
            foreach (ClienteFisico cliente in _clientes)
            {
                var row = "";
                foreach (var columna in _columnas)
                {
                    if (columna.Name.Contains("Fecha"))
                    {
                        var valor = (DateTime)cliente.GetType().GetProperty(columna.Name).GetValue(cliente);
                        row += valor.ToString("ddMMyyyy") + ",";
                    }
                    else
                    {
                        row += cliente.GetType().GetProperty(columna.Name).GetValue(cliente).ToString() + ",";
                    }
                }
                row = row.TrimEnd(',');
                newListView.Add(new ListViewItem(row.Split(',')));
            }
            listViewClientes.Items.Clear();
            listViewClientes.Items.AddRange(newListView.ToArray());
            listViewClientes.View = View.Details;
            listViewClientes.AjustarColumnas();
        }
        #endregion
    }
}
