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
            this.buttonCrear = new System.Windows.Forms.Button();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.comboBoxBuscar = new System.Windows.Forms.ComboBox();
            this.labelConsultaEmpleados = new System.Windows.Forms.Label();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.buttonLimpiarFiltro = new System.Windows.Forms.Button();
            this.buttonCerrar = new System.Windows.Forms.Button();
            this.listViewEmpleados = new System.Windows.Forms.ListView();
            this.comboBoxOrdenar = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCrear
            // 
            this.buttonCrear.Location = new System.Drawing.Point(635, 25);
            this.buttonCrear.Name = "buttonCrear";
            this.buttonCrear.Size = new System.Drawing.Size(96, 35);
            this.buttonCrear.TabIndex = 7;
            this.buttonCrear.Text = "Nuevo Empleado";
            this.buttonCrear.UseVisualStyleBackColor = true;
            this.buttonCrear.Click += new System.EventHandler(this.buttonCrearEmpleado_Click);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(113, 67);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscar.TabIndex = 6;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscarEmpleado_Click);
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.Location = new System.Drawing.Point(78, 40);
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(262, 20);
            this.textBoxBuscar.TabIndex = 5;
            this.textBoxBuscar.TextChanged += new System.EventHandler(this.textBoxBuscarEmpleado_TextChanged);
            // 
            // comboBoxBuscar
            // 
            this.comboBoxBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBuscar.FormattingEnabled = true;
            this.comboBoxBuscar.Location = new System.Drawing.Point(79, 9);
            this.comboBoxBuscar.Name = "comboBoxBuscar";
            this.comboBoxBuscar.Size = new System.Drawing.Size(261, 21);
            this.comboBoxBuscar.TabIndex = 4;
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
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(522, 25);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(96, 35);
            this.buttonEliminar.TabIndex = 2;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminarEmpleado_Click);
            // 
            // buttonModificar
            // 
            this.buttonModificar.Location = new System.Drawing.Point(405, 25);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(96, 35);
            this.buttonModificar.TabIndex = 1;
            this.buttonModificar.Text = "Modificar";
            this.buttonModificar.UseVisualStyleBackColor = true;
            this.buttonModificar.Click += new System.EventHandler(this.buttonModificarEmpleado_Click);
            // 
            // buttonLimpiarFiltro
            // 
            this.buttonLimpiarFiltro.Location = new System.Drawing.Point(212, 67);
            this.buttonLimpiarFiltro.Name = "buttonLimpiarFiltro";
            this.buttonLimpiarFiltro.Size = new System.Drawing.Size(75, 23);
            this.buttonLimpiarFiltro.TabIndex = 8;
            this.buttonLimpiarFiltro.Text = "Limpiar Filtro";
            this.buttonLimpiarFiltro.UseVisualStyleBackColor = true;
            this.buttonLimpiarFiltro.Click += new System.EventHandler(this.buttonLimpiarFiltro_Click);
            // 
            // buttonCerrar
            // 
            this.buttonCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCerrar.Location = new System.Drawing.Point(774, 0);
            this.buttonCerrar.Name = "buttonCerrar";
            this.buttonCerrar.Size = new System.Drawing.Size(26, 21);
            this.buttonCerrar.TabIndex = 9;
            this.buttonCerrar.Text = "X";
            this.buttonCerrar.UseVisualStyleBackColor = true;
            this.buttonCerrar.Click += new System.EventHandler(this.buttonCerrar_Click);
            // 
            // listViewEmpleados
            // 
            this.listViewEmpleados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewEmpleados.FullRowSelect = true;
            this.listViewEmpleados.Location = new System.Drawing.Point(12, 142);
            this.listViewEmpleados.MultiSelect = false;
            this.listViewEmpleados.Name = "listViewEmpleados";
            this.listViewEmpleados.Size = new System.Drawing.Size(776, 346);
            this.listViewEmpleados.TabIndex = 10;
            this.listViewEmpleados.UseCompatibleStateImageBehavior = false;
            this.listViewEmpleados.View = System.Windows.Forms.View.Details;
            this.listViewEmpleados.Resize += new System.EventHandler(this.listViewEmpleados_Ajuste);
            // 
            // comboBoxOrdenar
            // 
            this.comboBoxOrdenar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOrdenar.FormattingEnabled = true;
            this.comboBoxOrdenar.Location = new System.Drawing.Point(524, 112);
            this.comboBoxOrdenar.Name = "comboBoxOrdenar";
            this.comboBoxOrdenar.Size = new System.Drawing.Size(261, 21);
            this.comboBoxOrdenar.TabIndex = 12;
            this.comboBoxOrdenar.SelectedIndexChanged += new System.EventHandler(this.comboBoxOrdenar_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(449, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ordernar por:";
            // 
            // ConsultaEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.CancelButton = this.buttonCerrar;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.ControlBox = false;
            this.Controls.Add(this.comboBoxOrdenar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewEmpleados);
            this.Controls.Add(this.buttonCerrar);
            this.Controls.Add(this.buttonLimpiarFiltro);
            this.Controls.Add(this.buttonCrear);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.buttonModificar);
            this.Controls.Add(this.comboBoxBuscar);
            this.Controls.Add(this.textBoxBuscar);
            this.Controls.Add(this.labelConsultaEmpleados);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConsultaEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ConsultaEmpleado";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxBuscar;
        private System.Windows.Forms.Label labelConsultaEmpleados;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonModificar;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Button buttonCrear;
        private System.Windows.Forms.Button buttonLimpiarFiltro;
        private System.Windows.Forms.Button buttonCerrar;
        private System.Windows.Forms.ListView listViewEmpleados;
        private System.Windows.Forms.ComboBox comboBoxOrdenar;
        private System.Windows.Forms.Label label1;
    }
}