using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diasDeSemana
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.WriteLine("----------------------dias de la semana------------------------");

            Console.WriteLine("ingrese un numero del 1-7");
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero>0 && numero<=7)
            {
                switch (numero)
                {

                    case 1:

                        Console.WriteLine("el dia que corrresponde al numero seleccionado es lunes");
                        break;

                    case 2:

                        Console.WriteLine("el dia que corrresponde al numero seleccionado es martes");
                        break;

                    case 3:

                        Console.WriteLine("el dia que corrresponde al numero seleccionado es miercoles");
                        break;

                    case 4:

                        Console.WriteLine("el dia que corrresponde al numero seleccionado es juevez");
                        break;

                    case 5:

                        Console.WriteLine("el dia que corrresponde al numero seleccionado es viernes");
                        break;

                    case 6:

                        Console.WriteLine("el dia que corrresponde al numero seleccionado es sabado");
                        break;

                    case 7:

                        Console.WriteLine("el dia que corrresponde al numero seleccionado es Domingo");
                        break;
                }
            }
            else
            {
                Console.WriteLine("ingrese un valor en un rango de 1-7");
            }

            Console.ReadKey();

        }
    }
}
