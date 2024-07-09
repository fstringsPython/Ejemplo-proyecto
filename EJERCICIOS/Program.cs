using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIOS
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("========  CALCULADORA  ========");
            Console.WriteLine("\n Ingrese primer numero: ");
            string num1 = Console.ReadLine();
            num1 = num1.
            Console.WriteLine("\n Ingrese segundo valor: ");
            string num2 = Console.ReadLine();

            float suma = num1 + num2;
            float resta = num1 - num2;
            float mult = num1 * num2;
            float div = num1 / num2;

            Console.WriteLine($"La suma de los numeros es {suma}");
            Console.WriteLine($"La suma de los numeros es {resta}");
            Console.WriteLine($"La suma de los numeros es {mult}");
            Console.WriteLine($"La suma de los numeros es {div}");




        }
    }
}
