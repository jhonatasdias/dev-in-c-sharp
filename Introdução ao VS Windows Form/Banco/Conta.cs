namespace Banco
{
    internal class Conta
    {
        // propridade
        // prop + <tab> + <tab>
        public int Numero { get; set; }
        public double Saldo { get; private set; }
        public Cliente Titular { get; set; }

        public void Deposita(double valorOperacao)
        {
            this.Saldo += valorOperacao;
        }

        internal void Saca(double valorOperacao)
        {
            this.Saldo -= valorOperacao;
        }
        // ctor + <tab> + <tab>

    }
}