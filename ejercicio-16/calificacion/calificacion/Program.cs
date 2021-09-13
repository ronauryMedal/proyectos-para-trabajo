using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calificacion
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, nota3, nota4,notaFinal;
            Console.WriteLine("---------------------------promedio de califiaciones----------------------------");

            Console.WriteLine("ingrese primera nota");
            nota1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("ingre sesegunda  nota");
            nota2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("ingrese tercera nota");
            nota3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("ingrese cuarta nota");
            nota4 = Convert.ToDouble(Console.ReadLine());

            notaFinal = ((nota1 + nota2 + nota3 + nota4) / 4);

            if (notaFinal<70)
            {
                Console.WriteLine("la nota final es:" + notaFinal + "  'reprovado'");
            }else if (notaFinal >=70 && notaFinal<80)
            {
                Console.WriteLine("la nota final es:" + notaFinal + "  'aprovado'");
            }else if (notaFinal >=80 && notaFinal<=90)
            {
                Console.WriteLine("la nota final es:" + notaFinal + "  'buen estudiante'");
            }else if (notaFinal >90 && notaFinal<=100)
            {
                Console.WriteLine("la nota final es:" + notaFinal + "  'estudiante sobre saliente'");
            }

            Console.ReadKey();
        }
    }
}
