using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ProyectoFinal

{
    public partial class FormAdmin : Form
    {
        private PrivateFontCollection fontCollection = new PrivateFontCollection();
        private string nombreUsuario;
       
        List<Comida> data;

        public FormAdmin()
        {

            InitializeComponent();


        }
        public FormAdmin(string nomReg)
        {
            InitializeComponent();
            this.nombreUsuario = nomReg;
            this.labelUsuario.Text = nomReg;
         

        }

        private void CargarFuentePersonalizada()
        {
            // Cargar la fuente desde un recurso incrustado
            using (Stream fontStream = GetType().Assembly.GetManifestResourceStream("ProyectoFinal.Recursos.Mexicana.ttf"))
            {
                if (fontStream != null)
                {
                    byte[] fontData = new byte[fontStream.Length];
                    fontStream.Read(fontData, 0, fontData.Length);

                    IntPtr fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
                    System.Runtime.InteropServices.Marshal.Copy(fontData, 0, fontPtr, fontData.Length);

                    fontCollection.AddMemoryFont(fontPtr, fontData.Length);
                    System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);
                }
            }
        }
        void limpiar()
        {
            foreach (var control in this.Controls.OfType<TextBox>())
            {
                control.Clear();
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonMostrarAlta_Click(object sender, EventArgs e)
        {
            AltaComida pantalla = new AltaComida(nombreUsuario,this);
            pantalla.ShowDialog();
        }


        private void buttonVerComidas_Click(object sender, EventArgs e)
        {
            FormListaComidas pantalla = new FormListaComidas(nombreUsuario, this);
            pantalla.ShowDialog();
        }

        private void buttonVentasTotales_Click(object sender, EventArgs e)
        {
            FormVentasTotales pantalla = new FormVentasTotales(nombreUsuario, this);
            pantalla.ShowDialog();
        }



        private void FormAdmin_Load(object sender, EventArgs e)
        {

        }

        private void buttonMostrarChart_Click(object sender, EventArgs e)
        {
            FormGrafica pantalla = new FormGrafica(nombreUsuario,this);
            pantalla.ShowDialog();

        }

        private void buttonVerBaja_Click(object sender, EventArgs e)
        {
            formBajaComida pantalla = new formBajaComida(nombreUsuario,this);
            pantalla.ShowDialog();
        }

        private void buttonMostrarAlta_MouseEnter(object sender, EventArgs e)
        {
            this.buttonMostrarAlta.FlatStyle = FlatStyle.Flat;
            this.buttonMostrarAlta.BackColor = Color.Transparent;
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void labelUsuario_Click(object sender, EventArgs e)
        {

        }
    }
}
