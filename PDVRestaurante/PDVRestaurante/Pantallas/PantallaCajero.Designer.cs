namespace PDVRestaurante
{
    partial class PantallaCajero
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ordenesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarDeUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirDeAplicaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelConsultaCliente = new System.Windows.Forms.Panel();
            this.comboBoxConsultaCliente = new System.Windows.Forms.ComboBox();
            this.buttonConsultarCliente = new System.Windows.Forms.Button();
            this.labelConsultaCliente = new System.Windows.Forms.Label();
            this.buttonReiniciarConsultaCliente = new System.Windows.Forms.Button();
            this.dataGridConsultaClientes = new System.Windows.Forms.DataGridView();
            this.cedulaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre1DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre2DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido1DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido2DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoCivilDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaNacimientoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frecuenteDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clienteFisicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).BeginInit();
            this.panelConsultaCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridConsultaClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteFisicoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ordenesToolStripMenuItem,
            this.facturasToolStripMenuItem,
            this.consultasToolStripMenuItem,
            this.ayudaToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1245, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStripPantallaCajero";
            // 
            // ordenesToolStripMenuItem
            // 
            this.ordenesToolStripMenuItem.Name = "ordenesToolStripMenuItem";
            this.ordenesToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.ordenesToolStripMenuItem.Text = "Ordenes";
            // 
            // facturasToolStripMenuItem
            // 
            this.facturasToolStripMenuItem.Name = "facturasToolStripMenuItem";
            this.facturasToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.facturasToolStripMenuItem.Text = "Facturas";
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarClienteToolStripMenuItem});
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.clienteToolStripMenuItem.Text = "Cliente";
            // 
            // consultarClienteToolStripMenuItem
            // 
            this.consultarClienteToolStripMenuItem.Name = "consultarClienteToolStripMenuItem";
            this.consultarClienteToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.consultarClienteToolStripMenuItem.Text = "Consultar Cliente";
            this.consultarClienteToolStripMenuItem.Click += new System.EventHandler(this.consultarClienteToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cambiarDeUsuarioToolStripMenuItem,
            this.salirDeAplicaciónToolStripMenuItem});
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // cambiarDeUsuarioToolStripMenuItem
            // 
            this.cambiarDeUsuarioToolStripMenuItem.Name = "cambiarDeUsuarioToolStripMenuItem";
            this.cambiarDeUsuarioToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.cambiarDeUsuarioToolStripMenuItem.Text = "Cambiar de Usuario";
            this.cambiarDeUsuarioToolStripMenuItem.Click += new System.EventHandler(this.cambiarDeUsuarioToolStripMenuItem_Click);
            // 
            // salirDeAplicaciónToolStripMenuItem
            // 
            this.salirDeAplicaciónToolStripMenuItem.Name = "salirDeAplicaciónToolStripMenuItem";
            this.salirDeAplicaciónToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.salirDeAplicaciónToolStripMenuItem.Text = "Salir de aplicación";
            this.salirDeAplicaciónToolStripMenuItem.Click += new System.EventHandler(this.salirDeAplicaciónToolStripMenuItem_Click_1);
            // 
            // empleadoBindingSource
            // 
            this.empleadoBindingSource.DataSource = typeof(PDVRestaurante.Objetos.Empleado);
            // 
            // panelConsultaCliente
            // 
            this.panelConsultaCliente.Controls.Add(this.comboBoxConsultaCliente);
            this.panelConsultaCliente.Controls.Add(this.buttonConsultarCliente);
            this.panelConsultaCliente.Controls.Add(this.labelConsultaCliente);
            this.panelConsultaCliente.Controls.Add(this.buttonReiniciarConsultaCliente);
            this.panelConsultaCliente.Controls.Add(this.dataGridConsultaClientes);
            this.panelConsultaCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelConsultaCliente.Location = new System.Drawing.Point(0, 24);
            this.panelConsultaCliente.Name = "panelConsultaCliente";
            this.panelConsultaCliente.Size = new System.Drawing.Size(1245, 654);
            this.panelConsultaCliente.TabIndex = 21;
            this.panelConsultaCliente.Visible = false;
            // 
            // comboBoxConsultaCliente
            // 
            this.comboBoxConsultaCliente.FormattingEnabled = true;
            this.comboBoxConsultaCliente.Location = new System.Drawing.Point(293, 55);
            this.comboBoxConsultaCliente.Name = "comboBoxConsultaCliente";
            this.comboBoxConsultaCliente.Size = new System.Drawing.Size(287, 21);
            this.comboBoxConsultaCliente.TabIndex = 0;
            // 
            // buttonConsultarCliente
            // 
            this.buttonConsultarCliente.Location = new System.Drawing.Point(650, 35);
            this.buttonConsultarCliente.Name = "buttonConsultarCliente";
            this.buttonConsultarCliente.Size = new System.Drawing.Size(240, 59);
            this.buttonConsultarCliente.TabIndex = 2;
            this.buttonConsultarCliente.Text = "Consultar";
            this.buttonConsultarCliente.UseVisualStyleBackColor = true;
            this.buttonConsultarCliente.Click += new System.EventHandler(this.buttonConsultarCliente_Click);
            // 
            // labelConsultaCliente
            // 
            this.labelConsultaCliente.AutoSize = true;
            this.labelConsultaCliente.Location = new System.Drawing.Point(92, 58);
            this.labelConsultaCliente.Name = "labelConsultaCliente";
            this.labelConsultaCliente.Size = new System.Drawing.Size(195, 13);
            this.labelConsultaCliente.TabIndex = 4;
            this.labelConsultaCliente.Text = "Ingrese la cédula del cliente por buscar:";
            // 
            // buttonReiniciarConsultaCliente
            // 
            this.buttonReiniciarConsultaCliente.Location = new System.Drawing.Point(969, 35);
            this.buttonReiniciarConsultaCliente.Name = "buttonReiniciarConsultaCliente";
            this.buttonReiniciarConsultaCliente.Size = new System.Drawing.Size(240, 59);
            this.buttonReiniciarConsultaCliente.TabIndex = 1;
            this.buttonReiniciarConsultaCliente.Text = "Reiniciar";
            this.buttonReiniciarConsultaCliente.UseVisualStyleBackColor = true;
            this.buttonReiniciarConsultaCliente.Click += new System.EventHandler(this.buttonReiniciarConsultaCliente_Click);
            // 
            // dataGridConsultaClientes
            // 
            this.dataGridConsultaClientes.AllowUserToAddRows = false;
            this.dataGridConsultaClientes.AllowUserToDeleteRows = false;
            this.dataGridConsultaClientes.AutoGenerateColumns = false;
            this.dataGridConsultaClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridConsultaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridConsultaClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cedulaDataGridViewTextBoxColumn1,
            this.nombre1DataGridViewTextBoxColumn1,
            this.nombre2DataGridViewTextBoxColumn1,
            this.apellido1DataGridViewTextBoxColumn1,
            this.apellido2DataGridViewTextBoxColumn1,
            this.sexoDataGridViewTextBoxColumn1,
            this.estadoCivilDataGridViewTextBoxColumn1,
            this.fechaNacimientoDataGridViewTextBoxColumn1,
            this.frecuenteDataGridViewCheckBoxColumn});
            this.dataGridConsultaClientes.DataSource = this.clienteFisicoBindingSource;
            this.dataGridConsultaClientes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridConsultaClientes.Location = new System.Drawing.Point(0, 143);
            this.dataGridConsultaClientes.Name = "dataGridConsultaClientes";
            this.dataGridConsultaClientes.ReadOnly = true;
            this.dataGridConsultaClientes.Size = new System.Drawing.Size(1245, 511);
            this.dataGridConsultaClientes.TabIndex = 3;
            // 
            // cedulaDataGridViewTextBoxColumn1
            // 
            this.cedulaDataGridViewTextBoxColumn1.DataPropertyName = "Cedula";
            this.cedulaDataGridViewTextBoxColumn1.HeaderText = "Cedula";
            this.cedulaDataGridViewTextBoxColumn1.Name = "cedulaDataGridViewTextBoxColumn1";
            this.cedulaDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nombre1DataGridViewTextBoxColumn1
            // 
            this.nombre1DataGridViewTextBoxColumn1.DataPropertyName = "Nombre1";
            this.nombre1DataGridViewTextBoxColumn1.HeaderText = "Nombre1";
            this.nombre1DataGridViewTextBoxColumn1.Name = "nombre1DataGridViewTextBoxColumn1";
            this.nombre1DataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nombre2DataGridViewTextBoxColumn1
            // 
            this.nombre2DataGridViewTextBoxColumn1.DataPropertyName = "Nombre2";
            this.nombre2DataGridViewTextBoxColumn1.HeaderText = "Nombre2";
            this.nombre2DataGridViewTextBoxColumn1.Name = "nombre2DataGridViewTextBoxColumn1";
            this.nombre2DataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // apellido1DataGridViewTextBoxColumn1
            // 
            this.apellido1DataGridViewTextBoxColumn1.DataPropertyName = "Apellido1";
            this.apellido1DataGridViewTextBoxColumn1.HeaderText = "Apellido1";
            this.apellido1DataGridViewTextBoxColumn1.Name = "apellido1DataGridViewTextBoxColumn1";
            this.apellido1DataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // apellido2DataGridViewTextBoxColumn1
            // 
            this.apellido2DataGridViewTextBoxColumn1.DataPropertyName = "Apellido2";
            this.apellido2DataGridViewTextBoxColumn1.HeaderText = "Apellido2";
            this.apellido2DataGridViewTextBoxColumn1.Name = "apellido2DataGridViewTextBoxColumn1";
            this.apellido2DataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // sexoDataGridViewTextBoxColumn1
            // 
            this.sexoDataGridViewTextBoxColumn1.DataPropertyName = "Sexo";
            this.sexoDataGridViewTextBoxColumn1.HeaderText = "Sexo";
            this.sexoDataGridViewTextBoxColumn1.Name = "sexoDataGridViewTextBoxColumn1";
            this.sexoDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // estadoCivilDataGridViewTextBoxColumn1
            // 
            this.estadoCivilDataGridViewTextBoxColumn1.DataPropertyName = "EstadoCivil";
            this.estadoCivilDataGridViewTextBoxColumn1.HeaderText = "EstadoCivil";
            this.estadoCivilDataGridViewTextBoxColumn1.Name = "estadoCivilDataGridViewTextBoxColumn1";
            this.estadoCivilDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // fechaNacimientoDataGridViewTextBoxColumn1
            // 
            this.fechaNacimientoDataGridViewTextBoxColumn1.DataPropertyName = "FechaNacimiento";
            this.fechaNacimientoDataGridViewTextBoxColumn1.HeaderText = "FechaNacimiento";
            this.fechaNacimientoDataGridViewTextBoxColumn1.Name = "fechaNacimientoDataGridViewTextBoxColumn1";
            this.fechaNacimientoDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // frecuenteDataGridViewCheckBoxColumn
            // 
            this.frecuenteDataGridViewCheckBoxColumn.DataPropertyName = "Frecuente";
            this.frecuenteDataGridViewCheckBoxColumn.HeaderText = "Frecuente";
            this.frecuenteDataGridViewCheckBoxColumn.Name = "frecuenteDataGridViewCheckBoxColumn";
            this.frecuenteDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // clienteFisicoBindingSource
            // 
            this.clienteFisicoBindingSource.DataSource = typeof(PDVRestaurante.Objetos.ClienteFisico);
            // 
            // PantallaCajero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 678);
            this.Controls.Add(this.panelConsultaCliente);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PantallaCajero";
            this.Text = "PantallaCajero";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).EndInit();
            this.panelConsultaCliente.ResumeLayout(false);
            this.panelConsultaCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridConsultaClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteFisicoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ordenesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.BindingSource empleadoBindingSource;
        private System.Windows.Forms.Panel panelConsultaCliente;
        private System.Windows.Forms.DataGridView dataGridConsultaClientes;
        private System.Windows.Forms.Button buttonConsultarCliente;
        private System.Windows.Forms.Button buttonReiniciarConsultaCliente;
        private System.Windows.Forms.ComboBox comboBoxConsultaCliente;
        private System.Windows.Forms.Label labelConsultaCliente;
        private System.Windows.Forms.BindingSource clienteFisicoBindingSource;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarClienteToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedulaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre1DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre2DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido1DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido2DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoCivilDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaNacimientoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn frecuenteDataGridViewCheckBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarDeUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirDeAplicaciónToolStripMenuItem;
    }
}