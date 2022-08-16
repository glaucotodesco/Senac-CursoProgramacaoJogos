using System;

namespace Aula15_08_ExercicioMegaSena
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            Console.WriteLine("Mega Sena Aposta Versão 1.0");
            Console.WriteLine("");
            Console.Write("Aposta: ");
            Console.Write(r.Next(1,  10) + ", ");
            Console.Write(r.Next(10, 20) + ", ");
            Console.Write(r.Next(20, 30) + ", ");
            Console.Write(r.Next(30, 40) + ", ");
            Console.Write(r.Next(40, 50) + ", ");
            Console.Write(r.Next(50, 61) + ".");
            Console.WriteLine("");





        }
    }
}
