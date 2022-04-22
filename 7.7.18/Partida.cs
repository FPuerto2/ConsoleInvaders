 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace _7._7._18
{
    class Partida
    {
        public int Lanzar()
        {
            ConsoleKeyInfo tecla = new ConsoleKeyInfo();

            Nave n1 = new Nave(70, 29);
            BloqueDeEnemigos enemigos = new BloqueDeEnemigos();
            Ovni ovni = new Ovni(-5, 2);
            Disparo disparo = new Disparo(true);
            TorreDefensiva[] torres = new TorreDefensiva[4];

            torres[0] = new TorreDefensiva(18);
            torres[1] = new TorreDefensiva(43);
            torres[2] = new TorreDefensiva(67);
            torres[3] = new TorreDefensiva(92);

            Marcador marcador = new Marcador(3);

            do
            {
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("puntos = {0} | vidas = {1}", marcador.GetPuntos(), marcador.GetVidas());

                switch (tecla.Key)
                {
                    case ConsoleKey.LeftArrow:
                        n1.MoverIzquierda();
                        break;

                    case ConsoleKey.RightArrow:
                        n1.MoverDerecha();
                        break;

                    case ConsoleKey.Spacebar:
                        n1.Disparar(disparo);
                        break;
                }

                enemigos.Mover();


                n1.Dibujar();
                disparo.Dibujar();
                enemigos.Disparar();
                enemigos.DibujarEnemigos();

                for (int i = 0; i < 4; i++)
                {
                    if(torres[i].ComprobarColision(disparo, enemigos))
                        disparo.Desactivar();

                    torres[i].DibujarTorre();
                }

                if (disparo.IsActivo() && enemigos.ComprobarColision(disparo))
                {
                    disparo.Desactivar();
                    marcador.SumarPuntos(10);
                }

                if (enemigos.ComprobarColisionEnemiga(n1))
                    marcador.RestarVida();

                if (!ovni.IsActivo())
                    ovni.Activar();

                else if (ovni.IsOnEdge())
                    ovni.Desactivar();

                else
                {
                    ovni.MoverDerecha();
                    ovni.Dibujar();
                }

                if (ovni.ColisionaCon(disparo) && disparo.IsActivo())
                {
                    ovni.Desactivar();
                    marcador.SumarPuntos(50);
                    disparo.Desactivar();
                }
                 
                tecla = Console.ReadKey();

                if(marcador.GetVidas() == 0)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.SetCursorPosition(55, 14);

                    Console.WriteLine("Has perdido!");
                    Thread.Sleep(5000);

                    return marcador.GetPuntos();
                }

                if (enemigos.ComprobarVictoria())
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.SetCursorPosition(55, 14);

                    Console.WriteLine("Has Ganado!!!");
                    Thread.Sleep(5000);

                    return marcador.GetPuntos();
                }

                } while (tecla.Key != ConsoleKey.Escape);

            return marcador.GetPuntos();
        }
    }
}
