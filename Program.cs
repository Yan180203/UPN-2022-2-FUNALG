using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Diseñar un programa para imprimir la suma de los primeros números naturales imparesmenores o iguales que n.

            int num,suma = 0;
            Console.WriteLine("ESCRIBA UN NUMERO: ");
            num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i = i + 2)
            {
                suma = suma + i;
            }
            Console.WriteLine("LA SUMA DE NUMEROS IMPARES ES : " + suma);
            Console.ReadKey();
        }
    }
}
