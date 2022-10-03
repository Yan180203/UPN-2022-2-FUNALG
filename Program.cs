using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Diseñar un programa para buscar y escribir la primera vocal leída del teclado.
            //(Se supone quese leen, uno a uno, caracteres desde el teclado.)

            char caracter;

            do
            {
                Console.Write("INGRESE UNA LETRA: ");
                caracter = char.Parse(Console.ReadLine());
            }
            while (caracter != 'a' && caracter != 'e' && caracter != 'i' && caracter != 'o' &&
            caracter != 'u' && caracter != 'A' && caracter != 'E' && caracter != 'I' &&
            caracter != 'O' && caracter != 'U');

            Console.WriteLine("LA PRIMERA VOCAL INGRESADA ES: " +caracter);
            Console.ReadKey();
        }   
    }
}

