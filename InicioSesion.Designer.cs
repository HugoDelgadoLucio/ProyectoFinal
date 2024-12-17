namespace ProyectoFinal
{
    partial class InicioSesion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InicioSesion));
            ButtonPause = new Button();
            IdUsuarioBox = new PictureBox();
            pictureBox2 = new PictureBox();
            ContraseñaBox = new PictureBox();
            TboxContra = new TextBox();
            ButtonReanudar = new Button();
            BotonIngresar = new Button();
            TboxUser = new TextBox();
            label3 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)IdUsuarioBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ContraseñaBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // ButtonPause
            // 
            ButtonPause.BackColor = Color.Transparent;
            ButtonPause.BackgroundImage = Properties.Resources.pausar;
            ButtonPause.BackgroundImageLayout = ImageLayout.Zoom;
            ButtonPause.FlatAppearance.BorderSize = 0;
            ButtonPause.FlatAppearance.MouseDownBackColor = Color.Transparent;
            ButtonPause.FlatAppearance.MouseOverBackColor = Color.Transparent;
            ButtonPause.FlatStyle = FlatStyle.Flat;
            ButtonPause.Location = new Point(4, 676);
            ButtonPause.Margin = new Padding(2);
            ButtonPause.Name = "ButtonPause";
            ButtonPause.Size = new Size(245, 82);
            ButtonPause.TabIndex = 0;
            ButtonPause.UseVisualStyleBackColor = false;
            ButtonPause.Click += ButtonPause_Click;
            // 
            // IdUsuarioBox
            // 
            IdUsuarioBox.BackColor = Color.Transparent;
            IdUsuarioBox.Image = Properties.Resources.Id_usuario;
            IdUsuarioBox.Location = new Point(97, 210);
            IdUsuarioBox.Margin = new Padding(2);
            IdUsuarioBox.Name = "IdUsuarioBox";
            IdUsuarioBox.Size = new Size(387, 108);
            IdUsuarioBox.SizeMode = PictureBoxSizeMode.Zoom;
            IdUsuarioBox.TabIndex = 3;
            IdUsuarioBox.TabStop = false;
            IdUsuarioBox.Click += IdUsuarioBox_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.chica;
            pictureBox2.Location = new Point(809, 11);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(550, 724);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // ContraseñaBox
            // 
            ContraseñaBox.BackColor = Color.Transparent;
            ContraseñaBox.Image = Properties.Resources.Contraseña;
            ContraseñaBox.Location = new Point(25, 305);
            ContraseñaBox.Margin = new Padding(2);
            ContraseñaBox.Name = "ContraseñaBox";
            ContraseñaBox.Size = new Size(459, 110);
            ContraseñaBox.SizeMode = PictureBoxSizeMode.Zoom;
            ContraseñaBox.TabIndex = 5;
            ContraseñaBox.TabStop = false;
            // 
            // TboxContra
            // 
            TboxContra.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold | FontStyle.Italic);
            TboxContra.Location = new Point(445, 322);
            TboxContra.Margin = new Padding(2);
            TboxContra.Multiline = true;
            TboxContra.Name = "TboxContra";
            TboxContra.PasswordChar = '#';
            TboxContra.Size = new Size(321, 35);
            TboxContra.TabIndex = 7;
            TboxContra.TextAlign = HorizontalAlignment.Center;
            // 
            // ButtonReanudar
            // 
            ButtonReanudar.BackColor = Color.Transparent;
            ButtonReanudar.BackgroundImage = Properties.Resources.reanudar;
            ButtonReanudar.BackgroundImageLayout = ImageLayout.Zoom;
            ButtonReanudar.FlatAppearance.BorderSize = 0;
            ButtonReanudar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            ButtonReanudar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            ButtonReanudar.FlatStyle = FlatStyle.Flat;
            ButtonReanudar.Location = new Point(293, 676);
            ButtonReanudar.Margin = new Padding(2);
            ButtonReanudar.Name = "ButtonReanudar";
            ButtonReanudar.Size = new Size(249, 82);
            ButtonReanudar.TabIndex = 8;
            ButtonReanudar.UseVisualStyleBackColor = false;
            ButtonReanudar.Click += ButtonReanudar_Click;
            // 
            // BotonIngresar
            // 
            BotonIngresar.BackColor = Color.Transparent;
            BotonIngresar.BackgroundImage = Properties.Resources.ingresar;
            BotonIngresar.BackgroundImageLayout = ImageLayout.Zoom;
            BotonIngresar.FlatAppearance.BorderSize = 0;
            BotonIngresar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            BotonIngresar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            BotonIngresar.FlatStyle = FlatStyle.Flat;
            BotonIngresar.Location = new Point(307, 433);
            BotonIngresar.Margin = new Padding(2);
            BotonIngresar.Name = "BotonIngresar";
            BotonIngresar.Size = new Size(295, 85);
            BotonIngresar.TabIndex = 9;
            BotonIngresar.UseVisualStyleBackColor = false;
            BotonIngresar.Click += BotonIngresar_Click;
            // 
            // TboxUser
            // 
            TboxUser.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold | FontStyle.Italic);
            TboxUser.Location = new Point(445, 229);
            TboxUser.Margin = new Padding(2);
            TboxUser.Multiline = true;
            TboxUser.Name = "TboxUser";
            TboxUser.Size = new Size(321, 35);
            TboxUser.TabIndex = 10;
            TboxUser.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Mexicana", 24F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Brown;
            label3.Location = new Point(253, 66);
            label3.Name = "label3";
            label3.Size = new Size(343, 27);
            label3.TabIndex = 38;
            label3.Text = "De mexico a tu plato ";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("El Rio Lobo", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkGreen;
            label2.Location = new Point(228, 11);
            label2.Name = "label2";
            label2.Size = new Size(955, 62);
            label2.TabIndex = 37;
            label2.Text = "Comida Mexicana Doña Dominga";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 66);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(134, 125);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 36;
            pictureBox1.TabStop = false;
            // 
            // InicioSesion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fondopruebaopaca2;
            ClientSize = new Size(1370, 749);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(TboxUser);
            Controls.Add(BotonIngresar);
            Controls.Add(ButtonReanudar);
            Controls.Add(TboxContra);
            Controls.Add(ContraseñaBox);
            Controls.Add(pictureBox2);
            Controls.Add(IdUsuarioBox);
            Controls.Add(ButtonPause);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "InicioSesion";
            Text = "Inicia sesion!";
            WindowState = FormWindowState.Maximized;
            Load += InicioSesion_Load;
            ((System.ComponentModel.ISupportInitialize)IdUsuarioBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)ContraseñaBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ButtonPause;
        private PictureBox IdUsuarioBox;
        private PictureBox pictureBox2;
        private PictureBox ContraseñaBox;
        private TextBox TboxContra;
        private Button ButtonReanudar;
        private Button BotonIngresar;
        private TextBox TboxUser;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox1;
    }
}