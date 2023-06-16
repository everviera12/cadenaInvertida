using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cadenaInvertida
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un texto:");
            string texto = Console.ReadLine();

            string textoInvertido = InvertirCadena(texto);

            Console.WriteLine("Texto invertido: " + textoInvertido);
            Console.ReadLine();
        }

          static string InvertirCadena(string texto)
        {
            char[] caracteres = texto.ToCharArray();
            Array.Reverse(caracteres);
            return new string(caracteres);
        }
    }
}
