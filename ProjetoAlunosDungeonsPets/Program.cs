using System;

namespace JOGO_TRABALHO__
{
    class Program
    {
        //critico
        static int salvaratk = 0;
        static int salvaratk2 = 0;

        static string nome = "";
        static int vida = 0;
        static int atk = 0;
        static int def = 0;
        static int velo = 0;
        static int criticomob = 0;
        static int criticoplayer = 0;
        //HABILIDADES
        static int habilidade = 0;
        static int Venenoslime = 0;
        static int quebraarmadura = 0;
        static int rugido = 0;
        static int buraco = 0;
        static int trans = 0;

        static int Saldo = 0;
        static int faixapetra = 0, coracao = 0, bota = 0, curso = 0, seda = 0, rodas = 0, maca = 0, espada = 0, armadura = 0, super = 0, veneno = 0, espadademon = 0;
        static int ebslime = 0, ebbesta = 0, eburso = 0, ebmon = 0, ebalien = 0;
        static int mantorasgado = 0;

        //LOJA DO JOGO ()
        static int[] itens = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        static string[] itensName = {
            "(1) Faixa Preta                   |10 R$|: +2 de ATK",
            "(2) Manto Rasgado                 |12 R$|: +3 de DEF",
            "(3) Botas Vividas                 |05 R$|: +2 de VELO",
            "(4) Fazer Curso de Luta           |35 R$|: +4 de ATK",
            "(5) Coração do Mar S2             |50 R$|: +10 de HP",
            "(6) Manto de Seda Novo            |42 R$|: +5 de DEF",
            "(7) Comprar rodinhas para os pés  |50 R$|: +8 de VELO",
            "(8) MAÇA Dourada do Minecraft     |120 R$|: +15 de HP",
            "(9) Lendaria Espada =TERRA BLADE= |180 R$|: +10 de ATK",
            "(10) Armadura de FIBRA            |150 R$|: +10 de DEF",
            "(11) Superbonder de geladeira     |225 R$|: +12 de VELO",
            "(12) Armadilha de Veneno (-2 HP)  |100 R$|: +12 de VELO",
            "(13) Espada Demoniaca             |550 R$|: +15 de ATK",

            };


        static string escolhaloja = null;
        static string escolhamenu = null;
        static string escolhaluta = null;
        static int escolhafinal = 0;

