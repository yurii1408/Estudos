using System;

namespace Teste_laco_repeticao
{
    class Program
    {
        static void Main()
        {
            try
            {
                int numero;
                Console.Clear();
                Console.Write("Digite um numero..: ");
                numero = (Convert.ToInt32(Console.ReadLine()));

                for (int i = 1; i <= 9; i++)
                    Console.WriteLine(numero + " x " + i + " = " + (numero * i));

                Console.ReadKey();
            }
            catch
            {
                Console.Write("Erro inesperado, tente inserir somente números."); Console.ReadKey();
                Main();
            }
        }
    }
}
