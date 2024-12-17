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
    public partial class CarritoForm : Form
    {
        private List<ConexionUsuario> listaCompra;
        private int id;
        private decimal totalCompra;
        private int[] ides;
        private int[] cant;
        private int[] exist;
        private double TotalConImpuestos;
        public CarritoForm(List<ConexionUsuario> compras)
        {
            InitializeComponent();
            listaCompra = compras;
            MostrarCarrito();
        }
        public CarritoForm(List<ConexionUsuario> compras, int id)
        {
            this.id = id;
            InitializeComponent();
            listaCompra = compras;
            MostrarCarrito();
        }


        private void MostrarCarrito()
        {
            // Check if listViewCarrito is not null before using it
            if (listViewCarrito != null)
            {
                WonderOfU demo = new WonderOfU();
                listViewCarrito.Items.Clear();
                decimal totalCompra = 0;
                foreach (var producto in listaCompra)
                {
                    decimal totalProducto = (decimal)(producto.Cantidad * producto.Precio);
                
                    ListViewItem item = new ListViewItem(producto.Descripcion);
                    item.SubItems.Add(producto.Cantidad.ToString());
                    item.SubItems.Add($"${producto.Precio:F2}");
                    item.SubItems.Add($"${totalProducto:F2}");
                    listViewCarrito.Items.Add(item);
                    this.totalCompra += totalProducto;
                }
                double petitata = Convert.ToDouble(this.totalCompra);
                double taxes = petitata * 0.06; // Solo los impuestos
                this.TotalConImpuestos = petitata + taxes; // Sumar impuestos al total
                labelTotal.Text = $"Total: ${this.totalCompra:F2}";
                labelTaxes.Text = $"Total con impuestos: ${this.TotalConImpuestos:F2}";
            }
        }


        private void InitializeComponent()
        {
            listViewCarrito = new ListView();
            Producto = new ColumnHeader();
            cantidad = new ColumnHeader();
            Precio = new ColumnHeader();
            labelTotal = new Label();
            btnComprar = new Button();
            btnCancelar = new Button();
            btnPDF = new Button();
            labelTaxes = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // listViewCarrito
            // 
            listViewCarrito.BackgroundImage = Properties.Resources.f1;
            listViewCarrito.Columns.AddRange(new ColumnHeader[] { Producto, cantidad, Precio });
            listViewCarrito.Dock = DockStyle.Top;
            listViewCarrito.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listViewCarrito.Location = new Point(0, 0);
            listViewCarrito.Name = "listViewCarrito";
            listViewCarrito.Size = new Size(571, 413);
            listViewCarrito.TabIndex = 0;
            listViewCarrito.UseCompatibleStateImageBehavior = false;
            listViewCarrito.View = View.Details;
            listViewCarrito.SelectedIndexChanged += listViewCarrito_SelectedIndexChanged;
            // 
            // Producto
            // 
            Producto.Text = "Producto";
            Producto.Width = 100;
            // 
            // cantidad
            // 
            cantidad.Text = "Cantidad";
            cantidad.Width = 100;
            // 
            // Precio
            // 
            Precio.Text = "Precio";
            Precio.Width = 100;
            // 
            // labelTotal
            // 
            labelTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelTotal.Location = new Point(127, 431);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(300, 28);
            labelTotal.TabIndex = 1;
            labelTotal.Click += labelTotal_Click;
            // 
            // btnComprar
            // 
            btnComprar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnComprar.Location = new Point(12, 524);
            btnComprar.Name = "btnComprar";
            btnComprar.Size = new Size(100, 28);
            btnComprar.TabIndex = 2;
            btnComprar.Text = "Comprar";
            btnComprar.Click += BtnComprar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(305, 525);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(100, 28);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.Click += BtnCancelar_Click;
            // 
            // btnPDF
            // 
            btnPDF.Location = new Point(141, 525);
            btnPDF.Name = "btnPDF";
            btnPDF.Size = new Size(126, 28);
            btnPDF.TabIndex = 4;
            btnPDF.Text = "Descargar recibo";
            btnPDF.UseVisualStyleBackColor = true;
            btnPDF.Click += btnPDF_Click;
            // 
            // labelTaxes
            // 
            labelTaxes.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelTaxes.Location = new Point(127, 476);
            labelTaxes.Name = "labelTaxes";
            labelTaxes.Size = new Size(300, 28);
            labelTaxes.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(452, 526);
            button1.Name = "button1";
            button1.Size = new Size(90, 28);
            button1.TabIndex = 6;
            button1.Text = "Salir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // CarritoForm
            // 
            BackgroundImage = Properties.Resources.f1;
            ClientSize = new Size(571, 576);
            Controls.Add(button1);
            Controls.Add(labelTaxes);
            Controls.Add(btnPDF);
            Controls.Add(listViewCarrito);
            Controls.Add(labelTotal);
            Controls.Add(btnComprar);
            Controls.Add(btnCancelar);
            Name = "CarritoForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Carrito de Compras";
            Load += CarritoForm_Load_1;
            ResumeLayout(false);
        }

        private void BtnComprar_Click(object sender, EventArgs e)
        {
            Form4 frm = new Form4();
            frm.ShowDialog();
            MessageBox.Show("Compra realizada con éxito", "Compra", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;


            AdmonBD obj = new AdmonBD();
            ConexionUsuario cons;
            int i = 0;
            int aux = 0;
            int total = 0;
            foreach (var item in listaCompra)
            {
                i++;
            }
            this.ides = new int[i];
            this.cant = new int[i];
            this.exist = new int[i];

            foreach (var item in listaCompra)
            {
                this.ides[aux] = item.Id;
                this.cant[aux] = item.Cantidad;
                this.exist[aux] = item.Existencias;
                aux++;
            }

            for (int j = 0; j < i; j++)
            {
                obj.actualizarExis(this.ides[j], (this.exist[j] - this.cant[j]));
            }

            total = obj.consultaUsuario(this.id);
            obj.actualizarMonto(this.id, (Convert.ToDecimal(this.TotalConImpuestos) + total));
 
            this.Close();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        private void CarritoForm_Load(object sender, EventArgs e)
        {
            // Lógica para inicializar el formulario cuando se carga
            MessageBox.Show("Bienvenido al carrito de compras");
        }

        private void listViewCarrito_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            // Crear una instancia de PdfGenerator y generar el PDF
           
            PdfGenerator pdfGenerator1 = new PdfGenerator();
            WonderOfU f = new WonderOfU();
            string namae = f.gennamaereci();
            pdfGenerator1.GenerarPdf(listaCompra);
            MessageBox.Show("Su recibo es el: " + namae, "Recibo Descargado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void labelTotal_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CarritoForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}