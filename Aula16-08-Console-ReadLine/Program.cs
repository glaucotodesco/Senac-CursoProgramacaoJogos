using System;

namespace Aula16_08_Console_ReadLine
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int idade;
            double bonus;

            Console.Write("Digite o seu nome: ");
            nome = Console.ReadLine();

            Console.Write("Digite a sua idade: ");
            idade = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor do bônus: ");
            bonus = double.Parse(Console.ReadLine());

            Console.WriteLine("Boa noite " + nome + "!");
            Console.WriteLine("Sua idade: " + idade + ".");
            Console.WriteLine("Seu bônus: " + bonus + ".");



        }
    }
}
