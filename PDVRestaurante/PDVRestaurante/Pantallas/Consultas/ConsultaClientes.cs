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
        public ConsultaClientes()
        {
            InitializeComponent();

            //Carga el Grid con la lista de todos los empleados
            dataGridConsultaClientes.DataSource = TablaCliente.ObtenerClientesFisicos();
            dataGridConsultaClientes.ClearSelection();

            //Carga la lista de posibles filtros para búsqueda
            List<DataGridViewColumn> columnasFiltro = new List<DataGridViewColumn>();
            foreach (DataGridViewColumn c in dataGridConsultaClientes.Columns)
            {
                if (c.Visible == true)
                {
                    columnasFiltro.Add(c);
                }
            }
            comboBoxBuscarCliente.DataSource = columnasFiltro;
            comboBoxBuscarCliente.DisplayMember = "HeaderText";

            buttonBuscarCliente.Enabled = false;
        }

        private void buttonReiniciarConsultaCliente_Click(object sender, EventArgs e)
        {
            dataGridConsultaClientes.DataSource = TablaCliente.ObtenerClientesFisicos();
        }

        private void buttonLimpiarFiltro_Click(object sender, EventArgs e)
        {
            //Limpia el filtro de búsqueda y carga el Grid de nuevo con todos los empleados
            comboBoxBuscarCliente.ResetText();
            textBoxBuscarCliente.Clear();
            dataGridConsultaClientes.DataSource = TablaCliente.ObtenerClientesFisicos();
            dataGridConsultaClientes.ClearSelection();
        }

        private void textBoxBuscarCliente_TextChanged(object sender, EventArgs e)
        {
            //Para realizar una búsqueda por filtro tiene que haber algo escrito en el campo del valor del filtro
            buttonBuscarCliente.Enabled = textBoxBuscarCliente.Text.Length > 0;
        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
