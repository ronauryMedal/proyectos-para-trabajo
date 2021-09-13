using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace invertir_numero_2_cifras
{
    class Program
    {
        static void Main(string[] args)
        {
            string resultadoString;
            inicio: Console.Clear();

            Console.WriteLine("ingrese un numero de 2 cifras que desee invertir");
            char[] arreglo = Console.ReadLine().ToCharArray();
            
            if (arreglo.Length!=2){

                    Console.WriteLine("solo se permiten valores de 2 dijitos ");
                Thread.Sleep(2000);
                goto inicio;
            }
            else{
               Array.Reverse(arreglo);
               resultadoString = new string(arreglo);
               Console.WriteLine("el resultado es:"+ resultadoString);

                Console.WriteLine("pulse cualquier tecla para cerrar");
            }
            Console.ReadKey();
        }
    }
}
