using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarifa_telefonica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------------------------- tarifa telefonica--------------------------");

            int cantKilovatios;
            double tarifa, costoKilovatio=0;

            Console.WriteLine("ingrese la cantidad de kilovatio");
            cantKilovatios = Convert.ToInt32(Console.ReadLine());

            if (cantKilovatios <= 1000)
            {
                costoKilovatio = 1.60;
            }
            else if (cantKilovatios > 1000 && cantKilovatios <= 1800)
            {
                costoKilovatio = 0.80;
            }
            else if (cantKilovatios > 1800)
            {
                costoKilovatio = 0.60;
            }

            tarifa = cantKilovatios * costoKilovatio;


            Console.WriteLine("su total a pagar es: " + tarifa);

            Console.ReadKey();
        }
    }
}
