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

namespace PDVRestaurante.Pantallas.Usuarios
{
    public partial class CrearUsuario : Form
    {
        public CrearUsuario()
        {
            InitializeComponent();
            comboBoxCedula.DataSource = EmpleadoDB.ObtenerEmpleados();
            comboBoxCedula.DisplayMember = "Cedula";
            comboBoxTipoUsuario.DataSource = TipoUsuarioDB.ObtenerTipoUsuarios();
            comboBoxTipoUsuario.DisplayMember = "Nombre";
        }

        private void buttonCrear_Click(object sender, EventArgs e)
        {
            string cedula;
            Empleado empleado;
            if(comboBoxCedula.SelectedItem is Empleado)
            {
                empleado = (Empleado)comboBoxCedula.SelectedItem;
                cedula = empleado.Cedula;
            } else
            {
                cedula = comboBoxCedula.Text;
            }

            var tipoUsuario = (TipoUsuario)comboBoxTipoUsuario.SelectedItem;
            var salt = Ayudantes.Encriptador.CrearSalt();
            var contrasena = Ayudantes.Encriptador.Encriptar(Ayudantes.Encriptador.ComoTextoSeguro(textBoxContrasena.Text), salt);
            UsuarioDB.InsertarUsuario(textBoxNombre.Text.ToLower(), contrasena, Convert.ToBase64String(salt), cedula, tipoUsuario.IdTipoUsuario);
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
