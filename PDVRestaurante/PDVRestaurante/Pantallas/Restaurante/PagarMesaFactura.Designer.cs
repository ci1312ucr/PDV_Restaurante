namespace PDVRestaurante.Pantallas.Restaurante
{
    partial class PagarMesaFactura
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.textBuscar = new System.Windows.Forms.TextBox();
            this.labelConsultaFacturas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "(0 en caso de orden para llevar)";
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(289, 9);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscar.TabIndex = 37;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            // 
            // textBuscar
            // 
            this.textBuscar.Location = new System.Drawing.Point(186, 9);
            this.textBuscar.Name = "textBuscar";
            this.textBuscar.Size = new System.Drawing.Size(82, 20);
            this.textBuscar.TabIndex = 36;
            // 
            // labelConsultaFacturas
            // 
            this.labelConsultaFacturas.AutoSize = true;
            this.labelConsultaFacturas.Location = new System.Drawing.Point(27, 9);
            this.labelConsultaFacturas.Name = "labelConsultaFacturas";
            this.labelConsultaFacturas.Size = new System.Drawing.Size(129, 13);
            this.labelConsultaFacturas.TabIndex = 35;
            this.labelConsultaFacturas.Text = "Digite el número de mesa:";
            // 
            // PagarMesaFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.textBuscar);
            this.Controls.Add(this.labelConsultaFacturas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PagarMesaFactura";
            this.Text = "PagarMesaFactura";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.TextBox textBuscar;
        private System.Windows.Forms.Label labelConsultaFacturas;
    }
}