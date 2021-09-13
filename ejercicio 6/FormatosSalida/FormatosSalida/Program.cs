using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormatosSalida
{
    class Program
    {
        static void Main(string[] args)
        {
            double Base, altura,resultado;
            Console.WriteLine("ingrese la base");
            Base = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("ingrese la altura");
            altura = Convert.ToDouble(Console.ReadLine());
            resultado = Base*altura/2;
            Console.WriteLine("AREA TRIANGULO :" + String.Format("{0:####.00}", resultado));
            Console.WriteLine("AREA TRIANGULO :" + String.Format("{0:c}", resultado));
            Console.WriteLine("AREA TRIANGULO :" + String.Format("{0:f}", resultado));
            Console.WriteLine("AREA TRIANGULO :" + String.Format("{0:g}", resultado+"\n"));
            Console.WriteLine("HOY ES " + String.Format("Hoy es {0:F}", DateTime.Now));
            Console.WriteLine("HOY ES " + String.Format("Hoy es {0:dddd}{0:dd/MM/yyy}",DateTime.Now));
           
    }
}
