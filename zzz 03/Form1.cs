namespace zzz_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String numereTexto = txtnumero.Text;
            int numero = int.Parse (numerTexto);
            bool esPar = numero % 2 == 0;
            if (esPar)
            {
                lblresultado.Text = "Es : par";
            }
            else
            {
                lblresultado.Text = "Es : impar";
            }
        }
    }
}