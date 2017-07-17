namespace PDVRestaurante.Pantallas.Restaurante
{
    partial class ControlRestaurante
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
            this.buttonPagarFactura = new System.Windows.Forms.Button();
            this.buttonNuevaFactura = new System.Windows.Forms.Button();
            this.buttonImprimirFactura = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonPagarFactura
            // 
            this.buttonPagarFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPagarFactura.Location = new System.Drawing.Point(540, 70);
            this.buttonPagarFactura.Name = "buttonPagarFactura";
            this.buttonPagarFactura.Size = new System.Drawing.Size(248, 138);
            this.buttonPagarFactura.TabIndex = 0;
            this.buttonPagarFactura.Text = "Pagar Factura";
            this.buttonPagarFactura.UseVisualStyleBackColor = true;
            this.buttonPagarFactura.Click += new System.EventHandler(this.buttonPagarFactura_Click);
            // 
            // buttonNuevaFactura
            // 
            this.buttonNuevaFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNuevaFactura.Location = new System.Drawing.Point(12, 70);
            this.buttonNuevaFactura.Name = "buttonNuevaFactura";
            this.buttonNuevaFactura.Size = new System.Drawing.Size(248, 138);
            this.buttonNuevaFactura.TabIndex = 1;
            this.buttonNuevaFactura.Text = "Nueva Factura";
            this.buttonNuevaFactura.UseVisualStyleBackColor = true;
            this.buttonNuevaFactura.Click += new System.EventHandler(this.buttonNuevaFactura_Click);
            // 
            // buttonImprimirFactura
            // 
            this.buttonImprimirFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonImprimirFactura.Location = new System.Drawing.Point(276, 70);
            this.buttonImprimirFactura.Name = "buttonImprimirFactura";
            this.buttonImprimirFactura.Size = new System.Drawing.Size(248, 138);
            this.buttonImprimirFactura.TabIndex = 2;
            this.buttonImprimirFactura.Text = "Imprimir Factura";
            this.buttonImprimirFactura.UseVisualStyleBackColor = true;
            this.buttonImprimirFactura.Click += new System.EventHandler(this.buttonImprimirFactura_Click);
            // 
            // ControlRestaurante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.ControlBox = false;
            this.Controls.Add(this.buttonImprimirFactura);
            this.Controls.Add(this.buttonNuevaFactura);
            this.Controls.Add(this.buttonPagarFactura);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ControlRestaurante";
            this.Text = "Control de Restaurante";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonPagarFactura;
        private System.Windows.Forms.Button buttonNuevaFactura;
        private System.Windows.Forms.Button buttonImprimirFactura;
    }
}