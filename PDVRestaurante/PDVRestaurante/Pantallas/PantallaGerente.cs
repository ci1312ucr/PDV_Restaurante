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
    public partial class PantallaGerente : Form
    {
        private Usuario currentUser;

        public PantallaGerente(Usuario usuario)
        {
            InitializeComponent();
            currentUser = usuario;
        }


        private void consultarEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridConsultaEmpleados.DataSource = EmpleadoDB.ObtenerEmpleados();
            comboBoxConsultarEmpleado.DataSource = EmpleadoDB.ObtenerEmpleados();
            comboBoxConsultarEmpleado.DisplayMember = "Cedula";
            panelConsultaEmpleados.Visible = true;
            panelConsultaEmpleados.BringToFront();
        }

        private void buttonConsultarEmpleados_Click(object sender, EventArgs e)
        {
            Empleado empleado;
            if (comboBoxConsultarEmpleado.SelectedItem is Empleado)
            {
                empleado = (Empleado)comboBoxConsultarEmpleado.SelectedItem;
            }
            else
            {
                empleado = EmpleadoDB.ObtenerEmpleado(comboBoxConsultarEmpleado.Text);
            }
            dataGridConsultaEmpleados.DataSource = null;
            dataGridConsultaEmpleados.Rows.Clear();
            if (empleado != null)
            {
                dataGridConsultaEmpleados.Rows.Add();
                dataGridConsultaEmpleados[0, 0].Value = empleado.Cedula;
                dataGridConsultaEmpleados[1, 0].Value = empleado.Nombre1;
                dataGridConsultaEmpleados[2, 0].Value = empleado.Nombre1;
                dataGridConsultaEmpleados[3, 0].Value = empleado.Apellido1;
                dataGridConsultaEmpleados[4, 0].Value = empleado.Apellido2;
                dataGridConsultaEmpleados[5, 0].Value = empleado.TipoE;
                dataGridConsultaEmpleados[6, 0].Value = empleado.Salario;
                dataGridConsultaEmpleados[7, 0].Value = empleado.FechaInicio;
                dataGridConsultaEmpleados[8, 0].Value = empleado.Sexo;
                dataGridConsultaEmpleados[9, 0].Value = empleado.EstadoCivil;
                dataGridConsultaEmpleados[10, 0].Value = empleado.FechaNacimiento;
                dataGridConsultaEmpleados[11, 0].Value = empleado.IdSucursal;
            }
        }

        private void buttonReiniciarConsultaEmpleados_Click(object sender, EventArgs e)
        {
            dataGridConsultaEmpleados.DataSource = EmpleadoDB.ObtenerEmpleados();
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
