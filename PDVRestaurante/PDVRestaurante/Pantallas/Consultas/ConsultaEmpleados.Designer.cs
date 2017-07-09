namespace PDVRestaurante.Pantallas.Consultas
{
    partial class ConsultaEmpleados
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
            this.buttonCrearEmpleado = new System.Windows.Forms.Button();
            this.buttonBuscarEmpleado = new System.Windows.Forms.Button();
            this.textBoxBuscarEmpleado = new System.Windows.Forms.TextBox();
            this.comboBoxBuscarEmpleado = new System.Windows.Forms.ComboBox();
            this.labelConsultaEmpleados = new System.Windows.Forms.Label();
            this.buttonEliminarEmpleado = new System.Windows.Forms.Button();
            this.buttonModificarEmpleado = new System.Windows.Forms.Button();
            this.dataGridConsultaEmpleados = new System.Windows.Forms.DataGridView();
            this.empleadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonLimpiarFiltro = new System.Windows.Forms.Button();
            this.cedulaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaInicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreSucursalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaNacimientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoCivilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idSucursalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridConsultaEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCrearEmpleado
            // 
            this.buttonCrearEmpleado.Location = new System.Drawing.Point(949, 12);
            this.buttonCrearEmpleado.Name = "buttonCrearEmpleado";
            this.buttonCrearEmpleado.Size = new System.Drawing.Size(228, 51);
            this.buttonCrearEmpleado.TabIndex = 7;
            this.buttonCrearEmpleado.Text = "Nuevo Empleado";
            this.buttonCrearEmpleado.UseVisualStyleBackColor = true;
            // 
            // buttonBuscarEmpleado
            // 
            this.buttonBuscarEmpleado.Location = new System.Drawing.Point(346, 38);
            this.buttonBuscarEmpleado.Name = "buttonBuscarEmpleado";
            this.buttonBuscarEmpleado.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscarEmpleado.TabIndex = 6;
            this.buttonBuscarEmpleado.Text = "Buscar";
            this.buttonBuscarEmpleado.UseVisualStyleBackColor = true;
            this.buttonBuscarEmpleado.Click += new System.EventHandler(this.buttonBuscarEmpleado_Click);
            // 
            // textBoxBuscarEmpleado
            // 
            this.textBoxBuscarEmpleado.Location = new System.Drawing.Point(78, 40);
            this.textBoxBuscarEmpleado.Name = "textBoxBuscarEmpleado";
            this.textBoxBuscarEmpleado.Size = new System.Drawing.Size(262, 20);
            this.textBoxBuscarEmpleado.TabIndex = 5;
            this.textBoxBuscarEmpleado.TextChanged += new System.EventHandler(this.textBoxBuscarEmpleado_TextChanged);
            // 
            // comboBoxBuscarEmpleado
            // 
            this.comboBoxBuscarEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBuscarEmpleado.FormattingEnabled = true;
            this.comboBoxBuscarEmpleado.Location = new System.Drawing.Point(79, 9);
            this.comboBoxBuscarEmpleado.Name = "comboBoxBuscarEmpleado";
            this.comboBoxBuscarEmpleado.Size = new System.Drawing.Size(261, 21);
            this.comboBoxBuscarEmpleado.TabIndex = 4;
            // 
            // labelConsultaEmpleados
            // 
            this.labelConsultaEmpleados.AutoSize = true;
            this.labelConsultaEmpleados.Location = new System.Drawing.Point(12, 9);
            this.labelConsultaEmpleados.Name = "labelConsultaEmpleados";
            this.labelConsultaEmpleados.Size = new System.Drawing.Size(61, 13);
            this.labelConsultaEmpleados.TabIndex = 3;
            this.labelConsultaEmpleados.Text = "Buscar por:";
            // 
            // buttonEliminarEmpleado
            // 
            this.buttonEliminarEmpleado.Location = new System.Drawing.Point(704, 12);
            this.buttonEliminarEmpleado.Name = "buttonEliminarEmpleado";
            this.buttonEliminarEmpleado.Size = new System.Drawing.Size(228, 51);
            this.buttonEliminarEmpleado.TabIndex = 2;
            this.buttonEliminarEmpleado.Text = "Eliminar";
            this.buttonEliminarEmpleado.UseVisualStyleBackColor = true;
            // 
            // buttonModificarEmpleado
            // 
            this.buttonModificarEmpleado.Location = new System.Drawing.Point(458, 12);
            this.buttonModificarEmpleado.Name = "buttonModificarEmpleado";
            this.buttonModificarEmpleado.Size = new System.Drawing.Size(228, 51);
            this.buttonModificarEmpleado.TabIndex = 1;
            this.buttonModificarEmpleado.Text = "Modificar";
            this.buttonModificarEmpleado.UseVisualStyleBackColor = true;
            // 
            // dataGridConsultaEmpleados
            // 
            this.dataGridConsultaEmpleados.AllowUserToAddRows = false;
            this.dataGridConsultaEmpleados.AllowUserToDeleteRows = false;
            this.dataGridConsultaEmpleados.AllowUserToResizeColumns = false;
            this.dataGridConsultaEmpleados.AllowUserToResizeRows = false;
            this.dataGridConsultaEmpleados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridConsultaEmpleados.AutoGenerateColumns = false;
            this.dataGridConsultaEmpleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridConsultaEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridConsultaEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cedulaDataGridViewTextBoxColumn,
            this.nombre1DataGridViewTextBoxColumn,
            this.nombre2DataGridViewTextBoxColumn,
            this.apellido1DataGridViewTextBoxColumn,
            this.apellido2DataGridViewTextBoxColumn,
            this.tipoEDataGridViewTextBoxColumn,
            this.fechaInicioDataGridViewTextBoxColumn,
            this.nombreSucursalDataGridViewTextBoxColumn,
            this.fechaNacimientoDataGridViewTextBoxColumn,
            this.sexoDataGridViewTextBoxColumn,
            this.estadoCivilDataGridViewTextBoxColumn,
            this.salarioDataGridViewTextBoxColumn,
            this.tipoPDataGridViewTextBoxColumn,
            this.idSucursalDataGridViewTextBoxColumn});
            this.dataGridConsultaEmpleados.DataSource = this.empleadoBindingSource;
            this.dataGridConsultaEmpleados.Location = new System.Drawing.Point(0, 116);
            this.dataGridConsultaEmpleados.MultiSelect = false;
            this.dataGridConsultaEmpleados.Name = "dataGridConsultaEmpleados";
            this.dataGridConsultaEmpleados.ReadOnly = true;
            this.dataGridConsultaEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridConsultaEmpleados.Size = new System.Drawing.Size(1245, 346);
            this.dataGridConsultaEmpleados.TabIndex = 0;
            // 
            // empleadoBindingSource
            // 
            this.empleadoBindingSource.DataSource = typeof(PDVRestaurante.Objetos.Empleado);
            // 
            // buttonLimpiarFiltro
            // 
            this.buttonLimpiarFiltro.Location = new System.Drawing.Point(346, 67);
            this.buttonLimpiarFiltro.Name = "buttonLimpiarFiltro";
            this.buttonLimpiarFiltro.Size = new System.Drawing.Size(75, 23);
            this.buttonLimpiarFiltro.TabIndex = 8;
            this.buttonLimpiarFiltro.Text = "Limpiar Filtro";
            this.buttonLimpiarFiltro.UseVisualStyleBackColor = true;
            this.buttonLimpiarFiltro.Click += new System.EventHandler(this.buttonLimpiarFiltro_Click);
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
            // tipoEDataGridViewTextBoxColumn
            // 
            this.tipoEDataGridViewTextBoxColumn.DataPropertyName = "TipoE";
            this.tipoEDataGridViewTextBoxColumn.HeaderText = "Tipo de Empleado";
            this.tipoEDataGridViewTextBoxColumn.Name = "tipoEDataGridViewTextBoxColumn";
            this.tipoEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaInicioDataGridViewTextBoxColumn
            // 
            this.fechaInicioDataGridViewTextBoxColumn.DataPropertyName = "FechaInicio";
            this.fechaInicioDataGridViewTextBoxColumn.HeaderText = "Fecha de Inicio";
            this.fechaInicioDataGridViewTextBoxColumn.Name = "fechaInicioDataGridViewTextBoxColumn";
            this.fechaInicioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreSucursalDataGridViewTextBoxColumn
            // 
            this.nombreSucursalDataGridViewTextBoxColumn.DataPropertyName = "NombreSucursal";
            this.nombreSucursalDataGridViewTextBoxColumn.HeaderText = "Sucursal Asignada";
            this.nombreSucursalDataGridViewTextBoxColumn.Name = "nombreSucursalDataGridViewTextBoxColumn";
            this.nombreSucursalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaNacimientoDataGridViewTextBoxColumn
            // 
            this.fechaNacimientoDataGridViewTextBoxColumn.DataPropertyName = "FechaNacimiento";
            this.fechaNacimientoDataGridViewTextBoxColumn.HeaderText = "Fecha de Nacimiento";
            this.fechaNacimientoDataGridViewTextBoxColumn.Name = "fechaNacimientoDataGridViewTextBoxColumn";
            this.fechaNacimientoDataGridViewTextBoxColumn.ReadOnly = true;
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
            // salarioDataGridViewTextBoxColumn
            // 
            this.salarioDataGridViewTextBoxColumn.DataPropertyName = "Salario";
            this.salarioDataGridViewTextBoxColumn.HeaderText = "Salario";
            this.salarioDataGridViewTextBoxColumn.Name = "salarioDataGridViewTextBoxColumn";
            this.salarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoPDataGridViewTextBoxColumn
            // 
            this.tipoPDataGridViewTextBoxColumn.DataPropertyName = "TipoP";
            this.tipoPDataGridViewTextBoxColumn.HeaderText = "Tipo de Persona";
            this.tipoPDataGridViewTextBoxColumn.Name = "tipoPDataGridViewTextBoxColumn";
            this.tipoPDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipoPDataGridViewTextBoxColumn.Visible = false;
            // 
            // idSucursalDataGridViewTextBoxColumn
            // 
            this.idSucursalDataGridViewTextBoxColumn.DataPropertyName = "IdSucursal";
            this.idSucursalDataGridViewTextBoxColumn.HeaderText = "Id de Sucursal";
            this.idSucursalDataGridViewTextBoxColumn.Name = "idSucursalDataGridViewTextBoxColumn";
            this.idSucursalDataGridViewTextBoxColumn.ReadOnly = true;
            this.idSucursalDataGridViewTextBoxColumn.Visible = false;
            // 
            // buttonCerrar
            // 
            this.buttonCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCerrar.Location = new System.Drawing.Point(1219, 0);
            this.buttonCerrar.Name = "buttonCerrar";
            this.buttonCerrar.Size = new System.Drawing.Size(26, 21);
            this.buttonCerrar.TabIndex = 9;
            this.buttonCerrar.Text = "X";
            this.buttonCerrar.UseVisualStyleBackColor = true;
            this.buttonCerrar.Click += new System.EventHandler(this.buttonCerrar_Click);
            // 
            // ConsultaEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.buttonCerrar;
            this.ClientSize = new System.Drawing.Size(1245, 462);
            this.ControlBox = false;
            this.Controls.Add(this.buttonCerrar);
            this.Controls.Add(this.buttonLimpiarFiltro);
            this.Controls.Add(this.dataGridConsultaEmpleados);
            this.Controls.Add(this.buttonCrearEmpleado);
            this.Controls.Add(this.buttonEliminarEmpleado);
            this.Controls.Add(this.buttonBuscarEmpleado);
            this.Controls.Add(this.buttonModificarEmpleado);
            this.Controls.Add(this.comboBoxBuscarEmpleado);
            this.Controls.Add(this.textBoxBuscarEmpleado);
            this.Controls.Add(this.labelConsultaEmpleados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConsultaEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ConsultaEmpleado";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridConsultaEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxBuscarEmpleado;
        private System.Windows.Forms.Label labelConsultaEmpleados;
        private System.Windows.Forms.Button buttonEliminarEmpleado;
        private System.Windows.Forms.Button buttonModificarEmpleado;
        private System.Windows.Forms.DataGridView dataGridConsultaEmpleados;
        private System.Windows.Forms.BindingSource empleadoBindingSource;
        private System.Windows.Forms.TextBox textBoxBuscarEmpleado;
        private System.Windows.Forms.Button buttonBuscarEmpleado;
        private System.Windows.Forms.Button buttonCrearEmpleado;
        private System.Windows.Forms.Button buttonLimpiarFiltro;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedulaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaInicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreSucursalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaNacimientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoCivilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSucursalDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonCerrar;
    }
}