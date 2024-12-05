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

        private void buttonFormAdmin_Click(object sender, EventArgs e)
        {
      
            FormAdmin pantallaAdmin = new FormAdmin();
            pantallaAdmin.ShowDialog();
        }
    }
}
