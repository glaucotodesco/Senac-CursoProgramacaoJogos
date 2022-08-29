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
         
            int posicao = 1, dado=0; 
            string history="1 ";

            DesenhaHUD(dado, posicao, history);
            DesenhaTabuleiro(posicao);

            while (posicao != 20)
            {
                dado = SorteiaDado();
                Console.Clear();
                posicao += dado;
                posicao = VerificaPosicao(posicao);
                posicao = VerificaSorteOuAzar(posicao);
                history += posicao + " ";
                DesenhaHUD(dado, posicao, history);
                DesenhaTabuleiro(posicao);
            }

            DesenhaFimDeJogo(posicao);
        }


        static void DesenhaFimDeJogo(int posicao)
        {
            Console.Clear();
            Console.WriteLine("\nVocê venceu!");
            DesenhaTabuleiro(posicao);
            Console.WriteLine("\nFIM");
        }

        static int VerificaSorteOuAzar(int posicao)
        {
            string msg="";
            if (posicao == 13 || posicao == 19)
            {
                msg = "Azar: Você caiu na posicao " + posicao + " teve que voltar para a posição 1!";
                posicao = 1;
            }
            else
            {
                if (posicao == 4 || posicao == 9)
                {
                    msg="Sorte: Você caiu na posicao " + posicao + " e avançou para a casa 18!";
                    posicao = 18;
                    
                }
            }

            if (msg.Length > 0)
            {
                Console.WriteLine(msg);
            }

            return posicao;

        }


        static int VerificaPosicao(int posicao)
        {
            if (posicao > 20)
            {
                posicao = 20 - (posicao - 20);
            }

            return posicao;
        }

        static int SorteiaDado()
        {
            int dado;
            Random r = new Random();
            Console.WriteLine("\n\nTecle ENTER para lançar o dado!");
            Console.ReadKey();
            dado =  r.Next(1, 7);
            return dado;
        }

        static void DesenhaHUD(int dado, int posicao, string history)
        {
            
            if (dado != 0)
            {
                Console.WriteLine("Dado: " + dado);
                Console.WriteLine("Posição: " + posicao);
            }
            else
            {
                Console.WriteLine("Dado:");
                Console.WriteLine("Posição: " + posicao);
            }
            Console.WriteLine("Histórico de posições: " + history);
        }

        static void DesenhaTabuleiro(int posicao)
        {
            int desenha = 1;
            Console.WriteLine("");
            Console.Write("Tabuleiro: ");
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
        }


    }
    
}
