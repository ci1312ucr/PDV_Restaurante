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
            this.buttonCrearEmpleado = new System.Windows.Forms.Button();
            this.buttonBuscarEmpleado = new System.Windows.Forms.Button();
            this.textBoxBuscarEmpleado = new System.Windows.Forms.TextBox();
            this.comboBoxBuscarEmpleado = new System.Windows.Forms.ComboBox();
            this.labelConsultaEmpleados = new System.Windows.Forms.Label();
            this.buttonEliminarEmpleado = new System.Windows.Forms.Button();
            this.buttonModificarEmpleado = new System.Windows.Forms.Button();
            this.buttonLimpiarFiltro = new System.Windows.Forms.Button();
            this.buttonCerrar = new System.Windows.Forms.Button();
            this.listViewEmpleados = new System.Windows.Forms.ListView();
            this.comboBoxOrdenar = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.buttonCrearEmpleado.Click += new System.EventHandler(this.buttonCrearEmpleado_Click);
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
            this.buttonEliminarEmpleado.Click += new System.EventHandler(this.buttonEliminarEmpleado_Click);
            // 
            // buttonModificarEmpleado
            // 
            this.buttonModificarEmpleado.Location = new System.Drawing.Point(458, 12);
            this.buttonModificarEmpleado.Name = "buttonModificarEmpleado";
            this.buttonModificarEmpleado.Size = new System.Drawing.Size(228, 51);
            this.buttonModificarEmpleado.TabIndex = 1;
            this.buttonModificarEmpleado.Text = "Modificar";
            this.buttonModificarEmpleado.UseVisualStyleBackColor = true;
            this.buttonModificarEmpleado.Click += new System.EventHandler(this.buttonModificarEmpleado_Click);
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
            // listViewEmpleados
            // 
            this.listViewEmpleados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewEmpleados.FullRowSelect = true;
            this.listViewEmpleados.Location = new System.Drawing.Point(12, 142);
            this.listViewEmpleados.MultiSelect = false;
            this.listViewEmpleados.Name = "listViewEmpleados";
            this.listViewEmpleados.Size = new System.Drawing.Size(1221, 337);
            this.listViewEmpleados.TabIndex = 10;
            this.listViewEmpleados.UseCompatibleStateImageBehavior = false;
            this.listViewEmpleados.View = System.Windows.Forms.View.Details;
            this.listViewEmpleados.Resize += new System.EventHandler(this.listViewEmpleados_Ajuste);
            // 
            // comboBoxOrdenar
            // 
            this.comboBoxOrdenar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOrdenar.FormattingEnabled = true;
            this.comboBoxOrdenar.Location = new System.Drawing.Point(972, 115);
            this.comboBoxOrdenar.Name = "comboBoxOrdenar";
            this.comboBoxOrdenar.Size = new System.Drawing.Size(261, 21);
            this.comboBoxOrdenar.TabIndex = 12;
            this.comboBoxOrdenar.SelectedIndexChanged += new System.EventHandler(this.comboBoxOrdenar_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(905, 115);
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
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.buttonCerrar;
            this.ClientSize = new System.Drawing.Size(1245, 491);
            this.ControlBox = false;
            this.Controls.Add(this.comboBoxOrdenar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewEmpleados);
            this.Controls.Add(this.buttonCerrar);
            this.Controls.Add(this.buttonLimpiarFiltro);
            this.Controls.Add(this.buttonCrearEmpleado);
            this.Controls.Add(this.buttonEliminarEmpleado);
            this.Controls.Add(this.buttonBuscarEmpleado);
            this.Controls.Add(this.buttonModificarEmpleado);
            this.Controls.Add(this.comboBoxBuscarEmpleado);
            this.Controls.Add(this.textBoxBuscarEmpleado);
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
        private System.Windows.Forms.ComboBox comboBoxBuscarEmpleado;
        private System.Windows.Forms.Label labelConsultaEmpleados;
        private System.Windows.Forms.Button buttonEliminarEmpleado;
        private System.Windows.Forms.Button buttonModificarEmpleado;
        private System.Windows.Forms.TextBox textBoxBuscarEmpleado;
        private System.Windows.Forms.Button buttonBuscarEmpleado;
        private System.Windows.Forms.Button buttonCrearEmpleado;
        private System.Windows.Forms.Button buttonLimpiarFiltro;
        private System.Windows.Forms.Button buttonCerrar;
        private System.Windows.Forms.ListView listViewEmpleados;
        private System.Windows.Forms.ComboBox comboBoxOrdenar;
        private System.Windows.Forms.Label label1;
    }
}