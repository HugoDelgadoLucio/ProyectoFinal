namespace ProyectoFinal
{
    partial class FormAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmin));
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            labelUsuario = new Label();
            buttonLogout = new Button();
            labelSalir = new Label();
            label3 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            buttonMostrarChart = new Button();
            buttonVentasTotales = new Button();
            buttonVerComidas = new Button();
            buttonVerBaja = new Button();
            buttonMostrarAlta = new Button();
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            mySqlCommand2 = new MySql.Data.MySqlClient.MySqlCommand();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(buttonMostrarChart);
            panel1.Controls.Add(buttonVentasTotales);
            panel1.Controls.Add(buttonVerComidas);
            panel1.Controls.Add(buttonVerBaja);
            panel1.Controls.Add(buttonMostrarAlta);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1353, 749);
            panel1.TabIndex = 6;
            panel1.Paint += panel1_Paint;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.PeachPuff;
            groupBox1.Controls.Add(labelUsuario);
            groupBox1.Controls.Add(buttonLogout);
            groupBox1.Controls.Add(labelSalir);
            groupBox1.Font = new Font("MV Boli", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(1007, 92);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(346, 142);
            groupBox1.TabIndex = 30;
            groupBox1.TabStop = false;
            groupBox1.Text = "Usuario";
            // 
            // labelUsuario
            // 
            labelUsuario.AutoSize = true;
            labelUsuario.Font = new Font("MV Boli", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelUsuario.Location = new Point(16, 40);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.Size = new Size(66, 17);
            labelUsuario.TabIndex = 26;
            labelUsuario.Text = "Nombre: ";
            labelUsuario.Click += labelUsuario_Click;
            // 
            // buttonLogout
            // 
            buttonLogout.BackgroundImage = (Image)resources.GetObject("buttonLogout.BackgroundImage");
            buttonLogout.BackgroundImageLayout = ImageLayout.Zoom;
            buttonLogout.Cursor = Cursors.Hand;
            buttonLogout.FlatAppearance.BorderSize = 0;
            buttonLogout.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonLogout.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonLogout.FlatStyle = FlatStyle.Flat;
            buttonLogout.Location = new Point(239, 63);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(57, 54);
            buttonLogout.TabIndex = 27;
            buttonLogout.UseVisualStyleBackColor = true;
            buttonLogout.Click += buttonLogout_Click;
            // 
            // labelSalir
            // 
            labelSalir.AutoSize = true;
            labelSalir.Font = new Font("MV Boli", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelSalir.Location = new Point(208, 120);
            labelSalir.Name = "labelSalir";
            labelSalir.Size = new Size(88, 17);
            labelSalir.TabIndex = 28;
            labelSalir.Text = "Cerrar Sesion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Mexicana", 21.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Brown;
            label3.Location = new Point(185, 71);
            label3.Name = "label3";
            label3.Size = new Size(312, 25);
            label3.TabIndex = 25;
            label3.Text = "De mexico a tu plato ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("El Rio Lobo", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkGreen;
            label2.Location = new Point(170, 9);
            label2.Name = "label2";
            label2.Size = new Size(955, 62);
            label2.TabIndex = 24;
            label2.Text = "Comida Mexicana Doña Dominga";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(24, 102);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(141, 151);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.MistyRose;
            label1.Font = new Font("Mexicana", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(391, 144);
            label1.Name = "label1";
            label1.Size = new Size(518, 53);
            label1.TabIndex = 22;
            label1.Text = "ADMINISTRADOR";
            // 
            // buttonMostrarChart
            // 
            buttonMostrarChart.BackColor = Color.Transparent;
            buttonMostrarChart.BackgroundImage = (Image)resources.GetObject("buttonMostrarChart.BackgroundImage");
            buttonMostrarChart.BackgroundImageLayout = ImageLayout.Zoom;
            buttonMostrarChart.Cursor = Cursors.Hand;
            buttonMostrarChart.FlatAppearance.BorderSize = 0;
            buttonMostrarChart.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonMostrarChart.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonMostrarChart.FlatStyle = FlatStyle.Flat;
            buttonMostrarChart.Location = new Point(1040, 307);
            buttonMostrarChart.Name = "buttonMostrarChart";
            buttonMostrarChart.Size = new Size(310, 125);
            buttonMostrarChart.TabIndex = 21;
            buttonMostrarChart.UseVisualStyleBackColor = false;
            buttonMostrarChart.Click += buttonMostrarChart_Click;
            // 
            // buttonVentasTotales
            // 
            buttonVentasTotales.BackColor = Color.Transparent;
            buttonVentasTotales.BackgroundImage = (Image)resources.GetObject("buttonVentasTotales.BackgroundImage");
            buttonVentasTotales.BackgroundImageLayout = ImageLayout.Zoom;
            buttonVentasTotales.Cursor = Cursors.Hand;
            buttonVentasTotales.FlatAppearance.BorderSize = 0;
            buttonVentasTotales.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonVentasTotales.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonVentasTotales.FlatStyle = FlatStyle.Flat;
            buttonVentasTotales.Location = new Point(859, 509);
            buttonVentasTotales.Name = "buttonVentasTotales";
            buttonVentasTotales.Size = new Size(291, 141);
            buttonVentasTotales.TabIndex = 18;
            buttonVentasTotales.UseVisualStyleBackColor = false;
            buttonVentasTotales.Click += buttonVentasTotales_Click;
            // 
            // buttonVerComidas
            // 
            buttonVerComidas.BackColor = Color.Transparent;
            buttonVerComidas.BackgroundImage = (Image)resources.GetObject("buttonVerComidas.BackgroundImage");
            buttonVerComidas.BackgroundImageLayout = ImageLayout.Zoom;
            buttonVerComidas.Cursor = Cursors.Hand;
            buttonVerComidas.FlatAppearance.BorderSize = 0;
            buttonVerComidas.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonVerComidas.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonVerComidas.FlatStyle = FlatStyle.Flat;
            buttonVerComidas.Location = new Point(538, 322);
            buttonVerComidas.Name = "buttonVerComidas";
            buttonVerComidas.Size = new Size(315, 159);
            buttonVerComidas.TabIndex = 16;
            buttonVerComidas.UseVisualStyleBackColor = false;
            buttonVerComidas.Click += buttonVerComidas_Click;
            // 
            // buttonVerBaja
            // 
            buttonVerBaja.BackColor = Color.Transparent;
            buttonVerBaja.BackgroundImage = (Image)resources.GetObject("buttonVerBaja.BackgroundImage");
            buttonVerBaja.BackgroundImageLayout = ImageLayout.Zoom;
            buttonVerBaja.Cursor = Cursors.Hand;
            buttonVerBaja.FlatAppearance.BorderSize = 0;
            buttonVerBaja.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonVerBaja.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonVerBaja.FlatStyle = FlatStyle.Flat;
            buttonVerBaja.Location = new Point(290, 496);
            buttonVerBaja.Name = "buttonVerBaja";
            buttonVerBaja.Size = new Size(369, 172);
            buttonVerBaja.TabIndex = 14;
            buttonVerBaja.UseVisualStyleBackColor = false;
            buttonVerBaja.Click += buttonVerBaja_Click;
            // 
            // buttonMostrarAlta
            // 
            buttonMostrarAlta.BackColor = Color.Transparent;
            buttonMostrarAlta.BackgroundImage = (Image)resources.GetObject("buttonMostrarAlta.BackgroundImage");
            buttonMostrarAlta.BackgroundImageLayout = ImageLayout.Zoom;
            buttonMostrarAlta.Cursor = Cursors.Hand;
            buttonMostrarAlta.FlatAppearance.BorderSize = 0;
            buttonMostrarAlta.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonMostrarAlta.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonMostrarAlta.FlatStyle = FlatStyle.Flat;
            buttonMostrarAlta.ForeColor = SystemColors.WindowFrame;
            buttonMostrarAlta.Location = new Point(9, 239);
            buttonMostrarAlta.Name = "buttonMostrarAlta";
            buttonMostrarAlta.Size = new Size(351, 145);
            buttonMostrarAlta.TabIndex = 6;
            buttonMostrarAlta.UseVisualStyleBackColor = false;
            buttonMostrarAlta.Click += buttonMostrarAlta_Click;
            buttonMostrarAlta.MouseEnter += buttonMostrarAlta_MouseEnter;
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // mySqlCommand2
            // 
            mySqlCommand2.CacheAge = 0;
            mySqlCommand2.Connection = null;
            mySqlCommand2.EnableCaching = false;
            mySqlCommand2.Transaction = null;
            // 
            // FormAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1353, 749);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAdmin";
            Text = "FormAdmin";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button buttonMostrarAlta;
        private Button buttonVerBaja;
        private Button buttonVerComidas;
        private Button buttonVentasTotales;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand2;
        private Button buttonMostrarChart;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private Label labelUsuario;
        private Button buttonLogout;
        private Label labelSalir;
        private GroupBox groupBox1;
    }
}