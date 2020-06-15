using System;
using System.Collections.Generic;
using System.Text;

namespace ExClasseProd
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Qtd;

        public Produto(string nome, double preco, int qtd)
        {
            Nome = nome;
            Preco = preco;
            Qtd = qtd;
        }

        public override string ToString()
        {
            return "Dados do produto: " 
                + Nome 
                + ", $" 
                + Preco.ToString("F2") 
                + ", " 
                + Qtd 
                + " unidades, Total: $" 
                + ValorTotalEmEstoque().ToString("F2");
        }

        public double ValorTotalEmEstoque()
        {
            return Preco * Qtd;
        }

        public void AdicionarProduto(int quant)
        {
            Qtd += quant;
        }

        public void RemoverProduto(int quant)
        {
            Qtd -= quant;
        }

    }
}
