﻿namespace ProyectoFinal
{
    partial class FormGrafica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGrafica));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            labelUsuario = new Label();
            buttonLogout = new Button();
            labelSalir = new Label();
            groupBoxGrafica = new GroupBox();
            buttonActualizar = new Button();
            chartExistencias = new System.Windows.Forms.DataVisualization.Charting.Chart();
            label3 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBoxGrafica.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartExistencias).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(groupBoxGrafica);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1144, 636);
            panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.PeachPuff;
            groupBox1.Controls.Add(labelUsuario);
            groupBox1.Controls.Add(buttonLogout);
            groupBox1.Controls.Add(labelSalir);
            groupBox1.Font = new Font("MV Boli", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(830, 9);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(302, 121);
            groupBox1.TabIndex = 40;
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
            // groupBoxGrafica
            // 
            groupBoxGrafica.BackColor = Color.Tan;
            groupBoxGrafica.Controls.Add(buttonActualizar);
            groupBoxGrafica.Controls.Add(chartExistencias);
            groupBoxGrafica.Font = new Font("MV Boli", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBoxGrafica.Location = new Point(110, 103);
            groupBoxGrafica.Name = "groupBoxGrafica";
            groupBoxGrafica.Size = new Size(704, 508);
            groupBoxGrafica.TabIndex = 39;
            groupBoxGrafica.TabStop = false;
            groupBoxGrafica.Text = "Grafica";
            // 
            // buttonActualizar
            // 
            buttonActualizar.BackgroundImage = (Image)resources.GetObject("buttonActualizar.BackgroundImage");
            buttonActualizar.BackgroundImageLayout = ImageLayout.Zoom;
            buttonActualizar.Cursor = Cursors.Hand;
            buttonActualizar.FlatAppearance.BorderSize = 0;
            buttonActualizar.FlatStyle = FlatStyle.Flat;
            buttonActualizar.Location = new Point(470, 454);
            buttonActualizar.Name = "buttonActualizar";
            buttonActualizar.Size = new Size(244, 42);
            buttonActualizar.TabIndex = 22;
            buttonActualizar.UseVisualStyleBackColor = true;
            buttonActualizar.Click += buttonActualizar_Click;
            // 
            // chartExistencias
            // 
            chartExistencias.BackColor = Color.Transparent;
            chartExistencias.BorderlineColor = Color.RosyBrown;
            chartArea2.BackColor = Color.Transparent;
            chartArea2.Name = "ChartArea1";
            chartExistencias.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chartExistencias.Legends.Add(legend2);
            chartExistencias.Location = new Point(17, 0);
            chartExistencias.Name = "chartExistencias";
            chartExistencias.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.Color = Color.FromArgb(255, 224, 192);
            series2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            series2.Legend = "Legend1";
            series2.Name = "Existencias";
            series2.SmartLabelStyle.IsMarkerOverlappingAllowed = true;
            chartExistencias.Series.Add(series2);
            chartExistencias.Size = new Size(568, 498);
            chartExistencias.TabIndex = 21;
            chartExistencias.Text = "Existencias";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Mexicana", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Brown;
            label3.Location = new Point(217, 54);
            label3.Name = "label3";
            label3.Size = new Size(224, 18);
            label3.TabIndex = 38;
            label3.Text = "De mexico a tu plato ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("El Rio Lobo", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkGreen;
            label2.Location = new Point(217, 9);
            label2.Name = "label2";
            label2.Size = new Size(553, 36);
            label2.TabIndex = 37;
            label2.Text = "Comida Mexicana Doña Dominga";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.Taco_mascot;
            pictureBox1.Location = new Point(12, 54);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(92, 95);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 36;
            pictureBox1.TabStop = false;
            // 
            // FormGrafica
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1144, 636);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FormGrafica";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrameGrafica";
            Load += FormGrafica_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBoxGrafica.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartExistencias).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private GroupBox groupBoxGrafica;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox1;
        private Button buttonActualizar;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartExistencias;
        private GroupBox groupBox1;
        private Label labelUsuario;
        private Button buttonLogout;
        private Label labelSalir;
    }
}