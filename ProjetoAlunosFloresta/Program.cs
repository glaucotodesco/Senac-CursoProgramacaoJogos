using System;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(@". * . * . * . * . * . * . * . * . * . * . * . * . * . * . * . * . * . * . * . * . * . * . * . * . * .
            . * . * . * . * . * . * . * . * . * . * . * . * . * . * . * . * . * . * . * . * . * . * . * . * . * .
            . * . * . * . * . * . * . * . * . * . * . * . * . * . * . * . * . * . * . * . * . * . * . * . * . * .");

            Console.Write(@"
                           ______   _______  _______  _______  _______  ___   _______  _______               
                          |      | |       ||       ||   _   ||       ||   | |       ||       |              
                          |  _    ||    ___||  _____||  |_|  ||    ___||   | |   _   ||  _____|              
                          | | |   ||   |___ | |_____ |       ||   |___ |   | |  | |  || |_____               
                          | |_|   ||    ___||_____  ||       ||    ___||   | |  |_|  ||_____  |              
                          |       ||   |___  _____| ||   _   ||   |    |   | |       | _____| |              
                          |______| |_______||_______||__| |__||___|    |___| |_______||_______|              
             ______   _______        _______  ___      _______  ______    _______  _______  _______  _______ 
            |      | |   _   |      |       ||   |    |       ||    _ |  |       ||       ||       ||   _   |
            |  _    ||  |_|  |      |    ___||   |    |   _   ||   | ||  |    ___||  _____||_     _||  |_|  |
            | | |   ||       |      |   |___ |   |    |  | |  ||   |_||_ |   |___ | |_____   |   |  |       |
            | |_|   ||       |      |    ___||   |___ |  |_|  ||    __  ||    ___||_____  |  |   |  |       |
            |       ||   _   |      |   |    |       ||       ||   |  | ||   |___  _____| |  |   |  |   _   |
            |______| |__| |__|      |___|    |_______||_______||___|  |_||_______||_______|  |___|  |__| |__|

                                                                                                                ");


            Console.WriteLine(@"
            ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ 
            ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~");



            Console.Write(@"

                    _ \                         _)                          ____|         |               
                   |   |   __|  _ \   __|   __|  |   _ \   __ \    _ \      __|    __ \   __|   _ \   __| 
                   ___/   |     __/ \__ \ \__ \  |  (   |  |   |   __/      |      |   |  |     __/  |    
                  _|     _|   \___| ____/ ____/ _| \___/  _|  _| \___|     _____| _|  _| \__| \___| _|

                                                                                                        ");

            Console.ReadKey();

            Console.Clear();

            string msg = @"HISTÓRIA.......
Um grupo de pessoas entrou em uma floresta tropical na América do Sul, eles estavam em busca de um tesouro indígena,
mas essa floresta nunca foi explorada antes então eles se perderam !
Seu objetivo: encontrar a saída desse labirinto natural !
            BOA SORTE!";

            foreach (char letra in msg.ToCharArray())
            {
                Console.Write(letra);
                Thread.Sleep(50);
            }

            Console.WriteLine("\n" + "\n");

            int posicao1 = 1, posicao2 = 1, dado = 0, quantplayer, turno = 1;
            bool perdeup1 = false, perdeup2 = false;
            string history1 = "1 ", player1, player2, history2 = "1 ", vresp;


            do
            {
                posicao1 = 1;
                posicao2 = 1;
                turno = 1;
                history1 = "1 ";
                history2 = "1 ";
                Console.WriteLine("QUANTOS PLAYERS JOGARÃO ? (1-2)");
                quantplayer = int.Parse(Console.ReadLine());
                Console.Clear();

                while (quantplayer < 1 || quantplayer > 2)
                {
                    Console.WriteLine("Esse valor é inválido !!");
                    Console.WriteLine("Por favor digite o valor correto!(1-2)");
                    quantplayer = int.Parse(Console.ReadLine());
                    Console.Clear();
                }
                if (quantplayer == 1)
                {
                    Console.WriteLine("Qual seu nome jogador(a)? ");
                    player1 = Console.ReadLine();
                    player2 = "0";
                    Console.Clear();
                    Console.WriteLine("\nBem-vindo(a) jogador(a) " + player1 + "!\n");
                    DesenhaHUD(dado, posicao1, history1);
                    DesenhaTabuleiro(posicao1);

                    while (posicao1 != 50 && posicao1 != -1)
                    {
                        dado = SorteiaDado();
                        Console.Clear();
                        posicao1 += dado;
                        posicao1 = VerificaPosicao(posicao1);
                        posicao1 = SorteOuAzar(posicao1, dado);
                        posicao1 = Cartas(posicao1, dado, turno, player1, player2, history1, history2, quantplayer);
                        history1 += posicao1 + " ";
                        DesenhaHUD(dado, posicao1, history1);
                        DesenhaTabuleiro(posicao1);
                    }

                    if (posicao1 == 50)
                    {
                        Console.Clear();
                        Console.WriteLine("\nPARABÉNS !!! VOCÊ GANHOU JOGADOR(A) " + player1 + "!");
                        msg = @"Fim da Hitória.....
                        Depois de muitos desafios você foi o unico sobrevivente nesse labirinto. Você encontra um Baú Dourado acreditando ser o Tesouro que você e seus amigos tanto almejavam, 
                        abrindo o Baú sai uma luz muito forte e depois de alguns segundos se acostumando com ela você pega um Cranio Dourado.
                        Você vende o Crânio Dourado e vive sua vida em uma mansão em Las Vegas.";
                        foreach (char letra in msg.ToCharArray())
                        {
                            Console.Write(letra);
                            Thread.Sleep(50);
                        }
                        Console.WriteLine("\n" + "\n");
                    }

                }
                if (quantplayer == 2)
                {
                    Console.WriteLine("Qual seu nome Player1? ");
                    player1 = Console.ReadLine();
                    Console.WriteLine("Qual seu nome Player2? ");
                    player2 = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("\nBem-vindo(a) Jogador(a) " + player1 + " e Jogador(a) " + player2 + "!\n");
                    DesenhaHUD2(dado, posicao1, posicao2, history1, history2, player1, player2);
                    DesenhaTabuleirop2(posicao1, posicao2, player1, player2);

                    while (posicao1 != 50 && posicao2 != 50 && posicao1 != -1 && posicao2 != -1)
                    {
                        dado = SorteiaDado2(turno, player1, player2);
                        Console.Clear();
                        if (turno == 1)
                        {
                            posicao1 += dado;
                            posicao1 = VerificaPosicao(posicao1);
                            posicao1 = SorteOuAzar(posicao1, dado);
                            DesenhaHUD2(dado, posicao1, posicao2, history1, history2, player1, player2);
                            DesenhaTabuleirop2(posicao1, posicao2, player1, player2);

                            if (Perdeuvez(posicao1))
                            {
                                Console.WriteLine("\n***Player " + player1 + " Perdeu a vez***");
                                perdeup1 = true;
                            }
                            history1 += posicao1 + " ";

                            if (perdeup2)
                            {
                                perdeup2 = false;
                            }
                            else
                            {
                                turno = 2;
                            }
                        }
                        else
                        {
                            posicao2 += dado;
                            posicao2 = VerificaPosicao(posicao2);
                            posicao2 = SorteOuAzar(posicao2, dado);
                            DesenhaHUD2(dado, posicao1, posicao2, history1, history2, player1, player2);
                            DesenhaTabuleirop2(posicao1, posicao2, player1, player2);
                            if (Perdeuvez(posicao2))
                            {
                                Console.WriteLine("\n***Player " + player2 + " Perdeu a vez***");
                                perdeup2 = true;
                            }
                            history2 += posicao2 + " ";

                            if (perdeup1)
                            {
                                perdeup1 = false;
                            }
                            else
                            {
                                turno = 1;
                            }
                        }
                        if (posicao1 == 50)
                        {
                            Console.Clear();
                            Console.WriteLine("\nPARABÉNS !!! VOCÊ GANHOU JOGADOR(A) " + player1 + "!");
                            msg = @"Fim da Hitória.....
                   Depois de muitos desafios você foi o único sobrevivente nesse labirinto. Você encontra um Baú Dourado acreditando ser o Tesouro que você e seus amigos 
                   tanto almejavam, abrindo o Baú sai uma luz muito forte e depois de alguns segundos se acostumando com ela você pega um Cranio Dourado.
                   Você vende o Cranio Dourado e vive sua vida em uma mansão em Las Vegas.";
                            foreach (char letra in msg.ToCharArray())
                            {
                                Console.Write(letra);
                                Thread.Sleep(50);
                            }
                            Console.WriteLine("\n" + "\n");
                        }
                        if (posicao2 == 50)
                        {
                            Console.Clear();
                            Console.WriteLine("\nPARABÉNS !!! VOCÊ GANHOU JOGADOR(A) " + player2 + "!");
                            msg = @"Fim da Hitória.....
                            Depois de muitos desafios você foi o unico sobrevivente nesse labirinto. Você encontra um Baú Dourado acreditando ser o Tesouro que você e seus amigos 
                            tanto almejavam, abrindo o Baú sai uma luz muito forte e depois de alguns segundos se acostumando com ela você pega um Cranio Dourado.
                            Você vende o Cranio Dourado e vive sua vida em uma mansão em Las Vegas.";
                            foreach (char letra in msg.ToCharArray())
                            {
                                Console.Write(letra);
                                Thread.Sleep(50);
                            }
                            Console.WriteLine("\n" + "\n");
                        }
                    }
                }

                Console.WriteLine("\nDeseja Continuar Jogando ? (s/n)");
                vresp = Console.ReadLine();
                Console.Clear();


            } while (vresp.ToLower().Equals("s"));



            static int Cartas(int posicao1, int dado, int turno, string player1, string player2, string history1, string history2, int quantplayer)
            {
                int SorteiaCarta;
                Random r = new Random();
                SorteiaCarta = r.Next(1, 10);
                if (posicao1 == 3 || posicao1 == 10 || posicao1 == 22 || posicao1 == 36 || posicao1 == 41)
                {
                    if (SorteiaCarta == 1)
                    {
                        Console.WriteLine(@" 
                           =--------------------------------------=
                           |                SORTE!                |
                           '--------------------------------------'
                           |                                      |   
                           | Você achou um mapa e conseguiu andar |   
                           |  melhor pelo lugar, por isso andou   |
                           |     2x o número sorteado no dado     |
                           |                                      |
                           `--------------------------------------'`
                             
                           ");
                        posicao1 = posicao1 + (dado + dado) - dado;
                    }
                    if (SorteiaCarta == 2)
                    {
                        Console.WriteLine(@" 
                           =--------------------------------------=
                           |                AZAR!                 |
                           '--------------------------------------'
                           |                                      |   
                           |  Começou a chover e isso atrapalhou  |
                           |     sua caminhada, por isso você     |
                           |        andará uma casa a menos.      |
                           |                                      |
                           `--------------------------------------'`      
                           ");
                        posicao1 = posicao1 - 1;
                    }
                    if (SorteiaCarta == 3)
                    {
                        Console.WriteLine(@"                       
                           =--------------------------------------=
                           |                AZAR!                 |
                           '--------------------------------------'
                           |                                      |   
                           |   Você brigou com um nativo e teve   |
                           |     que correr, por isso retornou    |
                           |         para a primeira casa!        |
                           |                                      |
                           `--------------------------------------'`
                           ");
                        posicao1 = 1;
                    }
                    if (SorteiaCarta == 4)
                    {
                        Console.WriteLine(@"                                                                                                                                                
                           =--------------------------------------=
                           |                SORTE!                |
                           '--------------------------------------'
                           |                                      |   
                           |  Você encontrou um cipó e conseguiu  |
                           |           avançar 5 casas!           |   
                           |                                      |
                           `--------------------------------------'`
                           ");
                        posicao1 = posicao1 + 5;
                    }
                    if (SorteiaCarta == 5)
                    {
                        Console.WriteLine(@"                                                                                                                                                                                                                                                                                      
                           =--------------------------------------=
                           |                SORTE!                |
                           '--------------------------------------'
                           |                                      |   
                           |       Você usou seu facão e          | 
                           |          avançou 2 casas!            |   
                           |                                      |
                           `--------------------------------------'`
                           ");
                        posicao1 = posicao1 + 2;
                    }
                    if (SorteiaCarta == 6)
                    {
                        Console.WriteLine(@"                                                       
                           =--------------------------------------=
                           |                SORTE!                |
                           '--------------------------------------'
                           |                                      |   
                           |  Você encontrou um guarda florestal  | 
                           |       e ele te ajudou, por isso      | 
                           |             ande 2 casas.            |   
                           |                                      |
                           `--------------------------------------'`
                           ");
                        posicao1 = posicao1 + 2;
                    }
                    if (SorteiaCarta == 7)
                    {
                        Console.WriteLine(@" 
                           =--------------------------------------=
                           |                AZAR!                 |
                           '--------------------------------------'
                           |                                      |   
                           |   Você percebeu que estava andando   |  
                           |       em círculos, por isso teve     | 
                           |           retornar 4 casas.          |                     
                           |                                      |
                           `--------------------------------------'`      
                           ");
                        posicao1 = posicao1 - 4;
                    }
                    if (SorteiaCarta == 8)
                    {
                        Console.WriteLine(@"                                                                       
                           =--------------------------------------=
                           |             GAME OVER !              | 
                           '--------------------------------------'
                           |                                      |   
                           |    Você foi picado por uma cobra     | 
                           |       e morreu: O jogo acabou !      | 
                           |                                      |
                           `--------------------------------------'`
                           ");
                        if (Morte(turno, player1, player2, quantplayer))
                        {
                            posicao1 = -1;
                        }

                    }
                    if (SorteiaCarta == 9)
                    {
                        Perdeuvez(posicao1);
                    }
                }
                return posicao1;

            }
            static int SorteOuAzar(int posicao1, int dado)
            {
                string msg = "";
                if (posicao1 == 13 || posicao1 == 19 || posicao1 == 15 || posicao1 == 31 || posicao1 == 47)
                {
                    Console.WriteLine(@"                       
                           =--------------------------------------=
                           |                AZAR!                 |
                           '--------------------------------------'
                           |                                      |   
                           |   Você estava andando pelo caminho   |
                           |   errado, por isso precisou voltar   |
                           |                3 casas!              |
                           |                                      |
                           `--------------------------------------'`
                           ");
                    posicao1 = posicao1 - 3;
                }

                if (posicao1 == 4 || posicao1 == 12 || posicao1 == 20 || posicao1 == 30 || posicao1 == 45)
                {

                    Console.WriteLine(@"                       
                           =--------------------------------------=
                           |               SORTE!                 |
                           '--------------------------------------'
                           |                                      |   
                           |   Você estava andando e encontrou    |
                           |   uma trilha, por isso pode avançar  |
                           |                3 casas!              |
                           |                                      |
                           `--------------------------------------'`
                           ");
                    posicao1 = posicao1 + 3;
                }
                if (msg.Length > 0)
                {
                    Console.WriteLine(msg);
                }
                return posicao1;
            }
            static int VerificaPosicao(int posicao1)
            {
                if (posicao1 > 50)
                {
                    posicao1 = 50 - (posicao1 - 50);
                }
                return posicao1;
            }
            static int SorteiaDado()
            {
                int dado;
                Random r = new Random();
                Console.WriteLine("\n\nPara Jogar o Dado Pressione Enter !!!");
                Console.ReadKey();
                dado = r.Next(1, 7);
                return dado;
            }
            static void DesenhaHUD(int dado, int posicao1, string history)
            {
                if (dado != 0)
                {
                    Console.WriteLine("O Número Sorteado no Dado foi: " + dado);
                    Console.WriteLine("Sua posição é: " + posicao1);
                }
                else
                {
                    Console.WriteLine("O Número Sorteado no Dado foi:");
                    Console.WriteLine("Sua posição é: " + posicao1);
                }
                Console.WriteLine("Histórico de posições: " + history);
            }
            static void DesenhaTabuleiro(int posicao1)
            {
                int desenha = 1;
                Console.WriteLine("");
                Console.Write("Tabuleiro: ");
                while (desenha <= 50)
                {
                    if (desenha == posicao1)
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
            static bool Morte(int turno, string player1, string player2, int quantplayer)
            {
                if (quantplayer == 1)
                {
                    Console.WriteLine("\nEita ! Você Perdeu !! " + player1);
                    return true;
                }

                if (quantplayer == 2)
                {
                    if (turno == 1)
                    {
                        Console.WriteLine("\nQue Pena Você Perdeu  " + player1 + " !! ");
                        Console.WriteLine("\nPARABÉNS !!! VOCÊ GANHOU JOGADOR(A) " + player2 + "!");
                        string msg = @"Fim da Hitória.....
Depois de muitos desafios você foi o unico sobrevivente nesse labirinto. Você encontra um Baú Dourado acreditando ser o Tesouro que você e seus amigos tanto almejavam, 
abrindo o Baú sai uma luz muito forte e depois de alguns segundos se acostumando com ela você pega um Crânio Dourado.
Você vende o Crânio Dourado e vive sua vida em uma mansão em Las Vegas.";
                        foreach (char letra in msg.ToCharArray())
                        {
                            Console.Write(letra);
                            Thread.Sleep(50);
                        }
                        Console.WriteLine("\n" + "\n");
                        return true;

                    }
                    if (turno == 2)
                    {
                        Console.WriteLine("Que Pena Você Perdeu  " + player2 + " !! ");
                        Console.WriteLine("\nPARABÉNS !!! VOCÊ GANHOU JOGADOR(A) " + player1 + "!");
                        string msg = @"Fim da Hitória.....
Depois de muitos desafios você foi o unico sobrevivente nesse labirinto. Você encontra um Baú Dourado acreditando ser o Tesouro que você e seus amigos tanto almejavam, 
abrindo o Baú sai uma luz muito forte e depois de alguns segundos se acostumando com ela você pega um Cranio Dourado.
Você vende o Crânio Dourado e vive sua vida em uma mansão em Las Vegas.";
                        foreach (char letra in msg.ToCharArray())
                        {
                            Console.Write(letra);
                            Thread.Sleep(50);
                        }
                        Console.WriteLine("\n" + "\n");
                        return true;
                    }
                }
                return false;

            }

            //
            //
            //Começo código 2 players
            //
            //

            static int SorteOuAzar2(int posicao)
            {
                string msg = "";
                if (posicao == 13 || posicao == 19 || posicao == 15 || posicao == 31 || posicao == 47)
                {
                    msg = "Azar: Você caiu na posição " + posicao + " teve que voltar 3 casas";
                    posicao = posicao - 3;
                }

                if (posicao == 4 || posicao == 12 || posicao == 20 || posicao == 30 || posicao == 45)
                {
                    msg = "Sorte: Você caiu na posição " + posicao + " e avançou 3 casas!";
                    posicao = posicao + 3;
                }
                if (msg.Length > 0)
                {
                    Console.WriteLine(msg);
                }
                return posicao;
            }
            static int VerificaPosicao2(int posicao)
            {
                if (posicao > 50)
                {
                    posicao = 50 - (posicao - 50);
                }
                return posicao;
            }
            static int SorteiaDado2(int turno, string player1, string player2)
            {
                int dado;
                Random r = new Random();
                if (turno == 1)
                {
                    Console.WriteLine("\nTurno do " + player1);
                }
                else
                {
                    Console.WriteLine("\nTurno do " + player2);
                }
                Console.WriteLine("\n\nAperte ENTER para lançar o dado!");
                Console.ReadKey();
                dado = r.Next(1, 7);
                return dado;
            }
            static void DesenhaTabuleirop2(int posicao1, int posicao2, string player1, string player2)
            {
                int desenha = 1;
                Console.WriteLine("");
                Console.Write("Tabuleiro: ");
                while (desenha <= 50)
                {
                    if (desenha == posicao1 && desenha == posicao2)
                    {
                        Console.Write("[O]");
                    }
                    else
                    {
                        if (desenha == posicao1)
                        {
                            Console.Write("[" + player1 + "]");
                        }
                        else
                        {
                            if (desenha == posicao2)
                            {
                                Console.Write("[" + player2 + "]");
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
            static void DesenhaHUD2(int dado, int posicao1, int posicao2, string history1, string history2, string player1, string player2)
            {
                Console.WriteLine("O número sorteado no dado foi: " + dado);
                Console.WriteLine("A posição do player " + player1 + " é: " + posicao1);
                Console.WriteLine("A posição do player " + player2 + " é: " + posicao2);
                Console.WriteLine("Histórico de posições " + player1 + " é: " + history1);
                Console.WriteLine("Histórico de posições " + player2 + " é: " + history2);
            }
            static bool Perdeuvez(int posicao1)
            {
                if (posicao1 == 3 || posicao1 == 10 || posicao1 == 22 || posicao1 == 36 || posicao1 == 41)
                {
                    Console.WriteLine(@" 
                           =--------------------------------------=
                           |                AZAR!                 |
                           '--------------------------------------'
                           |                                      |   
                           |     Você tropeçou e se machucou,     |  
                           |   por isso não jogará por uma rodada.|                  
                           |                                      |
                           `--------------------------------------'`      
                           ");
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

