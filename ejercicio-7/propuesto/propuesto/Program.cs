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

            int Ivalor1, Ivalor2;
            double Dresultado;
            Console.WriteLine("ingrese el primer valor");
            Ivalor1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingresael segundo valor");
            Ivalor2 = Convert.ToInt32(Console.ReadLine());
            Dresultado = (Ivalor1 + Ivalor2) * (Ivalor1 - Ivalor2);
            Console.WriteLine("El resultado es : " + Dresultado);


            Console.ReadKey();
        }
    }
}
