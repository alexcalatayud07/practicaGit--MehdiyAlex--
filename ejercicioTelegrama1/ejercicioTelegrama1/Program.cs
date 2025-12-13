using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioTelegrama1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string texto;
            int numPalabras;
            double coste = 0;

            Console.WriteLine("Introduce el telegrama:");
            texto = Console.ReadLine();

          
            numPalabras = texto.Length;

            Console.WriteLine("¿Es urgente? (s/n)");
            char urgente = Console.ReadKey().KeyChar;
            Console.WriteLine();

            
            if (urgente == 's')
            {
                if (numPalabras <= 10)
                    coste = 5;
                else
                    coste = 0.75 * numPalabras;
            }
            else
            {
                if (numPalabras <= 10)
                    coste = 2.5;
                else
                    coste = 0.5 * numPalabras;
            }

            Console.WriteLine("Coste: " + coste + " euros");
            Console.ReadKey();
        }

    }
}
