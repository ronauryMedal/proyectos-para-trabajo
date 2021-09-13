using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numero_Intermedio
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor1, valor2, valor3;
            Console.WriteLine("ingrese el primer numero");
            valor1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ingrese el segundo numero");
            valor2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ingrese el tercer numero");
            valor3 = Convert.ToInt32(Console.ReadLine());

            if ((valor1 > valor2))
            {
                if ((valor1 < valor3))
                {
                    Console.WriteLine("el valor intermedio es:"+valor1);
                }
                else
                {
                    if ((valor2 < valor3))

                    {

                        Console.WriteLine("el valor intermedio es:" + valor3);
                    }
                    else
                    {

                        Console.WriteLine("el valor intermedio es:" + valor2);
                    }
                }
            }
            else
            {
                if ((valor2 < valor3))
                {
                    Console.WriteLine("el valor intermedio es:" + valor2);
                }
                else
                {
                    if ((valor1 < valor3))

                    {

                        Console.WriteLine("el valor intermedio es:" + valor3);
                    }
                    else
                    {

                        Console.WriteLine("el valor intermedio es:" + valor1);
                    }
                }
            }
            Console.ReadKey();


        }
    }
}
