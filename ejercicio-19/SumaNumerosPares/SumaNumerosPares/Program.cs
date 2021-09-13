using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumaNumerosPares
{
    class Program
    {
        static void Main(string[] args)
        {
            int max,total=0,totalImpar=0,TotalPares=0;
            Console.WriteLine("-----------------suma de numeros pares y impares hasta un maximo de numeros");
            Console.WriteLine("ingrese el maximo");
            max = int.Parse(Console.ReadLine());

            for (int i = 1; i <= max; i++)
            {
                total=total + 1;
                if (total%2==0)
                {
                    TotalPares=TotalPares + 1;
                }
                else
                {
                    totalImpar = totalImpar + 1;
                }
            }

            Console.WriteLine("el total de numero pares es:" + TotalPares);
            Console.WriteLine("el total de numeros inpares es:" + totalImpar);

            Console.ReadKey();
        }
    }
}
