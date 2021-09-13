using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace OperacionesBasicas
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            Double valor1, valor2, resultado;
            inicio: Console.Clear();
            Console.WriteLine("1-suma");
            Console.WriteLine("2-resta");
            Console.WriteLine("3-multiplicar");
            Console.WriteLine("4-dividir");
            Console.WriteLine("5-salir");

            Console.WriteLine("ingrese la operacion a realizar");
            opcion=Convert.ToInt32(Console.ReadLine());
            while (opcion<=4)
            {
                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("ha selecionado la suma!");
                        Console.WriteLine("ingrese el primer numero");
                        valor1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("ingrese el segundo numero");
                        valor2 = Convert.ToDouble(Console.ReadLine());
                        resultado = valor1 + valor2;
                        Console.WriteLine("el resultado es: " + resultado.ToString());
                        Thread.Sleep(4000);
                        goto inicio;
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("ha selecionado la resta!");
                        Console.WriteLine("ingrese el primer numero");
                        valor1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("ingrese el segundo numero");
                        valor2 = Convert.ToDouble(Console.ReadLine());
                        resultado = valor1 - valor2;
                        Console.WriteLine("el resultado es: " + resultado.ToString());
                        Thread.Sleep(4000);
                        goto inicio;
                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("ha selecionado la multiplicacion!");
                        Console.WriteLine("ingrese el primer numero");
                        valor1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("ingrese el segundo numero");
                        valor2 = Convert.ToDouble(Console.ReadLine());
                        resultado = valor1 * valor2;
                        Console.WriteLine("el resultado es: " + resultado.ToString());
                        Thread.Sleep(4000);
                        goto inicio;
                        break;

                    case 4:
                        Console.Clear();
                        Console.WriteLine("ha selecionado la divicion!");
                        Console.WriteLine("ingrese el primer numero");
                        valor1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("ingrese el segundo numero");
                        valor2 = Convert.ToDouble(Console.ReadLine());
                        resultado = valor1 / valor2;
                        Console.WriteLine("el resultado es: " + resultado.ToString());
                        Thread.Sleep(4000);
                        goto inicio;
                        break;

                }
            }
            
            Console.ReadKey();
        }
    }
}
