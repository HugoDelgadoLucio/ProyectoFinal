namespace ProyectoFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            InicioSesion pantalla = new InicioSesion();
            pantalla.ShowDialog();
        }

        //private void buttonFormAdmin_Click(object sender, EventArgs e)
        //{

        //FormCarga pantallaAdmin = new FormCarga("JETZAN AZAEL ESQUIVEL");
        //pantallaAdmin.ShowDialog();
        //}
    }
}
