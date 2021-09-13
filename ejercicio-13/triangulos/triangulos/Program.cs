using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triangulos
{
    class Program
    {
        static void Main(string[] args)
        {
            int lado1, lado2, lado3;
            Console.WriteLine("---------------------------------------triangulos----------------------------------");

            Console.WriteLine("ingrese lado 1 del triangulo");
            lado1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ingrese lado 2 del triangulo");
            lado2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ingrese lado 3 del triangulo");
            lado3 = Convert.ToInt32(Console.ReadLine());


            if (lado1==lado2 && lado2==lado3)
            {
                Console.WriteLine("triaangulo equilatero, donde todos son iguales");
            }
            else if (lado1 != lado2 && lado1 != lado3 && lado2 != lado3)
            {
                Console.WriteLine("triaangulo eescaleno, donde todos los lados son diferente");

            }

            Console.ReadKey();
        }
    }
}
