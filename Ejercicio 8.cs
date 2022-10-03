using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Diseñar un programa que permita escribir en una pantalla la frase
            //“¿Desea continuar? S/N”hasta que la respuesta sea 'N'

            string caracter;

            do
            {
                Console.Write("¿DESEA CONTINUAR? S/N: ");
                caracter = Console.ReadLine();
            }
            while (caracter != "N");
            Console.ReadKey();
        }
    }
}
