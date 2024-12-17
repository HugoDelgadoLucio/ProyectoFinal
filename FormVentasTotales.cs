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
    public partial class FormVentasTotales : Form
    {
        private FormAdmin ventanaAdmin;
        public FormVentasTotales()
        {
            InitializeComponent();
        }
        public FormVentasTotales(string nombre, FormAdmin ventanaAdm)
        {
            InitializeComponent();
            this.labelUsuario.Text = nombre;
            this.ventanaAdmin = ventanaAdm;
        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            List<Usuario> dataUsers;
            AdmonBD obj = new AdmonBD();
            dataUsers = obj.consultaUsuarios();
            float total = 0;
            /*muestra informacion*/
            dataUsers.ForEach(user =>
            {
                total += user.Monto;
            });
            this.textBoxVentas.Text = Convert.ToString(total);

            obj.Disconnect();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("Deseas Salir?",
            "Confirmación",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
             );
            if (respuesta == DialogResult.Yes)
            {
                ventanaAdmin.Close();
                this.Close();
            }


        }
    }
}
