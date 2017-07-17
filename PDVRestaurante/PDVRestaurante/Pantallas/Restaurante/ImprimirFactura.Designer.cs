namespace PDVRestaurante.Pantallas.Restaurante
{
    partial class ImprimirFactura
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
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.textBuscar = new System.Windows.Forms.TextBox();
            this.labelConsultaFacturas = new System.Windows.Forms.Label();
            this.listViewFactura = new System.Windows.Forms.ListView();
            this.buttonImprimir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(309, 20);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscar.TabIndex = 33;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // textBuscar
            // 
            this.textBuscar.Location = new System.Drawing.Point(170, 22);
            this.textBuscar.Name = "textBuscar";
            this.textBuscar.Size = new System.Drawing.Size(133, 20);
            this.textBuscar.TabIndex = 32;
            this.textBuscar.TextChanged += new System.EventHandler(this.textBuscar_TextChanged);
            // 
            // labelConsultaFacturas
            // 
            this.labelConsultaFacturas.AutoSize = true;
            this.labelConsultaFacturas.Location = new System.Drawing.Point(27, 25);
            this.labelConsultaFacturas.Name = "labelConsultaFacturas";
            this.labelConsultaFacturas.Size = new System.Drawing.Size(137, 13);
            this.labelConsultaFacturas.TabIndex = 31;
            this.labelConsultaFacturas.Text = "Digite el número de factura:";
            // 
            // listViewFactura
            // 
            this.listViewFactura.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewFactura.FullRowSelect = true;
            this.listViewFactura.Location = new System.Drawing.Point(12, 153);
            this.listViewFactura.MultiSelect = false;
            this.listViewFactura.Name = "listViewFactura";
            this.listViewFactura.Size = new System.Drawing.Size(776, 335);
            this.listViewFactura.TabIndex = 34;
            this.listViewFactura.UseCompatibleStateImageBehavior = false;
            this.listViewFactura.View = System.Windows.Forms.View.Details;
            // 
            // buttonImprimir
            // 
            this.buttonImprimir.Location = new System.Drawing.Point(294, 97);
            this.buttonImprimir.Name = "buttonImprimir";
            this.buttonImprimir.Size = new System.Drawing.Size(169, 37);
            this.buttonImprimir.TabIndex = 35;
            this.buttonImprimir.Text = "IMPRIMIR";
            this.buttonImprimir.UseVisualStyleBackColor = true;
            this.buttonImprimir.Click += new System.EventHandler(this.buttonImprimir_Click);
            // 
            // ImprimirFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.ControlBox = false;
            this.Controls.Add(this.buttonImprimir);
            this.Controls.Add(this.listViewFactura);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.textBuscar);
            this.Controls.Add(this.labelConsultaFacturas);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ImprimirFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ImprimirFactura";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.TextBox textBuscar;
        private System.Windows.Forms.Label labelConsultaFacturas;
        private System.Windows.Forms.ListView listViewFactura;
        private System.Windows.Forms.Button buttonImprimir;
    }
}