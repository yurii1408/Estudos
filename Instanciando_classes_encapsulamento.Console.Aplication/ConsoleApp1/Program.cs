using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //instanciando classe
            Produto objeto_instanciado_produto = new Produto();

            /*
            objeto_instanciado_produto.setNome("Dell");
            objeto_instanciado_produto.setPreco(2900);
            Console.WriteLine("Produto: " + objeto_instanciado_produto.getNome() + " -> Preço: " + objeto_instanciado_produto.getPreco());
                                 
            objeto_instanciado_produto.setNome("Asus");
            objeto_instanciado_produto.setPreco(1800);
            Console.WriteLine("Produto: " + objeto_instanciado_produto.getNome() + " -> Preço: " + objeto_instanciado_produto.getPreco());       */

            objeto_instanciado_produto.Nome_produto = "Dell";
            objeto_instanciado_produto.Preco = 2900;
            Console.WriteLine("Produto: " + objeto_instanciado_produto.Nome_produto + " -> Preco: R$" + objeto_instanciado_produto.Preco);

            objeto_instanciado_produto.Nome_produto = "Asus";
            objeto_instanciado_produto.Preco = 1800;
            Console.WriteLine("Produto: " + objeto_instanciado_produto.Nome_produto + " -> Preco: R$" + objeto_instanciado_produto.Preco);
            Console.ReadKey();
        }
    }
}
