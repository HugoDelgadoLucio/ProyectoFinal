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



        public CarritoForm(List<ConexionUsuario> compras)
        {
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
                    totalCompra += totalProducto;
                }
                double petitata = Convert.ToDouble(totalCompra);
                double taxes = petitata * 0.06; // Solo los impuestos
                double TotalConImpuestos = petitata + taxes; // Sumar impuestos al total
                labelTotal.Text = $"Total: ${totalCompra:F2}";
                labelTaxes.Text = $"Total con impuestos: ${TotalConImpuestos:F2}";
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
            this.button1 = new Button();
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
            this.button1.Location = new Point(452, 526);
            this.button1.Name = "button1";
            this.button1.Size = new Size(90, 28);
            this.button1.TabIndex = 6;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += this.button1_Click;
            // 
            // CarritoForm
            // 
            BackgroundImage = Properties.Resources.f1;
            ClientSize = new Size(571, 576);
            Controls.Add(this.button1);
            Controls.Add(labelTaxes);
            Controls.Add(btnPDF);
            Controls.Add(listViewCarrito);
            Controls.Add(labelTotal);
            Controls.Add(btnComprar);
            Controls.Add(btnCancelar);
            Name = "CarritoForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Carrito de Compras";
            ResumeLayout(false);
        }

        private void BtnComprar_Click(object sender, EventArgs e)
        {
            Form4 frm = new Form4();
            frm.ShowDialog();
            MessageBox.Show("Compra realizada con éxito", "Compra", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
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
            PdfGenerator pdfGenerator = new PdfGenerator();
            WonderOfU f = new WonderOfU();
            string namae = f.gennamaereci();
            pdfGenerator.GenerarPdf(listaCompra);
            MessageBox.Show("Su recibo es el: " + namae, "Recibo Descargado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void labelTotal_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}