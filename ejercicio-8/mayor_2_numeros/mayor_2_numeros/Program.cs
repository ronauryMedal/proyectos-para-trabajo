using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mayor_2_numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int Ivalor1, Ivalor2;

            Console.WriteLine("ingresa el primer valor");
            Ivalor1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ingresa el segundo valor");
            Ivalor2 = Convert.ToInt32(Console.ReadLine());

            if (Ivalor1==Ivalor2)
            {
                Console.WriteLine("los valores ingresados tiene el mismo valor");

            }
            else if (Ivalor1>Ivalor2)
            {
                Console.WriteLine("el numero mayor es:"+Ivalor1);
            }
            else
            {
                Console.WriteLine("el numero mayor es:" + Ivalor2);
            }

            Console.ReadKey();
        }
    }
}
