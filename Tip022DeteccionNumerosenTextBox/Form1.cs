namespace Tip022DeteccionNumerosenTextBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDetecta_Click(object sender, EventArgs e)
        {
            //int ri = 0;
            double rd = 0.0;

            //if (txtDato.Text == string.Empty)
            //    MessageBox.Show("No hay dato");
            //else if (int.TryParse(txtDato.Text, out ri))
            //    MessageBox.Show(String.Format("{0} Es un número entero", ri));
            //else if (double.TryParse(txtDato.Text, out rd))
            //    MessageBox.Show(String.Format("{0} Es un número flotante", rd));
            //else
            //    MessageBox.Show(String.Format("{0} Es una cadena", txtDato.Text));

            if(txtDato.Text==String.Empty ||
                !double.TryParse(txtDato.Text, out rd))
            {
                MessageBox.Show("Introduce un número");
                txtDato.Text = "0";
            }
            else
            {
                double resultado;
                resultado = Convert.ToDouble(txtDato.Text) * 3.5;
                MessageBox.Show(resultado.ToString());
            }
        }
    }
}