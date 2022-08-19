using System;

namespace Aula18_08_BatalhaNaval
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int tiro;
            int navio = r.Next(2, 10);
            int navioParte1 = navio - 1;
            int navioParte2 = navio;
            int navioParte3 = navio + 1;

            //Console.WriteLine("Posicao do navio: " + (navioParte1) + ", " + navioParte2 + " e " + (navioParte3));


            Console.WriteLine("Digite a posição do tiro: 1 à 10");
            tiro = int.Parse(Console.ReadLine());

            if (tiro >= navioParte1 && tiro <= navioParte3)
            {
                Console.WriteLine("Acertou! Você venceu");
            }
            else
            {
                Console.WriteLine("Água!");
                Console.WriteLine("Digite a posição do tiro: 1 à 10");
                tiro = int.Parse(Console.ReadLine());

                if (tiro >= navioParte1 && tiro <= navioParte3)
                {
                    Console.WriteLine("Acertou! Você venceu");
                }
                else
                {
                    Console.WriteLine("Água!");
                    Console.WriteLine("Digite a posição do tiro: 1 à 10");
                    tiro = int.Parse(Console.ReadLine());
                    if (tiro >= navioParte1 && tiro <= navioParte3)
                    {
                        Console.WriteLine("Acertou! Você venceu");
                    }
                    else
                    {
                        Console.WriteLine("Fim de jogo! Você perdeu!");
                        Console.WriteLine("Posicao do navio: " + (navioParte1) + ", " + navioParte2 + " e " + (navioParte3));

                    }
                }
            }

            


        }
    }
}
