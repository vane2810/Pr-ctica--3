﻿using System;

namespace Práctica_3._6
{
    class Program 
    {
        static void Main(string[] args)
        {
            int num1, num2;
            // Captura de datos desde consola
            Console.WriteLine("Introduzca un número: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca otro número: ");
            num2 = int.Parse(Console.ReadLine());
            //Llamadas de funciones locales
            Console.WriteLine("La suma es: " + Suma(num1, num2));
            Console.WriteLine("La resta es: " + Resta(num1, num2));
            Console.WriteLine("La multiplicación es: " + Multi(num1, num2));
            Console.WriteLine("La división es: " + Div(num1, num2));

        }

        //Función con variable return
        static int Suma(int num1, int num2)
        {
            var suma = num1 + num2;
            return suma;
        }

        //Función con return directo
        static int Resta(int num1, int num2)
        {
            return (num1 - num2);
        }

        //Función lambda
        static int Multi(int num1, int num2) => num1 * num2;

        //Función con conversión a double
        static double Div(int num1 , int num2)
        {
            double numd1 = Convert.ToDouble(num1);
            double numd2 = Convert.ToDouble(num2);

            return numd1 / numd2;

        }
    }
}
