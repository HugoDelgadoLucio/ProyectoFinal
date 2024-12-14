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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panel1 = new Panel();
            buttonMostrarChart = new Button();
            chartExistencias = new System.Windows.Forms.DataVisualization.Charting.Chart();
            labelVentas = new Label();
            buttonVentasTotales = new Button();
            richTextBoxComidas = new RichTextBox();
            buttonVerComidas = new Button();
            groupBoxBaja = new GroupBox();
            buttonEliminar = new Button();
            textBoxBajaId = new TextBox();
            buttonVerBaja = new Button();
            groupBoxAlta = new GroupBox();
            textBoxAltaId = new TextBox();
            buttonDarAlta = new Button();
            textBoxAltaDescripcion = new TextBox();
            textBoxAltaImagen = new TextBox();
            textBoxAltaPrecio = new TextBox();
            textBoxAltaExistencias = new TextBox();
            buttonMostrarAlta = new Button();
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            mySqlCommand2 = new MySql.Data.MySqlClient.MySqlCommand();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartExistencias).BeginInit();
            groupBoxBaja.SuspendLayout();
            groupBoxAlta.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonMostrarChart);
            panel1.Controls.Add(chartExistencias);
            panel1.Controls.Add(labelVentas);
            panel1.Controls.Add(buttonVentasTotales);
            panel1.Controls.Add(richTextBoxComidas);
            panel1.Controls.Add(buttonVerComidas);
            panel1.Controls.Add(groupBoxBaja);
            panel1.Controls.Add(buttonVerBaja);
            panel1.Controls.Add(groupBoxAlta);
            panel1.Controls.Add(buttonMostrarAlta);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1030, 533);
            panel1.TabIndex = 6;
            panel1.Paint += panel1_Paint;
            // 
            // buttonMostrarChart
            // 
            buttonMostrarChart.Location = new Point(798, 127);
            buttonMostrarChart.Name = "buttonMostrarChart";
            buttonMostrarChart.Size = new Size(151, 48);
            buttonMostrarChart.TabIndex = 21;
            buttonMostrarChart.Text = "Mostrar Grafica de Existencias";
            buttonMostrarChart.UseVisualStyleBackColor = true;
            buttonMostrarChart.Click += buttonMostrarChart_Click;
            // 
            // chartExistencias
            // 
            chartArea1.Name = "ChartArea1";
            chartExistencias.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartExistencias.Legends.Add(legend1);
            chartExistencias.Location = new Point(724, 210);
            chartExistencias.Name = "chartExistencias";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Existencias";
            series1.SmartLabelStyle.IsMarkerOverlappingAllowed = true;
            chartExistencias.Series.Add(series1);
            chartExistencias.Size = new Size(306, 404);
            chartExistencias.TabIndex = 20;
            chartExistencias.Text = "chart1";
            // 
            // labelVentas
            // 
            labelVentas.AutoSize = true;
            labelVentas.Location = new Point(684, 76);
            labelVentas.Name = "labelVentas";
            labelVentas.Size = new Size(83, 15);
            labelVentas.TabIndex = 19;
            labelVentas.Text = "Ventas Totales:";
            labelVentas.Click += labelVentas_Click;
            // 
            // buttonVentasTotales
            // 
            buttonVentasTotales.Location = new Point(684, 12);
            buttonVentasTotales.Name = "buttonVentasTotales";
            buttonVentasTotales.Size = new Size(131, 45);
            buttonVentasTotales.TabIndex = 18;
            buttonVentasTotales.Text = "Ver Ventas Totales";
            buttonVentasTotales.UseVisualStyleBackColor = true;
            buttonVentasTotales.Click += buttonVemtasTotales_Click;
            // 
            // richTextBoxComidas
            // 
            richTextBoxComidas.Location = new Point(426, 152);
            richTextBoxComidas.Name = "richTextBoxComidas";
            richTextBoxComidas.Size = new Size(283, 261);
            richTextBoxComidas.TabIndex = 17;
            richTextBoxComidas.Text = "";
            // 
            // buttonVerComidas
            // 
            buttonVerComidas.Location = new Point(467, 58);
            buttonVerComidas.Name = "buttonVerComidas";
            buttonVerComidas.Size = new Size(151, 50);
            buttonVerComidas.TabIndex = 16;
            buttonVerComidas.Text = "Ver Listado de Comidas";
            buttonVerComidas.UseVisualStyleBackColor = true;
            buttonVerComidas.Click += buttonVerComidas_Click;
            // 
            // groupBoxBaja
            // 
            groupBoxBaja.Controls.Add(buttonEliminar);
            groupBoxBaja.Controls.Add(textBoxBajaId);
            groupBoxBaja.Location = new Point(237, 128);
            groupBoxBaja.Name = "groupBoxBaja";
            groupBoxBaja.Size = new Size(158, 220);
            groupBoxBaja.TabIndex = 15;
            groupBoxBaja.TabStop = false;
            groupBoxBaja.Text = "Baja";
            // 
            // buttonEliminar
            // 
            buttonEliminar.Location = new Point(16, 82);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(122, 51);
            buttonEliminar.TabIndex = 1;
            buttonEliminar.Text = "Eliminar";
            buttonEliminar.UseVisualStyleBackColor = true;
            buttonEliminar.Click += buttonEliminar_Click;
            // 
            // textBoxBajaId
            // 
            textBoxBajaId.Location = new Point(16, 36);
            textBoxBajaId.Name = "textBoxBajaId";
            textBoxBajaId.PlaceholderText = "id";
            textBoxBajaId.Size = new Size(119, 23);
            textBoxBajaId.TabIndex = 0;
            // 
            // buttonVerBaja
            // 
            buttonVerBaja.Location = new Point(246, 60);
            buttonVerBaja.Name = "buttonVerBaja";
            buttonVerBaja.Size = new Size(118, 48);
            buttonVerBaja.TabIndex = 14;
            buttonVerBaja.Text = "Bajas";
            buttonVerBaja.UseVisualStyleBackColor = true;
            // 
            // groupBoxAlta
            // 
            groupBoxAlta.Controls.Add(textBoxAltaId);
            groupBoxAlta.Controls.Add(buttonDarAlta);
            groupBoxAlta.Controls.Add(textBoxAltaDescripcion);
            groupBoxAlta.Controls.Add(textBoxAltaImagen);
            groupBoxAlta.Controls.Add(textBoxAltaPrecio);
            groupBoxAlta.Controls.Add(textBoxAltaExistencias);
            groupBoxAlta.Location = new Point(31, 127);
            groupBoxAlta.Name = "groupBoxAlta";
            groupBoxAlta.Size = new Size(179, 320);
            groupBoxAlta.TabIndex = 13;
            groupBoxAlta.TabStop = false;
            groupBoxAlta.Text = "Alta";
            groupBoxAlta.Visible = false;
            // 
            // textBoxAltaId
            // 
            textBoxAltaId.Location = new Point(27, 39);
            textBoxAltaId.Name = "textBoxAltaId";
            textBoxAltaId.PlaceholderText = "id";
            textBoxAltaId.Size = new Size(117, 23);
            textBoxAltaId.TabIndex = 7;
            // 
            // buttonDarAlta
            // 
            buttonDarAlta.Location = new Point(7, 253);
            buttonDarAlta.Name = "buttonDarAlta";
            buttonDarAlta.Size = new Size(136, 52);
            buttonDarAlta.TabIndex = 12;
            buttonDarAlta.Text = "Dar de Alta";
            buttonDarAlta.UseVisualStyleBackColor = true;
            buttonDarAlta.Click += button1_Click;
            // 
            // textBoxAltaDescripcion
            // 
            textBoxAltaDescripcion.Location = new Point(27, 83);
            textBoxAltaDescripcion.Name = "textBoxAltaDescripcion";
            textBoxAltaDescripcion.PlaceholderText = "Descripcion";
            textBoxAltaDescripcion.Size = new Size(117, 23);
            textBoxAltaDescripcion.TabIndex = 8;
            // 
            // textBoxAltaImagen
            // 
            textBoxAltaImagen.Location = new Point(26, 212);
            textBoxAltaImagen.Name = "textBoxAltaImagen";
            textBoxAltaImagen.PlaceholderText = "Imagen";
            textBoxAltaImagen.Size = new Size(117, 23);
            textBoxAltaImagen.TabIndex = 11;
            // 
            // textBoxAltaPrecio
            // 
            textBoxAltaPrecio.Location = new Point(27, 129);
            textBoxAltaPrecio.Name = "textBoxAltaPrecio";
            textBoxAltaPrecio.PlaceholderText = "Precio";
            textBoxAltaPrecio.Size = new Size(117, 23);
            textBoxAltaPrecio.TabIndex = 9;
            // 
            // textBoxAltaExistencias
            // 
            textBoxAltaExistencias.Location = new Point(27, 171);
            textBoxAltaExistencias.Name = "textBoxAltaExistencias";
            textBoxAltaExistencias.PlaceholderText = "Existencias";
            textBoxAltaExistencias.Size = new Size(117, 23);
            textBoxAltaExistencias.TabIndex = 10;
            textBoxAltaExistencias.TextChanged += textBoxAltaExistencias_TextChanged;
            // 
            // buttonMostrarAlta
            // 
            buttonMostrarAlta.Location = new Point(40, 60);
            buttonMostrarAlta.Name = "buttonMostrarAlta";
            buttonMostrarAlta.Size = new Size(118, 48);
            buttonMostrarAlta.TabIndex = 6;
            buttonMostrarAlta.Text = "Alta ";
            buttonMostrarAlta.UseVisualStyleBackColor = true;
            buttonMostrarAlta.Click += buttonMostrarAlta_Click;
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
            ClientSize = new Size(1030, 533);
            Controls.Add(panel1);
            Name = "FormAdmin";
            Text = "FormAdmin";
            Load += FormAdmin_Load_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartExistencias).EndInit();
            groupBoxBaja.ResumeLayout(false);
            groupBoxBaja.PerformLayout();
            groupBoxAlta.ResumeLayout(false);
            groupBoxAlta.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox textBoxAltaImagen;
        private TextBox textBoxAltaExistencias;
        private TextBox textBoxAltaPrecio;
        private TextBox textBoxAltaDescripcion;
        private TextBox textBoxAltaId;
        private Button buttonMostrarAlta;
        private Button buttonDarAlta;
        private GroupBox groupBoxAlta;
        private GroupBox groupBoxBaja;
        private Button buttonEliminar;
        private TextBox textBoxBajaId;
        private Button buttonVerBaja;
        private Button buttonVerComidas;
        private RichTextBox richTextBoxComidas;
        private Button buttonVentasTotales;
        private Label labelVentas;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartExistencias;
        private Button buttonMostrarChart;
    }
}