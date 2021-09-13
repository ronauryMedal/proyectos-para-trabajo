using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propuesto
{
    class Program
    {
        static void Main(string[] args)
        {
            int Ivalor;
            string letra;
            Console.WriteLine("pulse una telca");
            letra =Console.ReadLine();

            byte[] asciiValues = Encoding.ASCII.GetBytes(letra);

            foreach (var letra2 in asciiValues)
            {
                Ivalor = Convert.ToInt32(letra2);
                if (Ivalor>=48 && Ivalor<=57)
                {
                    Console.WriteLine("la tecla pulsada es un numero");
                }
                else
                {
                    Console.WriteLine("la tecla pulsada es un letra");

                }
                Console.WriteLine(letra2);
            }
            Console.ReadKey();
        }
    }
}
