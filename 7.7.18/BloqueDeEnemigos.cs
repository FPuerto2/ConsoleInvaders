using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._7._18
{
    class BloqueDeEnemigos
    {
        Enemigo[,] enemigos = new Enemigo[3, 10];
        bool moviendoIzquierda = true;
        Disparo disparo = new Disparo(false);
        Random random = new Random();

        public BloqueDeEnemigos()
        {
            int i;

            for (i = 0; i < 10; i++)
                enemigos[0, i] = new Enemigo1(i * 10, 13);

            for (i = 0; i < 10; i++)
                enemigos[1, i] = new Enemigo2(i * 10, 15);

            for (i = 0; i < 10; i++)
                enemigos[2, i] = new Enemigo3(i * 10, 17);
        }

        public void DibujarEnemigos()
        {
            for (int j = 0; j < 3; j++)
                for (int i = 0; i < 10; i++)
                    if(enemigos[j, i].IsActivo())
                        enemigos[j, i].Dibujar();
        }

        public void Mover()
        {
            if (enemigos[0, 9].IsOnEdge() || enemigos[0, 0].IsOnEdge())
                moviendoIzquierda = !moviendoIzquierda;

            for (int j = 0; j < 3; j++)
            {
                for (int i = 0; i < 10; i++)
                {
                    if (moviendoIzquierda)
                    {
                        enemigos[j, i].MoverIzquierda();
                        continue;
                    }

                    enemigos[j, i].MoverDerecha();
                }
            }
        }

        public bool ComprobarColision(Disparo disparoNave) //método para comprobar el funcionamiento del método ColicionaCon
        {
            for (int j = 0; j < 3; j++)
            {
                for (int i = 0; i < 10; i++)
                {
                    if (enemigos[j, i].ColisionaCon(disparoNave) && enemigos[j, i].IsActivo())
                    {
                        enemigos[j, i].Desactivar();
                        return true;
                    }
                } 
            }

            return false;
        }

        public void Disparar()
        {
            for (int j = 0; j < 3; j++)
            {
                for (int i = 0; i < 10; i++)
                {
                    if (random.Next(0, 150) == 1 && enemigos[j, i].IsActivo())
                        enemigos[j, i].Disparar(); 
                }
            }
        }

        public bool ComprobarColisionEnemiga(Sprite n1)
        {
            for (int j = 0; j < 3; j++)
            {
                for (int i = 0; i < 10; i++)
                {
                    if (enemigos[j, i].ComprobarColisionDeDisparo(n1))
                        return true;
                }
            }

            return false;
        }

        public bool ComprobarVictoria()
        {
            for (int j = 0; j < 3; j++)
                for (int i = 0; i < 10; i++)
                    if (enemigos[j, i].IsActivo())
                        return false;

            return true;
        }
    }
}
