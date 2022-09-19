using System;

namespace CursoProgramação
{
    class Program
    {
        static void Main(string[] args)
        {
            int cartaPC1, cartaPC2, cartaPC3, cartaEscolhida = 0;
            int[] cartasPlayer = new int[3];

            int vitóriaPC = 0, totalPC = 0, totalPlayer = 0, placarPC = 0, placarPLAYER = 0, truco = 0;

            Console.WriteLine("*****Truco Adaptado*****");
            Console.WriteLine("Aperte Enter para iniciar.");
            Console.ReadLine();

            while (placarPC < 12 && placarPLAYER < 12)
            {
                vitóriaPC = 0;
                totalPC = 0;
                totalPlayer = 0;
                truco = 0;

                Console.Clear();
                Random r = new Random();

                cartasPlayer[0] = r.Next(1, 11);
                cartasPlayer[1] = r.Next(1, 11);
                cartasPlayer[2] = r.Next(1, 11);

                cartaPC1 = r.Next(1, 11);
                cartaPC2 = r.Next(1, 11);
                cartaPC3 = r.Next(1, 11);


                Console.WriteLine("PlacarPlayer: " + placarPLAYER + " | PlacarPC: " + placarPC);
                Console.WriteLine("\nAperte Enter para embaralhar as cartas e começar");
                Console.ReadLine();
                Console.Write("Suas cartas são: " + "carta um = " + cartasPlayer[0] + ", carta dois = " + cartasPlayer[1] + ", carta três = " + cartasPlayer[2]);





                Console.Write("\nQuem começa é o PC\n");

                {




                    if (VerificaTrucoPC(cartaPC1, cartaPC2, cartaPC3))
                    {
                        Console.WriteLine("Truco");
                        Console.WriteLine("1.Aceitar   2.não? ");
                        truco = int.Parse(Console.ReadLine());
                    }
                    if (truco == 2)
                    {
                        Console.WriteLine("fim da Partida! Ponto PC!!!");
                        Console.WriteLine("\nPC ganhou a partida!!!");
                        placarPC++;
                        Console.WriteLine("Ir pra próxima partida");
                        Console.ReadLine();
                    }

                    else
                    {
                        Console.WriteLine("Carta jogada pelo pc: " + cartaPC1);
                        Console.WriteLine("Escolha " + "1" + ", " + "2" + " ou " + "3" + " para jogar a sua carta\n");
                        Console.Write("Digite: ");
                        cartaEscolhida = int.Parse(Console.ReadLine());
                        Console.WriteLine("\nCarta jogada Player:  " + cartasPlayer[cartaEscolhida - 1]);


                        if (cartasPlayer[cartaEscolhida - 1] == cartaPC1)
                        {
                            Console.WriteLine("Empate! Ponto do PC. ");
                            vitóriaPC = 1;
                            totalPC++;
                        }
                        else
                        {
                            if (cartasPlayer[cartaEscolhida - 1] > cartaPC1)
                            {
                                Console.WriteLine("Sua carta é maior! Você ganhou a primeira rodada. ");
                                totalPlayer++;
                            }
                            else
                            {
                                Console.WriteLine("Sua carta é menor! Você perdeu a primeira rodada. ");
                                vitóriaPC = 1;
                                totalPC++;
                            }
                        }




                        //Comeca a segunda rodada
                        if (vitóriaPC == 0)
                        {
                            Console.WriteLine("\nPlayer começa!");
                            Console.WriteLine("Escolha " + "1" + ", " + "2" + " ou " + "3" + " para jogar a sua carta\n");
                            Console.Write("Digite: ");
                            cartaEscolhida = int.Parse(Console.ReadLine());

                            Console.WriteLine("Carta jogada pelo pc: " + cartaPC2);


                        }
                        else
                        {
                            Console.WriteLine("\nPC começa!");
                            Console.WriteLine("Carta jogada pelo pc: " + cartaPC2);
                            Console.WriteLine("Escolha " + "1" + ", " + "2" + " ou " + "3" + " para jogar a sua carta\n");
                            Console.Write("Digite: ");
                            cartaEscolhida = int.Parse(Console.ReadLine());
                        }

                        Console.WriteLine("\nCarta jogada Player:  " + cartasPlayer[cartaEscolhida - 1]);


                        if (cartasPlayer[cartaEscolhida - 1] == cartaPC2)
                        {
                            Console.WriteLine("Empate! Ponto do PC. ");
                            vitóriaPC = 1;
                            totalPC++;
                        }
                        else
                        {
                            if (cartasPlayer[cartaEscolhida - 1] > cartaPC2)
                            {
                                Console.WriteLine("Sua carta é maior! Você ganhou a segunda rodada. ");
                                totalPlayer++;
                            }
                            else
                            {
                                Console.WriteLine("Sua carta é menor! Você perdeu a segunda rodada. ");
                                vitóriaPC = 1;
                                totalPC++;
                            }
                        }
                        if (totalPC == 2 && truco == 1)
                        {
                            Console.WriteLine("\nPC ganhou a partida!!!");
                            placarPC = placarPC + 3;

                            Console.WriteLine("Ir pra próxima partida");
                            Console.ReadLine();
                        }
                        else
                        {
                            if (totalPlayer == 2 && truco == 1)
                            {
                                Console.WriteLine("\nPlayer ganhou a partida!!!");
                                placarPLAYER = placarPLAYER + 3;

                                Console.WriteLine("Ir pra próxima partida");
                                Console.ReadLine();
                            }
                            else
                            {
                                if (totalPC == 2)
                                {
                                    Console.WriteLine("\nPC ganhou a partida!!!");
                                    placarPC++;
                                    Console.WriteLine("Ir pra próxima partida");
                                    Console.ReadLine();
                                }
                                else
                                {
                                    if (totalPlayer == 2)
                                    {
                                        Console.WriteLine("\nplayer ganhou a partida!!!");
                                        placarPLAYER++;
                                        Console.WriteLine("Ir pra próxima partida");
                                        Console.ReadLine();
                                    }
                                }
                            }
                        }


                        if (totalPlayer == 2 || totalPC == 2)
                        {
                            Console.WriteLine("12 pontos!!!");
                        }
                        else
                        {
                            //Comeca a terceira rodada
                            if (vitóriaPC == 0)
                            {
                                Console.WriteLine("\nPlayer começa!");
                                Console.WriteLine("\nEscolha " + "1" + ", " + "2" + " ou " + "3" + " para jogar a sua carta\n");
                                Console.Write("Digite: ");
                                cartaEscolhida = int.Parse(Console.ReadLine());
                                Console.WriteLine("\nCarta jogada pelo pc: " + cartaPC3);
                            }
                            else
                            {
                                Console.WriteLine("\nPC começa!");
                                Console.WriteLine("Carta jogada pelo pc: " + cartaPC3);
                                Console.WriteLine("\nEscolha " + "1" + ", " + "2" + " ou " + "3" + " para jogar a sua carta\n");
                                Console.Write("Digite: ");
                                cartaEscolhida = int.Parse(Console.ReadLine());
                            }

                            Console.WriteLine("\nCarta jogada Player:  " + cartasPlayer[cartaEscolhida - 1]);


                            if (cartasPlayer[cartaEscolhida - 1] == cartaPC3)
                            {
                                Console.WriteLine("Empate! Ponto do PC. ");
                                vitóriaPC = 1;
                                totalPC++;
                            }
                            else
                            {
                                if (cartasPlayer[cartaEscolhida - 1] > cartaPC3)
                                {
                                    Console.WriteLine("Sua carta é maior! Você ganhou a terceira rodada. ");
                                    totalPlayer++;
                                }
                                else
                                {
                                    Console.WriteLine("Sua carta é menor! Você perdeu a terceira rodada. ");
                                    vitóriaPC = 1;
                                    totalPC++;
                                }
                            }

                            if (totalPC == 2 && truco == 1)
                            {
                                Console.WriteLine("\nPC ganhou a partida!!!");
                                placarPC = placarPC + 3;
                                Console.WriteLine("Ir pra próxima partida");
                                Console.ReadLine();
                            }
                            else
                            {
                                if (totalPlayer == 2 && truco == 1)
                                {
                                    Console.WriteLine("\nPlayer ganhou a partida!!!");
                                    placarPLAYER = placarPLAYER + 3;
                                    Console.WriteLine("Ir pra próxima partida");
                                    Console.ReadLine();
                                }
                                else
                                {
                                    if (totalPC == 2)
                                    {
                                        Console.WriteLine("\nPC ganhou a partida!!!");
                                        placarPC++;
                                        Console.WriteLine("Ir pra próxima partida");
                                        Console.ReadLine();
                                    }
                                    else
                                    {
                                        if (totalPlayer == 2)
                                        {
                                            Console.WriteLine("\nplayer ganhou a partida!!!");
                                            placarPLAYER++;
                                            Console.WriteLine("Ir pra próxima partida");
                                            Console.ReadLine();
                                        }
                                    }
                                }
                            }
                        }
                    }



                }




            }








            if (placarPLAYER == 12)
            {
                Console.WriteLine("\nO JOGADOR VENCEU O JOGO!!!");
            }
            if (placarPC == 12)
            {
                Console.WriteLine("\nO PC VENCEU O JOGO!!!");
            }

        }


        public static bool VerificaTrucoPC(int cartaPC1, int cartaPC2, int cartaPC3)
        {

            if (cartaPC1 + cartaPC2 + cartaPC3 > 5)
            {
                return true;
            }
            else
            {
                if (cartaPC1 + cartaPC2 + cartaPC3 < 50)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }


        }
    }
}

