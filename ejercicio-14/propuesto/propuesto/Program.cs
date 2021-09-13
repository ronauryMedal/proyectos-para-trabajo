using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace propuesto
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;

            Console.WriteLine("ingrese su nombre");
            nombre = Console.ReadLine();

            if (nombre=="david")
            {
                Console.WriteLine("hola " + nombre);
            }
            else
            {
                Console.WriteLine("no te conozco");
            }


            Console.ReadKey();


        }
    }
}
