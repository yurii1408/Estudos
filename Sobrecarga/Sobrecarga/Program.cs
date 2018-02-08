using System;

namespace Sobrecarga
{
    class Program
    {
        static double media;

        static void Main(string[] args)
        {
            Calcular("1", 2); Console.ReadKey();
        }

        public static void Calcular(string nota1, double nota2)
        {
            media = (Convert.ToDouble(nota1) + nota2) / 2;
            Console.WriteLine("public void Calcular(string nota1, double nota2)");
        }

        public static void Calcular(double nota1, double nota2)
        {
            media = (nota1 + nota2) / 2;
            Console.WriteLine("public void Calcular(double nota1, double nota2)");
        }

        
    }
}
