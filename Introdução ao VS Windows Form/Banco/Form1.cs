namespace Banco
{
    public partial class Form1 : Form
    {
        private Conta conta;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.conta = new Conta();
            conta.Numero = 1;
            Cliente cliente = new Cliente("victor");
            conta.Titular = cliente;
            textoTitular.Text = conta.Titular.Nome;
            textoNumero.Text = conta.Numero.ToString();
            textoSaldo.Text = conta.Saldo.ToString();
        }

        private void textoTitular_TextChanged(object sender, EventArgs e)
        {



        }

        private void botaoDepositar_Click(object sender, EventArgs e)
        {
            string valorDigitado = textoValor.Text;
            double valorOperacao = Convert.ToDouble(valorDigitado);
            this.conta.Deposita(valorOperacao);
            textoSaldo.Text = Convert.ToString(this.conta.Saldo);
            MessageBox.Show("Sucesso");
        }

        private void botaoSacar_Click(object sender, EventArgs e)
        {
            // ctrl + . criação de método/classe
            // Alterar nome ctrl + r, ctrl + r
            string valorDigitado = textoValor.Text;
            double valorOperacao = Convert.ToDouble(valorDigitado);
            this.conta.Saca(valorOperacao);
            textoSaldo.Text = Convert.ToString(this.conta.Saldo);
            MessageBox.Show("Sucesso"); // mbox + <tab> + <tab>
        }
    }
}