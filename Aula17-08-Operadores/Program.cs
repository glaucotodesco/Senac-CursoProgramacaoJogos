using System;

namespace Aula17_08_Operadores
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double x = 10, y = 20;

            x = x + y;
            Console.WriteLine(x);

            
            //   x += y;   ou  x = x + y;
            //   x -= y;   ou  x = x - y;
            //   x *= y;   ou  x = x * y;
            //   x /= y;   ou  x = x / y; 
            

            x += y;
            Console.WriteLine(x);

            int z = 10;
            Console.WriteLine(z);
            z = z + 1;
            Console.WriteLine(z);
            z += 1;
            Console.WriteLine(z);
            z++;
            Console.WriteLine(z);

            int w = 10;
            Console.WriteLine(w);
            w = w - 1;
            Console.WriteLine(w);
            w -= 1;
            Console.WriteLine(w);
            w--;
            Console.WriteLine(w);

           

            int a=0, b;

            b = a + 1;

            Console.WriteLine(a);
            Console.WriteLine(b);
             

            int c=10, d, e;

            c++;
            d = c++;
            e = ++c;

            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);









        }
    }
}
