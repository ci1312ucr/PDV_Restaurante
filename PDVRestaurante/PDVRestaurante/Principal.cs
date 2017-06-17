using PDVRestaurante.Objetos;
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
            var pantallaCrearUsuario = new CrearUsuario();
            pantallaCrearUsuario.MdiParent = this;
            pantallaCrearUsuario.Show();
        }
    }
}
