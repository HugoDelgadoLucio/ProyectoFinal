namespace ProyectoFinal
{
    partial class FormVentasTotales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVentasTotales));
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            labelUsuario = new Label();
            buttonLogout = new Button();
            labelSalir = new Label();
            groupBoxVentas = new GroupBox();
            buttonActualizar = new Button();
            textBoxVentas = new TextBox();
            labelVentas = new Label();
            label3 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBoxVentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(groupBoxVentas);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(940, 450);
            panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.PeachPuff;
            groupBox1.Controls.Add(labelUsuario);
            groupBox1.Controls.Add(buttonLogout);
            groupBox1.Controls.Add(labelSalir);
            groupBox1.Font = new Font("MV Boli", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(612, 81);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(302, 121);
            groupBox1.TabIndex = 37;
            groupBox1.TabStop = false;
            groupBox1.Text = "Usuario";
            // 
            // labelUsuario
            // 
            labelUsuario.AutoSize = true;
            labelUsuario.Font = new Font("MV Boli", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelUsuario.Location = new Point(16, 36);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.Size = new Size(66, 17);
            labelUsuario.TabIndex = 26;
            labelUsuario.Text = "Nombre: ";
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
            buttonLogout.Location = new Point(239, 53);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(57, 43);
            buttonLogout.TabIndex = 27;
            buttonLogout.UseVisualStyleBackColor = true;
            buttonLogout.Click += buttonLogout_Click;
            // 
            // labelSalir
            // 
            labelSalir.AutoSize = true;
            labelSalir.Font = new Font("MV Boli", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelSalir.Location = new Point(208, 101);
            labelSalir.Name = "labelSalir";
            labelSalir.Size = new Size(88, 17);
            labelSalir.TabIndex = 28;
            labelSalir.Text = "Cerrar Sesion";
            // 
            // groupBoxVentas
            // 
            groupBoxVentas.BackColor = Color.Tan;
            groupBoxVentas.Controls.Add(buttonActualizar);
            groupBoxVentas.Controls.Add(textBoxVentas);
            groupBoxVentas.Controls.Add(labelVentas);
            groupBoxVentas.Font = new Font("MV Boli", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBoxVentas.Location = new Point(218, 157);
            groupBoxVentas.Name = "groupBoxVentas";
            groupBoxVentas.Size = new Size(388, 246);
            groupBoxVentas.TabIndex = 36;
            groupBoxVentas.TabStop = false;
            groupBoxVentas.Text = "VentasTotales";
            // 
            // buttonActualizar
            // 
            buttonActualizar.BackColor = Color.Transparent;
            buttonActualizar.BackgroundImage = (Image)resources.GetObject("buttonActualizar.BackgroundImage");
            buttonActualizar.BackgroundImageLayout = ImageLayout.Zoom;
            buttonActualizar.FlatAppearance.BorderSize = 0;
            buttonActualizar.FlatStyle = FlatStyle.Flat;
            buttonActualizar.Location = new Point(98, 144);
            buttonActualizar.Name = "buttonActualizar";
            buttonActualizar.Size = new Size(204, 62);
            buttonActualizar.TabIndex = 22;
            buttonActualizar.UseVisualStyleBackColor = false;
            buttonActualizar.Click += buttonActualizar_Click;
            // 
            // textBoxVentas
            // 
            textBoxVentas.Location = new Point(194, 78);
            textBoxVentas.Name = "textBoxVentas";
            textBoxVentas.Size = new Size(157, 33);
            textBoxVentas.TabIndex = 21;
            // 
            // labelVentas
            // 
            labelVentas.AutoSize = true;
            labelVentas.Font = new Font("MV Boli", 12F);
            labelVentas.Location = new Point(51, 81);
            labelVentas.Name = "labelVentas";
            labelVentas.Size = new Size(127, 21);
            labelVentas.TabIndex = 20;
            labelVentas.Text = "Ventas Totales:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Mexicana", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Brown;
            label3.Location = new Point(184, 60);
            label3.Name = "label3";
            label3.Size = new Size(224, 18);
            label3.TabIndex = 35;
            label3.Text = "De mexico a tu plato ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("El Rio Lobo", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkGreen;
            label2.Location = new Point(184, 24);
            label2.Name = "label2";
            label2.Size = new Size(553, 36);
            label2.TabIndex = 34;
            label2.Text = "Comida Mexicana Doña Dominga";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.Taco_mascot;
            pictureBox1.Location = new Point(45, 81);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(92, 95);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 33;
            pictureBox1.TabStop = false;
            // 
            // FormVentasTotales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(940, 450);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormVentasTotales";
            Text = "FormVentasTotales";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBoxVentas.ResumeLayout(false);
            groupBoxVentas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private GroupBox groupBoxVentas;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox1;
        private Button buttonActualizar;
        private TextBox textBoxVentas;
        private Label labelVentas;
        private GroupBox groupBox1;
        private Label labelUsuario;
        private Button buttonLogout;
        private Label labelSalir;
    }
}