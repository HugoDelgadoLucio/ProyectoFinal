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

namespace ProyectoFinal
{
    public partial class AltaComida : Form
    {
        private FormAdmin ventanaAdmin;
        public AltaComida()
        {
            InitializeComponent();
        }
        public AltaComida(string nombre,FormAdmin ventanaAdm)
        {
            InitializeComponent();
            this.labelUsuario.Text = nombre;
            this.ventanaAdmin = ventanaAdm;
        }

        private void buttonDarAlta_Click(object sender, EventArgs e)
        {

        }
        void limpiar()
        {
            foreach (var control in this.Controls.OfType<TextBox>())
            {
                control.Clear();
            }

        }

        private void buttonDarAlta_Click_1(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBoxAltaId.Text);
            string descripcion = textBoxAltaDescripcion.Text;
            float precio = float.Parse(textBoxAltaPrecio.Text);
            int existencias = Convert.ToInt32(textBoxAltaExistencias.Text);
            string imagen = textBoxAltaImagen.Text;

            AdmonBD obj = new AdmonBD();
            obj.insertarComida(id, descripcion, precio, existencias, imagen);
            limpiar();
            obj.Disconnect();

        }

        private void AltaComida_Load(object sender, EventArgs e)
        {

        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            ventanaAdmin.Close();
            this.Close();
        }
    }
}
