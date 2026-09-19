namespace CalculadoraWinForms
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

        private void btnSumar_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtNumero1.Text, out double n1) && double.TryParse(txtNumero2.Text, out double n2))
            {
                lblResultado.Text = "Resultado: " + (n1 + n2);
            }
            else
            {
                lblResultado.Text = "Ingresa dos números válidos";
            }
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtNumero1.Text, out double n1) && double.TryParse(txtNumero2.Text, out double n2))
            {
                lblResultado.Text = "Resultado: " + (n1 - n2);
            }
            else
            {
                lblResultado.Text = "Ingresa dos números válidos";
            }
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtNumero1.Text, out double n1) && double.TryParse(txtNumero2.Text, out double n2))
            {
                lblResultado.Text = "Resultado: " + (n1 * n2);
            }
            else
            {
                lblResultado.Text = "Ingresa dos números válidos";
            }
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtNumero1.Text, out double n1) && double.TryParse(txtNumero2.Text, out double n2))
            {
                if (n2 == 0)
                    lblResultado.Text = "Error: no se puede dividir entre cero";
                else
                    lblResultado.Text = "Resultado: " + (n1 / n2);
            }
            else
            {
                lblResultado.Text = "Ingresa dos números válidos";
            }
        }
    }
}
