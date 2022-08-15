using System;

namespace Práctica_3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un número:");
            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.WriteLine("Eligió la opción {0}", option);
                    break;

                case 2:
                    Console.WriteLine("Eligió la opción {0}", option);
                    break;

                case 3:
                    Console.WriteLine("Eligió la opción {0}", option);
                    break;

                case 4:
                    Console.WriteLine("Eligió la opción {0}", option);
                    break;

                case 5:
                    Console.WriteLine("Eligió la opción {0}", option);
                    break;

                default:
                    Console.WriteLine("Está opción no existe");
                    break;

            }
        }
    }
}
