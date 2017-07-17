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
using PDVRestaurante.Ayudantes;
using PDVRestaurante.Pantallas.Ayuda;

namespace PDVRestaurante
{
    public partial class Principal : Form
    {
        private Usuario _usuarioActual;
        private Sucursal _sucursalActual;

        public Principal(Usuario usuario)
        {
            InitializeComponent();
            _usuarioActual = usuario;
            ValidarMenu();
        }

        public Sucursal SucursalActual()
        {
            if (_sucursalActual == null)
            {
                var empleado = TablaEmpleado.ObtenerEmpleado(_usuarioActual.IdEmpleado);
                _sucursalActual = TablaSucursal.ObtenerSucursal("IdSucursal", empleado.IdSucursal.ToString());
            }
            return _sucursalActual;
        }


        //--------------------------------------------------------------------------------------------------------------------
        //Esta sección es específica para funciones que se necesiten para controlar aspectos propios de la pantalla principal
        #region Funciones

        private void ValidarMenu()
        {
            ActivaMenu(this.MenuPrincipal.Items);
            switch (this._usuarioActual.IdTipoUsuario)
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

        private void MostrarPantalla(string area, string nombrePantalla, params object[] args)
        {
            this.CambiarPantalla(area, nombrePantalla, args);
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
            var pantallaAyuda = new Ayuda();
            pantallaAyuda.ShowDialog();
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
                _usuarioActual = login.usuario();
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
