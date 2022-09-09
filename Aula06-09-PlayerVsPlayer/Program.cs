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

namespace Aula06_09_PlayerVsPlayer
{
    class Program
    {

        static void Main(string[] args)
        {

            int posicao1 = 1, posicao2=1, dado = 0,  quemJoga =1;
            bool perdeuVezPlayer1 = false, perdeuVezPlayer2 = false;
            string history1 = "1 ", history2="1 ";

            DesenhaHUD(dado, posicao1, posicao2, history1, history2);
            DesenhaTabuleiro(posicao1, posicao2);

            while (posicao1 != 20 && posicao2 != 20)
            {
                dado = SorteiaDado(quemJoga);
              
                if(quemJoga == 1)
                {
                    posicao1 += dado;
                    posicao1 = VerificaPosicao(posicao1);
                    posicao1 = VerificaSorteOuAzar(posicao1);
                   
                    if (PerdeuAVez(posicao1))
                    {
                        Console.WriteLine("Player 1 perdeu a vez");
                        perdeuVezPlayer1 = true;
                    }
                    history1 += posicao1 + " ";
                    
                    if (perdeuVezPlayer2)
                    {
                        perdeuVezPlayer2 = false; //Repete o turno 1
                    }
                    else
                    {
                        quemJoga = 2;
                    }
                }
                else
                {
                        posicao2 += dado;
                        posicao2 = VerificaPosicao(posicao2);
                        posicao2 = VerificaSorteOuAzar(posicao2);
                        if (PerdeuAVez(posicao2))
                        {
                            Console.WriteLine("Player 2 perdeu a vez");
                            perdeuVezPlayer2 = true;
                        }
                        history2 += posicao2 + " ";

                        if (perdeuVezPlayer1)
                        {
                            perdeuVezPlayer1 = false; //Repete o turno 2
                        }
                        else
                        {
                            quemJoga = 1;
                        }
                    
                }

                
            


                DesenhaHUD(dado, posicao1, posicao2, history1, history2);
                DesenhaTabuleiro(posicao1, posicao2);
            }

            DesenhaFimDeJogo(posicao1, posicao2);
        }


        static void DesenhaFimDeJogo(int posicao1, int posicao2)
        {
            Console.Clear();
            if(posicao1 == 20)
                Console.WriteLine("\nPlayer 1 venceu!");
            else
                Console.WriteLine("\nPlayer 2 venceu!");

            DesenhaTabuleiro(posicao1, posicao2);
            Console.WriteLine("\nFIM");
        }


        static bool PerdeuAVez(int posicao)
        {
            if(posicao == 14)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static int VerificaSorteOuAzar(int posicao)
        {
            string msg = "";
            if (posicao == 13 || posicao == 19)
            {
                msg = "Azar: Você caiu na posicao " + posicao + " teve que voltar para a posição 1!";
                posicao = 1;
            }
            else
            {
                if (posicao == 4 || posicao == 9)
                {
                    msg = "Sorte: Você caiu na posicao " + posicao + " e avançou para a casa 18!";
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

        static int SorteiaDado(int turno)
        {
            int dado;
            Random r = new Random();
            if(turno == 1)
            {
                Console.WriteLine("\nTurno do player 1");
            }
            else
            {
                Console.WriteLine("\nTurno do player 2");
            }

            Console.WriteLine("\n\nTecle ENTER para lançar o dado!");
            Console.ReadKey();
            dado = r.Next(1, 7);

            return dado;
        }

        static void DesenhaHUD(int dado, int posicao1, int posicao2, string history1, string history2)
        {

            Console.WriteLine("Dado: " + dado);
            Console.WriteLine("Posição Player1: " + posicao1);
            Console.WriteLine("Posição Player2: " + posicao2);
            Console.WriteLine("Histórico de posições player 1: " + history1);
            Console.WriteLine("Histórico de posições player 2: " + history2);
        }

        static void DesenhaTabuleiro(int posicao1, int posicao2)
        {
            int desenha = 1;
            Console.WriteLine("");
            Console.Write("Tabuleiro: ");
            while (desenha <= 20)
            {

                if (desenha == posicao1 && desenha == posicao2)
                {
                    Console.Write("[0]");
                }
                else
                {
                    if(desenha == posicao1)
                    {
                        Console.Write("[X]");
                    }
                    else
                    {
                        if (desenha == posicao2)
                        {
                            Console.Write("[Y]");
                        }
                        else
                        {
                            Console.Write("[ ]");
                        }
                    }
                        
                }
                desenha++;
            }
        }


    }

}
