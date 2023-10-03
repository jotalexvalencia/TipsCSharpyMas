namespace Tip23_ConsolayForm
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

        private void btnAConsola_Click(object sender, EventArgs e)
        {
            // Imprimimos a la consola
            Console.WriteLine("Desde la forma a la consola");
            Console.WriteLine("El textbox tiene {0}",txtDato.Text);

        }

        private void btnPide_Click(object sender, EventArgs e)
        {
            this.Hide();
            Console.WriteLine("Escribe un mensaje");
            string msg = Console.ReadLine();
            lblMensaje.Text = msg;
            this.Show();
        }
    }
}