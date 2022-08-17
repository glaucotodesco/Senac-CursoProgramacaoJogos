using System;

namespace Aula16_08_ExercicioCalculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, resp;

            Console.Write("Digite o primeiro número: ");
            num1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            num2 = double.Parse(Console.ReadLine());

            resp = num1 + num2;
            Console.WriteLine("num1 + num2 = " + resp.ToString("N2"));
            
            resp = num1 - num2;
            Console.WriteLine("num1 - num2 = " + resp.ToString("N2"));

            resp = num1 * num2;
            Console.WriteLine("num1 * num2 = " + resp.ToString("N2"));

            resp = num1 / num2;
            Console.WriteLine("num1 / num2 = " + resp.ToString("N2"));
        }
    }
}
