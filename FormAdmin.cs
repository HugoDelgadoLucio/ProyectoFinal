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
    public partial class FormAdmin : Form
    {
        List<Comida> data;
        public FormAdmin()
        {
            InitializeComponent();



        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBoxAltaExistencias_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
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
        void limpiar()
        {
            foreach (var control in this.Controls.OfType<TextBox>())
            {
                control.Clear();
            }

        }

        private void buttonMostrarAlta_Click(object sender, EventArgs e)
        {
            groupBoxAlta.Visible = true;
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


            this.limpiar();
            obj.Disconnect();
        }

        private void buttonVerComidas_Click(object sender, EventArgs e)
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

        private void buttonVemtasTotales_Click(object sender, EventArgs e)
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
            this.labelVentas.Text = "Ventas Totales: " + Convert.ToString(total);

            obj.Disconnect();
        }

        private void labelVentas_Click(object sender, EventArgs e)
        {


        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {

        }

        private void buttonMostrarChart_Click(object sender, EventArgs e)
        {

            AdmonBD obj = new AdmonBD();
            data = obj.consultaComida();
            
            /*muestra informacion*/
            this.richTextBoxComidas.Clear();
            data.ForEach(food =>
            {

                this.chartExistencias.Series["Existencias"].Points.AddXY(food.Descripcion, food.Precio);
               
            });

            obj.Disconnect();

        }

        private void FormAdmin_Load_1(object sender, EventArgs e)
        {

        }
    }
}
