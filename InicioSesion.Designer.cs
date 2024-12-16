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
            ((System.ComponentModel.ISupportInitialize)IdUsuarioBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ContraseñaBox).BeginInit();
            SuspendLayout();
            // 
            // ButtonPause
            // 
            ButtonPause.BackColor = Color.Transparent;
            ButtonPause.BackgroundImageLayout = ImageLayout.Zoom;
            ButtonPause.FlatAppearance.BorderSize = 0;
            ButtonPause.FlatAppearance.MouseDownBackColor = Color.Transparent;
            ButtonPause.FlatAppearance.MouseOverBackColor = Color.Transparent;
            ButtonPause.FlatStyle = FlatStyle.Flat;
            ButtonPause.Image = Properties.Resources.pausar;
            ButtonPause.Location = new Point(12, 932);
            ButtonPause.Name = "ButtonPause";
            ButtonPause.Size = new Size(251, 80);
            ButtonPause.TabIndex = 0;
            ButtonPause.UseVisualStyleBackColor = false;
            ButtonPause.Click += ButtonPause_Click;
            // 
            // IdUsuarioBox
            // 
            IdUsuarioBox.BackColor = Color.Transparent;
            IdUsuarioBox.Image = Properties.Resources.Id_usuario;
            IdUsuarioBox.Location = new Point(114, 308);
            IdUsuarioBox.Name = "IdUsuarioBox";
            IdUsuarioBox.Size = new Size(387, 108);
            IdUsuarioBox.SizeMode = PictureBoxSizeMode.AutoSize;
            IdUsuarioBox.TabIndex = 3;
            IdUsuarioBox.TabStop = false;
            IdUsuarioBox.Click += IdUsuarioBox_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.chica;
            pictureBox2.Location = new Point(1002, 85);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(817, 867);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // ContraseñaBox
            // 
            ContraseñaBox.BackColor = Color.Transparent;
            ContraseñaBox.Image = Properties.Resources.Contraseña;
            ContraseñaBox.Location = new Point(42, 434);
            ContraseñaBox.Name = "ContraseñaBox";
            ContraseñaBox.Size = new Size(459, 110);
            ContraseñaBox.SizeMode = PictureBoxSizeMode.AutoSize;
            ContraseñaBox.TabIndex = 5;
            ContraseñaBox.TabStop = false;
            // 
            // TboxContra
            // 
            TboxContra.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold | FontStyle.Italic);
            TboxContra.Location = new Point(473, 444);
            TboxContra.Multiline = true;
            TboxContra.Name = "TboxContra";
            TboxContra.PasswordChar = '#';
            TboxContra.Size = new Size(457, 55);
            TboxContra.TabIndex = 7;
            TboxContra.TextAlign = HorizontalAlignment.Center;
            // 
            // ButtonReanudar
            // 
            ButtonReanudar.BackColor = Color.Transparent;
            ButtonReanudar.BackgroundImageLayout = ImageLayout.Zoom;
            ButtonReanudar.FlatAppearance.BorderSize = 0;
            ButtonReanudar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            ButtonReanudar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            ButtonReanudar.FlatStyle = FlatStyle.Flat;
            ButtonReanudar.Image = (Image)resources.GetObject("ButtonReanudar.Image");
            ButtonReanudar.Location = new Point(288, 932);
            ButtonReanudar.Name = "ButtonReanudar";
            ButtonReanudar.Size = new Size(249, 80);
            ButtonReanudar.TabIndex = 8;
            ButtonReanudar.UseVisualStyleBackColor = false;
            ButtonReanudar.Click += ButtonReanudar_Click;
            // 
            // BotonIngresar
            // 
            BotonIngresar.BackColor = Color.Transparent;
            BotonIngresar.BackgroundImageLayout = ImageLayout.Zoom;
            BotonIngresar.FlatAppearance.BorderSize = 0;
            BotonIngresar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            BotonIngresar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            BotonIngresar.FlatStyle = FlatStyle.Flat;
            BotonIngresar.Image = (Image)resources.GetObject("BotonIngresar.Image");
            BotonIngresar.Location = new Point(389, 628);
            BotonIngresar.Name = "BotonIngresar";
            BotonIngresar.Size = new Size(421, 141);
            BotonIngresar.TabIndex = 9;
            BotonIngresar.UseVisualStyleBackColor = false;
            BotonIngresar.Click += BotonIngresar_Click;
            // 
            // TboxUser
            // 
            TboxUser.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold | FontStyle.Italic);
            TboxUser.Location = new Point(473, 318);
            TboxUser.Multiline = true;
            TboxUser.Name = "TboxUser";
            TboxUser.Size = new Size(457, 55);
            TboxUser.TabIndex = 10;
            TboxUser.TextAlign = HorizontalAlignment.Center;
            // 
            // InicioSesion
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.WhatsApp_Image_2024_12_11_at_12_34_00_PM;
            ClientSize = new Size(1898, 1024);
            Controls.Add(TboxUser);
            Controls.Add(BotonIngresar);
            Controls.Add(ButtonReanudar);
            Controls.Add(TboxContra);
            Controls.Add(ContraseñaBox);
            Controls.Add(pictureBox2);
            Controls.Add(IdUsuarioBox);
            Controls.Add(ButtonPause);
            Name = "InicioSesion";
            Text = "Inicia sesion!";
            WindowState = FormWindowState.Maximized;
            Load += InicioSesion_Load;
            ((System.ComponentModel.ISupportInitialize)IdUsuarioBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)ContraseñaBox).EndInit();
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
    }
}