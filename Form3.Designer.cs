namespace ProyectoFinal
{
    partial class Form3
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
            labelQr = new Label();
            labelATM = new Label();
            labelEfectivo = new Label();
            labelATM1 = new Label();
            labelQr1 = new Label();
            buttonRtrn = new Button();
            pictureBoxQr = new PictureBox();
            textBoxATMNom = new TextBox();
            textBoxATMNip = new TextBox();
            comboBoxATMMonth = new ComboBox();
            comboBoxATMYear = new ComboBox();
            pictureBoxATMBanks = new PictureBox();
            btnATMPaga = new Button();
            labelATM2 = new Label();
            labelATM3 = new Label();
            labelATM4 = new Label();
            labelATM5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxQr).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxATMBanks).BeginInit();
            SuspendLayout();
            // 
            // labelQr
            // 
            labelQr.AutoSize = true;
            labelQr.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelQr.Location = new Point(3, 9);
            labelQr.Name = "labelQr";
            labelQr.Size = new Size(798, 32);
            labelQr.TabIndex = 0;
            labelQr.Text = "Escanea el siguiente codigo para proceder con el pago de la comida:\r\n";
            // 
            // labelATM
            // 
            labelATM.AutoSize = true;
            labelATM.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelATM.Location = new Point(3, 9);
            labelATM.Name = "labelATM";
            labelATM.Size = new Size(666, 64);
            labelATM.TabIndex = 1;
            labelATM.Text = "Favor de Ingresar la informacion de su tarjeta de credito:\r\n\r\n";
            labelATM.Click += label2_Click;
            // 
            // labelEfectivo
            // 
            labelEfectivo.AutoSize = true;
            labelEfectivo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelEfectivo.Location = new Point(67, 133);
            labelEfectivo.Name = "labelEfectivo";
            labelEfectivo.Size = new Size(661, 180);
            labelEfectivo.TabIndex = 2;
            labelEfectivo.Text = "Se le notificara al repartidor de su decicsion y traera cambio \r\nacorde con el precio del pedido.\r\n\r\nPresione el botn regresar para acabar con la compra del producto.\r\n\r\n\r\n";
            // 
            // labelATM1
            // 
            labelATM1.AutoSize = true;
            labelATM1.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelATM1.Location = new Point(3, 387);
            labelATM1.Name = "labelATM1";
            labelATM1.Size = new Size(592, 60);
            labelATM1.TabIndex = 3;
            labelATM1.Text = "Al acabar la transaccion presione el boton para regresar:\r\n\r\n";
            // 
            // labelQr1
            // 
            labelQr1.AutoSize = true;
            labelQr1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelQr1.Location = new Point(3, 388);
            labelQr1.Name = "labelQr1";
            labelQr1.Size = new Size(686, 50);
            labelQr1.TabIndex = 4;
            labelQr1.Text = "Al acabar de escanear el codigo presione el siguiente botno para continuar: \r\n\r\n";
            // 
            // buttonRtrn
            // 
            buttonRtrn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonRtrn.Location = new Point(689, 363);
            buttonRtrn.Name = "buttonRtrn";
            buttonRtrn.Size = new Size(105, 75);
            buttonRtrn.TabIndex = 5;
            buttonRtrn.Text = "Regresar";
            buttonRtrn.UseVisualStyleBackColor = true;
            buttonRtrn.Click += buttonRtrn_Click;
            // 
            // pictureBoxQr
            // 
            pictureBoxQr.Location = new Point(231, 60);
            pictureBoxQr.Name = "pictureBoxQr";
            pictureBoxQr.Size = new Size(316, 311);
            pictureBoxQr.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxQr.TabIndex = 6;
            pictureBoxQr.TabStop = false;
            // 
            // textBoxATMNom
            // 
            textBoxATMNom.Location = new Point(154, 96);
            textBoxATMNom.Name = "textBoxATMNom";
            textBoxATMNom.PlaceholderText = "0000-0000-0000-0000";
            textBoxATMNom.Size = new Size(293, 23);
            textBoxATMNom.TabIndex = 7;
            // 
            // textBoxATMNip
            // 
            textBoxATMNip.Location = new Point(154, 151);
            textBoxATMNip.Name = "textBoxATMNip";
            textBoxATMNip.PlaceholderText = "0000";
            textBoxATMNip.Size = new Size(112, 23);
            textBoxATMNip.TabIndex = 8;
            // 
            // comboBoxATMMonth
            // 
            comboBoxATMMonth.FormattingEnabled = true;
            comboBoxATMMonth.Items.AddRange(new object[] { "00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12" });
            comboBoxATMMonth.Location = new Point(154, 212);
            comboBoxATMMonth.Name = "comboBoxATMMonth";
            comboBoxATMMonth.Size = new Size(121, 23);
            comboBoxATMMonth.TabIndex = 9;
            // 
            // comboBoxATMYear
            // 
            comboBoxATMYear.FormattingEnabled = true;
            comboBoxATMYear.Items.AddRange(new object[] { "0000", "2024", "2025", "2026", "2027", "2028" });
            comboBoxATMYear.Location = new Point(154, 264);
            comboBoxATMYear.Name = "comboBoxATMYear";
            comboBoxATMYear.Size = new Size(121, 23);
            comboBoxATMYear.TabIndex = 10;
            // 
            // pictureBoxATMBanks
            // 
            pictureBoxATMBanks.Location = new Point(396, 133);
            pictureBoxATMBanks.Name = "pictureBoxATMBanks";
            pictureBoxATMBanks.Size = new Size(366, 50);
            pictureBoxATMBanks.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxATMBanks.TabIndex = 11;
            pictureBoxATMBanks.TabStop = false;
            // 
            // btnATMPaga
            // 
            btnATMPaga.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnATMPaga.Location = new Point(375, 231);
            btnATMPaga.Name = "btnATMPaga";
            btnATMPaga.Size = new Size(387, 56);
            btnATMPaga.TabIndex = 12;
            btnATMPaga.Text = "Pagar";
            btnATMPaga.UseVisualStyleBackColor = true;
            btnATMPaga.Click += btnATMPaga_Click_1;
            // 
            // labelATM2
            // 
            labelATM2.BackColor = SystemColors.AppWorkspace;
            labelATM2.BorderStyle = BorderStyle.FixedSingle;
            labelATM2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelATM2.Location = new Point(48, 73);
            labelATM2.Name = "labelATM2";
            labelATM2.Size = new Size(100, 46);
            labelATM2.TabIndex = 13;
            labelATM2.Text = "Numero de tarjeta";
            // 
            // labelATM3
            // 
            labelATM3.BackColor = SystemColors.AppWorkspace;
            labelATM3.BorderStyle = BorderStyle.FixedSingle;
            labelATM3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelATM3.Location = new Point(48, 146);
            labelATM3.Name = "labelATM3";
            labelATM3.Size = new Size(100, 28);
            labelATM3.TabIndex = 14;
            labelATM3.Text = "NIP";
            // 
            // labelATM4
            // 
            labelATM4.BackColor = SystemColors.AppWorkspace;
            labelATM4.BorderStyle = BorderStyle.FixedSingle;
            labelATM4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelATM4.Location = new Point(48, 207);
            labelATM4.Name = "labelATM4";
            labelATM4.Size = new Size(100, 28);
            labelATM4.TabIndex = 15;
            labelATM4.Text = "Mes";
            // 
            // labelATM5
            // 
            labelATM5.BackColor = SystemColors.AppWorkspace;
            labelATM5.BorderStyle = BorderStyle.FixedSingle;
            labelATM5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelATM5.Location = new Point(48, 264);
            labelATM5.Name = "labelATM5";
            labelATM5.Size = new Size(100, 28);
            labelATM5.TabIndex = 16;
            labelATM5.Text = "Ano";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Imagen_de_WhatsApp_2024_12_05_a_las_18_13_19_8c457d6a;
            ClientSize = new Size(800, 450);
            Controls.Add(labelATM5);
            Controls.Add(labelATM4);
            Controls.Add(labelATM3);
            Controls.Add(labelATM2);
            Controls.Add(btnATMPaga);
            Controls.Add(pictureBoxATMBanks);
            Controls.Add(comboBoxATMYear);
            Controls.Add(comboBoxATMMonth);
            Controls.Add(textBoxATMNip);
            Controls.Add(textBoxATMNom);
            Controls.Add(buttonRtrn);
            Controls.Add(labelQr1);
            Controls.Add(labelATM1);
            Controls.Add(labelEfectivo);
            Controls.Add(labelATM);
            Controls.Add(labelQr);
            Controls.Add(pictureBoxQr);
            Name = "Form3";
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)pictureBoxQr).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxATMBanks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelQr;
        private Label labelATM;
        private Label labelEfectivo;
        private Label labelATM1;
        private Label labelQr1;
        private Button buttonRtrn;
        private PictureBox pictureBoxQr;
        private TextBox textBoxATMNom;
        private TextBox textBoxATMNip;
        private ComboBox comboBoxATMMonth;
        private ComboBox comboBoxATMYear;
        private PictureBox pictureBoxATMBanks;
        private Button btnATMPaga;
        private Label labelATM2;
        private Label labelATM3;
        private Label labelATM4;
        private Label labelATM5;
    }
}