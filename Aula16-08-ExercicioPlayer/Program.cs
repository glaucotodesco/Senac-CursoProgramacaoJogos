using System;

namespace Aula16_08_EntradaDeDados
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            Console.WriteLine("Digite o nome do player: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite o poder do player: (De 1 à 10)");
            double poder        = double.Parse(Console.ReadLine());
            double magia        = (10 - poder) / 2;
            double resistencia  = (10 - poder);
            double inteligencia = r.NextDouble()*10;

            Console.WriteLine("Dados do player");
            Console.WriteLine("Nome........: " + nome);
            Console.WriteLine("Poder.......: " + poder.ToString("N2"));
            Console.WriteLine("Magia.......: " + magia.ToString("N2"));
            Console.WriteLine("Resistência.: " + resistencia.ToString("N2"));
            Console.WriteLine("Inteligência: " + inteligencia.ToString("N2"));







        }
    }
}
