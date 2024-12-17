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
    public partial class Form3 : Form
    {
        int chkATM = 0;
        string projectDirectory = Directory.GetCurrentDirectory();
        public string TipoDeDiseno { get; set; }

        public Form3()
        {
            InitializeComponent();
            textBoxATMNom.MaxLength = 16;
            textBoxATMNip.MaxLength = 4;
            comboBoxATMMonth.SelectedIndex = 0;
            comboBoxATMYear.SelectedIndex = 0;
            labelEfectivo.Hide();
            labelQr.Hide();
            labelQr1.Hide();
            labelATM.Hide();
            labelATM1.Hide();
            labelATM2.Hide();
            labelATM3.Hide();
            labelATM4.Hide();
            labelATM5.Hide();
            btnATMPaga.Hide();
            textBoxATMNip.Hide();
            textBoxATMNom.Hide();
            pictureBoxQr.Hide();
            pictureBoxATMBanks.Hide();
            comboBoxATMMonth.Hide();
            comboBoxATMYear.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void AplicarDiseno()
        {
            // Cambiar el diseño de acuerdo con la propiedad TipoDeDiseno
            if (TipoDeDiseno == "Estilo1")
            {
                this.BackColor = System.Drawing.Color.LightBlue;
                this.Text = "Pago en efectivo";
                labelEfectivo.Show();
            }
            else if (TipoDeDiseno == "Estilo2")
            {
                chkATM = 0;
                this.BackColor = System.Drawing.Color.LightGreen;
                this.Text = "Pago por Tarjeta";
                labelATM.Show();
                labelATM1.Show();
                labelATM2.Show();
                labelATM3.Show();
                labelATM4.Show();
                labelATM5.Show();
                btnATMPaga.Show();
                textBoxATMNip.Show();
                textBoxATMNom.Show();
                pictureBoxATMBanks.Show();
                comboBoxATMMonth.Show();
                comboBoxATMYear.Show();
                string jpgFilePath = Path.Combine(projectDirectory, "Resources", "BanksLogos.png");
                pictureBoxATMBanks.Image = Image.FromFile(jpgFilePath);
            }
            else if (TipoDeDiseno == "Estilo3")
            {
                this.BackColor = System.Drawing.Color.Pink;
                this.Text = "Pago QR";
                pictureBoxQr.Show();
                labelQr.Show();
                labelQr1.Show();

                Random r = new Random();
                int rQr = r.Next(0, 10); string fil = rQr.ToString() + ".jpeg";
                string jpgFilePath = Path.Combine(projectDirectory, "Qrs", fil);
                pictureBoxQr.Image = Image.FromFile(jpgFilePath);
            }
            else
            {
                this.BackColor = System.Drawing.Color.White;
                this.Text = "Diseño Predeterminado";
            }
        }

        private void pictureBoxQr_Click(object sender, EventArgs e)
        {

        }

        private void buttonRtrn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnATMPaga_Click(object sender, EventArgs e)
        {
            // Verifica si chkATM es igual a 4, lo que indica que todos los campos necesarios están completos.

            MessageBox.Show("Transferencia Exitosa", "Transferencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBoxATMNom_TextChanged(object sender, EventArgs e)
        {
            int numeroDeCaracteres = textBoxATMNom.Text.Length;
            // Si el número de caracteres es exactamente 16, incrementamos chkATM
            if (numeroDeCaracteres == 16)
            {
                chkATM = chkATM + 1;
            }
            // Si el número de caracteres no es 16, restamos de chkATM para reflejar que no es válido
            else
            {
                chkATM = Math.Max(0, chkATM - 1);
            }
        }

        private void textBoxATMNip_TextChanged(object sender, EventArgs e)
        {
            int numeroDeCaracteres = textBoxATMNip.Text.Length;
            // Si el número de caracteres es exactamente 4, incrementamos chkATM
            if (numeroDeCaracteres == 4)
            {
                chkATM = chkATM + 1;
            }
            // Si el número de caracteres no es 4, restamos de chkATM para reflejar que no es válido
            else
            {
                chkATM = Math.Max(0, chkATM - 1);
            }
        }

        private void comboBoxATMMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Si el mes no es seleccionado (0 significa no seleccionado), restamos de chkATM
            if (comboBoxATMMonth.SelectedIndex == 0)
            {
                chkATM = Math.Max(0, chkATM - 1);
            }
            else
            {
                chkATM = chkATM + 1;
            }
        }

        private void comboBoxATMYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Si el año no es seleccionado (0 significa no seleccionado), restamos de chkATM
            if (comboBoxATMYear.SelectedIndex == 0)
            {
                chkATM = Math.Max(0, chkATM - 1);
            }
            else
            {
                chkATM = chkATM + 1;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnATMPaga_Click_1(object sender, EventArgs e)
        {
            if (textBoxATMNip.Text.Length >= 4 && textBoxATMNom.Text.Length >= 16 && comboBoxATMMonth.SelectedIndex != 0 && comboBoxATMYear.SelectedIndex != 0)
            {
                MessageBox.Show("Transferencia Exitosa", "Transferencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Transferencia No Exitosa", "Transferencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
