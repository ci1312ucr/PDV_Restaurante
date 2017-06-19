using PDVRestaurante.Objetos;
using PDVRestaurante.BaseDatos;
using PDVRestaurante.Pantallas.Usuarios;
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
    public partial class Principal : Form
    {

        public Principal(Usuario usuario)
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void crearUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*var pantallaCrearUsuario = new CrearUsuario();
            pantallaCrearUsuario.MdiParent = this;
            pantallaCrearUsuario.Show();*/
            comboBoxCedula.DataSource = EmpleadoDB.ObtenerEmpleados();
            comboBoxCedula.DisplayMember = "Cedula";
            comboBoxTipoUsuario.DataSource = TipoUsuarioDB.ObtenerTipoUsuarios();
            comboBoxTipoUsuario.DisplayMember = "Nombre";
            panelCrearUsuario.Visible = true;
            panelCrearUsuario.BringToFront();
        }
        private void consultarEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridConsultaEmpleados.DataSource = EmpleadoDB.ObtenerEmpleados();
            comboBoxConsultarEmpleado.DataSource = EmpleadoDB.ObtenerEmpleados();
            comboBoxConsultarEmpleado.DisplayMember = "Cedula";
            panelConsultaEmpleados.Visible = true;
            panelConsultaEmpleados.BringToFront();
        }
        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dataGridEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void empleadoBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void panelConsultaEmpleados_Paint(object sender, PaintEventArgs e)
        {

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
                dataGridConsultaEmpleados[5, 0].Value = empleado.Tipo;
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

        private void buttonCrear_Click(object sender, EventArgs e)
        {
            string cedula;
            Empleado empleado;
            if (comboBoxCedula.SelectedItem is Empleado)
            {
                empleado = (Empleado)comboBoxCedula.SelectedItem;
                cedula = empleado.Cedula;
            }
            else
            {
                cedula = comboBoxCedula.Text;
            }

            var tipoUsuario = (TipoUsuario)comboBoxTipoUsuario.SelectedItem;
            var salt = Ayudantes.Encriptador.CrearSalt();
            var contrasena = Ayudantes.Encriptador.Encriptar(Ayudantes.Encriptador.ComoTextoSeguro(textBoxContrasena.Text), salt);
            UsuarioDB.InsertarUsuario(textBoxNombre.Text.ToLower(), contrasena, Convert.ToBase64String(salt), cedula, tipoUsuario.IdTipoUsuario);
        }
    }
}
