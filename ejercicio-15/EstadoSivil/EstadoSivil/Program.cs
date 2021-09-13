using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstadoSivil
{
    class Program
    {
        static void Main(string[] args)
        {

            string EstCivil=string.Empty;
            Console.WriteLine("ingrese una de estas letras C,S,V,D :");
            EstCivil = Console.ReadLine();

            if (EstCivil.Length>1)
            {
                Console.WriteLine("ingrese una de las letras indicadas");
            }
            else
            {

           
                switch (EstCivil)
                {
                    case "c":
                        ; Console.WriteLine(" usted es CASADO");
                        break;
                    case "s":
                        ; Console.WriteLine("usted es SOLTERO");
                        break;
                    case "v":
                        ; Console.WriteLine("usted es VIUDO");
                        break;
                    case "d":
                        ; Console.WriteLine(" usted es DIVORCIADO");
                        break;

                    default:
                        Console.WriteLine("opcion incorrecta");
                        break;
                }
            }
                    Console.ReadKey();
        }
    }
}
