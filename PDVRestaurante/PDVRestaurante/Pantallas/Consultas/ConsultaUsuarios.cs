using PDVRestaurante.Pantallas.Mantenimiento.Usuarios;
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
    public partial class ConsultaUsuarios : Form
    {
        public ConsultaUsuarios()
        {
            InitializeComponent();
        }

        private void buttonCrearUsuario_Click(object sender, EventArgs e)
        {
            var crearUsuarioForm = this.ParentForm.MdiChildren.ToList().Find(f => f.Name == "CrearUsuario");
            if (crearUsuarioForm == null)
            {
                var pantallaCrearUsuario = new CrearUsuario();
                pantallaCrearUsuario.MdiParent = this.ParentForm;
                pantallaCrearUsuario.Dock = DockStyle.Fill;
                pantallaCrearUsuario.Show();
            }
            else
            {
                crearUsuarioForm.Show();
            }
        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
