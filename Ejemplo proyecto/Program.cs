using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_proyecto
{//LLAVE INICIO SOLUCION
    //namespace encapsula la clase para evitar confictos con demas proyectos
    internal class Program
    {
        static void Main(string[] args)
        {//llave de inicio del main

            //TIPOS DE DATOS

            /*
            * Comentario multilinea
            */

         
            //para declarar una variable primero indico el tipo de dato

            //tipo de datos: entero   
            
            int numero = 4;

            //para imprimir utilizo la clase Console con el método .WriteLine()

            Console.WriteLine(numero);
            Console.WriteLine("el número ingresado es: " + numero);
            Console.WriteLine($"el número ingresado es {numero}");
            Console.ReadKey();
            //Si declaro una variable de tipo byte solo puedo almacenar un numero entre 0 y 255
            byte numero1 = 255;
            Console.WriteLine(numero1);

            //Un short, que puede almacenar valores de -32768 a 32767
            short numero2 = 45;

            //Un long, que puede almacenar valores de -9223372036854775808 a 9223372036854775807.
            long numero3 = 67;

            //Tipos de datos: Flotantes
            float numero4 = 5.4f;
            double numero5 = 5.456987d;

            //tipo cadenas
            char caracter = 'a';
            string nombre3 = "Jaime";

            //De tipo Bool
            bool esLunes = true;
            bool esMartes = false;

            //Operadores aritméticos
            //+,-,*,/,%

            //Operadores Lógicos
            // &&, ||, ,!

            //Operadores de Incremento
            //++, --

            //Entrada de datos por teclado

            Console.WriteLine("Ingrese su nombre: ");
            string nombre1 = Console.ReadLine();

            Console.WriteLine("Ingrese su edad: ");
            string edad = Console.ReadLine();

            Console.WriteLine($"Hola {nombre1} tu edad es {edad}");
            Console.ReadLine();

            



        }//llave de cierre método main
    }
}//LLAVE DE CIERRE SOLUCION
