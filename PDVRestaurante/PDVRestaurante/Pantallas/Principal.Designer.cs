namespace PDVRestaurante
{
    partial class Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MenuPrincipal = new System.Windows.Forms.MenuStrip();
            this.MenuRestaurante = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuControlRestaurante = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuConsultas = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuConsultasClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuConsultasEmpleados = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuConsultasFacturas = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuConsultasSucursales = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuConsultasUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuInventario = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAyuda = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCambiarUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSalirAplicacion = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuPrincipal
            // 
            this.MenuPrincipal.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuRestaurante,
            this.MenuConsultas,
            this.MenuInventario,
            this.MenuAyuda,
            this.MenuSalir});
            this.MenuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.MenuPrincipal.Name = "MenuPrincipal";
            this.MenuPrincipal.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.MenuPrincipal.Size = new System.Drawing.Size(1184, 24);
            this.MenuPrincipal.TabIndex = 0;
            this.MenuPrincipal.Text = "menuStripPrincipal";
            // 
            // MenuRestaurante
            // 
            this.MenuRestaurante.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuControlRestaurante});
            this.MenuRestaurante.Name = "MenuRestaurante";
            this.MenuRestaurante.Size = new System.Drawing.Size(81, 18);
            this.MenuRestaurante.Text = "Restaurante";
            // 
            // MenuControlRestaurante
            // 
            this.MenuControlRestaurante.Name = "MenuControlRestaurante";
            this.MenuControlRestaurante.Size = new System.Drawing.Size(178, 22);
            this.MenuControlRestaurante.Text = "Control Restaurante";
            this.MenuControlRestaurante.Click += new System.EventHandler(this.MenuControlRestaurante_Click);
            // 
            // MenuConsultas
            // 
            this.MenuConsultas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuConsultasClientes,
            this.MenuConsultasEmpleados,
            this.MenuConsultasFacturas,
            this.MenuConsultasSucursales,
            this.MenuConsultasUsuarios});
            this.MenuConsultas.Name = "MenuConsultas";
            this.MenuConsultas.Size = new System.Drawing.Size(70, 18);
            this.MenuConsultas.Text = "Consultas";
            // 
            // MenuConsultasClientes
            // 
            this.MenuConsultasClientes.Name = "MenuConsultasClientes";
            this.MenuConsultasClientes.Size = new System.Drawing.Size(130, 22);
            this.MenuConsultasClientes.Text = "Clientes";
            this.MenuConsultasClientes.Click += new System.EventHandler(this.MenuConsultasClientes_Click);
            // 
            // MenuConsultasEmpleados
            // 
            this.MenuConsultasEmpleados.Name = "MenuConsultasEmpleados";
            this.MenuConsultasEmpleados.Size = new System.Drawing.Size(130, 22);
            this.MenuConsultasEmpleados.Text = "Empleados";
            this.MenuConsultasEmpleados.Click += new System.EventHandler(this.MenuConsultasEmpleado_Click);
            // 
            // MenuConsultasFacturas
            // 
            this.MenuConsultasFacturas.Name = "MenuConsultasFacturas";
            this.MenuConsultasFacturas.Size = new System.Drawing.Size(130, 22);
            this.MenuConsultasFacturas.Text = "Facturas";
            this.MenuConsultasFacturas.Click += new System.EventHandler(this.MenuConsultasFacturas_Click);
            // 
            // MenuConsultasSucursales
            // 
            this.MenuConsultasSucursales.Name = "MenuConsultasSucursales";
            this.MenuConsultasSucursales.Size = new System.Drawing.Size(130, 22);
            this.MenuConsultasSucursales.Text = "Sucursales";
            this.MenuConsultasSucursales.Click += new System.EventHandler(this.MenuConsultasSucursales_Click);
            // 
            // MenuConsultasUsuarios
            // 
            this.MenuConsultasUsuarios.Name = "MenuConsultasUsuarios";
            this.MenuConsultasUsuarios.Size = new System.Drawing.Size(130, 22);
            this.MenuConsultasUsuarios.Text = "Usuarios";
            this.MenuConsultasUsuarios.Click += new System.EventHandler(this.MenuConsultasUsuarios_Click);
            // 
            // MenuInventario
            // 
            this.MenuInventario.Name = "MenuInventario";
            this.MenuInventario.Size = new System.Drawing.Size(71, 18);
            this.MenuInventario.Text = "Inventario";
            this.MenuInventario.Click += new System.EventHandler(this.MenuInventario_Click);
            // 
            // MenuAyuda
            // 
            this.MenuAyuda.Name = "MenuAyuda";
            this.MenuAyuda.Size = new System.Drawing.Size(51, 18);
            this.MenuAyuda.Text = "Ayuda";
            this.MenuAyuda.Click += new System.EventHandler(this.MenuAyuda_Click);
            // 
            // MenuSalir
            // 
            this.MenuSalir.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuCambiarUsuario,
            this.MenuSalirAplicacion});
            this.MenuSalir.Name = "MenuSalir";
            this.MenuSalir.Size = new System.Drawing.Size(41, 18);
            this.MenuSalir.Text = "Salir";
            // 
            // MenuCambiarUsuario
            // 
            this.MenuCambiarUsuario.Name = "MenuCambiarUsuario";
            this.MenuCambiarUsuario.Size = new System.Drawing.Size(175, 22);
            this.MenuCambiarUsuario.Text = "Cambiar de Usuario";
            this.MenuCambiarUsuario.Click += new System.EventHandler(this.MenuCambiarUsuario_Click);
            // 
            // MenuSalirAplicacion
            // 
            this.MenuSalirAplicacion.Name = "MenuSalirAplicacion";
            this.MenuSalirAplicacion.Size = new System.Drawing.Size(175, 22);
            this.MenuSalirAplicacion.Text = "Salir de aplicación";
            this.MenuSalirAplicacion.Click += new System.EventHandler(this.MenuSalirAplicacion_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.MenuPrincipal);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MenuPrincipal;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Principal";
            this.Text = "Punto de Venta";
            this.MenuPrincipal.ResumeLayout(false);
            this.MenuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem MenuAyuda;
        private System.Windows.Forms.ToolStripMenuItem MenuConsultas;
        private System.Windows.Forms.ToolStripMenuItem MenuConsultasEmpleados;
        private System.Windows.Forms.ToolStripMenuItem MenuConsultasClientes;
        private System.Windows.Forms.ToolStripMenuItem MenuSalir;
        private System.Windows.Forms.ToolStripMenuItem MenuCambiarUsuario;
        private System.Windows.Forms.ToolStripMenuItem MenuSalirAplicacion;
        private System.Windows.Forms.ToolStripMenuItem MenuRestaurante;
        private System.Windows.Forms.ToolStripMenuItem MenuControlRestaurante;
        private System.Windows.Forms.ToolStripMenuItem MenuConsultasFacturas;
        private System.Windows.Forms.ToolStripMenuItem MenuConsultasSucursales;
        private System.Windows.Forms.ToolStripMenuItem MenuInventario;
        private System.Windows.Forms.ToolStripMenuItem MenuConsultasUsuarios;
    }
}