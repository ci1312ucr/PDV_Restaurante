using PDVRestaurante.Ayudantes;
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

namespace PDVRestaurante
{
    public partial class Login : Form
    {
        private Usuario _usuario;
        public Login()
        {
            InitializeComponent();
        }

        public Usuario usuario()
        {
            return _usuario;
        }

        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            errorAutenticacion.Clear();
            labelErrorAut.Text = "";
            var usuario = Autenticacion.Autenticacion.Autenticar(txtBoxUsuario.Text, Encriptador.ComoTextoSeguro(txtBoxContrasena.Text));
            if (usuario == null)
            {
                //Usuario invalido
                errorAutenticacion.SetError(buttonIngresar, "Usuario o Clave inválidos");
                labelErrorAut.Text = "Usuario o Clave inválidos";
            } else
            {
                //Usuario autenticado, cargar ventana principal con opciones para usuario específico
                _usuario = usuario;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
        public int tipo()
        {
            return _usuario.IdTipoUsuario;
        }
        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
