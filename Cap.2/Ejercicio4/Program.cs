//4 Hacer un programa que transforme de
//grados centígrados a grados Fahrenheit.

using System;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            
         float a = 0, resultado = 0;
            string valor = "";
 
            Console.WriteLine("Ingrese El grado Celsius a Convertir");
            valor = Console.ReadLine();
            a = Convert.ToSingle(valor);
 
            resultado = (a * 9 / 5) + 32;
            Console.WriteLine("El Grado en Fahrenheit Es: {0}", resultado);   

        }
    }
}
