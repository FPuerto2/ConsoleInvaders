using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._7._18
{
    class Enemigo : Sprite
    {
        protected bool activo = true;
        protected Disparo disparo = new Disparo(false);
        public Enemigo(int nuevaX, int nuevaY)
        {
            X = nuevaX;
            Y = nuevaY;
        }

        public virtual bool IsOnEdge()
        {
            if (X >= 118 || X <= 0)
                return true;

            return false;
        }

        public void MoverIzquierda()
        {
            X -= 2;
        }

        public void MoverDerecha()
        {
            X += 2;
        }

        public void Desactivar()
        {
            activo = false;
            Y = -5;
        }

        public bool IsActivo()
        {
            return activo;
        }

        public void Disparar()
        {
            disparo.Crear(X, Y);
        }

        public bool ComprobarColisionDeDisparo(Sprite n1)
        {
            if (disparo.ColisionaCon(n1))
            {
                disparo.Desactivar();
                return true;
            }

            return false;
        }
    }
}
