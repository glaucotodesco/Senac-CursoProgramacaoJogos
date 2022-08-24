using System;


/*
 *   Jogo de tabuleiro.
 * 
 *  Tabuleiro tem 20 casas (Em linha).
 *  O player começa na casa 1.
 *  Ao pressionar enter lançar o dado. 
 *  Mostrar resultado do dado e em que casa você vai parar.
 *  Andar as casas conforme o dado.
 *  Criar regras para avançar ou voltar casas.
 *  Exemplo: Se cair a casa 13, voltar para a casa 1.
 *  
 *  Finalizar o jogo quando o player chegar exatamente na casa 20.
 *  Exemplos:
 *  Você esta na casa 17: se o dado sortear 3, 
 *                        você ganhou e finaliza o jogo
 *  Você esta na casa 17: se o dado sortear 5, 
 *                        você vai até a casa 20 e volta para a casa 18.
 *  Você esta na casa 17: se o dado sortear 2, 
 *                        você vai para a casa casa 19.
 *  
 */

namespace Aula23_08_Exercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int posicao = 1, dado=0, desenha;
            
          

            while (posicao != 20)
            {
                Console.Clear();

                if (dado != 0)
                {
                    Console.WriteLine("Dado: " + dado);
                    Console.WriteLine("Posição: " + posicao);
                }
                else
                {
                    Console.WriteLine("Dado:");
                    Console.WriteLine("Posição: " + posicao );
                }

                desenha = 1;
                
                while (desenha <= 20)
                {

                    if (desenha == posicao)
                    {
                        Console.Write("[X]");
                    }
                    else
                    {
                        Console.Write("[ ]");
                    }
                    desenha++;
                }

                Console.WriteLine("\n\nTecle ENTER para lançar o dado!");
                Console.ReadKey();
                dado = r.Next(1, 7);
                posicao += dado;
                
                if (posicao > 20)
                {
                    posicao = 20  - (posicao - 20);
                }
            }

            Console.Clear();
            Console.WriteLine("Você venceu!");
            desenha = 1;
            while (desenha <= 20)
            {

                if (desenha == posicao)
                {
                    Console.Write("[X]");
                }
                else
                {
                    Console.Write("[ ]");
                }
                desenha++;
            }
            Console.WriteLine("\nFIM");
        }

    }
    
}
