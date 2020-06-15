namespace ExBanco
{
    class ContaBancaria
    {
        public double Saldo { get; set; }
        public int NumConta { get; private set; }
        public string Nome { get; set; }

        public ContaBancaria(int numConta, string nome)
        {
            NumConta = numConta;
            Nome = nome;
        }
        public ContaBancaria(int numConta, string nome, double depositoInicial) : this (numConta,nome)
        {
            Deposito(depositoInicial);
        }


        public void Deposito (double valor)
        {
            Saldo += valor;
        }


        public void Saque( double valor)
        {
            Saldo = Saldo - 5.00 - valor ;
        }

        public override string ToString()
        {
            return "\nDados da Conta: \nConta "
                + NumConta
                + ", Titular: "
                + Nome
                + ", Saldo: $ "
                + Saldo.ToString("F2")
                + "\n";
        }


    }
}
