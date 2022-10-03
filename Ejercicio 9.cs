using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Diseñar un programa para leer sucesivamente números del
            //teclado hasta que aparezca un número comprendido entre 1 y 5

            int num;

            do
            {
                Console.Write("\t\tINGRESE UN NUMERO SEGUIDO DE ENTER: ");
                num = int.Parse(Console.ReadLine());
            }
            while (num <= 1 || num >= 5);

        }
    }
}
