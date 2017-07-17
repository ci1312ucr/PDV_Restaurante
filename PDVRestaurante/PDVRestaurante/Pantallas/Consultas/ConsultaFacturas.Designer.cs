namespace PDVRestaurante.Pantallas.Consultas
{
    partial class ConsultaFacturas
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
            this.comboBoxOrdenar = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listViewFacturas = new System.Windows.Forms.ListView();
            this.buttonLimpiarFiltro = new System.Windows.Forms.Button();
            this.buttonCrear = new System.Windows.Forms.Button();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.comboBoxBuscar = new System.Windows.Forms.ComboBox();
            this.textBuscar = new System.Windows.Forms.TextBox();
            this.labelConsultaFacturas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxOrdenar
            // 
            this.comboBoxOrdenar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOrdenar.FormattingEnabled = true;
            this.comboBoxOrdenar.Location = new System.Drawing.Point(524, 112);
            this.comboBoxOrdenar.Name = "comboBoxOrdenar";
            this.comboBoxOrdenar.Size = new System.Drawing.Size(261, 21);
            this.comboBoxOrdenar.TabIndex = 35;
            this.comboBoxOrdenar.SelectedIndexChanged += new System.EventHandler(this.comboBoxOrdenar_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(449, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Ordernar por:";
            // 
            // listViewFacturas
            // 
            this.listViewFacturas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewFacturas.FullRowSelect = true;
            this.listViewFacturas.Location = new System.Drawing.Point(12, 142);
            this.listViewFacturas.MultiSelect = false;
            this.listViewFacturas.Name = "listViewFacturas";
            this.listViewFacturas.Size = new System.Drawing.Size(776, 346);
            this.listViewFacturas.TabIndex = 33;
            this.listViewFacturas.UseCompatibleStateImageBehavior = false;
            this.listViewFacturas.View = System.Windows.Forms.View.Details;
            this.listViewFacturas.Resize += new System.EventHandler(this.listViewFacturas_Ajuste);
            // 
            // buttonLimpiarFiltro
            // 
            this.buttonLimpiarFiltro.Location = new System.Drawing.Point(212, 67);
            this.buttonLimpiarFiltro.Name = "buttonLimpiarFiltro";
            this.buttonLimpiarFiltro.Size = new System.Drawing.Size(75, 23);
            this.buttonLimpiarFiltro.TabIndex = 32;
            this.buttonLimpiarFiltro.Text = "Limpiar Filtro";
            this.buttonLimpiarFiltro.UseVisualStyleBackColor = true;
            this.buttonLimpiarFiltro.Click += new System.EventHandler(this.buttonLimpiarFiltro_Click);
            // 
            // buttonCrear
            // 
            this.buttonCrear.Location = new System.Drawing.Point(569, 25);
            this.buttonCrear.Name = "buttonCrear";
            this.buttonCrear.Size = new System.Drawing.Size(96, 35);
            this.buttonCrear.TabIndex = 31;
            this.buttonCrear.Text = "Nueva Factura";
            this.buttonCrear.UseVisualStyleBackColor = true;
            this.buttonCrear.Click += new System.EventHandler(this.buttonCrear_Click);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(113, 67);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscar.TabIndex = 30;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // comboBoxBuscar
            // 
            this.comboBoxBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBuscar.FormattingEnabled = true;
            this.comboBoxBuscar.Location = new System.Drawing.Point(79, 9);
            this.comboBoxBuscar.Name = "comboBoxBuscar";
            this.comboBoxBuscar.Size = new System.Drawing.Size(261, 21);
            this.comboBoxBuscar.TabIndex = 28;
            // 
            // textBuscar
            // 
            this.textBuscar.Location = new System.Drawing.Point(78, 40);
            this.textBuscar.Name = "textBuscar";
            this.textBuscar.Size = new System.Drawing.Size(262, 20);
            this.textBuscar.TabIndex = 29;
            this.textBuscar.TextChanged += new System.EventHandler(this.textBuscar_TextChanged);
            // 
            // labelConsultaFacturas
            // 
            this.labelConsultaFacturas.AutoSize = true;
            this.labelConsultaFacturas.Location = new System.Drawing.Point(12, 9);
            this.labelConsultaFacturas.Name = "labelConsultaFacturas";
            this.labelConsultaFacturas.Size = new System.Drawing.Size(61, 13);
            this.labelConsultaFacturas.TabIndex = 27;
            this.labelConsultaFacturas.Text = "Buscar por:";
            // 
            // ConsultaFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.ControlBox = false;
            this.Controls.Add(this.comboBoxOrdenar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewFacturas);
            this.Controls.Add(this.buttonLimpiarFiltro);
            this.Controls.Add(this.buttonCrear);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.comboBoxBuscar);
            this.Controls.Add(this.textBuscar);
            this.Controls.Add(this.labelConsultaFacturas);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConsultaFacturas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ConsultaFacturas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxOrdenar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewFacturas;
        private System.Windows.Forms.Button buttonLimpiarFiltro;
        private System.Windows.Forms.Button buttonCrear;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.ComboBox comboBoxBuscar;
        private System.Windows.Forms.TextBox textBuscar;
        private System.Windows.Forms.Label labelConsultaFacturas;
    }
}