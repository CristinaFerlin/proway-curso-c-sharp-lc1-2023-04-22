namespace WindowsFormsExemplos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = textBoxNome.Text;
            int quantidadeHoras = Convert.ToInt32(textBoxQuantidadeHoras.Text);
            double valorHora = Convert.ToDouble(textBoxValorHora.text);

        }
    }
}