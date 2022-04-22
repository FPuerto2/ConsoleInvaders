using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._7._18
{
    class Juego
    {
        public static void Lanzar()
        {
            Bienvenida b = new Bienvenida();
            Partida p = new Partida();
            bool iniciar;

            int[] highScores = new int[10];
            int ultimoPuntaje, i, j;

            for (i = 0; i < 10; i++)
                highScores[i] = 0;

            do
            {
                iniciar = b.Lanzar(highScores);

                if (iniciar)
                {
                    ultimoPuntaje = p.Lanzar();

                    for(i = 0; i < 10; i++)
                    {
                        if(ultimoPuntaje > highScores[i])
                        {
                            for(j = 9; j >= i; j--)
                                if (j > 0)
                                    highScores[j] = highScores[j - 1];

                            highScores[i] = ultimoPuntaje;

                            break;
                        }
                    }
                }
                Console.Clear();

            } while (iniciar);
        }
        static void Main(string[] args)
        {
            Juego.Lanzar();
        }
    }
}
