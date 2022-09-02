using System;
using System.Threading;
namespace Aula01_09_Sprite
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int x, i,j;
            string pos;
            Random r = new Random();
            Console.CursorVisible = false;

            while (true)
            {

                i = 0;
                j = r.Next(1, 10);
                pos = "";
                while (i < j){
                    pos += "\t";
                    i++;
                }

                x = 20;
                while(x > 0)
                {
                    i = 0;
                    Console.Clear();

                    
                    while (i < x)
                    {
                        Console.WriteLine("");
                        i++;
                    }

                    Console.WriteLine(pos + "   /\\   ");
                    Console.WriteLine(pos + "   ||    ");
                    Console.WriteLine(pos + "   ||    ");
                    Console.WriteLine(pos + "  /||\\  ");
                    x--;
                    Thread.Sleep(10);
                }
                
            }

        }
    }
}
