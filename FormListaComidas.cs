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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ProyectoFinal
{
    public partial class FormListaComidas : Form
    {
        private FormAdmin ventanaAdmin;
        public FormListaComidas()
        {
            InitializeComponent();
        }
        public FormListaComidas(string nom, FormAdmin ventanaAdm)
        {
            InitializeComponent();
            this.ventanaAdmin = ventanaAdm;
            this.labelUsuario.Text = nom;
        }
        List<Comida> data;

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            AdmonBD obj = new AdmonBD();
            data = obj.consultaComida();

            /*muestra informacion*/
            this.richTextBoxComidas.Clear();
            data.ForEach(food =>
            {
                this.richTextBoxComidas.AppendText("id=" + food.Id + " descripcion=" + food.Descripcion + " Precio=" + food.Precio + " Existencias:" + food.Existencias + " Imagen:" + food.Imagen + "\n");
            });

            obj.Disconnect();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.ventanaAdmin.Close();
            this.Close();

        }
    }
}