        static void Main(string[] args)
        {
            //Variaveis


            string escolha = null;














            Console.WriteLine("\n");

            Console.ForegroundColor = ConsoleColor.Green;


            Console.WriteLine(@"██████╗ ██╗   ██╗███╗   ██╗ ██████╗ ███████╗ ██████╗ ███╗   ██╗███████╗    ██████╗ ███████╗████████╗███████╗
██╔══██╗██║   ██║████╗  ██║██╔════╝ ██╔════╝██╔═══██╗████╗  ██║██╔════╝    ██╔══██╗██╔════╝╚══██╔══╝██╔════╝
██║  ██║██║   ██║██╔██╗ ██║██║  ███╗█████╗  ██║   ██║██╔██╗ ██║███████╗    ██████╔╝█████╗     ██║   ███████╗
██║  ██║██║   ██║██║╚██╗██║██║   ██║██╔══╝  ██║   ██║██║╚██╗██║╚════██║    ██╔═══╝ ██╔══╝     ██║   ╚════██║
██████╔╝╚██████╔╝██║ ╚████║╚██████╔╝███████╗╚██████╔╝██║ ╚████║███████║    ██║     ███████╗   ██║   ███████║
╚═════╝  ╚═════╝ ╚═╝  ╚═══╝ ╚═════╝ ╚══════╝ ╚═════╝ ╚═╝  ╚═══╝╚══════╝    ╚═╝     ╚══════╝   ╚═╝   ╚══════╝
                                                                                                            ");

            Console.WriteLine("\n");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Blue;


            Console.WriteLine(@"░▄▀▄▀▀▀▀▄▀▄░░░░░░░░░
░█░░░░░░░░▀▄░░░░░░▄░
█░░▀░░▀░░░░░▀▄▄░░█░█
█░▄░█▀░▄░░░░░░░▀▀░░█
█░░▀▀▀▀░░░░░░░░░░░░█
█░░░░░░░░░░░░░░░░░░█
█░░░░░░░░░░░░░░░░░░█
░█░░▄▄░░▄▄▄▄░░▄▄░░█░
░█░▄▀█░▄▀░░█░▄▀█░▄▀░
░░▀░░░▀░░░░░▀░░░▀░░░");

            Console.ResetColor();
            Console.WriteLine("\n");

            Continuar();




            Console.ForegroundColor = ConsoleColor.White;


            Console.WriteLine("Você acaba de completar 10 anos, seu momento finalmente chegou !");
            Console.WriteLine("\n");
            Console.WriteLine("Você finalmente vai escolher o seu primeiro PET de Combate!");

            Console.WriteLine("\n");

            Continuar();

            Console.WriteLine(@"███████ ███████  ██████  ██████  ██      ██   ██  █████      ███████  ██████  ███    ███ ███████ ███    ██ ████████ ███████      ██ 
██      ██      ██      ██    ██ ██      ██   ██ ██   ██     ██      ██    ██ ████  ████ ██      ████   ██    ██    ██          ███ 
█████   ███████ ██      ██    ██ ██      ███████ ███████     ███████ ██    ██ ██ ████ ██ █████   ██ ██  ██    ██    █████        ██ 
██           ██ ██      ██    ██ ██      ██   ██ ██   ██          ██ ██    ██ ██  ██  ██ ██      ██  ██ ██    ██    ██           ██ 
███████ ███████  ██████  ██████  ███████ ██   ██ ██   ██     ███████  ██████  ██      ██ ███████ ██   ████    ██    ███████      ██ 
                                                                                                                                    
                                                                                                                                        ");
            Continuar();
            while (escolhafinal == 0)
            {





                Console.WriteLine(@"──────────────────────────────▓▓█───────
────────────────────────────▒██▒▒█──────
───────────────────────────█▓▓▓░▒▓▓─────
─────────────────────────▒█▓▒█░▒▒▒█─────
────────────────────────▒█▒▒▒█▒▒▒▒▓▒────
─▓▓▒░──────────────────▓█▒▒▒▓██▓▒░▒█────
─█▓▓██▓░──────────────▓█▒▒▒▒████▒▒▒█────
─▓█▓▒▒▓██▓░──────────▒█▒▒▒▒▒██▓█▓░░▓▒───
─▓▒▓▒▒▒▒▒▓█▓░──░▒▒▓▓██▒▒▒▒▒▒█████▒▒▒▓───
─▓░█▒▒▒▒▒▒▒▓▓█▓█▓▓▓▓▒▒▒▒▒▒▒▒██▓██▒░▒█───
─▓░▓█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓████▒▒▒█───
─▓░▓██▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▒▒▒▒▒▒▒▒▒▓██░░░█───
─▓░▓███▒▒▒▒▒▒▒▒▒▒▒▓█▒▒▒▒▒▒▒▒▒▒▒▒▓▓▓▒▓▓──
─▒▒▒██▓▒▓█▓▒▒▒▒▒▒▒▓▒▒▒▒▒▒▓▓▓▒▒▒▒▒▒▒▓▒█──
──▓▒█▓▒▒▒▒▓▒▒▒▒▒▒▒▒▒▒▒▓█▓▓▓▓█▓▒▒▒▒▒▒▒▓▒─
──▓▒█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓──────▓█▓▒▒▒▒▒▓█─
──▒▒▓▒▒▒▓▓▓▒▒▒▒▒▒▒▒▒▓▓───░▓▓───█▓▒▒▒▒▒█─
───█▒▒▓▓▓▒▒▓▓▒▒▒▒▒▒▓▓───█████▓──█▓▒▒▒▒▓▒
───▓▓█▒─────▒▓▒▒▒▒▒█───░██████──░█▒▒▒▒▓▓
───▓█▒──▒███─▒▓▒▒▒▒█────██████───▓▒▒▒▒▒▓
───██───█████─█▒▒▒▒█─────███▓────▓▓▒▒▒▒▓
───█▓───█████─▒▓▒▒▒█─────────────█▓▓▓▒▒▓
───█▓───░███──░▓▒▒▒▓█──────────░█▓▒▒▒▓▒▓
───██─────────▒▓▒▒▒▒▓▓──────░▒▓█▓────░▓▓
───▓█░────────█▓██▓▒▒▓█▓▓▓▓██▓▓▒▓▒░░▒▓▒▓
───▒██░──────▓▒███▓▒▒▒▒▓▓▓▓▒▒▒▒▒▒▓▓▓▓▒▓─
────█▓█▓▓▒▒▓█▓▒░██▒▒▓▓█▓▒▒▒▒▒▒▒▒▒▒▒▒▓▓█▒
────▓─░▓▓▓▓▓▒▓▓▓▓▒▓▓▓▒▓▒▒▒▒▒▒▒▒▒▒▒▓▓▓▓▓▓
────▒▒▒▓▒▒▒▒▒▒▓█░─░░░─▓▓▒▒▒▒▒▒▒▒▒▒▒▓██▓▒
─────█▓▒▒▒▒▒▒▒▒▓▓─░░░─▓▓▒▒▒▒▒▒▒▒▒▓▓▓▒▒▓▒
──────██▓▓▒▒▒▒▒▒█▒░░░░█▒▒▒▒▒▒▒▒▓█▓▓▒▒▒▒▒
─────░─▒██▓▓▒▒▒▒▒█▓▒▒▓▒▒▒▒▒▒▓███▓▒▒▒▒▒▓▓
──────────░▒▓▓▓▓▒▒▓▓▓▓▓▓████▓▓█▒▒▒▒▒▓▓█░");

                pular();

                Console.ForegroundColor = ConsoleColor.DarkMagenta;

                Console.WriteLine("1° Felix UM PET FELIZ, Resistente, fácil de cuidar");

                Console.WriteLine("Você quer escolher FELIX ? (Se a respota for SIM digite (1)");
                Console.WriteLine("Quer ver as outras opçoes  (Se quiser ver outros Digite (2)");

                Console.ResetColor();
                escolha = (Console.ReadLine());

                if (escolha == "1")
                {
                    pular();
                    Console.WriteLine("VOCÊ ESCOLHEU FELIX !");

                    escolhafinal++;
                    Continuar();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine(@"──████─────────────────────────────████
───██████────────░█───█░────────██████
────██?▓████─────██───██─────████▓?██
─────██?░░▓███─────█─█─────███▓░░?██
─────██?░░░░▓███───█─█───███▓░░░░?██
──────██?░?░░░▓██──███──██▓░░░?░?██
──────██?░░░?░░▓███─█─██▓░░░?░░░?██
─────██?░░?░░░?░░▓█████▓░░?░░░?░░?██
─────██?░░░░░░░░?░▓███▓░?░░░░░░░░?██
─────█████████▒░░░░▓█▓░░░░▒█████████
───────█████████▒░░▒█▒░░▒█████████
────███?░░░░░░░██░░▓█▓░░██░░░░░░░?███
─────███?░░?░?░░░░░███░░░░░?░?░░?███
───────██?░░░░░?░░▓███▓░░?░░░░░?██
────────██?░?░░░░▓█████▓░░░░?░?██
────────██?░░░▓████─█─████▓░░░?██
─────────██?▓███────█────███▓?██
─────────██████───────────██████
──────────███──────────────████");


                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("2° Abigail UM PET Gentil, Rapido porém frágil: ");


                    Console.WriteLine("Você quer escolher ABIGAIL ? (Se a respota for SIM digite (1)");
                    Console.WriteLine("Quer ver as outras opçoes    (Se quiser ver outros Digite (2)");
                    Console.ResetColor();

                    escolha = (Console.ReadLine());

                    if (escolha == "1")
                    {
                        pular();
                        Console.WriteLine("VOCÊ ESCOLHEU ABIGAIL !");

                        escolhafinal += 2;
                        Continuar();
                    }
                    else
                    {
                        Console.Clear();



                        Console.WriteLine(@"┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼▒
┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼▒▒▒
┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼▒▒░▒
┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼▒▒░░▒
┼┼┼┼┼┼┼┼┼┼┼████▒▒▒░░▒
┼┼┼┼┼┼┼┼┼███████▒▒░░▒█
┼┼┼┼┼┼┼┼█████████▒▒████
┼┼┼┼┼┼┼████████▒█▒▒█████
┼┼┼┼┼┼┼████████▒▒▒▒██████
┼┼┼┼┼┼████████▒▒▒▒▒███████
┼┼┼┼┼┼██████▒█▒▒▒▒▒████████
┼┼┼┼┼████▒█▒▒▒▒▒▒▒██████████
┼┼┼┼┼┼░▒▒▒░▒▒▒▒▒▒▒███████████
┼┼┼┼┼░▒▒▒▒██░▒▒▒▒▒▒███████████
┼┼┼┼┼░▒▒▒▒██░▒▒▒▒▒▒███████████
┼┼┼┼░▒▒▒▒▒▒▒▒▒▒▒▒▒▒█▒█████████
┼┼┼┼░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█████████
┼┼┼░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██▒██████
┼┼░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██▒██████
┼┼░▒█▒▒▒▒▒▒▒▒▒▒▒░┼░▒▒█▒▒██████
┼┼░▒██▒▒▒▒▒▒▒▒░░┼┼┼░▒▒▒▒██████
┼┼░▒▒▒▒▒▒█▒░░┼┼┼┼┼┼┼░▒▒▒██▒███
┼┼░▒▒▒▒▒█▒▒░┼┼┼┼┼┼┼┼░▒▒▒██▒███
┼┼┼░▒▒▒██▒░┼┼┼┼┼┼┼┼┼┼░▒▒██▒███
┼┼┼┼┼▒█▒░┼┼┼┼┼┼┼┼┼┼┼┼┼░▒▒█▒███
┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼░▒▒█▒███
┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼░▒▒▒███
┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼░▒░█░█");


                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("3° Sonoplastia UM PET Caotico, Forte porém lento: ");


                        Console.WriteLine("Você vai escolher SONOPLATIA ?   Digite (1)");
                        Console.WriteLine("Você deseja Voltar as escolhas ? Digite (2)");

                        Console.ResetColor();

                        escolha = (Console.ReadLine());

                        if (escolha == "1")
                        {
                            pular();

                            Console.WriteLine("Parabéns vc escolheu Sonoplastia ! ");
                            escolhafinal += 3;
                            Continuar();


                        }










                    }

                }




                Console.Clear();

            }





            menu();













        }



        static void Continuar()
        {
            Console.WriteLine("Aperte Enter para continuar !");
            Console.ReadLine();
            Console.Clear();
        }

        static void pular()
        {
            Console.WriteLine("\n");

        }


        //BATALHAS !
        static void slime(string escolhaluta)
        {
            int vidaslime = 12;
            int atkslime = 15;
            int defslime = 2;
            int veloslime = 15;
            int rodadaslime = 1;

            while (vida > 0 && vidaslime > 0)
            {




                if (escolhaluta == "1")
                {

                    Console.Clear();
                    Console.WriteLine("UM SLIME APARECEU !");



                    pular();

                    Console.WriteLine(@" 
 ░░░░░░░▄▀▀▀▀█░░░░░░░░░░░░░░░░░░░░
 ░░░░░░█▀░░░░█░░░░░░░░░░░░░░░░░░░░
 ░░░░░█░░░░░░█▀▀▀▄▄░░░░░░▓░░░░░░░░
 ░░░░▄█░░░░░░░░░░░░▀▀▄▄░▓▓▓░░░░░░░
 ░░░▄█░░░░░░░░░░░░░░░░░▀▓▓▓▓▀▀▀█░░
 ▀▄▄█░░░░░░░░░░░░░░░░▓▓▓▓▓▓▓▓░░█░░
 ▀▄█░▀▄░░░░▄▄░░░░░░▓▓▓▓▓▓▓░░▓▓▓▓▓▓
 ▄▀█▀▄░░░░███░░░░░░░░░▓▓▓▓▓▓▓▓▓▓▓░
 ░▀█▀▄░░░░▀▀░░░░░░░░░▄▄░░░▓▓▓▓▓░░░
 ░░▀█░░░░░░░░▄▄░░░░░███░░░░▓▓░█░░░
 ░░░▀█░░░░░░█░░▀▄░░░▀▀░░░░░▓░█▀░░░
 ░░░░▀█░░░░░░▀▄▄▀░░░░░░░░▀▄░█▀░░░░
 ░░░░░░▀█▄░░░░░░░░░░░░░▀▄░░██░░░░░
 ░░░░░░░░░▀█▄░░░░░░░░▀▄░░██▀░▀░░░░
 ░░░░░░░░░░░░▀▀▄▄▄▄▄▄▄█▀█░░▀▄░░░░░
 ░░░░░░░░░░░░░░░░░░░░░░░░▀░░░░░░░░");

                    pular();

                    if (veneno == 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("O Monstro está envenenado !");
                        Console.ResetColor();
                        pular();
                    }

                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("VIDA:" + vidaslime);
                    Console.WriteLine("ATK:" + atkslime);
                    Console.WriteLine("DEF:" + defslime);
                    Console.WriteLine("VELO:" + veloslime);
                    pular();
                    Console.ResetColor();

                    if (Venenoslime == 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("VOCÊ ESTÁ Envenenado: -2 Todo Turno !");
                        Console.ResetColor();
                        vida -= 2;
                        pular();
                    }

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("SUA VIDA: " + vida);
                    Console.WriteLine("SEU ATK : " + atk);
                    Console.WriteLine("SUA DEF : " + def);
                    Console.WriteLine("SUA VELO: " + velo);
                    pular();
                    Console.ResetColor();

                    Console.WriteLine("RODADA: " + rodadaslime);

                    Continuar();

                    if (veneno == 2)
                    {
                        vidaslime -= 2;
                    }



                    if (velo > veloslime)
                    {
                        Random r = new Random();
                        criticoplayer = r.Next(1, 11);

                        if (criticoplayer == 3)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("Player Critico !!! " + "\n");
                            Console.ResetColor();

                            salvaratk = atk;
                            atk += atk;
                        }


                        Console.WriteLine("Você atacou o slime Primeiro !");

                        //CALCULO DE ATAQUE DO PLAYER
                        if (atk - defslime > 0)
                        {
                            vidaslime -= atk - defslime;
                        }

                        if (criticoplayer == 3)
                        {
                            atk = salvaratk;
                        }



                        Console.ReadLine();

                        Random rr = new Random();
                        criticomob = rr.Next(1, 11);

                        if (criticomob == 3)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("Monstro Critico !!!" + "\n");
                            Console.ResetColor();
                            atkslime += atkslime;
                        }

                        //HABILIDADE ESPECIAL DO MOB
                        Random h = new Random();
                        habilidade = h.Next(1, 11);

                        if (habilidade == 3 && Venenoslime == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine("O Slime usou sua Habilidade: Você está Envenenado");
                            Console.ResetColor();
                            Venenoslime += 2;
                        }

                        Console.WriteLine("O Slime te Ataca !");

                        if (atkslime - def > 0)
                        {
                            vida -= atkslime - def;
                        }

                        atkslime = 15;

                    }
                    else
                    {


                        Random rr = new Random();
                        criticomob = rr.Next(1, 11);

                        if (criticomob == 3)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("Monstro Critico !!!" + "\n");
                            Console.ResetColor();
                            atkslime += atkslime;
                        }

                        //HABILIDADE ESPECIAL DO MOB
                        Random h = new Random();
                        habilidade = h.Next(1, 11);

                        if (habilidade == 3 && Venenoslime == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine("O Slime usou sua Habilidade: Você está Envenenado");
                            Console.ResetColor();
                            Venenoslime += 2;
                        }

                        Console.WriteLine("O Slime te Ataca Primeiro !");

                        if (atkslime - def > 0)
                        {
                            vida -= atkslime - def;
                        }

                        atkslime = 15;

                        Random r = new Random();
                        criticoplayer = r.Next(1, 11);

                        if (criticoplayer == 3)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("Player Critico !!! " + "\n");
                            Console.ResetColor();
                            salvaratk = atk;
                            atk += atk;
                        }

                        Console.WriteLine("Você atacou o Slime !");

                        //CALCULO DE ATAQUE DO PLAYER
                        if (atk - defslime > 0)
                        {
                            vidaslime -= atk - defslime;
                        }

                        if (criticoplayer == 3)
                        {
                            atk = salvaratk;
                        }

                        Console.ReadLine();

                    }







                    rodadaslime++;
                    Console.ReadLine();

                }



            }
            //FIM DO WHILE


            Console.Clear();

            if (vidaslime <= 0)
            {
                pular();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(@"██    ██ ███████ ███    ██  ██████ ███████ ██    ██ 
██    ██ ██      ████   ██ ██      ██      ██    ██ 
██    ██ █████   ██ ██  ██ ██      █████   ██    ██ 
 ██  ██  ██      ██  ██ ██ ██      ██      ██    ██ 
  ████   ███████ ██   ████  ██████ ███████  ██████  ");

                Random Ouroslime = new Random();
                int Ouro = Ouroslime.Next(1, 6);
                Venenoslime = 0;

                Console.WriteLine("Ouro Obtido: " + Ouro);
                Console.ResetColor();
                pular();

                //DROP RARO DO SLIME
                Random emblema = new Random();
                int eb = emblema.Next(1, 11);


                if (eb == 3 && ebslime == 0)
                {
                    pular();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(@"██████  ██████   ██████  ██████      ██████   █████  ██████   ██████  
██   ██ ██   ██ ██    ██ ██   ██     ██   ██ ██   ██ ██   ██ ██    ██ 
██   ██ ██████  ██    ██ ██████      ██████  ███████ ██████  ██    ██ 
██   ██ ██   ██ ██    ██ ██          ██   ██ ██   ██ ██   ██ ██    ██ 
██████  ██   ██  ██████  ██          ██   ██ ██   ██ ██   ██  ██████  
                                                                      
                                                                      " + "\n");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("Emblema de Slime |HP + 5|");
                    Console.ResetColor();
                    ebslime += 5;
                }
                //FIM DO DROP RARO
                Saldo += Ouro;


                Console.ReadLine();
            }
            else
            {
                pular();
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine(@"██████  ███████ ██████  ██████   ██████  ████████  █████  
██   ██ ██      ██   ██ ██   ██ ██    ██    ██    ██   ██ 
██   ██ █████   ██████  ██████  ██    ██    ██    ███████ 
██   ██ ██      ██   ██ ██   ██ ██    ██    ██    ██   ██ 
██████  ███████ ██   ██ ██   ██  ██████     ██    ██   ██ 
                                                          ");

                Console.ResetColor();
                Venenoslime = 0;
                Console.ReadLine();
            }



            menu();



        }








        static void statusbase()
        {
            if (escolhafinal == 1)
            {
                nome = "FELIX";
                vida = 60 + coracao + maca + ebslime;
                atk = 5 + faixapetra + curso + espada + ebbesta + espadademon;
                def = 10 + mantorasgado + seda + armadura + eburso;
                velo = 35 + bota + rodas + super + ebmon;

            }
            else
            {
                if (escolhafinal == 2)
                {
                    nome = "ABIGAIL";
                    vida = 38 + coracao + maca + ebslime;
                    atk = 8 + faixapetra + curso + espada + ebbesta + espadademon;
                    def = 5 + mantorasgado + seda + armadura + eburso;
                    velo = 60 + bota + rodas + super + ebmon;
                }
                else
                {
                    if (escolhafinal == 3)
                    {
                        nome = "SONOPLASTIA";
                        vida = 45 + coracao + maca + ebslime;
                        atk = 10 + faixapetra + curso + espada + ebbesta + espadademon;
                        def = 5 + mantorasgado + seda + armadura + eburso;
                        velo = 20 + bota + rodas + super + ebmon;
                    }
                }




            }
        }


        //VOID DO MENU !!!
        static void menu()
        {


            statusbase();
            Console.Clear();
            pular();
            Console.WriteLine(@"███    ███ ███████ ███    ██ ██    ██     ██ ███    ██ ██  ██████ ██  █████  ██      
████  ████ ██      ████   ██ ██    ██     ██ ████   ██ ██ ██      ██ ██   ██ ██      
██ ████ ██ █████   ██ ██  ██ ██    ██     ██ ██ ██  ██ ██ ██      ██ ███████ ██      
██  ██  ██ ██      ██  ██ ██ ██    ██     ██ ██  ██ ██ ██ ██      ██ ██   ██ ██      
██      ██ ███████ ██   ████  ██████      ██ ██   ████ ██  ██████ ██ ██   ██ ███████ 
                                                                                     
                                                                                     ");

            pular();
            Console.WriteLine("SALDO: " + Saldo + "\n" + "\n" + "NOME: " + nome + "\n" + "Vida: " + vida + "\n" + "ATK: " + atk + "\n" + "DEF: " + def + "\n" + "Velo: " + velo);

            pular();
            Console.WriteLine("O que deseja fazer ? ");
            pular();
            Console.WriteLine("LUTAR (1)" + "\n" + "LOJA  (2)" + "\n" + "FINAL (3)");



            do
            {

                escolhamenu = Console.ReadLine();

                if (!escolhamenu.Equals("1") && !escolhamenu.Equals("2") && !escolhamenu.Equals("3"))
                {
                    Console.WriteLine("ERRO!! Pare de ser tapado, escolha uma opção valida!");
                }

            } while (!escolhamenu.Equals("1") && !escolhamenu.Equals("2") && !escolhamenu.Equals("3"));









            if (escolhamenu == "3")
            {
                Console.Clear();
                pular();
                Console.WriteLine(@"███████  █████  ██ ██    ██     ██████   ██████           ██  ██████   ██████   ██████      ██ 
██      ██   ██ ██ ██    ██     ██   ██ ██    ██          ██ ██    ██ ██       ██    ██     ██ 
███████ ███████ ██ ██    ██     ██   ██ ██    ██          ██ ██    ██ ██   ███ ██    ██     ██ 
     ██ ██   ██ ██ ██    ██     ██   ██ ██    ██     ██   ██ ██    ██ ██    ██ ██    ██        
███████ ██   ██ ██  ██████      ██████   ██████       █████   ██████   ██████   ██████      ██ 
                                                                                               
                                                                                               ");
                System.Diagnostics.Process.GetCurrentProcess().Close();

            }




            else if (escolhamenu == "1")
            {

                escolhamenu = "0";
                Console.Clear();
                Console.WriteLine("LISTA DE INIMIGOS: ");
                pular();
                Console.WriteLine("(1) SLIME"); if (ebslime > 1) { Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine(" |DROP RARO:COLETADO|" + "\n"); Console.ResetColor(); }
                Console.WriteLine("(2) BESTA DA CAVERNA"); if (ebbesta > 1) { Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine(" |DROP RARO:COLETADO|" + "\n"); Console.ResetColor(); }
                Console.WriteLine("(3) URSO NERVOSO"); if (eburso > 1) { Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine(" |DROP RARO:COLETADO|" + "\n"); Console.ResetColor(); }
                Console.WriteLine("(4) AWNTEDEGUEMON"); if (ebmon > 1) { Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine(" |DROP RARO:COLETADO|" + "\n"); Console.ResetColor(); }
                Console.WriteLine("(5) ALIEN BINA"); if (ebalien > 1) { Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine(" |DROP RARO:COLETADO|" + "\n"); Console.ResetColor(); }





                do
                {
                    escolhaluta = Console.ReadLine();
                    if ((!escolhaluta.Equals("1") && !escolhaluta.Equals("2") && !escolhaluta.Equals("3") && !escolhaluta.Equals("4") && !escolhaluta.Equals("5") && !escolhaluta.Equals("000")))
                    {
                        Console.WriteLine("ERRO!! Pare de ser tapado, escolha uma opção valida!");
                    }

                } while (!escolhaluta.Equals("1") && !escolhaluta.Equals("2") && !escolhaluta.Equals("3") && !escolhaluta.Equals("4") && !escolhaluta.Equals("5") && !escolhaluta.Equals("000"));



                if (escolhaluta == "1")
                {
                    slime(escolhaluta);
                }
                else if (escolhaluta == "2")
                {
                    bestadacaverna(escolhaluta);
                }
                else if (escolhaluta == "3")
                {
                    urso(escolhaluta);
                }
                else if (escolhaluta == "4")
                {
                    AWNTEDEGUEMON(escolhaluta);
                }
                else if (escolhaluta == "000")
                {
                    slimehack(escolhaluta);
                }
                else if (escolhaluta == "5")
                {
                    Alienbina(escolhaluta);
                }





            }
            else if (escolhamenu == "2")
            {
                pular();
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkYellow;

                Console.WriteLine(@"██       ██████       ██  █████  
██      ██    ██      ██ ██   ██ 
██      ██    ██      ██ ███████ 
██      ██    ██ ██   ██ ██   ██ 
███████  ██████   █████  ██   ██ 
                                 
                                 ");
                pular();
                Console.WriteLine("Saldo: " + Saldo);

                Console.ResetColor();



                pular();

                for (int i = 0; i < itens.Length; i++)
                {
                    if (itens[i] == 0)
                    {
                        Console.WriteLine(itensName[i]);
                    }
                }

                pular();

                Console.WriteLine("(0) Sair da LOJA !");

                pular();



                do
                {
                    escolhaloja = Console.ReadLine();
                    if ((!escolhaloja.Equals("1") && !escolhaloja.Equals("2") && !escolhaloja.Equals("3") && !escolhaloja.Equals("4") && !escolhaloja.Equals("5") && !escolhaloja.Equals("6") && !escolhaloja.Equals("7") && !escolhaloja.Equals("8") && !escolhaloja.Equals("9") && !escolhaloja.Equals("10") && !escolhaloja.Equals("11") && !escolhaloja.Equals("12") && !escolhaloja.Equals("13") && !escolhaloja.Equals("0")))
                    {
                        Console.WriteLine("ERRO!! Pare de ser tapado, escolha uma opção valida!");
                    }

                } while (!escolhaloja.Equals("1") && !escolhaloja.Equals("2") && !escolhaloja.Equals("3") && !escolhaloja.Equals("4") && !escolhaloja.Equals("5") && !escolhaloja.Equals("6") && !escolhaloja.Equals("7") && !escolhaloja.Equals("8") && !escolhaloja.Equals("9") && !escolhaloja.Equals("10") && !escolhaloja.Equals("11") && !escolhaloja.Equals("12") && !escolhaloja.Equals("13") && !escolhaloja.Equals("0"));



                if (escolhaloja == "1" && Saldo >= 10 && faixapetra == 0)
                {
                    pular();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("VOCÊ COMPROU A Faixa Preta!");
                    Console.ResetColor();
                    itens[0] = 1; //Vendido
                    faixapetra += 2;
                    Saldo -= 10;
                    pular();
                    Continuar();
                    menu();
                }


                else if (escolhaloja == "2" && Saldo >= 12 && mantorasgado == 0)
                {
                    pular();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("VOCÊ COMPROU O Manto Rasgado!");
                    Console.ResetColor();
                    itens[1] = 1; //Vendido
                    mantorasgado += 3;
                    Saldo -= 12;
                    pular();
                    Continuar();
                    menu();
                }


                else if (escolhaloja == "5" && Saldo >= 50 && coracao == 0)
                {
                    pular();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("VOCÊ COMPROU O Coração do MAR!");
                    Console.ResetColor();
                    pular();
                    itens[4] = 1; //Vendido
                    coracao += 10;
                    Saldo -= 50;
                    Continuar();
                    menu();
                }


                else if (escolhaloja == "3" && Saldo >= 5 && bota == 0)
                {
                    pular();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("VOCÊ COMPROU A BOTAS VIVIDAS!");
                    Console.ResetColor();
                    itens[2] = 1; //Vendido
                    bota += 2;
                    Saldo -= 5;
                    pular();
                    Continuar();
                    menu();
                }

                else if (escolhaloja == "4" && Saldo >= 35 && curso == 0)
                {
                    pular();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("VOCÊ COMPROU O TeleCurso de Luta 2022!");
                    Console.ResetColor();
                    itens[3] = 1; //Vendido
                    curso += 4;
                    Saldo -= 35;
                    pular();
                    Continuar();
                    menu();
                }

                else if (escolhaloja == "6" && Saldo >= 42 && seda == 0)
                {
                    pular();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("VOCÊ COMPROU O Manto de Seda!");
                    Console.ResetColor();
                    itens[5] = 1; //Vendido
                    seda += 5;
                    Saldo -= 42;
                    pular();
                    Continuar();
                    menu();
                }

                else if (escolhaloja == "7" && Saldo >= 50 && rodas == 0)
                {
                    pular();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("VOCÊ COMPROU AS RODINHAS!");
                    Console.ResetColor();
                    itens[6] = 1; //Vendido
                    rodas += 8;
                    Saldo -= 50;
                    pular();
                    Continuar();
                    menu();
                }



                else if (escolhaloja == "8" && Saldo >= 120 && maca == 0)
                {
                    pular();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("VOCÊ COMPROU A MAÇA DOURADA!");
                    Console.ResetColor();
                    itens[7] = 1; //Vendido
                    maca += 15;
                    Saldo -= 120;
                    pular();
                    Continuar();
                    menu();
                }

                else if (escolhaloja == "9" && Saldo >= 120 && espada == 0)
                {
                    pular();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("VOCÊ COMPROU A TERRA BLADE !!!");
                    Console.ResetColor();
                    itens[8] = 1; //Vendido
                    espada += 10;
                    Saldo -= 180;
                    pular();
                    Continuar();
                    menu();
                }

                else if (escolhaloja == "10" && Saldo >= 150 && armadura == 0)
                {
                    pular();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("VOCÊ COMPROU A ARMADURA de FIBRA !!!");
                    Console.ResetColor();
                    itens[9] = 1; //Vendido
                    armadura += 10;
                    Saldo -= 150;
                    pular();
                    Continuar();
                    menu();
                }

                else if (escolhaloja == "11" && Saldo >= 225 && super == 0)
                {
                    pular();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("VOCÊ COMPROU A ARMADURA de FIBRA !!!");
                    Console.ResetColor();
                    itens[10] = 1; //Vendido
                    super += 12;
                    Saldo -= 225;
                    pular();
                    Continuar();
                    menu();
                }

                else if (escolhaloja == "12" && Saldo >= 100 && veneno == 0)
                {
                    pular();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("VOCÊ COMPROU ARMADILHA DE VENENO !!!");
                    Console.ResetColor();
                    itens[11] = 1; //Vendido
                    veneno += 2;
                    Saldo -= 100;
                    pular();
                    Continuar();
                    menu();
                }

                else if (escolhaloja == "13" && Saldo >= 550 && espadademon == 0)
                {
                    pular();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("VOCÊ COMPROU A Espada Demoniaca !!!");
                    Console.ResetColor();
                    itens[12] = 1; //Vendido
                    espadademon += 15;
                    Saldo -= 550;
                    pular();
                    Continuar();
                    menu();
                }


                else if (escolhaloja == "0")
                {
                    menu();
                }
                else
                {
                    pular();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("VOCÊ ESTÁ SEM DINHEIRO, OU JÁ TEM ESSE ITEM !");
                    Console.ResetColor();
                    pular();
                    Continuar();
                    menu();
                }


            }







        }
        //BOSS BESTA DA CAVERNA !!!
        static void bestadacaverna(string escolhaluta)
        {
            int vidabesta = 25;
            int atkbesta = 20;
            int defbesta = 3;
            int velobesta = 25;
            int rodadabesta = 1;

            while (vida > 0 && vidabesta > 0)
            {
                if (escolhaluta == "2")
                {

                    Console.Clear();
                    Console.WriteLine("UM BESTA ENFURECIDA TE DESAFIA !");



                    pular();

                    Console.WriteLine(@"──────────────────▄▄───▄▄▄▄▄▄▀▀▀▄──▄
────────────────▄▀──▀▀█▄▄──▄────█▄█▄▀▀▄▄▄▄
─────────────────▀█▀────▀▀▀▀█▄▄▄▄───▄▄────▀▀▀▀
─────────────▄▀▀▀▀▀──▀█▄▄▄▄▄─▀▀▀▀▀█▄███▀
──────────────▀█▄▄▄──▀▀─▄▄▄▄──────────▀▀▀▀█▀▀▀
───────▄▀▀▀▄▄▀▀████▀█▄▄▄▄▄▄▄▄▄▄▄───▄▄▄▄──▄█░▄█
────────▀▄▄▄▀▀██▀▀▀▄█─███▄──██─────▀██▀▀─█░░██
────────────▀█─▀▀█▄█▄─▀▀▀───█────────────▀█░▀█
─────────▄▄▀▀─▀▀▀▀░░▀█────▄█▄▀────────────█░░░
───▄▀▀▀▀▀░░░░░░░░░░░░░▀██▀▀▄▄▀▀──────────██░░░
▄▀▀▄████░░███████░░▄▄▄▄░░▀█▄─▀▀──────────▀█▄▄░
█░░█████▄▄███████▄██████▄▄░▀█──███▄▄────────█▄
█░░░▀▀▀▀▀▀▀▀▀▀▀░░░░░░░░░▀▀▀░░█─▀███▀───────▄█▀
─▀▀▄▄▄▄▄░░░░░░░░░░░░░░░░░░░░▄▀─────────────▀█░
───▄▀▄▄▀░░░░░░░░░░░░░░░░░░░░█────────────────█
▀▀▀─▀▄▀█░░░░░░░░░░░░░░░░░░░░█───────────────▄▀
─▄▄▀▀──▀▄░░░░░░░░░░░░░░░░░░█────────────────█░
▀────────▀▄░░░░░░░░░░░░░░▄▀──────────▄█▄▄────█
───────────▀▄▄▄▄░░░░░▄▄▄▀────────────▀██▀────█
────────────█░░░▀▀▀▀██████████▀▀▀▀▀▀▄▄▄▄▄▄▄▄▄█
───────────▄▀░░░░░░░█▒▒▒▒▒▒▒▒█░░░░░░░░░▄▄░░░░█
───────────▀▄▄▄░░░░░█▒▒▒▒▒▒▒▒█░░░░░░░░░▀█▀░░░█");

                    pular();

                    if (veneno == 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("O Monstro está envenenado !");
                        Console.ResetColor();
                        pular();
                    }

                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("VIDA:" + vidabesta);
                    Console.WriteLine("ATK:" + atkbesta);
                    Console.WriteLine("DEF:" + defbesta);
                    Console.WriteLine("VELO:" + velobesta);
                    pular();
                    Console.ResetColor();

                    if (quebraarmadura > 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Sua DEF Caiu em: " + quebraarmadura);
                        Console.ResetColor();
                        pular();
                    }

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("SUA VIDA: " + vida);
                    Console.WriteLine("SEU ATK : " + atk);
                    Console.WriteLine("SUA DEF : " + def);
                    Console.WriteLine("SUA VELO: " + velo);
                    pular();
                    Console.ResetColor();

                    Console.WriteLine("RODADA: " + rodadabesta);

                    Continuar();

                    if (veneno == 2)
                    {
                        vidabesta -= 2;
                    }


                    if (velo > velobesta)
                    {
                        Random r = new Random();
                        criticoplayer = r.Next(1, 11);

                        if (criticoplayer == 3)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("Player Critico !!! " + "\n");
                            Console.ResetColor();
                            salvaratk = atk;
                            atk += atk;
                        }

                        Console.WriteLine("Você atacou A Besta da Caverna Primeiro !");

                        //CALCULO DE ATAQUE DO PLAYER
                        if (atk - defbesta > 0)
                        {
                            vidabesta -= atk - defbesta;
                        }

                        if (criticoplayer == 3)
                        {
                            atk = salvaratk;
                        }


                        Console.ReadLine();

                        Random rr = new Random();
                        criticomob = rr.Next(1, 11);

                        if (criticomob == 3)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("Monstro Critico !!!" + "\n");
                            Console.ResetColor();
                            atkbesta *= 2;
                        }

                        //HABILIDADE DO MONSTRO
                        Random h = new Random();
                        habilidade = h.Next(1, 11);

                        if (habilidade == 3)
                        {
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine("A Besta usou sua Habilidade: Sua Def Diminui !");
                            Console.ResetColor();
                            quebraarmadura++;
                            def -= quebraarmadura;
                        }
                        //FIM DA HABILIDADE DO MONSTRO

                        Console.WriteLine("A Besta te Ataca !");

                        if (atkbesta - def > 0)
                        {
                            vida -= atkbesta - def;
                        }

                        atkbesta = 20;

                    }
                    else
                    {
                        if (criticomob == 3)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("Monstro Critico !!!" + "\n");
                            Console.ResetColor();
                            atkbesta *= 2;
                        }

                        //HABILIDADE DO MONSTRO
                        Random h = new Random();
                        habilidade = h.Next(1, 11);

                        if (habilidade == 3)
                        {
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine("A Besta usou sua Habilidade: Sua Def, Diminui !");
                            Console.ResetColor();
                            quebraarmadura++;
                            def -= quebraarmadura;
                        }
                        //FIM DA HABILIDADE DO MONSTRO

                        Console.WriteLine("A Besta da Caverna te Ataca Primeiro !");

                        if (atkbesta - def > 0)
                        {
                            vida -= atkbesta - def;
                        }

                        atkbesta = 20;


                        Console.ReadLine();

                        Random r = new Random();
                        criticoplayer = r.Next(1, 11);

                        if (criticoplayer == 3)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("Player Critico !!! " + "\n");
                            Console.ResetColor();
                            salvaratk = atk;
                            atk += atk;
                        }

                        Console.WriteLine("Você atacou a Besta da Caverna !");

                        //CALCULO DE ATAQUE DO PLAYER
                        if (atk - defbesta > 0)
                        {
                            vidabesta -= atk - defbesta;
                        }

                        if (criticoplayer == 3)
                        {
                            atk = salvaratk;
                        }


                    }







                    rodadabesta++;
                    Console.ReadLine();

                }



            }
            //FIM DO WHILE


            Console.Clear();

            if (vidabesta <= 0)
            {
                pular();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(@"██    ██ ███████ ███    ██  ██████ ███████ ██    ██ 
██    ██ ██      ████   ██ ██      ██      ██    ██ 
██    ██ █████   ██ ██  ██ ██      █████   ██    ██ 
 ██  ██  ██      ██  ██ ██ ██      ██      ██    ██ 
  ████   ███████ ██   ████  ██████ ███████  ██████  ");

                quebraarmadura = 0;
                Random Ouroslime = new Random();
                int Ouro = Ouroslime.Next(5, 11);

                Console.WriteLine("Ouro Obtido: " + Ouro);

                //DROP RARO
                Random emblema = new Random();
                int eb = emblema.Next(1, 11);


                if (eb == 3 && ebbesta == 0)
                {
                    pular();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(@"██████  ██████   ██████  ██████      ██████   █████  ██████   ██████  
██   ██ ██   ██ ██    ██ ██   ██     ██   ██ ██   ██ ██   ██ ██    ██ 
██   ██ ██████  ██    ██ ██████      ██████  ███████ ██████  ██    ██ 
██   ██ ██   ██ ██    ██ ██          ██   ██ ██   ██ ██   ██ ██    ██ 
██████  ██   ██  ██████  ██          ██   ██ ██   ██ ██   ██  ██████  
                                                                      
                                                                      " + "\n");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("Emblema da Besta |ATK + 3|");
                    Console.ResetColor();
                    ebbesta += 3;
                }
                //FIM DO DROP RARO
                Saldo += Ouro;

                Console.ResetColor();
                Console.ReadLine();
            }
            else
            {
                pular();
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine(@"██████  ███████ ██████  ██████   ██████  ████████  █████  
██   ██ ██      ██   ██ ██   ██ ██    ██    ██    ██   ██ 
██   ██ █████   ██████  ██████  ██    ██    ██    ███████ 
██   ██ ██      ██   ██ ██   ██ ██    ██    ██    ██   ██ 
██████  ███████ ██   ██ ██   ██  ██████     ██    ██   ██ 
                                                          ");
                quebraarmadura = 0;
                Console.ResetColor();

                Console.ReadLine();
            }



            menu();



        }

        //BOSS URSO !!!
        static void urso(string escolhaluta)
        {
            int vidaurso = 35;
            int atkurso = 25;
            int defurso = 5;
            int velourso = 30;
            int rodadaurso = 1;

            while (vida > 0 && vidaurso > 0)
            {
                if (escolhaluta == "3")
                {

                    Console.Clear();
                    Console.WriteLine("UM URSO NERVOSO QUER TE QUEBRAR NO PAU !");



                    pular();

                    Console.WriteLine(@"─────────────────────────▐█
────▄──────────────────▄█▓█
───▐██▄───────────────▄▓░░▓▓
───▐█░██▓────────────▓▓░░░▓▌
───▐█▌░▓██──────────█▓░░░░▓
────▓█▌░░▓█▄███████▄███▓░▓█
────▓██▌░▓██░░░░░░░░░░▓█░▓▌
─────▓█████░░░░░░░░░░░░▓██
─────▓██▓░░░░░░░░░░░░░░░▓█
─────▐█▓░░░░░░█▓░░▓█░░░░▓█▌
─────▓█▌░▓█▓▓██▓░█▓▓▓▓▓░▓█▌
─────▓▓░▓██████▓░▓███▓▓▌░█▓
────▐▓▓░█▄▐▓▌█▓░░▓█▐▓▌▄▓░██
────▓█▓░▓█▄▄▄█▓░░▓█▄▄▄█▓░██▌
────▓█▌░▓█████▓░░░▓███▓▀░▓█▓
───▐▓█░░░▀▓██▀░░░░░─▀▓▀░░▓█▓
───▓██░░░░░░░░▀▄▄▄▄▀░░░░░░▓▓
───▓█▌░░░░░░░░░░▐▌░░░░░░░░▓▓▌
───▓█░░░░░░░░░▄▀▀▀▀▄░░░░░░░█▓
──▐█▌░░░░░░░░▀░░░░░░▀░░░░░░█▓
──▓█░░░░░░░░░░░░░░░░░░░░░░░██▓
──▓█░░░░░░░░░░░░░░░░░░░░░░░▓█▓
──██░░░░░░░░░░░░░░░░░░░░░░░░█▓
──█▌░░░░░░░░░░░░░░░░░░░░░░░░▐▓▌
─▐▓░░░░░░░░░░░░░░░░░░░░░░░░░░█▓
─█▓░░░░░░░░░░░░░░░░░░░░░░░░░░▓▓
─█▓░░░░░░░░░░░░░░░░░░░░░░░░░░▓▓
▐█▓░░░░░░░░░░░░░░░░░░░░░░░░░░░█
█▓▌░░░░░░░░░░░░░░░░░░░░░░░░░░░▓");

                    pular();

                    if (veneno == 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("O Monstro está envenenado !");
                        Console.ResetColor();
                        pular();
                    }

                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("VIDA:" + vidaurso);
                    Console.WriteLine("ATK:" + atkurso);
                    Console.WriteLine("DEF:" + defurso);
                    Console.WriteLine("VELO:" + velourso);
                    pular();
                    Console.ResetColor();

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("SUA VIDA: " + vida);
                    Console.WriteLine("SEU ATK : " + atk);
                    Console.WriteLine("SUA DEF : " + def);
                    Console.WriteLine("SUA VELO: " + velo);
                    pular();
                    Console.ResetColor();

                    Console.WriteLine("RODADA: " + rodadaurso);

                    Continuar();

                    if (veneno == 2)
                    {
                        vidaurso -= 2;
                    }

                    if (velo > velourso)
                    {
                        Random r = new Random();
                        criticoplayer = r.Next(1, 11);

                        if (criticoplayer == 3)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("Player Critico !!! " + "\n");
                            Console.ResetColor();
                            salvaratk = atk;
                            atk += atk;
                        }

                        Console.WriteLine("Você atacou O Urso Primeiro !");

                        //CALCULO DE ATAQUE DO PLAYER
                        if (atk - defurso > 0)
                        {
                            vidaurso -= atk - defurso;
                        }


                        if (criticoplayer == 3)
                        {
                            atk = salvaratk;
                        }


                        Console.ReadLine();

                        Random rr = new Random();
                        criticomob = rr.Next(1, 11);

                        if (criticomob == 3)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("Monstro Critico !!!" + "\n");
                            Console.ResetColor();
                            atkurso *= 2;
                        }

                        //HABILIDADE DO MONSTRO
                        Random h = new Random();
                        habilidade = h.Next(1, 11);

                        if (habilidade == 3)
                        {
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine("O urso usou sua Habilidade: Rugido Feroz, O ataque dele Aumenta em +3 ");
                            Console.ResetColor();
                            rugido += 3;
                            atkurso += rugido;


                        }
                        //FIM DA HABILIDADE DO MONSTRO

                        Console.WriteLine("O Urso te Ataca !");


                        if (atkurso - def > 0)
                        {
                            vida -= atkurso - def;
                        }


                        atkurso = 25 + rugido;

                    }
                    else
                    {
                        Random rr = new Random();
                        criticomob = rr.Next(1, 11);

                        if (criticomob == 3)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("Monstro Critico !!!" + "\n");
                            Console.ResetColor();
                            atkurso *= 2;
                        }

                        //HABILIDADE DO MONSTRO
                        Random h = new Random();
                        habilidade = h.Next(1, 11);

                        if (habilidade == 3)
                        {
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine("O urso usou sua Habilidade: Rugido Feroz, O ataque dele Aumenta em +3 ");
                            Console.ResetColor();
                            rugido += 3;
                            atkurso += rugido;

                        }
                        //FIM DA HABILIDADE DO MONSTRO

                        Console.WriteLine("O Urso te Ataca Primeiro !");


                        if (atkurso - def > 0)
                        {
                            vida -= atkurso - def;
                        }

                        atkurso = 25 + rugido;

                        Console.ReadLine();

                        Random r = new Random();
                        criticoplayer = r.Next(1, 11);

                        if (criticoplayer == 3)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("Player Critico !!! " + "\n");
                            Console.ResetColor();
                            salvaratk = atk;
                            atk += atk;
                        }

                        Console.WriteLine("Você atacou o Urso !");

                        //CALCULO DE ATAQUE DO PLAYER
                        if (atk - defurso > 0)
                        {
                            vidaurso -= atk - defurso;
                        }

                        if (criticoplayer == 3)
                        {
                            atk = salvaratk;
                        }


                    }







                    rodadaurso++;
                    Console.ReadLine();

                }



            }
            //FIM DO WHILE


            Console.Clear();

            if (vidaurso <= 0)
            {
                pular();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(@"██    ██ ███████ ███    ██  ██████ ███████ ██    ██ 
██    ██ ██      ████   ██ ██      ██      ██    ██ 
██    ██ █████   ██ ██  ██ ██      █████   ██    ██ 
 ██  ██  ██      ██  ██ ██ ██      ██      ██    ██ 
  ████   ███████ ██   ████  ██████ ███████  ██████  ");
                rugido = 0;

                Random Ouroslime = new Random();
                int Ouro = Ouroslime.Next(10, 21);

                Console.WriteLine("Ouro Obtido: " + Ouro);

                //DROP RARO
                Random emblema = new Random();
                int eb = emblema.Next(1, 11);


                if (eb == 3 && eburso == 0)
                {
                    pular();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(@"██████  ██████   ██████  ██████      ██████   █████  ██████   ██████  
██   ██ ██   ██ ██    ██ ██   ██     ██   ██ ██   ██ ██   ██ ██    ██ 
██   ██ ██████  ██    ██ ██████      ██████  ███████ ██████  ██    ██ 
██   ██ ██   ██ ██    ██ ██          ██   ██ ██   ██ ██   ██ ██    ██ 
██████  ██   ██  ██████  ██          ██   ██ ██   ██ ██   ██  ██████  
                                                                      
                                                                      " + "\n");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("Emblema do Urso |DEF + 3|");
                    Console.ResetColor();
                    eburso += 3;
                }
                //FIM DO DROP RARO
                Saldo += Ouro;

                Console.ResetColor();
                Console.ReadLine();
            }
            else
            {
                pular();
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine(@"██████  ███████ ██████  ██████   ██████  ████████  █████  
██   ██ ██      ██   ██ ██   ██ ██    ██    ██    ██   ██ 
██   ██ █████   ██████  ██████  ██    ██    ██    ███████ 
██   ██ ██      ██   ██ ██   ██ ██    ██    ██    ██   ██ 
██████  ███████ ██   ██ ██   ██  ██████     ██    ██   ██ 
                                                          ");
                rugido = 0;
                Console.ResetColor();

                Console.ReadLine();
            }



            menu();



        }

        //BOSS AWNTEDEGUEMON !!!
        static void AWNTEDEGUEMON(string escolhaluta)
        {
            int vidamon = 60;
            int atkmon = 30;
            int defmon = 8;
            int velomon = 666;
            int rodadamon = 1;

            while (vida > 0 && vidamon > 0)
            {
                if (escolhaluta == "4")
                {

                    Console.Clear();
                    Console.WriteLine("O LENDARIO AWNTEDEGUEMON Aparece e QUER TE VER MORTO !!!");



                    pular();

                    Console.WriteLine(@"╦═╩═╦═╩═╦═╩═╦═╩═╦═╩═╦═╩═╦═╩═╦═╩═╦═╩═╦═╩═╦═╩═╦═ 
╩═╦═╩═╦═╩═╦▄████▄═╦▄████▄═╦═╩═╦═╩═╦═╩═╦═╩═╦═╩═ 
╦═╩═╦═╩═╦═╩██▀▀██═╩██▀▀██═╩═╦═╩═╦═╩═╦═╩═╦═╩═╦═ 
╩═╦═╩═╦═╩═╦██──██═╦██──██═╦═╩═╦═╩═╦═╩═╦═╩═╦═╩═ 
╦═╩═╦═╩═╦═╩██──██═╩██──██═╩═╦═╩═╦═╩═╦═╩═╦═╩═╦═ 
╩═╦═╩═╦═╩═╦██──██═╦██──██═╦═╩═╦═╩═╦═╩═╦═╩═╦═╩═ 
╦═╩═╦═╩═╦═╩██──██═╩██──██═╩═╦═╩═╦═╩═╦═╩═╦═╩═╦═ 
╩═╦═╩═╦═╩═▄██──██████──██▄╦═╩═╦═╩═╦═╩═╦═╩═╦═╩═ 
╦═╩═╦═╩═▄███▀──────────▀███▄╦═╩═╦═╩═╦═╩═╦═╩═╦═ 
╩═╦═╩═╦██▀────────────────▀██═╦═╩═╦═╩═╦═╩═╦═╩═ 
╦═╩═╦═███─────██─────██────███╩═╦═╩═╦═╩═╦═╩═╦═ 
╩═╦═╩═██──────██─────██─────██╦═╩═╦═╩═╦═╩═╦═╩═ 
╦═╩═╦═██─██▄██▄─────────────██╩▄▄▄╩═█▄╩═▄▄▄═╦═ 
╩═╦═╩═██─██████─────────────██╦═▀▀▀▄██▄▀▀▀╦═╩═ 
╦═╩═╦▄███████▀───▒▒▒────────██╩═╦═█▒▒▒▒█╦═╩═╦═ 
╩═╦▄█████▀─────────────────▄██╦═╩███████╩═╦═╩═ 
╦═▐█████▄▄───────────────▄▄██═╩═▄███▒▒▒█╦═╩═╦═ 
╩═▐████▀▀█████▄▄▄▄▄▄▄█████▀▀╩═╦▄████▒▒██╩═╦═╩═ 
╦═▐█████▄▄▄██▀▀▀▀▀▀▀▀▀██▄▄▄▄████████▒▒██╦═╩═╦═ 
╩═╦▀████████████▄▄▄██████████████▀╦█▒▒▒█╩═╦═╩═ 
╦═╩═╦▀████████████████████████▀═╦═╩█▒▒▒█╦═╩═╦═");

                    pular();

                    if (veneno == 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("O Monstro está envenenado !");
                        Console.ResetColor();
                        pular();
                    }

                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("VIDA:" + vidamon);
                    Console.WriteLine("ATK:" + atkmon);
                    Console.WriteLine("DEF:" + defmon);
                    Console.WriteLine("VELO:" + velomon);
                    pular();
                    Console.ResetColor();

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("SUA VIDA: " + vida);
                    Console.WriteLine("SEU ATK : " + atk);
                    Console.WriteLine("SUA DEF : " + def);
                    Console.WriteLine("SUA VELO: " + velo);
                    pular();
                    Console.ResetColor();

                    Console.WriteLine("RODADA: " + rodadamon);

                    Continuar();

                    if (veneno == 2)
                    {
                        vidamon -= 2;
                    }


                    if (velo < velomon)
                    {
                        Random rr = new Random();
                        criticomob = rr.Next(1, 11);

                        if (criticomob == 3)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("Monstro Critico !!!" + "\n");
                            Console.ResetColor();
                            atkmon *= 2;
                        }

                        //HABILIDADE DO MONSTRO
                        Random h = new Random();
                        habilidade = h.Next(1, 11);

                        if (habilidade == 3)
                        {
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine("O Anteguemon usou sua Habilidade: Buraco Negro, seu ataque foi anulado ");
                            Console.ResetColor();
                            salvaratk2 = atk;

                            atk = 0;

                        }
                        //FIM DA HABILIDADE DO MONSTRO

                        Console.WriteLine("O AWNTEDEGUEMON te Ataca Primeiro !");

                        if (atkmon - def > 0)
                        {
                            vida -= atkmon - def;
                        }

                        atkmon = 30;

                        Console.ReadLine();

                        Random r = new Random();
                        criticoplayer = r.Next(1, 11);

                        if (criticoplayer == 3)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("Player Critico !!! " + "\n");
                            Console.ResetColor();
                            salvaratk = atk;
                            atk += atk;
                        }


                        Console.WriteLine("Você atacou o AWNTEDEGUEMON !");

                        //CALCULO DE ATAQUE DO PLAYER
                        if (atk - defmon > 0)
                        {
                            vidamon -= atk - defmon;
                        }

                        if (criticoplayer == 3)
                        {
                            atk = salvaratk;
                        }

                        if (habilidade == 3)
                        {
                            atk = salvaratk2;
                        }
                    }







                    rodadamon++;
                    Console.ReadLine();

                }



            }
            //FIM DO WHILE


            Console.Clear();

            if (vidamon <= 0)
            {
                pular();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(@"██    ██ ███████ ███    ██  ██████ ███████ ██    ██ 
██    ██ ██      ████   ██ ██      ██      ██    ██ 
██    ██ █████   ██ ██  ██ ██      █████   ██    ██ 
 ██  ██  ██      ██  ██ ██ ██      ██      ██    ██ 
  ████   ███████ ██   ████  ██████ ███████  ██████  ");

                Random Ouroslime = new Random();
                int Ouro = Ouroslime.Next(20, 31);

                Console.WriteLine("Ouro Obtido: " + Ouro);

                //DROP RARO DO SLIME
                Random emblema = new Random();
                int eb = emblema.Next(1, 11);


                if (eb == 3 && ebmon == 0)
                {
                    pular();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(@"██████  ██████   ██████  ██████      ██████   █████  ██████   ██████  
██   ██ ██   ██ ██    ██ ██   ██     ██   ██ ██   ██ ██   ██ ██    ██ 
██   ██ ██████  ██    ██ ██████      ██████  ███████ ██████  ██    ██ 
██   ██ ██   ██ ██    ██ ██          ██   ██ ██   ██ ██   ██ ██    ██ 
██████  ██   ██  ██████  ██          ██   ██ ██   ██ ██   ██  ██████  
                                                                      
                                                                      " + "\n");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("Emblema do MON |VELO + 10|");
                    Console.ResetColor();
                    ebmon += 10;
                }
                //FIM DO DROP RARO
                Saldo += Ouro;

                Console.ResetColor();
                Console.ReadLine();
            }
            else
            {
                pular();
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine(@"██████  ███████ ██████  ██████   ██████  ████████  █████  
██   ██ ██      ██   ██ ██   ██ ██    ██    ██    ██   ██ 
██   ██ █████   ██████  ██████  ██    ██    ██    ███████ 
██   ██ ██      ██   ██ ██   ██ ██    ██    ██    ██   ██ 
██████  ███████ ██   ██ ██   ██  ██████     ██    ██   ██ 
                                                          ");

                Console.ResetColor();

                Console.ReadLine();
            }



            menu();



        }

        static void slimehack(string escolhaluta)
        {
            int vidaslime = 12;
            int atkslime = 15;
            int defslime = 2;
            int veloslime = 15;
            int rodadaslime = 1;

            while (vida > 0 && vidaslime > 0)
            {
                if (escolhaluta == "000")
                {

                    Console.Clear();
                    Console.WriteLine("UM GOLDEN SLIME APARECEU !");



                    pular();

                    {
                        Console.WriteLine(@"                        
 ░░░░░░░▄▀▀▀▀█░░░░░░░░░░░░░░░░░░░░       
 ░░░░░░█▀░░░░█░░░░░░░░░░░░░░░░░░░░        
 ░░░░░█░░░░░░█▀▀▀▄▄░░░░░░▓░░░░░░░░        
 ░░░░▄█░░░░░░░░░░░░▀▀▄▄░▓▓▓░░░░░░░                              
 ░░░▄█░░░░░░░░░░░░░░░░░▀▓▓▓▓▀▀▀█░░                                              
 ▀▄▄█░░░░░░░░░░░░░░░░▓▓▓▓▓▓▓▓░░█░░
 ▀▄█░▀▄░░░░▄▄░░░░░░▓▓▓▓▓▓▓░░▓▓▓▓▓▓
 ▄▀█▀▄░░░░███░░░░░░░░░▓▓▓▓▓▓▓▓▓▓▓░
 ░▀█▀▄░░░░▀▀░░░░░░░░░▄▄░░░▓▓▓▓▓░░░
 ░░▀█░░░░░░░░▄▄░░░░░███░░░░▓▓░█░░░
 ░░░▀█░░░░░░█░░▀▄░░░▀▀░░░░░▓░█▀░░░
 ░░░░▀█░░░░░░▀▄▄▀░░░░░░░░▀▄░█▀░░░░
 ░░░░░░▀█▄░░░░░░░░░░░░░▀▄░░██░░░░░
 ░░░░░░░░░▀█▄░░░░░░░░▀▄░░██▀░▀░░░░
 ░░░░░░░░░░░░▀▀▄▄▄▄▄▄▄█▀█░░▀▄░░░░░
 ░░░░░░░░░░░░░░░░░░░░░░░░▀░░░░░░░░");

                    }

                    pular();

                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("VIDA:" + vidaslime);
                    Console.WriteLine("ATK:" + atkslime);
                    Console.WriteLine("DEF:" + defslime);
                    Console.WriteLine("VELO:" + veloslime);
                    pular();
                    Console.ResetColor();

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("SUA VIDA: " + vida);
                    Console.WriteLine("SEU ATK : " + atk);
                    Console.WriteLine("SUA DEF : " + def);
                    Console.WriteLine("SUA VELO: " + velo);
                    pular();
                    Console.ResetColor();

                    Console.WriteLine("RODADA: " + rodadaslime);

                    Continuar();



                    if (velo > veloslime)
                    {
                        Console.WriteLine("Você atacou o slime Primeiro !");
                        vidaslime -= atk - defslime;
                        Console.ReadLine();

                        Console.WriteLine("O Slime te Ataca !");
                        vida -= atkslime - def;
                    }
                    else
                    {
                        Console.WriteLine("O Slime te Ataca Primeiro !");
                        vida -= atkslime - def;

                        Console.WriteLine("Você atacou o Slime !");
                        vidaslime -= atk - defslime;
                        Console.ReadLine();

                    }







                    rodadaslime++;
                    Console.ReadLine();

                }



            }
            //FIM DO WHILE


            Console.Clear();

            if (vidaslime <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(@"██    ██ ███████ ███    ██  ██████ ███████ ██    ██ 
██    ██ ██      ████   ██ ██      ██      ██    ██ 
██    ██ █████   ██ ██  ██ ██      █████   ██    ██ 
 ██  ██  ██      ██  ██ ██ ██      ██      ██    ██ 
  ████   ███████ ██   ████  ██████ ███████  ██████  ");

                Random Ouroslime = new Random();
                int Ouro = Ouroslime.Next(2000, 2002);

                Console.WriteLine("Ouro Obtido: " + Ouro);

                Saldo += Ouro;

                Console.ResetColor();
                Console.ReadLine();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine(@"██████  ███████ ██████  ██████   ██████  ████████  █████  
██   ██ ██      ██   ██ ██   ██ ██    ██    ██    ██   ██ 
██   ██ █████   ██████  ██████  ██    ██    ██    ███████ 
██   ██ ██      ██   ██ ██   ██ ██    ██    ██    ██   ██ 
██████  ███████ ██   ██ ██   ██  ██████     ██    ██   ██ 
                                                          ");

                Console.ResetColor();

                Console.ReadLine();
            }



            menu();



        }

        static void Alienbina(string escolhaluta)
        {
            int vidaalien = 90;
            int atkalien = 47;
            int defalien = 14;
            int veloalien = 56;
            int rodadaalien = 1;

            while (vida > 0 && vidaalien > 0)
            {
                if (escolhaluta == "5")
                {

                    Console.Clear();
                    Console.WriteLine("UM UFO BROTOU NO CÉU !");



                    pular();

                    if (trans > 0)
                    {
                        Console.WriteLine(@"███████▀▀▀░░░░░░░▀▀▀███████
██████▀░░░░░░░░░░░░░░░▀████
█████│░░░░░░░░░░░░░░░░│████
████└┐░░░░░░░░░░░░░░░┌┘░███
███░░└┐░░░░░░░░░░░░░░┌┘░░██
███░┌┘▄▄▄▄▄░░░░░▄▄▄▄▄└┐░░██
██▌░▄██████▄░░░▄██████▄░▐██
███─┘░░▓▓▓▓░░░░░▓▓▓▓░░└─███
██▀▓▓▓░▓▓▓▓░░░░░▓▓▓▓░▓▓░▀██
██▄▓▓▓░▓▓▓▓▄▄▄▄▄▓▓▓▓░▓▓▄███
████▄─┘█████████████└─▄████
█████░░▐███████████▌░░█████
██████░░▀█████████▀░░▐█████
███████░░░░▓▓▓▓▓░░░░▄██████
████████▄░░░░░░░░░▄████████
███████████▓▓▓▓▓███████████
███████████▓▓▓▓▓███████████

████╗████████╗██╗███████╗███╗═══███╗████████╗
═██╔╝═══██╔══╝╚█║██╔════╝████╗═████║██╔═════╝
═██║════██║════╚╝███████╗██╔████╔██║█████╗
═██║════██║══════╚════██║██║╚██╔╝██║██╔══╝
████╗═══██║══════███████║██║═╚═╝═██║███████╗");
                    }
                    else
                    {


                        Console.WriteLine(@"███████▓█████▓▓╬╬╬╬╬╬╬╬▓███▓╬╬╬╬╬╬╬▓╬╬▓█
████▓▓▓▓╬╬▓█████╬╬╬╬╬╬███▓╬╬╬╬╬╬╬╬╬╬╬╬╬█
███▓▓▓▓╬╬╬╬╬╬▓██╬╬╬╬╬╬▓▓╬╬╬╬╬╬╬╬╬╬╬╬╬╬▓█
████▓▓▓╬╬╬╬╬╬╬▓█▓╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬▓█
███▓█▓███████▓▓███▓╬╬╬╬╬╬▓███████▓╬╬╬╬▓█
████████████████▓█▓╬╬╬╬╬▓▓▓▓▓▓▓▓╬╬╬╬╬╬╬█
███▓▓▓▓▓▓▓▓▓▓▓▓▓▓█▓╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬▓█
████▓▓▓▓▓▓▓▓▓▓▓▓▓█▓╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬▓█
███▓█▓▓▓▓▓▓▓▓▓▓▓▓▓▓╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬▓█
█████▓▓▓▓▓▓▓▓█▓▓▓█▓╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬▓█
█████▓▓▓▓▓▓▓██▓▓▓█▓╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬██
█████▓▓▓▓▓████▓▓▓█▓╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬██
████▓█▓▓▓▓██▓▓▓▓██╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬██
████▓▓███▓▓▓▓▓▓▓██▓╬╬╬╬╬╬╬╬╬╬╬╬█▓╬▓╬╬▓██
█████▓███▓▓▓▓▓▓▓▓████▓▓╬╬╬╬╬╬╬█▓╬╬╬╬╬▓██
█████▓▓█▓███▓▓▓████╬▓█▓▓╬╬╬▓▓█▓╬╬╬╬╬╬███
██████▓██▓███████▓╬╬╬▓▓╬▓▓██▓╬╬╬╬╬╬╬▓███
███████▓██▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓╬╬╬╬╬╬╬╬╬╬╬████
███████▓▓██▓▓▓▓▓╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬▓████
████████▓▓▓█████▓▓╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬▓█████
█████████▓▓▓█▓▓▓▓▓███▓╬╬╬╬╬╬╬╬╬╬╬▓██████
██████████▓▓▓█▓▓▓▓▓██╬╬╬╬╬╬╬╬╬╬╬▓███████
███████████▓▓█▓▓▓▓███▓╬╬╬╬╬╬╬╬╬▓████████
██████████████▓▓▓███▓▓╬╬╬╬╬╬╬╬██████████
███████████████▓▓▓██▓▓╬╬╬╬╬╬▓███████████");

                    }


                    pular();

                    if (veneno == 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("O Monstro está envenenado !");
                        Console.ResetColor();
                        pular();
                    }

                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("VIDA:" + vidaalien);
                    Console.WriteLine("ATK:" + atkalien);
                    Console.WriteLine("DEF:" + defalien);
                    Console.WriteLine("VELO:" + veloalien);
                    pular();
                    Console.ResetColor();

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("SUA VIDA: " + vida);
                    Console.WriteLine("SEU ATK : " + atk);
                    Console.WriteLine("SUA DEF : " + def);
                    Console.WriteLine("SUA VELO: " + velo);
                    pular();
                    Console.ResetColor();

                    Console.WriteLine("RODADA: " + rodadaalien);

                    Continuar();

                    if (veneno == 2)
                    {
                        vidaalien -= 2;
                    }

                    if (velo > veloalien)
                    {
                        Random r = new Random();
                        criticoplayer = r.Next(1, 11);

                        if (criticoplayer == 3)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("Player Critico !!! " + "\n");
                            Console.ResetColor();
                            salvaratk = atk;
                            atk += atk;
                        }

                        Console.WriteLine("Você atacou o ET primeiro !");

                        //CALCULO DE ATAQUE DO PLAYER
                        if (atk - defalien > 0)
                        {
                            vidaalien -= atk - defalien;
                        }

                        pular();
                        if (criticoplayer == 3)
                        {
                            atk = salvaratk;
                        }


                        Console.ReadLine();

                        Random rr = new Random();
                        criticomob = rr.Next(1, 11);

                        if (criticomob == 3)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("Monstro Critico !!!" + "\n");
                            Console.ResetColor();
                            atkalien *= 2;
                        }

                        //HABILIDADE DO MONSTRO
                        Random h = new Random();
                        habilidade = h.Next(1, 4);

                        if (habilidade == 3 && trans == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine("O Alien Transcende ! |Ganhou 30 de VIDA|");
                            Console.ResetColor();
                            vidaalien += 40;

                            trans++;

                        }
                        //FIM DA HABILIDADE DO MONSTRO

                        Console.WriteLine("O ET te Ataca !");

                        if (atkalien - def > 0)
                        {
                            vida -= atkalien - def;
                        }

                        atkalien = 47;
                    }
                    else
                    {
                        Random rr = new Random();
                        criticomob = rr.Next(1, 11);

                        if (criticomob == 3)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("Monstro Critico !!!" + "\n");
                            Console.ResetColor();
                            atkalien *= 2;
                        }

                        //HABILIDADE DO MONSTRO
                        Random h = new Random();
                        habilidade = h.Next(1, 4);

                        if (habilidade == 3 && trans == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine("O Alien Transcende ! |Ganhou 30 de VIDA|");
                            Console.ResetColor();
                            vidaalien += 40;


                            trans++;
                        }
                        //FIM DA HABILIDADE DO MONSTRO

                        Console.WriteLine("VOCE FOI HACKIADO !");

                        if (atkalien - def > 0)
                        {
                            vida -= atkalien - def;
                        }

                        atkalien = 47;

                        pular();

                        Random r = new Random();
                        criticoplayer = r.Next(1, 11);

                        if (criticoplayer == 3)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("Player Critico !!! ");
                            Console.ResetColor();
                            salvaratk = atk;
                            atk += atk;
                        }

                        Console.ReadLine();
                        Console.WriteLine("Você atacou o UFO !");

                        //CALCULO DE ATAQUE DO PLAYER
                        if (atk - defalien > 0)
                        {
                            vidaalien -= atk - defalien;
                        }

                        if (criticoplayer == 3)
                        {
                            atk = salvaratk;
                        }



                    }







                    rodadaalien++;
                    Console.ReadLine();

                }



            }
            //FIM DO WHILE


            Console.Clear();

            if (vidaalien <= 0)
            {
                pular();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(@"██    ██ ███████ ███    ██  ██████ ███████ ██    ██ 
██    ██ ██      ████   ██ ██      ██      ██    ██ 
██    ██ █████   ██ ██  ██ ██      █████   ██    ██ 
 ██  ██  ██      ██  ██ ██ ██      ██      ██    ██ 
  ████   ███████ ██   ████  ██████ ███████  ██████  ");

                Random Ouroalien = new Random();
                int Ouro = Ouroalien.Next(35, 51);

                Console.WriteLine("Ouro Obtido: " + Ouro);

                Saldo += Ouro;

                Console.ResetColor();
                Console.ReadLine();
            }
            else
            {
                pular();
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine(@"██████  ███████ ██████  ██████   ██████  ████████  █████  
██   ██ ██      ██   ██ ██   ██ ██    ██    ██    ██   ██ 
██   ██ █████   ██████  ██████  ██    ██    ██    ███████ 
██   ██ ██      ██   ██ ██   ██ ██    ██    ██    ██   ██ 
██████  ███████ ██   ██ ██   ██  ██████     ██    ██   ██ 
                                                          ");
                trans = 0;
                Console.ResetColor();

                Console.ReadLine();
            }

            if (vidaalien <= 0)
            {
                Console.WriteLine(@"██    ██  ██████   ██████ ███████     ██    ██ ███████ ███    ██  ██████ ███████ ██    ██      ██████           ██  ██████   ██████   ██████  
██    ██ ██    ██ ██      ██          ██    ██ ██      ████   ██ ██      ██      ██    ██     ██    ██          ██ ██    ██ ██       ██    ██ 
██    ██ ██    ██ ██      █████       ██    ██ █████   ██ ██  ██ ██      █████   ██    ██     ██    ██          ██ ██    ██ ██   ███ ██    ██ 
 ██  ██  ██    ██ ██      ██           ██  ██  ██      ██  ██ ██ ██      ██      ██    ██     ██    ██     ██   ██ ██    ██ ██    ██ ██    ██ 
  ████    ██████   ██████ ███████       ████   ███████ ██   ████  ██████ ███████  ██████       ██████       █████   ██████   ██████   ██████  
                                                                                                                                              
                                                                                                                                              ");

                Continuar();

                Console.WriteLine(@" ██████  ██████  ██████  ██  ██████   █████  ██████   ██████      ██████   ██████  ██████           ██  ██████   ██████   █████  ██████  
██    ██ ██   ██ ██   ██ ██ ██       ██   ██ ██   ██ ██    ██     ██   ██ ██    ██ ██   ██          ██ ██    ██ ██       ██   ██ ██   ██ 
██    ██ ██████  ██████  ██ ██   ███ ███████ ██   ██ ██    ██     ██████  ██    ██ ██████           ██ ██    ██ ██   ███ ███████ ██████  
██    ██ ██   ██ ██   ██ ██ ██    ██ ██   ██ ██   ██ ██    ██     ██      ██    ██ ██   ██     ██   ██ ██    ██ ██    ██ ██   ██ ██   ██ 
 ██████  ██████  ██   ██ ██  ██████  ██   ██ ██████   ██████      ██       ██████  ██   ██      █████   ██████   ██████  ██   ██ ██   ██ 
                                                                                                                                         
                                                                                                                                         ");
            }






            if (vidaalien >= 1)
            {
                menu();
            }




        }




    }

}

