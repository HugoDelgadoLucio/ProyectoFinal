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
    public partial class FormCarga : Form
    {
        private int contador=0;
        private string nombreUsuario;
        public FormCarga()
        {
            InitializeComponent();

        }
        public FormCarga(string nombre)
        {
            InitializeComponent();
            this.nombreUsuario = nombre;


        }
       

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormCarga_Load(object sender, EventArgs e)
        {

        }

        private void timerProgreso_Tick(object sender, EventArgs e)
        {
            if (contador < 100)
            {
                contador++;
                this.progressBarCarga.Value = contador;
            }
            else
            {
                this.timerProgreso.Enabled = false;
                this.Close();
                FormAdmin pantalla = new FormAdmin(this.nombreUsuario);
                pantalla.ShowDialog();

            }
        }
    }
}
