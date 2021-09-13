using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace serieFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {

            int a, b, limite, auxiliar;
            Console.WriteLine("-------------------------------serie fibonasis----------------------");
            Console.WriteLine("cantidad de fibonacis a mostar");
            limite = int.Parse(Console.ReadLine());
            a = 0;
            b = 1;
            for (int i = 0; i < limite; i++)
            {
                auxiliar = a;
                a = b;
                b = auxiliar + a;
                Console.WriteLine(a);
            }

            Console.ReadKey();        }
    }
}
