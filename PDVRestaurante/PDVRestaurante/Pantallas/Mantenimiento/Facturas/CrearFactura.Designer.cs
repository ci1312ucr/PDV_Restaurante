namespace PDVRestaurante.Pantallas.Mantenimiento.Facturas
{
    partial class CrearFactura
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
            this.numericUpDownMesa = new System.Windows.Forms.NumericUpDown();
            this.comboBoxTipoPago = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonCrear = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxCedula = new System.Windows.Forms.ComboBox();
            this.textBoxMonto = new System.Windows.Forms.TextBox();
            this.platoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listViewPlatos = new System.Windows.Forms.ListView();
            this.comboBoxPlato = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownCantidad = new System.Windows.Forms.NumericUpDown();
            this.buttonAgregarPlato = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMesa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownMesa
            // 
            this.numericUpDownMesa.Location = new System.Drawing.Point(155, 76);
            this.numericUpDownMesa.Name = "numericUpDownMesa";
            this.numericUpDownMesa.Size = new System.Drawing.Size(294, 20);
            this.numericUpDownMesa.TabIndex = 24;
            // 
            // comboBoxTipoPago
            // 
            this.comboBoxTipoPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipoPago.FormattingEnabled = true;
            this.comboBoxTipoPago.Items.AddRange(new object[] {
            "Cheque",
            "Efectivo",
            "Tarjeta Debito",
            "Tarjeta Credito"});
            this.comboBoxTipoPago.Location = new System.Drawing.Point(155, 41);
            this.comboBoxTipoPago.Name = "comboBoxTipoPago";
            this.comboBoxTipoPago.Size = new System.Drawing.Size(294, 21);
            this.comboBoxTipoPago.TabIndex = 23;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(27, -32);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(294, 21);
            this.comboBox1.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Mesa";
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancelar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.Location = new System.Drawing.Point(634, 35);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(129, 34);
            this.buttonCancelar.TabIndex = 19;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonCrear
            // 
            this.buttonCrear.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCrear.Location = new System.Drawing.Point(634, 103);
            this.buttonCrear.Name = "buttonCrear";
            this.buttonCrear.Size = new System.Drawing.Size(129, 34);
            this.buttonCrear.TabIndex = 18;
            this.buttonCrear.Text = "Crear";
            this.buttonCrear.UseVisualStyleBackColor = true;
            this.buttonCrear.Click += new System.EventHandler(this.buttonCrear_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(560, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "Monto Total";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "Cédula del Cliente";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "Tipo de Pago";
            // 
            // comboBoxCedula
            // 
            this.comboBoxCedula.AllowDrop = true;
            this.comboBoxCedula.FormattingEnabled = true;
            this.comboBoxCedula.Location = new System.Drawing.Point(155, 11);
            this.comboBoxCedula.Name = "comboBoxCedula";
            this.comboBoxCedula.Size = new System.Drawing.Size(294, 21);
            this.comboBoxCedula.TabIndex = 28;
            // 
            // textBoxMonto
            // 
            this.textBoxMonto.Location = new System.Drawing.Point(659, 178);
            this.textBoxMonto.Name = "textBoxMonto";
            this.textBoxMonto.ReadOnly = true;
            this.textBoxMonto.Size = new System.Drawing.Size(129, 20);
            this.textBoxMonto.TabIndex = 29;
            this.textBoxMonto.Text = "₡0";
            // 
            // platoBindingSource
            // 
            this.platoBindingSource.DataSource = typeof(PDVRestaurante.Objetos.Plato);
            // 
            // listViewPlatos
            // 
            this.listViewPlatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewPlatos.Location = new System.Drawing.Point(12, 204);
            this.listViewPlatos.Name = "listViewPlatos";
            this.listViewPlatos.Size = new System.Drawing.Size(776, 284);
            this.listViewPlatos.TabIndex = 30;
            this.listViewPlatos.UseCompatibleStateImageBehavior = false;
            this.listViewPlatos.Resize += new System.EventHandler(this.listViewFacturas_Ajuste);
            // 
            // comboBoxPlato
            // 
            this.comboBoxPlato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPlato.FormattingEnabled = true;
            this.comboBoxPlato.Location = new System.Drawing.Point(155, 117);
            this.comboBoxPlato.Name = "comboBoxPlato";
            this.comboBoxPlato.Size = new System.Drawing.Size(234, 21);
            this.comboBoxPlato.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(43, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 20);
            this.label5.TabIndex = 32;
            this.label5.Text = "Agregar Plato";
            // 
            // numericUpDownCantidad
            // 
            this.numericUpDownCantidad.Location = new System.Drawing.Point(395, 117);
            this.numericUpDownCantidad.Name = "numericUpDownCantidad";
            this.numericUpDownCantidad.Size = new System.Drawing.Size(54, 20);
            this.numericUpDownCantidad.TabIndex = 33;
            // 
            // buttonAgregarPlato
            // 
            this.buttonAgregarPlato.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAgregarPlato.Location = new System.Drawing.Point(232, 155);
            this.buttonAgregarPlato.Name = "buttonAgregarPlato";
            this.buttonAgregarPlato.Size = new System.Drawing.Size(129, 34);
            this.buttonAgregarPlato.TabIndex = 34;
            this.buttonAgregarPlato.Text = "Agregar";
            this.buttonAgregarPlato.UseVisualStyleBackColor = true;
            this.buttonAgregarPlato.Click += new System.EventHandler(this.buttonAgregarPlato_Click);
            // 
            // CrearFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.buttonAgregarPlato);
            this.Controls.Add(this.numericUpDownCantidad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxPlato);
            this.Controls.Add(this.listViewPlatos);
            this.Controls.Add(this.textBoxMonto);
            this.Controls.Add(this.comboBoxCedula);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDownMesa);
            this.Controls.Add(this.comboBoxTipoPago);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonCrear);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CrearFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CrearUsuario";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMesa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownMesa;
        private System.Windows.Forms.ComboBox comboBoxTipoPago;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonCrear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxCedula;
        private System.Windows.Forms.TextBox textBoxMonto;
        private System.Windows.Forms.BindingSource platoBindingSource;
        private System.Windows.Forms.ListView listViewPlatos;
        private System.Windows.Forms.ComboBox comboBoxPlato;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDownCantidad;
        private System.Windows.Forms.Button buttonAgregarPlato;
    }
}