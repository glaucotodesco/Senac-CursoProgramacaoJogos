using System;

namespace Aula15_08_OperadoresMatematicos
{
    class Program
    {
        static void Main(string[] args)
        {
            //double num1, num2, resp;
            int num1, num2, resp;

            num1 = 8;
            num2 = 3;

            resp = num1 + num2;
            Console.WriteLine("Soma = " + resp);
            
            resp = num1 - num2;
            Console.WriteLine("Subtração = " + resp);
            
            resp = num1 * num2;
            Console.WriteLine("Multiplicação = " + resp);
            
            resp = num1 / num2;
            Console.WriteLine("Divisão = " + resp);
            Console.WriteLine("Divisão = " + (8   /   3));
            Console.WriteLine("Divisão = " + (8.0 / 3.0));
            Console.WriteLine("Divisão = " + (8.0 / 3  ));
            Console.WriteLine("Divisão = " + (8   / 3.0));


        }
    }
}
