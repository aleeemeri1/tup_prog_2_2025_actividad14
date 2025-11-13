namespace Ejercicio2_Desktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FileStream fs = null;
            try
            {
                fs = new FileStream("sistema.dat", FileMode.Open , FileAccess.Read);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string cuit = textBox4.Text;
                string nombre = textBox5.Text;
                string telefono = textBox6.Text;
                string tarjeta = textBox7.Text;
                miEmpresa.CrearTicket
            }
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormVer fver = new FormVer();
            fver.listBox1.items.AddRange.ShowDialog();
        }
    }
}
