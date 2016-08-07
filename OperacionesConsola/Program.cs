using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OperacionesConsola
{
    class Program
    {
        static double operacion(double a, double b, char operacion)
        {
            //podemos RETORNAR directamente el resultado
            //sin necesidad de guardarlo en alguna variable
            switch (operacion)
            {
                case '+':
                    //cada case usualmente requiere un break
                    //pero como un return acaba la función inmediatamente
                    //ya no es necesario
                    return a + b;
                case '-':
                    return a - b;
                case '*':
                    return a * b;
                case '/':
                    return a / b;
                default:
                    //operación no permitida si el caracter
                    //especificado no es ninguno de los anteriores
                    return 0;
            }
        }
        static void Main(string[] args)
        {
            System.Console.WriteLine("Sumando: " + operacion(5, 3, '+'));
            System.Console.WriteLine("Restando: " + operacion(5, 3, '-'));
            System.Console.WriteLine("Multiplicando: " + operacion(5, 3, '*'));
            System.Console.WriteLine("Dividiendo: " + operacion(5, 3, '/'));
        }
    }
}
