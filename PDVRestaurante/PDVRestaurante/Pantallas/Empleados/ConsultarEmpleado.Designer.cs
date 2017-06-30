namespace PDVRestaurante.Pantallas.Clientes
{
    partial class ConsultarCliente
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
            this.empleadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.empleadoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cedulaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idSucursalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaInicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // empleadoBindingSource
            // 
            this.empleadoBindingSource.DataSource = typeof(PDVRestaurante.Objetos.Empleado);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cedulaDataGridViewTextBoxColumn,
            this.tipoDataGridViewTextBoxColumn,
            this.salarioDataGridViewTextBoxColumn,
            this.idSucursalDataGridViewTextBoxColumn,
            this.fechaInicioDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.empleadoBindingSource1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(603, 323);
            this.dataGridView1.TabIndex = 0;
            // 
            // empleadoBindingSource1
            // 
            this.empleadoBindingSource1.DataSource = typeof(PDVRestaurante.Objetos.Empleado);
            // 
            // cedulaDataGridViewTextBoxColumn
            // 
            this.cedulaDataGridViewTextBoxColumn.DataPropertyName = "Cedula";
            this.cedulaDataGridViewTextBoxColumn.HeaderText = "Cedula";
            this.cedulaDataGridViewTextBoxColumn.Name = "cedulaDataGridViewTextBoxColumn";
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            this.tipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo";
            this.tipoDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            // 
            // salarioDataGridViewTextBoxColumn
            // 
            this.salarioDataGridViewTextBoxColumn.DataPropertyName = "Salario";
            this.salarioDataGridViewTextBoxColumn.HeaderText = "Salario";
            this.salarioDataGridViewTextBoxColumn.Name = "salarioDataGridViewTextBoxColumn";
            // 
            // idSucursalDataGridViewTextBoxColumn
            // 
            this.idSucursalDataGridViewTextBoxColumn.DataPropertyName = "IdSucursal";
            this.idSucursalDataGridViewTextBoxColumn.HeaderText = "IdSucursal";
            this.idSucursalDataGridViewTextBoxColumn.Name = "idSucursalDataGridViewTextBoxColumn";
            // 
            // fechaInicioDataGridViewTextBoxColumn
            // 
            this.fechaInicioDataGridViewTextBoxColumn.DataPropertyName = "FechaInicio";
            this.fechaInicioDataGridViewTextBoxColumn.HeaderText = "FechaInicio";
            this.fechaInicioDataGridViewTextBoxColumn.Name = "fechaInicioDataGridViewTextBoxColumn";
            // 
            // ConsultarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 323);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ConsultarCliente";
            this.Text = "Consultar Empleado";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource empleadoBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedulaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSucursalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaInicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource empleadoBindingSource1;
    }
}