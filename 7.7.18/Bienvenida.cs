using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._7._18
{
    class Bienvenida
    {
        ConsoleKeyInfo tecla;

        public bool Lanzar(int[] mejoresPuntuaciones)
        {
            while(true)
            {
                Console.WriteLine("Bienvenido a Console Invaders!");

                if(mejoresPuntuaciones[0] > 0)
                {
                    Console.WriteLine("\nMejores puntuaciones: ");

                    for(int i = 0; i < 10; i++)
                    {
                        if (mejoresPuntuaciones[i] == 0)
                            break;

                        Console.Write(mejoresPuntuaciones[i] + " | ");
                    }

                    Console.WriteLine("\n");
                }


                Console.Write("Pulse INTRO para jugar o ESC para salir. . . ");
                tecla = Console.ReadKey();

                Console.WriteLine();

                if (tecla.Key == ConsoleKey.Enter)
                    return true;

                if (tecla.Key == ConsoleKey.Escape)
                    return false;

                Console.Clear();

                Console.WriteLine("Tecla erronea");
            }
        }
    }
}
