namespace ProyectoFinal
{
    partial class FormCarga
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCarga));
            timerProgreso = new System.Windows.Forms.Timer(components);
            progressBarCarga = new ProgressBar();
            panel1 = new Panel();
            label3 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // timerProgreso
            // 
            timerProgreso.Enabled = true;
            timerProgreso.Tick += timerProgreso_Tick;
            // 
            // progressBarCarga
            // 
            progressBarCarga.BackColor = Color.Tan;
            progressBarCarga.ForeColor = Color.DarkGoldenrod;
            progressBarCarga.Location = new Point(223, 131);
            progressBarCarga.Name = "progressBarCarga";
            progressBarCarga.Size = new Size(307, 71);
            progressBarCarga.TabIndex = 0;
            progressBarCarga.Value = 10;
            progressBarCarga.Click += progressBar1_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(progressBarCarga);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(752, 250);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Mexicana", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Brown;
            label3.Location = new Point(150, 58);
            label3.Name = "label3";
            label3.Size = new Size(224, 18);
            label3.TabIndex = 41;
            label3.Text = "De mexico a tu plato ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("El Rio Lobo", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkGreen;
            label2.Location = new Point(150, 13);
            label2.Name = "label2";
            label2.Size = new Size(553, 36);
            label2.TabIndex = 40;
            label2.Text = "Comida Mexicana Doña Dominga";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(34, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(92, 95);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 39;
            pictureBox1.TabStop = false;
            // 
            // FormCarga
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(752, 250);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormCarga";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormCarga";
            Load += FormCarga_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer timerProgreso;
        private ProgressBar progressBarCarga;
        private Panel panel1;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox1;
    }
}