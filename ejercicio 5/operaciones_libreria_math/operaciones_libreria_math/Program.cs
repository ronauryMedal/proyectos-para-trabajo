using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace operaciones_libreria_math
{
    class Program
    {
        static void Main(string[] args)
        {
            int menu, Ivalor1,Ivalor2,opcionSalir,Iresultado;
            double Dresultado,Dvalor1,Dvalor2;
            
            inicio: Console.Clear();
            Console.WriteLine("--------------------------------welcome to basic oprations with library math------------------------------");

            Console.WriteLine("1-valor absoluto\n" +
                "2-potencia\n" +
                "3-raiz cuadrada\n" +
                "4-seno\n" +
                "5-coceno\n" +
                "6-maximo\n" +
                "7-minimo\n");

            Console.WriteLine("selecione la operacion que desea realizar");
            menu = Convert.ToInt32(Console.ReadLine());
            if (menu >= 1 && menu <= 7) 
            {
                switch (menu)
                {
                    case 1:
                            Console.WriteLine("ingrese un muero entero");
                            Ivalor1 = Convert.ToInt32(Console.ReadLine());
                            Iresultado = Math.Abs(Ivalor1);
                            Console.WriteLine("el valor absoluto es:" + Iresultado + "\n");
                            Console.WriteLine("desea realizar otra operacion\n" +
                            "1=SI\n" +
                            "2=no");
                            opcionSalir = Convert.ToInt32(Console.ReadLine());

                            if (opcionSalir==1){
                                goto inicio;
                            }
                            else{
                                Console.WriteLine("pulse cualquier tecla para cerrar");
                            }
                             break;


                    case 2:

                        Console.WriteLine("ingerese el valor a pontenciar");
                        Dvalor1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("ingerese el valor ha elebar");
                        Dvalor2 = Convert.ToDouble(Console.ReadLine());
                        Dresultado = Math.Pow(Dvalor1, Dvalor2);
                        Console.WriteLine("la potencia es:" + Dresultado + "\n");
                        Console.WriteLine("desea realizar otra operacion\n" +
                        "1=SI\n" +
                        "2=no");
                        opcionSalir = Convert.ToInt32(Console.ReadLine());

                        if (opcionSalir == 1)
                        {
                            goto inicio;
                        }
                        else
                        {
                            Console.WriteLine("pulse cualquier tecla para cerrar");
                        }
                        break;

                    case 3:


                        Console.WriteLine("ingrese un muero entero");
                        Dvalor1 = Convert.ToDouble(Console.ReadLine());
                        Dresultado = Math.Sqrt(Dvalor1);
                        Console.WriteLine("la raiz cuadrada es:" + Dresultado + "\n");
                        Console.WriteLine("desea realizar otra operacion\n" +
                        "1=SI\n" +
                        "2=no");
                        opcionSalir = Convert.ToInt32(Console.ReadLine());

                        if (opcionSalir == 1)
                        {
                            goto inicio;
                        }
                        else
                        {
                            Console.WriteLine("pulse cualquier tecla para cerrar");
                        }
                        break;

                    case 4:


                        Console.WriteLine("ingrese un muero entero");
                        Dvalor1 = Convert.ToDouble(Console.ReadLine());
                        Dresultado = Math.Sin(Dvalor1*Math.PI/180);
                        Console.WriteLine("el ceno es:" + Dresultado + "\n");
                        Console.WriteLine("desea realizar otra operacion\n" +
                        "1=SI\n" +
                        "2=no");
                        opcionSalir = Convert.ToInt32(Console.ReadLine());

                        if (opcionSalir == 1)
                        {
                            goto inicio;
                        }
                        else
                        {
                            Console.WriteLine("pulse cualquier tecla para cerrar");
                        }
                        break;

                    case 5:


                        Console.WriteLine("ingrese un muero entero");
                        Dvalor1 = Convert.ToDouble(Console.ReadLine());
                        Dresultado = Math.Cos(Dvalor1 * Math.PI / 180);
                        Console.WriteLine("el coseno es:" + Dresultado + "\n");
                        Console.WriteLine("desea realizar otra operacion\n" +
                        "1=SI\n" +
                        "2=no");
                        opcionSalir = Convert.ToInt32(Console.ReadLine());

                        if (opcionSalir == 1)
                        {
                            goto inicio;
                        }
                        else
                        {
                            Console.WriteLine("pulse cualquier tecla para cerrar");
                        }
                        break;

                    case 6:

                        Console.WriteLine("ingrese un muero entero");
                        Dvalor1 = Convert.ToDouble(Console.ReadLine());
                        Dresultado = Math.Max(Dvalor1,50);
                        Console.WriteLine("el max de el valor es:" + Dresultado + "\n");
                        Console.WriteLine("desea realizar otra operacion\n" +
                        "1=SI\n" +
                        "2=no");
                        opcionSalir = Convert.ToInt32(Console.ReadLine());

                        if (opcionSalir == 1)
                        {
                            goto inicio;
                        }
                        else
                        {
                            Console.WriteLine("pulse cualquier tecla para cerrar");
                        }
                        break;

                    case 7:

                        Console.WriteLine("ingrese un muero entero");
                        Dvalor1 = Convert.ToDouble(Console.ReadLine());
                        Dresultado = Math.Min(Dvalor1, 50);
                        Console.WriteLine("el min de el valor es:" + Dresultado + "\n");
                        Console.WriteLine("desea realizar otra operacion\n" +
                        "1=SI\n" +
                        "2=no");
                        opcionSalir = Convert.ToInt32(Console.ReadLine());

                        if (opcionSalir == 1)
                        {
                            goto inicio;
                        }
                        else
                        {
                            Console.WriteLine("pulse cualquier tecla para cerrar");
                        }
                        break;


                }
            }
            else
            {
                Console.WriteLine("ingrese una opcion valida");
                Thread.Sleep(2000);
                goto inicio;
            }






            Console.ReadKey();
        }
    }
}
