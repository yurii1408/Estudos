using System;
using System.Collections;

namespace Array_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList dados_cliente = new ArrayList();

            dados_cliente.Add("Yuri Pinheiro Teixeira");
            dados_cliente.Add("EcoCentauro");
            dados_cliente.Add(22);
            dados_cliente.Add(957.00);

            int qtd = dados_cliente.Count;

            for (int i = 0; i < qtd; i++)
                Console.WriteLine(dados_cliente[i]);


            Console.ReadKey();
        }
    }
}
