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
using PDVRestaurante.Constantes;

namespace PDVRestaurante
{
    public partial class Principal : Form
    {
        private Usuario currentUser;

        public Principal(Usuario usuario)
        {
            InitializeComponent();
            currentUser = usuario;
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            ValidarMenu();
        }


        #region OpcionesDelMenu
        private void MenuCrearUsuario_Click(object sender, EventArgs e)
        {
            // solo superadmin puede crear usuarios
            comboBoxCrearUsuario.DataSource = EmpleadoDB.ObtenerEmpleados();
            comboBoxCrearUsuario.DisplayMember = "Cedula";
            comboBoxCreaUsuarioTipo.DataSource = TipoUsuarioDB.ObtenerTipoUsuarios();
            comboBoxCreaUsuarioTipo.DisplayMember = "Nombre";
            panelCrearUsuario.Visible = true;
            panelCrearUsuario.BringToFront();
        }

        private void MenuConsultarEmpleado_Click(object sender, EventArgs e)
        {
            // superadmin y gerente pueden consultar empleados
            dataGridConsultaEmpleados.DataSource = EmpleadoDB.ObtenerEmpleados();
            comboBoxConsultarEmpleado.DataSource = EmpleadoDB.ObtenerEmpleados();
            comboBoxConsultarEmpleado.DisplayMember = "Cedula";
            panelConsultaEmpleados.Visible = true;
            panelConsultaEmpleados.BringToFront();
        }
        private void MenuConsultarCliente_Click(object sender, EventArgs e)
        {
            // todos los roles tienen permiso de consultar clientes por lo que no se efecúa un checkeo
            dataGridConsultaClientes.DataSource = ClienteFisicoDB.ObtenerClientes();
            comboBoxConsultaCliente.DataSource = ClienteFisicoDB.ObtenerClientes();
            comboBoxConsultaCliente.DisplayMember = "Cedula";
            panelConsultaCliente.Visible = true;
            panelConsultaCliente.BringToFront();
        }

        private void MenuCambiarUsuario_Click(object sender, EventArgs e)
        {
            var login = new Login();
            this.Hide();
            if (login.ShowDialog() == DialogResult.OK)
            {
                currentUser = login.usuario();
                ValidarMenu();
                this.Show();
                panelConsultaCliente.Visible = false;
                panelConsultaEmpleados.Visible = false;
                panelCrearUsuario.Visible = false;
            }
            else
            {
                Application.Exit();
            }
        }

        private void MenuSalirAplicacion_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

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

        private void buttonCrear_Click(object sender, EventArgs e)
        {
            string cedula;
            Empleado empleado;
            if (comboBoxCrearUsuario.SelectedItem is Empleado)
            {
                empleado = (Empleado)comboBoxCrearUsuario.SelectedItem;
                cedula = empleado.Cedula;
            }
            else
            {
                cedula = comboBoxCrearUsuario.Text;
            }

            var tipoUsuario = (TipoUsuario)comboBoxCreaUsuarioTipo.SelectedItem;
            var salt = Ayudantes.Encriptador.CrearSalt();
            var contrasena = Ayudantes.Encriptador.Encriptar(Ayudantes.Encriptador.ComoTextoSeguro(textBoxCreaUsuarioContrasena.Text), salt);
            UsuarioDB.InsertarUsuario(textBoxCreaUsuarioNombre.Text.ToLower(), contrasena, Convert.ToBase64String(salt), cedula, tipoUsuario.IdTipoUsuario);
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



        #region Funciones
        private void ValidarMenu()
        {
            ActivaMenu(this.menuStrip1.Items);
            switch (this.currentUser.IdTipoUsuario)
            {
                case (int)TipoDeUsuario.Superadmin:
                    break;
                case (int)TipoDeUsuario.Gerente:
                    DesactivaMenu("MenuMantenimiento");
                    break;
                case (int)TipoDeUsuario.Cajero:
                    DesactivaMenu("MenuMantenimiento");
                    DesactivaMenu("MenuConsultasEmpleado");
                    break;
                default:
                    break;
            }
            this.menuStrip1.Refresh();
        }

        private void ActivaMenu(ToolStripItemCollection items)
        {
            foreach (ToolStripMenuItem item in items)
            {
                item.Visible = true;
                item.Enabled = true;
                ActivaMenu(item.DropDown.Items);
            }
        }

        private void DesactivaMenu(string nombreMenu)
        {
            var menuDesactivar = this.menuStrip1.Items.Find(nombreMenu, true).FirstOrDefault();
            menuDesactivar.Visible = false;
            menuDesactivar.Enabled = false;
        }
        #endregion

        private void cambiarAGerenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.currentUser.IdTipoUsuario = 2;
            ValidarMenu();
        }

        private void cambiarACajeroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.currentUser.IdTipoUsuario = 3;
            ValidarMenu();
        }
    }
}
