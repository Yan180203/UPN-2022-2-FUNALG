using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Diseñar un programa que visualice el siguiente triángulo isósceles.
            int a;
            Console.Write("Ingrese numero de escalones de la piramide: ");
            a = int.Parse(Console.ReadLine());
            for (int y = 1; y <= a; y++)
            {
                for (int x = 1; x <= a - y; x++)
                {
                    Console.Write(" ");
                }
                for (int x = 1; x <= y; x++)
                {
                    Console.Write("*");
                }
                for (int x = 1; x <= y - 1; x++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
