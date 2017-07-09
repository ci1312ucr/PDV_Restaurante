namespace PDVRestaurante.Pantallas.Consultas
{
    partial class ConsultaClientes
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
            this.dataGridConsultaClientes = new System.Windows.Forms.DataGridView();
            this.clienteFisicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonLimpiarFiltro = new System.Windows.Forms.Button();
            this.buttonBuscarCliente = new System.Windows.Forms.Button();
            this.comboBoxBuscarCliente = new System.Windows.Forms.ComboBox();
            this.textBoxBuscarCliente = new System.Windows.Forms.TextBox();
            this.labelConsultaEmpleados = new System.Windows.Forms.Label();
            this.buttonCrearCliente = new System.Windows.Forms.Button();
            this.buttonEliminarCliente = new System.Windows.Forms.Button();
            this.buttonModificarCliente = new System.Windows.Forms.Button();
            this.cedulaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoCivilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaNacimientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frecuenteDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tipoPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridConsultaClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteFisicoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridConsultaClientes
            // 
            this.dataGridConsultaClientes.AllowUserToAddRows = false;
            this.dataGridConsultaClientes.AllowUserToDeleteRows = false;
            this.dataGridConsultaClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridConsultaClientes.AutoGenerateColumns = false;
            this.dataGridConsultaClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridConsultaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridConsultaClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cedulaDataGridViewTextBoxColumn,
            this.nombre1DataGridViewTextBoxColumn,
            this.nombre2DataGridViewTextBoxColumn,
            this.apellido1DataGridViewTextBoxColumn,
            this.apellido2DataGridViewTextBoxColumn,
            this.sexoDataGridViewTextBoxColumn,
            this.estadoCivilDataGridViewTextBoxColumn,
            this.fechaNacimientoDataGridViewTextBoxColumn,
            this.frecuenteDataGridViewCheckBoxColumn,
            this.tipoPDataGridViewTextBoxColumn});
            this.dataGridConsultaClientes.DataSource = this.clienteFisicoBindingSource;
            this.dataGridConsultaClientes.Location = new System.Drawing.Point(1, 119);
            this.dataGridConsultaClientes.Name = "dataGridConsultaClientes";
            this.dataGridConsultaClientes.ReadOnly = true;
            this.dataGridConsultaClientes.Size = new System.Drawing.Size(1240, 347);
            this.dataGridConsultaClientes.TabIndex = 3;
            // 
            // clienteFisicoBindingSource
            // 
            this.clienteFisicoBindingSource.DataSource = typeof(PDVRestaurante.Objetos.ClienteFisico);
            // 
            // buttonLimpiarFiltro
            // 
            this.buttonLimpiarFiltro.Location = new System.Drawing.Point(346, 67);
            this.buttonLimpiarFiltro.Name = "buttonLimpiarFiltro";
            this.buttonLimpiarFiltro.Size = new System.Drawing.Size(75, 23);
            this.buttonLimpiarFiltro.TabIndex = 13;
            this.buttonLimpiarFiltro.Text = "Limpiar Filtro";
            this.buttonLimpiarFiltro.UseVisualStyleBackColor = true;
            this.buttonLimpiarFiltro.Click += new System.EventHandler(this.buttonLimpiarFiltro_Click);
            // 
            // buttonBuscarCliente
            // 
            this.buttonBuscarCliente.Location = new System.Drawing.Point(346, 38);
            this.buttonBuscarCliente.Name = "buttonBuscarCliente";
            this.buttonBuscarCliente.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscarCliente.TabIndex = 12;
            this.buttonBuscarCliente.Text = "Buscar";
            this.buttonBuscarCliente.UseVisualStyleBackColor = true;
            // 
            // comboBoxBuscarCliente
            // 
            this.comboBoxBuscarCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBuscarCliente.FormattingEnabled = true;
            this.comboBoxBuscarCliente.Location = new System.Drawing.Point(79, 9);
            this.comboBoxBuscarCliente.Name = "comboBoxBuscarCliente";
            this.comboBoxBuscarCliente.Size = new System.Drawing.Size(261, 21);
            this.comboBoxBuscarCliente.TabIndex = 10;
            // 
            // textBoxBuscarCliente
            // 
            this.textBoxBuscarCliente.Location = new System.Drawing.Point(78, 40);
            this.textBoxBuscarCliente.Name = "textBoxBuscarCliente";
            this.textBoxBuscarCliente.Size = new System.Drawing.Size(262, 20);
            this.textBoxBuscarCliente.TabIndex = 11;
            this.textBoxBuscarCliente.TextChanged += new System.EventHandler(this.textBoxBuscarCliente_TextChanged);
            // 
            // labelConsultaEmpleados
            // 
            this.labelConsultaEmpleados.AutoSize = true;
            this.labelConsultaEmpleados.Location = new System.Drawing.Point(12, 9);
            this.labelConsultaEmpleados.Name = "labelConsultaEmpleados";
            this.labelConsultaEmpleados.Size = new System.Drawing.Size(61, 13);
            this.labelConsultaEmpleados.TabIndex = 9;
            this.labelConsultaEmpleados.Text = "Buscar por:";
            // 
            // buttonCrearCliente
            // 
            this.buttonCrearCliente.Location = new System.Drawing.Point(948, 12);
            this.buttonCrearCliente.Name = "buttonCrearCliente";
            this.buttonCrearCliente.Size = new System.Drawing.Size(228, 51);
            this.buttonCrearCliente.TabIndex = 16;
            this.buttonCrearCliente.Text = "Nuevo Cliente";
            this.buttonCrearCliente.UseVisualStyleBackColor = true;
            // 
            // buttonEliminarCliente
            // 
            this.buttonEliminarCliente.Location = new System.Drawing.Point(703, 12);
            this.buttonEliminarCliente.Name = "buttonEliminarCliente";
            this.buttonEliminarCliente.Size = new System.Drawing.Size(228, 51);
            this.buttonEliminarCliente.TabIndex = 15;
            this.buttonEliminarCliente.Text = "Eliminar";
            this.buttonEliminarCliente.UseVisualStyleBackColor = true;
            // 
            // buttonModificarCliente
            // 
            this.buttonModificarCliente.Location = new System.Drawing.Point(457, 12);
            this.buttonModificarCliente.Name = "buttonModificarCliente";
            this.buttonModificarCliente.Size = new System.Drawing.Size(228, 51);
            this.buttonModificarCliente.TabIndex = 14;
            this.buttonModificarCliente.Text = "Modificar";
            this.buttonModificarCliente.UseVisualStyleBackColor = true;
            // 
            // cedulaDataGridViewTextBoxColumn
            // 
            this.cedulaDataGridViewTextBoxColumn.DataPropertyName = "Cedula";
            this.cedulaDataGridViewTextBoxColumn.HeaderText = "Cedula";
            this.cedulaDataGridViewTextBoxColumn.Name = "cedulaDataGridViewTextBoxColumn";
            this.cedulaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombre1DataGridViewTextBoxColumn
            // 
            this.nombre1DataGridViewTextBoxColumn.DataPropertyName = "Nombre1";
            this.nombre1DataGridViewTextBoxColumn.HeaderText = "Primer Nombre";
            this.nombre1DataGridViewTextBoxColumn.Name = "nombre1DataGridViewTextBoxColumn";
            this.nombre1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombre2DataGridViewTextBoxColumn
            // 
            this.nombre2DataGridViewTextBoxColumn.DataPropertyName = "Nombre2";
            this.nombre2DataGridViewTextBoxColumn.HeaderText = "Segundo Nombre";
            this.nombre2DataGridViewTextBoxColumn.Name = "nombre2DataGridViewTextBoxColumn";
            this.nombre2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apellido1DataGridViewTextBoxColumn
            // 
            this.apellido1DataGridViewTextBoxColumn.DataPropertyName = "Apellido1";
            this.apellido1DataGridViewTextBoxColumn.HeaderText = "Primer Apellido";
            this.apellido1DataGridViewTextBoxColumn.Name = "apellido1DataGridViewTextBoxColumn";
            this.apellido1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apellido2DataGridViewTextBoxColumn
            // 
            this.apellido2DataGridViewTextBoxColumn.DataPropertyName = "Apellido2";
            this.apellido2DataGridViewTextBoxColumn.HeaderText = "Segundo Apellido";
            this.apellido2DataGridViewTextBoxColumn.Name = "apellido2DataGridViewTextBoxColumn";
            this.apellido2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sexoDataGridViewTextBoxColumn
            // 
            this.sexoDataGridViewTextBoxColumn.DataPropertyName = "Sexo";
            this.sexoDataGridViewTextBoxColumn.HeaderText = "Sexo";
            this.sexoDataGridViewTextBoxColumn.Name = "sexoDataGridViewTextBoxColumn";
            this.sexoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estadoCivilDataGridViewTextBoxColumn
            // 
            this.estadoCivilDataGridViewTextBoxColumn.DataPropertyName = "EstadoCivil";
            this.estadoCivilDataGridViewTextBoxColumn.HeaderText = "Estado Civil";
            this.estadoCivilDataGridViewTextBoxColumn.Name = "estadoCivilDataGridViewTextBoxColumn";
            this.estadoCivilDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaNacimientoDataGridViewTextBoxColumn
            // 
            this.fechaNacimientoDataGridViewTextBoxColumn.DataPropertyName = "FechaNacimiento";
            this.fechaNacimientoDataGridViewTextBoxColumn.HeaderText = "Fecha de Nacimiento";
            this.fechaNacimientoDataGridViewTextBoxColumn.Name = "fechaNacimientoDataGridViewTextBoxColumn";
            this.fechaNacimientoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frecuenteDataGridViewCheckBoxColumn
            // 
            this.frecuenteDataGridViewCheckBoxColumn.DataPropertyName = "Frecuente";
            this.frecuenteDataGridViewCheckBoxColumn.HeaderText = "Frecuente";
            this.frecuenteDataGridViewCheckBoxColumn.Name = "frecuenteDataGridViewCheckBoxColumn";
            this.frecuenteDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // tipoPDataGridViewTextBoxColumn
            // 
            this.tipoPDataGridViewTextBoxColumn.DataPropertyName = "TipoP";
            this.tipoPDataGridViewTextBoxColumn.HeaderText = "Tipo de Persona";
            this.tipoPDataGridViewTextBoxColumn.Name = "tipoPDataGridViewTextBoxColumn";
            this.tipoPDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipoPDataGridViewTextBoxColumn.Visible = false;
            // 
            // buttonCerrar
            // 
            this.buttonCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCerrar.Location = new System.Drawing.Point(1215, 0);
            this.buttonCerrar.Name = "buttonCerrar";
            this.buttonCerrar.Size = new System.Drawing.Size(26, 21);
            this.buttonCerrar.TabIndex = 17;
            this.buttonCerrar.Text = "X";
            this.buttonCerrar.UseVisualStyleBackColor = true;
            this.buttonCerrar.Click += new System.EventHandler(this.buttonCerrar_Click);
            // 
            // ConsultaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1240, 466);
            this.ControlBox = false;
            this.Controls.Add(this.buttonCerrar);
            this.Controls.Add(this.buttonCrearCliente);
            this.Controls.Add(this.buttonEliminarCliente);
            this.Controls.Add(this.buttonModificarCliente);
            this.Controls.Add(this.buttonLimpiarFiltro);
            this.Controls.Add(this.buttonBuscarCliente);
            this.Controls.Add(this.comboBoxBuscarCliente);
            this.Controls.Add(this.textBoxBuscarCliente);
            this.Controls.Add(this.labelConsultaEmpleados);
            this.Controls.Add(this.dataGridConsultaClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConsultaClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ConsultaCliente";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridConsultaClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteFisicoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridConsultaClientes;
        private System.Windows.Forms.BindingSource clienteFisicoBindingSource;
        private System.Windows.Forms.Button buttonLimpiarFiltro;
        private System.Windows.Forms.Button buttonBuscarCliente;
        private System.Windows.Forms.ComboBox comboBoxBuscarCliente;
        private System.Windows.Forms.TextBox textBoxBuscarCliente;
        private System.Windows.Forms.Label labelConsultaEmpleados;
        private System.Windows.Forms.Button buttonCrearCliente;
        private System.Windows.Forms.Button buttonEliminarCliente;
        private System.Windows.Forms.Button buttonModificarCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedulaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoCivilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaNacimientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn frecuenteDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoPDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonCerrar;
    }
}