using System;

namespace Aula16_08_Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor;

            Console.WriteLine("Digite um valor inteiro: ");
            valor = int.Parse(Console.ReadLine());

            Console.WriteLine("Antecessor: " + (valor - 1  ));
            Console.WriteLine("Sucessor..: " + (valor + 1  ));
            Console.WriteLine("Dobro.....: " + (valor * 2  ));
            Console.WriteLine("Metade....: " + (valor / 2.0));
        }
    }
}
