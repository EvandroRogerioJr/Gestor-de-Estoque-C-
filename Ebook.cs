using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto3
{
    [System.Serializable]
    class Ebook : Produto, IEstoque
    {
        public string autor;
        private int vendas;

        public Ebook(string nome, float preco, string autor)
        {
            this.nome = nome;
            this.preco = preco;
            this.autor = autor;
        }

        public void AdicionarEntrada()
        {
            Console.WriteLine("Não é possível dar entrada em um Ebook");
            Console.ReadLine();
        }

        public void AdicionarSairda()
        {
            Console.WriteLine($"Adicionar Vendas no E-book {nome}");
            Console.WriteLine("Digite a quantidade de vendas que você quer dar a entrada: ");
            int entrada = int.Parse(Console.ReadLine());
            vendas += entrada;
            Console.WriteLine("Saida Resgitrada ");
            Console.ReadLine();
        }

        public void Exibir()
        {
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Preço: {preco}");
            Console.WriteLine($"Quantidade de vendas: {vendas}");
            Console.WriteLine($"Autor do Curso: {autor}");
            Console.WriteLine("===============================");
        }
    }
}
