using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Diseñar un programa para imprimir todos los números primos entre 2 y 100 inclusive. 
            bool esPrimo;
            int n = 100;
            string primos = "";

            for (int x = 2; x <= n; x++) 
            {
                esPrimo = true;
                for (int y = 2; y < x; y++) 
                {
                    if (x % y==0)
                    {
                        esPrimo = false;
                        break;
                    }
                }
                if (esPrimo) primos += x + "-"; 
            }
            Console.WriteLine("Los numeros primos son: " + primos);
            Console.ReadKey();
        }   
    }
}          

