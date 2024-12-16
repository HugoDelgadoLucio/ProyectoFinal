namespace ProyectoFinal
{
    partial class Form4
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
            btnEfectivo = new Button();
            btnTarjetaCredito = new Button();
            btnQr = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnEfectivo
            // 
            btnEfectivo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEfectivo.Location = new Point(32, 159);
            btnEfectivo.Name = "btnEfectivo";
            btnEfectivo.Size = new Size(187, 77);
            btnEfectivo.TabIndex = 0;
            btnEfectivo.Text = "Efectivo";
            btnEfectivo.UseVisualStyleBackColor = true;
            btnEfectivo.Click += btnEfectivo_Click_1;
            // 
            // btnTarjetaCredito
            // 
            btnTarjetaCredito.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnTarjetaCredito.Location = new Point(296, 159);
            btnTarjetaCredito.Name = "btnTarjetaCredito";
            btnTarjetaCredito.Size = new Size(187, 77);
            btnTarjetaCredito.TabIndex = 1;
            btnTarjetaCredito.Text = "Tarjeta de Credito";
            btnTarjetaCredito.UseVisualStyleBackColor = true;
            btnTarjetaCredito.Click += btnTarjetaCredito_Click_1;
            // 
            // btnQr
            // 
            btnQr.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnQr.Location = new Point(564, 159);
            btnQr.Name = "btnQr";
            btnQr.Size = new Size(187, 77);
            btnQr.TabIndex = 2;
            btnQr.Text = "Codigo QR";
            btnQr.UseVisualStyleBackColor = true;
            btnQr.Click += btnQr_Click_1;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(61, 37);
            label1.Name = "label1";
            label1.Size = new Size(605, 42);
            label1.TabIndex = 3;
            label1.Text = "Escoja el metodo de pago que quiera usar:";
            label1.Click += label1_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Imagen_de_WhatsApp_2024_12_05_a_las_18_13_19_8c457d6a;
            ClientSize = new Size(800, 314);
            Controls.Add(label1);
            Controls.Add(btnQr);
            Controls.Add(btnTarjetaCredito);
            Controls.Add(btnEfectivo);
            Name = "Form4";
            Text = "Form4";
            ResumeLayout(false);
        }

        #endregion

        private Button btnEfectivo;
        private Button btnTarjetaCredito;
        private Button btnQr;
        private Label label1;
    }
}