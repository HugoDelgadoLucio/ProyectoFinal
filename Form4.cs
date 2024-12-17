using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void AbrirForm(string estilo)
        {
            // Crear una instancia de Form2 y configurar la propiedad
            Form3 form3 = new Form3();
            form3.TipoDeDiseno = estilo;
            form3.AplicarDiseno(); // Aplicar el diseño basado en la propiedad
            form3.ShowDialog();
        }

        private void btnEfectivo_Click(object sender, EventArgs e)
        {

        }

        private void btnTarjetaCredito_Click(object sender, EventArgs e)
        {

        }

        private void btnQr_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnQr_Click_1(object sender, EventArgs e)
        {
            AbrirForm("Estilo3");
        }

        private void btnTarjetaCredito_Click_1(object sender, EventArgs e)
        {
            AbrirForm("Estilo2");
        }

        private void btnEfectivo_Click_1(object sender, EventArgs e)
        {
            AbrirForm("Estilo1");
        }
    }
}
