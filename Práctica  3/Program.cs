﻿using System;

namespace Práctica__3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su nota promedio:");
            double nota = double.Parse(Console.ReadLine());
            if (nota >= 0 && nota <= 10)
            {
                if (nota >= 6)
                {
                    Console.WriteLine("Aprobado");
                }

                else if (nota >= 5)
                {
                    Console.WriteLine("Reposición");
                }

                else
                {
                    Console.WriteLine("Reprobado");
                }
            }
            else
            {
                Console.WriteLine("La nota no es correcta");
            }
        }
    }
}
