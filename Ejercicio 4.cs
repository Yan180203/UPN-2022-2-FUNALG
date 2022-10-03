using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Diseñar un programa para calcular la suma de los números naturales,
            //comprendidos entre 2 números ingresados por el usuario.
            
            int num1, num2, resulado;
            Console.WriteLine("Ingrese el primer numero: ");
            num1=int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero: ");
            num2 =int.Parse(Console.ReadLine());

            resulado = num1 + num2;
            Console.WriteLine("El resultado es: "+ resulado);
            Console.ReadKey();
        }

    }
}
