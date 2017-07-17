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

namespace PDVRestaurante.Pantallas.Mantenimiento.Usuarios
{
    public partial class CrearUsuario : Form
    {
        public CrearUsuario()
        {
            InitializeComponent();
            comboBoxCedula.DataSource = TablaEmpleado.ObtenerEmpleados();
            comboBoxCedula.DisplayMember = "Cedula";
            comboBoxTipoUsuario.DataSource = TablaTipoUsuario.ObtenerTiposUsuarios();
            comboBoxTipoUsuario.DisplayMember = "Nombre";
        }

        private void buttonCrear_Click(object sender, EventArgs e)
        {
            try
            {
                var empleado = (Cliente)comboBoxCedula.SelectedItem;
                var tipoUsuario = (TipoUsuario)comboBoxTipoUsuario.SelectedItem;
                var salt = Ayudantes.Encriptador.CrearSalt();
                var contrasena = Ayudantes.Encriptador.Encriptar(Ayudantes.Encriptador.ComoTextoSeguro(textBoxContrasena.Text), salt);
                if(TablaUsuario.InsertarUsuario(textBoxNombre.Text.ToLower(), contrasena, Convert.ToBase64String(salt), empleado.Cedula, tipoUsuario.IdTipoUsuario))
                {
                    MessageBox.Show("Se agregó el nuevo usuario exitosamente", "Nuevo usuario creado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                } else
                {
                    throw new Exception("Error insertando el usuario en la base de datos");
                }
            } catch (Exception ex)
            {
                ManejoExcepciones.LogearExcepcion(ex);
                MessageBox.Show("Se produjo un error al tratar de crear el usuario", "Error al crear usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
