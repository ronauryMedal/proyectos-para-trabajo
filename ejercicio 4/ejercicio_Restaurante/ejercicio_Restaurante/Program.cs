using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_Restaurante
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantidadHamburguesa, cantidadBebidas, cantidadPapas;
            double total_A_pagar;
            const double precioHamburguesa = 350;
            const double precioBebida = 150;
            const double precioPapas = 200;
            Console.WriteLine("----------------------welcome to burger king----------------------\n");

            Console.WriteLine("candiad de hamburguesa deseada");
            cantidadHamburguesa = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("candiad de papas deseada");
            cantidadPapas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("candiad de bebidas deseada");
            cantidadBebidas = Convert.ToInt32(Console.ReadLine());

            total_A_pagar = ((cantidadBebidas * precioBebida) + (cantidadHamburguesa * precioHamburguesa) + (cantidadPapas * precioPapas));

            Console.WriteLine("el total a pagar es:" + "$RD" + total_A_pagar);
            Console.WriteLine("pulse cualquier tecla para finalizar compra");

           
            Console.ReadKey();




        }
    }
}
