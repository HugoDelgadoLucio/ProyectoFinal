namespace PARTE_PROC
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            ContraseñaBox = new PictureBox();
            UsuarioBox = new PictureBox();
            BotonIngresar = new Button();
            TboxContra = new TextBox();
            TboxUser = new TextBox();
            pictureBox1 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            ButtonPause = new Button();
            ButtonReanudar = new Button();
            ((System.ComponentModel.ISupportInitialize)ContraseñaBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UsuarioBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // ContraseñaBox
            // 
            ContraseñaBox.BackColor = Color.Transparent;
            ContraseñaBox.Image = (Image)resources.GetObject("ContraseñaBox.Image");
            ContraseñaBox.Location = new Point(123, 422);
            ContraseñaBox.Name = "ContraseñaBox";
            ContraseñaBox.Size = new Size(442, 75);
            ContraseñaBox.TabIndex = 0;
            ContraseñaBox.TabStop = false;
            // 
            // UsuarioBox
            // 
            UsuarioBox.BackColor = Color.Transparent;
            UsuarioBox.Image = (Image)resources.GetObject("UsuarioBox.Image");
            UsuarioBox.Location = new Point(192, 273);
            UsuarioBox.Name = "UsuarioBox";
            UsuarioBox.Size = new Size(384, 75);
            UsuarioBox.TabIndex = 1;
            UsuarioBox.TabStop = false;
            // 
            // BotonIngresar
            // 
            BotonIngresar.BackColor = Color.Transparent;
            BotonIngresar.BackgroundImageLayout = ImageLayout.Zoom;
            BotonIngresar.FlatAppearance.BorderSize = 0;
            BotonIngresar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            BotonIngresar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            BotonIngresar.FlatStyle = FlatStyle.Flat;
            BotonIngresar.Image = Properties.Resources.ingresar;
            BotonIngresar.ImageAlign = ContentAlignment.TopLeft;
            BotonIngresar.Location = new Point(466, 629);
            BotonIngresar.Name = "BotonIngresar";
            BotonIngresar.Size = new Size(373, 108);
            BotonIngresar.TabIndex = 2;
            BotonIngresar.UseVisualStyleBackColor = false;
            BotonIngresar.Click += BotonIngresar_Click;
            // 
            // TboxContra
            // 
            TboxContra.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            TboxContra.ForeColor = Color.Black;
            TboxContra.Location = new Point(552, 433);
            TboxContra.Multiline = true;
            TboxContra.Name = "TboxContra";
            TboxContra.PasswordChar = '#';
            TboxContra.Size = new Size(488, 53);
            TboxContra.TabIndex = 3;
            TboxContra.TextAlign = HorizontalAlignment.Center;
            TboxContra.TextChanged += TboxContra_TextChanged;
            // 
            // TboxUser
            // 
            TboxUser.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            TboxUser.ForeColor = Color.Black;
            TboxUser.Location = new Point(552, 286);
            TboxUser.Multiline = true;
            TboxUser.Name = "TboxUser";
            TboxUser.Size = new Size(488, 53);
            TboxUser.TabIndex = 4;
            TboxUser.TextAlign = HorizontalAlignment.Center;
            TboxUser.TextChanged += TboxUser_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1074, 56);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(817, 867);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // ButtonPause
            // 
            ButtonPause.BackColor = Color.Transparent;
            ButtonPause.BackgroundImageLayout = ImageLayout.Zoom;
            ButtonPause.FlatAppearance.BorderSize = 0;
            ButtonPause.FlatAppearance.MouseDownBackColor = Color.Transparent;
            ButtonPause.FlatAppearance.MouseOverBackColor = Color.Transparent;
            ButtonPause.FlatStyle = FlatStyle.Flat;
            ButtonPause.Image = (Image)resources.GetObject("ButtonPause.Image");
            ButtonPause.ImageAlign = ContentAlignment.TopLeft;
            ButtonPause.Location = new Point(-1, 924);
            ButtonPause.Name = "ButtonPause";
            ButtonPause.Size = new Size(261, 68);
            ButtonPause.TabIndex = 7;
            ButtonPause.UseVisualStyleBackColor = false;
            ButtonPause.Click += ButtonPause_Click;
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
            ButtonReanudar.ImageAlign = ContentAlignment.TopLeft;
            ButtonReanudar.Location = new Point(247, 924);
            ButtonReanudar.Name = "ButtonReanudar";
            ButtonReanudar.Size = new Size(261, 68);
            ButtonReanudar.TabIndex = 8;
            ButtonReanudar.UseVisualStyleBackColor = false;
            ButtonReanudar.Click += ButtonReanudar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.WhatsApp_Image_2024_12_11_at_12_34_00_PM;
            ClientSize = new Size(1898, 1024);
            Controls.Add(ButtonReanudar);
            Controls.Add(ButtonPause);
            Controls.Add(pictureBox1);
            Controls.Add(TboxUser);
            Controls.Add(TboxContra);
            Controls.Add(ContraseñaBox);
            Controls.Add(BotonIngresar);
            Controls.Add(UsuarioBox);
            Name = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)ContraseñaBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)UsuarioBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox ContraseñaBox;
        private PictureBox UsuarioBox;
        private Button BotonIngresar;
        private TextBox TboxContra;
        private TextBox TboxUser;
        private PictureBox pictureBox1;
        private ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private Button ButtonPause;
        private Button ButtonReanudar;
    }
}
