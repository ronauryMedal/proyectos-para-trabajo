using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tablaMultiplicar
{
    class Program
    {
        static void Main(string[] args)
        {
            int tabla,result;
            Console.WriteLine("------------------------------------tabla de multiplicar---------------------------");

            Console.WriteLine("ingrese la tabla que quiere visualizar");
            tabla = int.Parse(Console.ReadLine());

            for (int i=1;i<=12; i++)
            {
                result = i * tabla;

                Console.WriteLine(i + "x" + tabla + "=" + result);
            }

            Console.ReadLine();
        }
    }
}
