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
using PDVRestaurante.Pantallas.Mantenimiento.Usuarios;
using PDVRestaurante.Pantallas.Restaurante;

namespace PDVRestaurante
{
    public partial class Principal : Form
    {
        private Usuario currentUser;

        public Principal(Usuario usuario)
        {
            InitializeComponent();
            currentUser = usuario;
            ValidarMenu();
        }


        //--------------------------------------------------------------------------------------------------------------------
        //Esta sección es específica para funciones que se necesiten para controlar aspectos propios de la pantalla principal
        #region Funciones

        private void ValidarMenu()
        {
            ActivaMenu(this.MenuPrincipal.Items);
            switch (this.currentUser.IdTipoUsuario)
            {
                case (int)TipoDeUsuario.Superadmin:
                    ActivarMantenimiento();
                    break;
                case (int)TipoDeUsuario.Gerente:
                    break;
                case (int)TipoDeUsuario.Cajero:
                    DesactivaMenu("MenuConsultasEmpleados");
                    DesactivaMenu("MenuConsultasUsuarios");
                    break;
                default:
                    break;
            }
            this.MenuPrincipal.Refresh();
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
            var menuDesactivar = this.MenuPrincipal.Items.Find(nombreMenu, true).FirstOrDefault();
            if (menuDesactivar != null)
            {
                menuDesactivar.Visible = false;
                menuDesactivar.Enabled = false;
            }
        }

        private void ActivarMantenimiento()
        {
            var menuConsultas = this.MenuPrincipal.Items.Find("MenuConsultas", true).FirstOrDefault();
            menuConsultas.Text = "Consultas / Mantenimiento";
        }

        private void MostrarPantalla(string area, string nombrePantalla)
        {
            var pantallaMostrar = this.MdiChildren.ToList().Find(f => f.Name == nombrePantalla);
            if (pantallaMostrar == null)
            {
                var pantallaType = Type.GetType("PDVRestaurante.Pantallas." + area + "." + nombrePantalla);
                if (pantallaType != null)
                {
                    try
                    {
                        var nuevaPantalla = (Form)Activator.CreateInstance(pantallaType);
                        nuevaPantalla.MdiParent = this;
                        nuevaPantalla.Dock = DockStyle.Fill;
                        nuevaPantalla.Show();
                    } catch (Exception ex)
                    {
                        MessageBox.Show("Se produjo un error al tratar de abrir la pantalla >> " + ex.Message, "Error al abrir pantalla", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                pantallaMostrar.Show();
                pantallaMostrar.BringToFront();
            }
        }

        #endregion
        //--------------------------------------------------------------------------------------------------------------------



        //--------------------------------------------------------------------------------------------------------------------
        //Sección propia de las opciones del menú
        #region OpcionesDelMenu


        private void MenuControlRestaurante_Click(object sender, EventArgs e)
        {
            MostrarPantalla("Restaurante", "ControlRestaurante");
        }

        private void MenuConsultasClientes_Click(object sender, EventArgs e)
        {
            MostrarPantalla("Consultas", "ConsultaClientes");
        }

        private void MenuConsultasEmpleado_Click(object sender, EventArgs e)
        {
            MostrarPantalla("Consultas", "ConsultaEmpleados");
        }

        private void MenuConsultasFacturas_Click(object sender, EventArgs e)
        {
            MostrarPantalla("Consultas", "ConsultaFacturas");
        }

        private void MenuConsultasSucursales_Click(object sender, EventArgs e)
        {
            MostrarPantalla("Consultas", "ConsultaSucursales");
        }
        private void MenuConsultasUsuarios_Click(object sender, EventArgs e)
        {
            MostrarPantalla("Consultas", "ConsultaUsuarios");
        }

        private void MenuInventario_Click(object sender, EventArgs e)
        {
            MostrarPantalla("Inventario", "");
        }

        private void MenuAyuda_Click(object sender, EventArgs e)
        {
            MostrarPantalla("Ayuda", "");
        }

        private void MenuCambiarUsuario_Click(object sender, EventArgs e)
        {
            foreach (var child in this.MdiChildren)
            {
                child.Dispose();
            }
            this.Hide();

            var login = new Login();
            if (login.ShowDialog() == DialogResult.OK)
            {
                currentUser = login.usuario();
                ValidarMenu();
                this.Show();
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
        //--------------------------------------------------------------------------------------------------------------------

    }
}
