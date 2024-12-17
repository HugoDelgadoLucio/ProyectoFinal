namespace ProyectoFinal
{
    partial class AltaComida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AltaComida));
            groupBoxAlta = new GroupBox();
            buttonDarAlta = new Button();
            textBoxAltaImagen = new TextBox();
            textBoxAltaExistencias = new TextBox();
            textBoxAltaPrecio = new TextBox();
            textBoxAltaDescripcion = new TextBox();
            textBoxAltaId = new TextBox();
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            labelUsuario = new Label();
            buttonLogout = new Button();
            labelSalir = new Label();
            label3 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            groupBoxAlta.SuspendLayout();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBoxAlta
            // 
            groupBoxAlta.BackColor = Color.Tan;
            groupBoxAlta.Controls.Add(buttonDarAlta);
            groupBoxAlta.Controls.Add(textBoxAltaImagen);
            groupBoxAlta.Controls.Add(textBoxAltaExistencias);
            groupBoxAlta.Controls.Add(textBoxAltaPrecio);
            groupBoxAlta.Controls.Add(textBoxAltaDescripcion);
            groupBoxAlta.Controls.Add(textBoxAltaId);
            groupBoxAlta.Font = new Font("MV Boli", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBoxAlta.Location = new Point(226, 94);
            groupBoxAlta.Name = "groupBoxAlta";
            groupBoxAlta.Size = new Size(266, 405);
            groupBoxAlta.TabIndex = 0;
            groupBoxAlta.TabStop = false;
            groupBoxAlta.Text = "Alta";
            // 
            // buttonDarAlta
            // 
            buttonDarAlta.BackColor = Color.Transparent;
            buttonDarAlta.BackgroundImage = (Image)resources.GetObject("buttonDarAlta.BackgroundImage");
            buttonDarAlta.BackgroundImageLayout = ImageLayout.Zoom;
            buttonDarAlta.FlatAppearance.BorderSize = 0;
            buttonDarAlta.FlatStyle = FlatStyle.Flat;
            buttonDarAlta.Location = new Point(23, 281);
            buttonDarAlta.Name = "buttonDarAlta";
            buttonDarAlta.Size = new Size(213, 65);
            buttonDarAlta.TabIndex = 5;
            buttonDarAlta.UseVisualStyleBackColor = false;
            buttonDarAlta.Click += buttonDarAlta_Click_1;
            // 
            // textBoxAltaImagen
            // 
            textBoxAltaImagen.Location = new Point(37, 217);
            textBoxAltaImagen.Name = "textBoxAltaImagen";
            textBoxAltaImagen.PlaceholderText = "Imagen";
            textBoxAltaImagen.Size = new Size(199, 33);
            textBoxAltaImagen.TabIndex = 4;
            // 
            // textBoxAltaExistencias
            // 
            textBoxAltaExistencias.Location = new Point(37, 171);
            textBoxAltaExistencias.Name = "textBoxAltaExistencias";
            textBoxAltaExistencias.PlaceholderText = "Existencias";
            textBoxAltaExistencias.Size = new Size(199, 33);
            textBoxAltaExistencias.TabIndex = 3;
            // 
            // textBoxAltaPrecio
            // 
            textBoxAltaPrecio.Location = new Point(37, 124);
            textBoxAltaPrecio.Name = "textBoxAltaPrecio";
            textBoxAltaPrecio.PlaceholderText = "Precio";
            textBoxAltaPrecio.Size = new Size(199, 33);
            textBoxAltaPrecio.TabIndex = 2;
            // 
            // textBoxAltaDescripcion
            // 
            textBoxAltaDescripcion.Location = new Point(37, 76);
            textBoxAltaDescripcion.Name = "textBoxAltaDescripcion";
            textBoxAltaDescripcion.PlaceholderText = "Descripcion";
            textBoxAltaDescripcion.Size = new Size(199, 33);
            textBoxAltaDescripcion.TabIndex = 1;
            // 
            // textBoxAltaId
            // 
            textBoxAltaId.Location = new Point(37, 33);
            textBoxAltaId.Name = "textBoxAltaId";
            textBoxAltaId.PlaceholderText = "id";
            textBoxAltaId.Size = new Size(199, 33);
            textBoxAltaId.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(groupBoxAlta);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(838, 540);
            panel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.PeachPuff;
            groupBox1.Controls.Add(labelUsuario);
            groupBox1.Controls.Add(buttonLogout);
            groupBox1.Controls.Add(labelSalir);
            groupBox1.Font = new Font("MV Boli", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(524, 66);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(311, 121);
            groupBox1.TabIndex = 31;
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
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Mexicana", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Brown;
            label3.Location = new Point(128, 54);
            label3.Name = "label3";
            label3.Size = new Size(224, 18);
            label3.TabIndex = 29;
            label3.Text = "De mexico a tu plato ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("El Rio Lobo", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkGreen;
            label2.Location = new Point(128, 9);
            label2.Name = "label2";
            label2.Size = new Size(553, 36);
            label2.TabIndex = 28;
            label2.Text = "Comida Mexicana Doña Dominga";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(92, 95);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 27;
            pictureBox1.TabStop = false;
            // 
            // AltaComida
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(838, 540);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AltaComida";
            Text = "AltaComida";
            Load += AltaComida_Load;
            groupBoxAlta.ResumeLayout(false);
            groupBoxAlta.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxAlta;
        private TextBox textBoxAltaId;
        private TextBox textBoxAltaImagen;
        private TextBox textBoxAltaExistencias;
        private TextBox textBoxAltaPrecio;
        private TextBox textBoxAltaDescripcion;
        private Panel panel1;
        private Button buttonDarAlta;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private Label labelUsuario;
        private Button buttonLogout;
        private Label labelSalir;
    }
}