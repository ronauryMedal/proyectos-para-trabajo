using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mayorMenorDe_N_numero
{
    class Program
    {
        static void Main(string[] args)
        {

            int NumMayor = 0, NumMenor = 0, numIngresado = 0;
            Console.WriteLine("-----------------------el mayor de n cantidad de numeros-------------");

            Console.WriteLine("cantidad de numeros a comparar");
            int numeros = int.Parse(Console.ReadLine());
            for (int i = 1; i <= numeros; i++)
            {
                Console.WriteLine("Digite un numero: ");
                numIngresado = int.Parse(Console.ReadLine());

                if (i == 1)
                {
                    NumMayor = numIngresado;
                    NumMenor = numIngresado;
                }
                if (numIngresado > NumMayor){
                    NumMayor = numIngresado; 
                }
                if (numIngresado < NumMenor){ 
                    NumMenor = numIngresado;
                }              
            }

            Console.WriteLine("el numero mayor es:" + NumMayor);
            Console.WriteLine("el numero menor es:" + NumMenor);

            Console.ReadKey();
        }
    }
}
