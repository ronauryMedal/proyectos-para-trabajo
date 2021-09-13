using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace invertir_3_cifras
{
    class Program
    {
        static void Main(string[] args)
        {
            string resultado;

            Console.WriteLine("ingrese un numero de 3 cifras que desee invertir");

            char[] arreglo = Console.ReadLine().ToCharArray();

            if (arreglo.Length!=3){
                Console.WriteLine("solo se permiten cantidades de 3 dijitos");
            }
            else{

                Array.Reverse(arreglo);
                resultado = new string(arreglo);
                Console.WriteLine(arreglo);
            }
            Console.ReadKey();
        }
    }
}
