using System;

namespace Aula17_08_OperadoresII
{
    class Program
    {
        static void Main(string[] args)
        {
            bool resp = true;
            Console.WriteLine(resp);
            resp = false;
            Console.WriteLine(resp);
           
            /*  Operadores Relacionais
             
                >    Maior
                >=   Maior ou Igual
                <    Menor
                <=   Menor ou Igual 
                ==   Igual
                !=   Diferente
            */ 
            
            resp = 10 > 20;
            Console.WriteLine(resp);

            resp = 10 >= 20;
            Console.WriteLine(resp);

            resp = 10 <= 20;
            Console.WriteLine(resp);

            resp = 10 != 20;
            Console.WriteLine(resp);

            resp = 20 != 20;
            Console.WriteLine(resp);

            int x = 10, y = 20;
            Console.WriteLine(x > y);
            Console.WriteLine(!(x > y));


        }
    }
}
