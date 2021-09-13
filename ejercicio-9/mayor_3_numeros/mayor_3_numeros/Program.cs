using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mayor_3_numeros
{
    class Program
    {
        static void Main(string[] args)
        {

            int MAY, MEN, NUM1, NUM2, NUM3;
            Console.WriteLine("ingrese valor primer");
            NUM1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese valor segundo");
            NUM2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese valor tercer");
            NUM3 = Convert.ToInt32(Console.ReadLine());
            MAY = NUM1; MEN = NUM1;
            if ((NUM2 > MAY)) MAY = NUM2;
            if ((NUM3 > MAY)) MAY = NUM3;
            if ((NUM2 > MEN)) MEN = NUM2;
            if ((NUM3 < MEN)) MEN = NUM3;
            Console.WriteLine("MAYOR ES:" + MAY);
            Console.WriteLine("MENOR ES:" + MEN);

            Console.ReadKey();
        }
    }
}
