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
    public partial class formBajaComida : Form
    {
        private FormAdmin ventanaAdmin;
        public formBajaComida()
        {
            InitializeComponent();
        }
        public formBajaComida(string nombre,FormAdmin ventanaAdm)
        {
            InitializeComponent();
            this.labelUsuario.Text = nombre;
            this.ventanaAdmin = ventanaAdm;
        }


        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            AdmonBD obj = new AdmonBD();
            Comida aux = obj.consultaUnRegistroComida(Convert.ToInt32(this.textBoxBajaId.Text));
            DialogResult respuesta = MessageBox.Show(
            "Se eliminara el registro:\n  Id: " + aux.Id + "\nDescripcion: " + aux.Descripcion
            + "\nPrecio: " + aux.Precio + "\nExistencias: " + aux.Existencias + "\nImagen: " + aux.Imagen,
            "Confirmación",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
             );
            if (respuesta == DialogResult.OK)
            {
                obj.eliminar(Convert.ToInt32(this.textBoxBajaId.Text));
            }
            else if (respuesta == DialogResult.Cancel)
            {
                MessageBox.Show("Eliminación cancelada", "Cancelado", MessageBoxButtons.OK);
            }


            this.textBoxBajaId.Text = "";
            obj.Disconnect();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            ventanaAdmin.Close();
            this.Close();
        }
    }
}
