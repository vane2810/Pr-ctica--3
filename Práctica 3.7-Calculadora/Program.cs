using System;

namespace Práctica_3._7_Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "";
            do
            {
                Console.WriteLine(" Elija una opción:");
                Console.WriteLine(" 1. SUMA");
                Console.WriteLine(" 2. RESTA");
                Console.WriteLine(" 3. MULTIPLICACIÓN");
                Console.WriteLine(" 4. DIVISIÓN");
                int option = int.Parse(Console.ReadLine());


                int nume1, nume2;
                switch (option)

                {

                    case 1:
                        Console.WriteLine(" 1. SUMA:");
                        Console.WriteLine("Ingrese el primer valor: ");
                        nume1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo valor: ");
                        nume2 = int.Parse(Console.ReadLine());
                        //Llamadas de funciones locales
                        Console.WriteLine("La suma es = " + SUMA(nume1, nume2));
                        break;

                    case 2:
                        Console.WriteLine(" 2. RESTA:");
                        Console.WriteLine("Ingrese el primer valor: ");
                        nume1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo valor: ");
                        nume2 = int.Parse(Console.ReadLine());
                        //Llamadas de funciones locales
                        Console.WriteLine("La resta es = " + RESTA(nume1, nume2));
                        break;

                    case 3:
                        Console.WriteLine("3. MULTIPLICACIÓN");
                        Console.WriteLine("Ingrese el primer valor: ");
                        nume1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo valor: ");
                        nume2 = int.Parse(Console.ReadLine());
                        //Llamadas de funciones locales
                        Console.WriteLine("La multiplicación  es =  " + MULTIP(nume1, nume2));
                        break;

                    case 4:
                        Console.WriteLine("4. DIVISIÓN");
                        Console.WriteLine("Ingrese el primer valor: ");
                        nume1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo valor: ");
                        nume2 = int.Parse(Console.ReadLine());
                        //Llamadas de funciones locales
                        Console.WriteLine("La división es = " + DIV(nume1, nume2));
                        break;

                    default:
                        Console.WriteLine("Opción inválida => Presione enter para continuar.");
                        Console.ReadLine();
                        break;
                }

                Console.WriteLine("¿Desea continuar?");
                Console.WriteLine("Elija la opción:");
                Console.WriteLine("1. Sí");
                Console.WriteLine("2. No");
                a = Console.ReadLine();
            }
            while (a == "1" || a== "1");
         
            //Función lambda - SUMA
            static int SUMA(int nume1, int nume2) => nume1 + nume2;

            //Función lambda - RESTA
            static int RESTA(int nume1, int nume2) => nume1 - nume2;

            //Función lambda - MULTIPLICACIÓN
            static int MULTIP(int nume1, int nume2) => nume1 * nume2;

            //Función lambda - DIVISIÓN
            static int DIV(int nume1, int nume2) => nume1 * nume2;
        
}   }   }
