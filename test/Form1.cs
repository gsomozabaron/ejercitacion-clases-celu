namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = this.txtUsuario.Text;
            string password = this.txtContraseña.Text;
            if (usuario == "a" && password == "a")
            {
                MessageBox.Show($"bienvenido {usuario}");
                 

            }
        }
    }
}