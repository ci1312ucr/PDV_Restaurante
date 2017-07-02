using PDVRestaurante.Objetos;
using PDVRestaurante.BaseDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDVRestaurante
{
    public partial class PantallaCajero : Form
    {
        private Usuario currentUser;

        public PantallaCajero(Usuario usuario)
        {
            InitializeComponent();
            currentUser = usuario;
        }

        private void consultarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridConsultaClientes.DataSource = ClienteFisicoDB.ObtenerClientes();
            comboBoxConsultaCliente.DataSource = ClienteFisicoDB.ObtenerClientes();
            comboBoxConsultaCliente.DisplayMember = "Cedula";
            panelConsultaCliente.Visible = true;
            panelConsultaCliente.BringToFront();
        }

        private void buttonReiniciarConsultaCliente_Click(object sender, EventArgs e)
        {
            dataGridConsultaClientes.DataSource = ClienteFisicoDB.ObtenerClientes();
        }

        private void buttonConsultarCliente_Click(object sender, EventArgs e)
        {
            ClienteFisico cliente;
            if (comboBoxConsultaCliente.SelectedItem is ClienteFisico)
            {
                cliente = (ClienteFisico)comboBoxConsultaCliente.SelectedItem;
            }
            else
            {
                cliente = ClienteFisicoDB.ObtenerCliente(comboBoxConsultaCliente.Text);
            }
            dataGridConsultaClientes.DataSource = null;
            dataGridConsultaClientes.Rows.Clear();
            if (cliente != null)
            {
                dataGridConsultaClientes.Rows.Add();
                dataGridConsultaClientes[0, 0].Value = cliente.Cedula;
                dataGridConsultaClientes[1, 0].Value = cliente.Nombre1;
                dataGridConsultaClientes[2, 0].Value = cliente.Nombre1;
                dataGridConsultaClientes[3, 0].Value = cliente.Apellido1;
                dataGridConsultaClientes[4, 0].Value = cliente.Apellido2;
                dataGridConsultaClientes[5, 0].Value = cliente.Sexo;
                dataGridConsultaClientes[6, 0].Value = cliente.EstadoCivil;
                dataGridConsultaClientes[7, 0].Value = cliente.FechaNacimiento;
                dataGridConsultaClientes[8, 0].Value = cliente.Frecuente;
            }
        }

        private void salirDeAplicaciónToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
            this.Close();
        }

        private void cambiarDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
