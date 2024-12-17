namespace ProyectoFinal
{
    partial class FormListaComidas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListaComidas));
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            labelUsuario = new Label();
            buttonLogout = new Button();
            labelSalir = new Label();
            groupBoxListaComidas = new GroupBox();
            buttonActualizar = new Button();
            richTextBoxComidas = new RichTextBox();
            label3 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBoxListaComidas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(groupBoxListaComidas);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(995, 530);
            panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.PeachPuff;
            groupBox1.Controls.Add(labelUsuario);
            groupBox1.Controls.Add(buttonLogout);
            groupBox1.Controls.Add(labelSalir);
            groupBox1.Font = new Font("MV Boli", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(681, 60);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(302, 121);
            groupBox1.TabIndex = 34;
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
            // groupBoxListaComidas
            // 
            groupBoxListaComidas.BackColor = Color.Tan;
            groupBoxListaComidas.Controls.Add(buttonActualizar);
            groupBoxListaComidas.Controls.Add(richTextBoxComidas);
            groupBoxListaComidas.Font = new Font("MV Boli", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBoxListaComidas.Location = new Point(177, 102);
            groupBoxListaComidas.Name = "groupBoxListaComidas";
            groupBoxListaComidas.Size = new Size(485, 380);
            groupBoxListaComidas.TabIndex = 33;
            groupBoxListaComidas.TabStop = false;
            groupBoxListaComidas.Text = "Lista de Comidas";
            groupBoxListaComidas.Enter += groupBox1_Enter;
            // 
            // buttonActualizar
            // 
            buttonActualizar.BackgroundImage = (Image)resources.GetObject("buttonActualizar.BackgroundImage");
            buttonActualizar.BackgroundImageLayout = ImageLayout.Zoom;
            buttonActualizar.Cursor = Cursors.Hand;
            buttonActualizar.FlatAppearance.BorderSize = 0;
            buttonActualizar.FlatStyle = FlatStyle.Flat;
            buttonActualizar.Location = new Point(135, 303);
            buttonActualizar.Name = "buttonActualizar";
            buttonActualizar.Size = new Size(213, 71);
            buttonActualizar.TabIndex = 19;
            buttonActualizar.UseVisualStyleBackColor = true;
            buttonActualizar.Click += buttonActualizar_Click;
            // 
            // richTextBoxComidas
            // 
            richTextBoxComidas.Font = new Font("MV Boli", 12F);
            richTextBoxComidas.Location = new Point(18, 42);
            richTextBoxComidas.Name = "richTextBoxComidas";
            richTextBoxComidas.Size = new Size(449, 252);
            richTextBoxComidas.TabIndex = 18;
            richTextBoxComidas.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Mexicana", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Brown;
            label3.Location = new Point(159, 60);
            label3.Name = "label3";
            label3.Size = new Size(224, 18);
            label3.TabIndex = 32;
            label3.Text = "De mexico a tu plato ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("El Rio Lobo", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkGreen;
            label2.Location = new Point(159, 15);
            label2.Name = "label2";
            label2.Size = new Size(553, 36);
            label2.TabIndex = 31;
            label2.Text = "Comida Mexicana Doña Dominga";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(43, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(92, 95);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 30;
            pictureBox1.TabStop = false;
            // 
            // FormListaComidas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(995, 530);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FormListaComidas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormListaComidas";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBoxListaComidas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox1;
        private GroupBox groupBoxListaComidas;
        private Button buttonActualizar;
        private RichTextBox richTextBoxComidas;
        private GroupBox groupBox1;
        private Label labelUsuario;
        private Button buttonLogout;
        private Label labelSalir;
    }
}