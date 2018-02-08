using System;

namespace Console_pratice
{
    class Program
    {
        static void Main(string[] args)
        {
            Estoque estoque = new Estoque();

            estoque.Nome_produto = "Samsung";
            estoque.Preco = 1200;
            Console.WriteLine("Produto: " + estoque.Nome_produto);
            Console.WriteLine("Preço: " + estoque.Preco);

            Console.ReadKey();
        }
    }
}
