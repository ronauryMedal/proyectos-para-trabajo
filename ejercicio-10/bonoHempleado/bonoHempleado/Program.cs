using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bonoHempleado
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantHijos, Bonos;
            double total, sueldo;
            string nombre;

            Console.WriteLine("--------------------------------bono de empleado por hijos");

            Console.WriteLine("ingrese nombre del empleado");
            nombre = Console.ReadLine();

            Console.WriteLine("ingrese el sueldo  del empleado");
            sueldo =Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("ingrese cantidad de hijos");
            cantHijos =Convert.ToInt32(Console.ReadLine());

            if (cantHijos>=3)
            {
                Bonos = (cantHijos * 10);
            }
            else
            {
                Bonos = cantHijos * 20;
            }
            total = sueldo + Bonos;

            Console.WriteLine("el empleado:" + nombre + "->" + string.Format("{0:c}", total));



            Console.ReadKey();


        }
    }
}
