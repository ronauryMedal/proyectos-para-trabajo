using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tablasMultiplicar
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantidad, resultado;
            Console.WriteLine("--------------------tabalas de multiplicar----------------------");

            Console.WriteLine("cuantas tablas desea mostrar");
            cantidad = int.Parse(Console.ReadLine());

            for (int i = 1; i <=cantidad; i++)
            {
                for (int h =1; h <= 12; h++)
                {
                    resultado = i * h;
                    Console.WriteLine(i + "x" + h + "=" + resultado);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
