using System.IO; // Necesario para Path.GetFileNameWithoutExtension

namespace ProyectoFinal
{
    public partial class InterfazUsuario : Form
    {
        private int prods;
        private int id;
        private string nombre;
        List<ConexionUsuario> data;
        List<ConexionUsuario> listaCompra;
        ConexionUsuario item;

        public static string dia;
        public static string hora;

        private PictureBox[] cajas;
        private GroupBox[] groupBoxes;
        private Label[] descripciones;
        private Button[] agregar;
        private NumericUpDown[] cantidad;

        private string[] iniciales = new string[10] { "-", "-", "-", "-", "-", "-", "-", "-", "-", "-" };
        private string[] imagenes = new string[10] { "-", "-", "-", "-", "-", "-", "-", "-", "-", "-" };

        private int[] ids = new int[10];
        private int[] exis = new int[10];

        public InterfazUsuario()
        {
            InitializeComponent();

            //Obtiene el dia actual
            dia = DateTime.UtcNow.ToString("dd/MM/yyyy");
            //Obtiene la hora con unevento el cual se activa cada segundo y actualiza la etiqueta labelHora 
            System.Windows.Forms.Timer timerHora = new System.Windows.Forms.Timer();
            timerHora.Interval = 1000; // 1 segundo
            timerHora.Tick += TimerHora_Tick; // Asociar el evento Tick
            timerHora.Start(); // Iniciar el Timer

            labelTime.Text = $"{dia}";

            cajas = new PictureBox[]{ pictureBoxProd1, pictureBoxProd2, pictureBoxProd3, pictureBoxProd4, pictureBoxProd5,
                                        pictureBoxProd6, pictureBoxProd7, pictureBoxProd8,pictureBoxProd9, pictureBoxProd10 };

            groupBoxes = new GroupBox[] { groupBoxProd1, groupBoxProd2, groupBoxProd3, groupBoxProd4, groupBoxProd5, groupBoxProd6,
                                            groupBoxProd7, groupBoxProd8, groupBoxProd9, groupBoxProd10};

            descripciones = new Label[] { labelProd1, labelProd2, labelProd3, labelProd4, labelProd5, labelProd6, labelProd7,
                                        labelProd8, labelProd9, labelProd10 };

            agregar = new Button[] { btnProd1, btnProd2, btnProd3, btnProd4, btnProd5, btnProd6, btnProd7, btnProd8, btnProd9, btnProd10 };

            cantidad = new NumericUpDown[] { numUpDwProd1, numUpDwProd2, numUpDwProd3, numUpDwProd4, numUpDwProd5, numUpDwProd6,
                                                numUpDwProd7, numUpDwProd8, numUpDwProd9, numUpDwProd10};

            this.prods = 0;

            foreach (var pictureBox in cajas)
            {
                pictureBox.MouseEnter += PictureBox_MouseEnter;
                pictureBox.MouseLeave += PictureBox_MouseLeave;
            }

            pictureBoxLogOut.MouseEnter += PictureBoxLO_MouseEnter;
            pictureBoxLogOut.MouseLeave += PictureBoxLO_MouseLeave;

            foreach (var button in agregar)
            {
                button.MouseClick += Button_Click;
            }

            AdmonBD obj = new AdmonBD();
            data = obj.consulta();

            data.ForEach(p =>
            {
                if (prods < 10)
                {
                    this.iniciales[prods] = p.Descripcion;
                    this.imagenes[prods] = p.Imagen;
                    this.ids[prods] = p.Id;
                    this.exis[prods] = p.Existencias;
                }
                this.prods++;
            });

            for (int i = 0; i < prods; i++)
            {
                if (i < 10)
                {
                    cajas[i].Visible = true;
                    groupBoxes[i].Visible = true;
                }
            }

            AsignarImagenes();

            obj.Disconnect();

        }
        public InterfazUsuario(int id, string nombre)
        {


            InitializeComponent();
            listaCompra = new List<ConexionUsuario>();

            //Obtiene el dia actual
            dia = DateTime.UtcNow.ToString("dd/MM/yyyy");
            //Obtiene la hora con unevento el cual se activa cada segundo y actualiza la etiqueta labelHora 
            System.Windows.Forms.Timer timerHora = new System.Windows.Forms.Timer();
            timerHora.Interval = 1000; // 1 segundo
            timerHora.Tick += TimerHora_Tick; // Asociar el evento Tick
            timerHora.Start(); // Iniciar el Timer

            labelTime.Text = $"{dia}";

            cajas = new PictureBox[]{ pictureBoxProd1, pictureBoxProd2, pictureBoxProd3, pictureBoxProd4, pictureBoxProd5,
                                pictureBoxProd6, pictureBoxProd7, pictureBoxProd8,pictureBoxProd9, pictureBoxProd10 };

            groupBoxes = new GroupBox[] { groupBoxProd1, groupBoxProd2, groupBoxProd3, groupBoxProd4, groupBoxProd5, groupBoxProd6,
                                    groupBoxProd7, groupBoxProd8, groupBoxProd9, groupBoxProd10};

            descripciones = new Label[] { labelProd1, labelProd2, labelProd3, labelProd4, labelProd5, labelProd6, labelProd7,
                                labelProd8, labelProd9, labelProd10 };

            agregar = new Button[] { btnProd1, btnProd2, btnProd3, btnProd4, btnProd5, btnProd6, btnProd7, btnProd8, btnProd9, btnProd10 };

            cantidad = new NumericUpDown[] { numUpDwProd1, numUpDwProd2, numUpDwProd3, numUpDwProd4, numUpDwProd5, numUpDwProd6,
                                        numUpDwProd7, numUpDwProd8, numUpDwProd9, numUpDwProd10};

            this.prods = 0;

            foreach (var pictureBox in cajas)
            {
                pictureBox.MouseEnter += PictureBox_MouseEnter;
                pictureBox.MouseLeave += PictureBox_MouseLeave;
            }

            pictureBoxLogOut.MouseEnter += PictureBoxLO_MouseEnter;
            pictureBoxLogOut.MouseLeave += PictureBoxLO_MouseLeave;

            foreach (var button in agregar)
            {
                button.MouseClick += Button_Click;
            }

            AdmonBD obj = new AdmonBD();
            data = obj.consulta();

            data.ForEach(p =>
            {
                if (prods < 10)
                {
                    this.iniciales[prods] = p.Descripcion;
                    this.imagenes[prods] = p.Imagen;
                    this.ids[prods] = p.Id;
                    this.exis[prods] = p.Existencias;
                }
                this.prods++;
            });

            for (int i = 0; i < prods; i++)
            {
                if (i < 10)
                {
                    cajas[i].Visible = true;
                    groupBoxes[i].Visible = true;
                }
            }

            AsignarImagenes();

            obj.Disconnect();
            Button btnCarrito = new Button();
            btnCarrito.Text = "Ver Carrito";
            btnCarrito.Location = new Point(this.ClientSize.Width - 120, this.ClientSize.Height - 50);
            btnCarrito.Size = new Size(100, 30);
            btnCarrito.Click += BtnCarrito_Click;
            this.Controls.Add(btnCarrito);

            this.id = id;
            this.nombre = nombre;

            labelUsuario.Text = $"{this.nombre}";
        }
        private void BtnCarrito_Click(object sender, EventArgs e)
        {
            AdmonBD obj = new AdmonBD();

            if (listaCompra.Count == 0)
            {
                MessageBox.Show("El carrito está vacío.", "Carrito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (CarritoForm carritoForm = new CarritoForm(listaCompra, this.id))
            {
                DialogResult result = carritoForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    // Compra realizada, limpiar el carrito
                    listaCompra.Clear();
                }
            }
        }
        public bool ValidarProds()
        {
            if (prods < 6 || prods > 10)
            {
                MessageBox.Show("El total de productos no esta en el rango\nsoportado por el sistema.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void TimerHora_Tick(object sender, EventArgs e)
        {
            // Actualizar la etiqueta con la hora actual
            labelTiempo.Text = DateTime.Now.ToString("HH:mm:ss tt");
        }

        private void AsignarImagenes()
        {
            for (int i = 0; i < this.prods; i++)
            {
                if (i < 10)
                {
                    string nom = imagenes[i];

                    if (string.IsNullOrEmpty(nom))
                    {
                        continue;
                    }

                    // Elimina la extensión .png porque l asignar una imagen en un picturebox no se necesita
                    string nombreSinExtension = Path.GetFileNameWithoutExtension(nom);

                    // Obtener la imagen desde los recursos
                    var imagen = Properties.Resources.ResourceManager.GetObject(nombreSinExtension) as Image;

                    if (imagen != null)
                    {
                        if (exis[i] > 0)
                        {
                            cajas[i].Image = imagen;
                        }
                        else
                        {
                            AdmonBD obj = new AdmonBD();
                            ConexionUsuario cons;
                            cons = obj.consultaUnRegistro(ids[i], 0);

                            cajas[i].Image = imagen;
                            descripciones[i].Visible = true;
                            descripciones[i].Text = $"¡¡¡Agotado!!!\n\nDescripcion: {cons.Descripcion}\n\nPRECIO: ${cons.Precio}\n\nEXISTENCIAS: {cons.Existencias}";
                            descripciones[i].BackColor = Color.DarkGray;
                            agregar[i].Enabled = false;
                            cantidad[i].Enabled = false;
                        }
                    }
                    else
                    {
                        cajas[i].Image = null;
                    }
                }
            }
        }

        private void PictureBox_MouseEnter(object sender, EventArgs e)
        {
            PictureBox auxpb = sender as PictureBox;
            AdmonBD obj = new AdmonBD();
            ConexionUsuario cons;

            if (auxpb != null)
            {
                int indice = Array.IndexOf(cajas, auxpb);
                if (exis[indice] > 0)
                {
                    if (indice >= 0 && indice < prods)
                    {
                        cons = obj.consultaUnRegistro(ids[indice], 0);
                        descripciones[indice].Visible = true;
                        descripciones[indice].Text = $"Descripcion: {cons.Descripcion}\n\nPRECIO: ${cons.Precio}\n\nEXISTENCIAS: {cons.Existencias}";
                        descripciones[indice].BackColor = Color.FromArgb(255, 2, 38);
                    }
                }
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button auxbtn = sender as Button;
            AdmonBD obj = new AdmonBD();
            ConexionUsuario cons;
            int cant;
            string aux;

            if (auxbtn != null)
            {
                int indice = Array.IndexOf(agregar, auxbtn);
                if (indice >= 0 && indice < prods)
                {
                    if (cantidad[indice].Text == "0")
                    {
                        MessageBox.Show("Error en la cantidad indicada.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cantidad[indice].Text = "1";
                    }
                    else
                    {
                        aux = cantidad[indice].Text;
                        cant = Convert.ToInt32(aux);
                        cons = obj.consultaUnRegistro(ids[indice], cant);
                        if (cant > cons.Existencias)
                        {
                            MessageBox.Show("Error en la cantidad indicada.\nSe exceden las exitencias del producto.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            cantidad[indice].Text = "1";
                        }
                        else
                        {
                            MessageBox.Show("Producto(s) agregado(s) al carrito.", "CARRITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cantidad[indice].Text = "1";
                            this.listaCompra.Add(cons);
                        }
                    }
                }
            }
        }

        private void PictureBox_MouseLeave(object sender, EventArgs e)
        {
            int i = 0;
            foreach (var item1 in descripciones)
            {
                if (exis[i] > 0)
                {
                    item1.Text = " ";
                    item1.Visible = false;
                }
                i++;
            }
        }

        private void PictureBoxLO_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxLogOut.Location = new Point(12, 11);
            pictureBoxLogOut.Size = new Size(59, 59);
        }

        private void PictureBoxLO_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxLogOut.Location = new Point(14, 13);
            pictureBoxLogOut.Size = new Size(55, 55);
        }

        private void pictureBoxLogOut_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show("Desea salir de su cuenta?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resp == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void labelTitulo_Click(object sender, EventArgs e)
        {

        }

        private void InterfazUsuario_Load(object sender, EventArgs e)
        {

        }

        private void btnProd9_Click(object sender, EventArgs e)
        {

        }

        private void btnProd10_Click(object sender, EventArgs e)
        {

        }

        private void buttonComprar_Click(object sender, EventArgs e)
        {
            AdmonBD obj = new AdmonBD();

            if (listaCompra.Count == 0)
            {
                MessageBox.Show("El carrito está vacío.", "Carrito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (CarritoForm carritoForm = new CarritoForm(listaCompra, this.id))
            {
                DialogResult result = carritoForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    // Compra realizada, limpiar el carrito
                    listaCompra.Clear();
                }
            }
        }

        private void btnProd4_Click(object sender, EventArgs e)
        {

        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            listaCompra.Clear();
        }
    }
}
