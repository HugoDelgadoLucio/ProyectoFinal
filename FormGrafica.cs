using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ProyectoFinal
{
    public partial class FormGrafica : Form
    {
        private FormAdmin ventanaAdmin;
        List<Comida> data;
        public FormGrafica()
        {
            InitializeComponent();
        }
        public FormGrafica(string nombre, FormAdmin ventanaAdm)
        {
            InitializeComponent();
            this.labelUsuario.Text = nombre;
            this.ventanaAdmin = ventanaAdm;
        }
        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            AdmonBD obj = new AdmonBD();
            data = obj.consultaComida();
            this.chartExistencias.Series["Existencias"].Points.Clear();

            data.ForEach(food =>
            {
                var punto = this.chartExistencias.Series["Existencias"].Points.AddXY(food.Descripcion, food.Precio);


            });

            obj.Disconnect();
        }

        private void FormGrafica_Load(object sender, EventArgs e)
        {

        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.ventanaAdmin.Close();
            this.Close();
        }
    }
}
