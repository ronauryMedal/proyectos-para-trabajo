using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumasDeNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantidadNumeros;
            double numerEntrada,sumatoria=0;
            Console.WriteLine("--------sumas de n numeros");
            Console.WriteLine("ingrese la cantidad de numero que quieres sumar");
            cantidadNumeros = int.Parse(Console.ReadLine());

            for (int i = 1; i <=cantidadNumeros; i++)
            {
                Console.WriteLine("ingrese numero a sumar");
                numerEntrada = double.Parse(Console.ReadLine());

                sumatoria += numerEntrada;
            }
            Console.WriteLine("la sumatoria todal = " + sumatoria);

            Console.ReadKey();



        }
    }
}
