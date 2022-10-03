using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Diseñar un programa que imprima una tabla de m filas por n columnas y un caracter fijado.
            //El usuario debe ingresar “m”, “n” y el caracter.
            
            int f, c;
            string n;
            Console.Write("INGRESE NUMERO DE FILAS: ");
            f = int.Parse(Console.ReadLine());
            Console.Write("INGRESE NUMERO DE COLUMNAS: ");
            c = int.Parse(Console.ReadLine());
            Console.Write("INGRESE UN CARACTER: ");
            n = Console.ReadLine();

            for (int i = 0; i <= f; i++)
            {
                for (int j = 0; j <= c; j++)
                {
                    Console.Write("" + n + "");
                }
                Console.WriteLine("\n");
            }
            Console.ReadKey();
        }
    }
}
