using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Diseñar un programa para leer una serie de números
            //hasta obtener un número superior a 100.

            int num;
            do
            {
                Console.Write("INGRESE UN NUMERO SEGUIDO DE ENTER: ");
                num= int.Parse(Console.ReadLine());

            }
            while (num <= 100);
            Console.Write("NUMERO FUERA DE RANGO: ");
        }
    }
}
