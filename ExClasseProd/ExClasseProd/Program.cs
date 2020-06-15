using System;

namespace ExClasseProd
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto;
            string nome;
            double preco;
            int qtd,aux = 1;

            Console.WriteLine("Digite o nome do produto:");
            nome = Console.ReadLine();
            Console.WriteLine("Digite o preço do produto:");
            preco = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o qtd do produto:");
            qtd = int.Parse(Console.ReadLine());

            produto = new Produto(nome, preco, qtd);

            while (aux != 0)
            {
                Console.WriteLine(produto);

                Console.WriteLine("Opções: 0 = Sair , 1 = Adicionar Produto , 2 = Remover Produto");

                aux = int.Parse(Console.ReadLine());

                if( aux == 1){

                    Console.Write("Digite o numero de produtos a serem adicionados ao estoque: ");
                    produto.AdicionarProduto(int.Parse(Console.ReadLine()));

                }else if( aux == 2){

                    Console.Write("Digite o numero de produtos a serem removidos do estoque: ");
                    produto.RemoverProduto(int.Parse(Console.ReadLine()));
                }
            }
        }
    }
}
