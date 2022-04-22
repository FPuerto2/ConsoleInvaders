using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._7._18
{
    class Sprite
    {
        protected int X, Y;
        protected string imagen;

        public void MoverA(int nuevaX, int nuevaY)
        {
            X = nuevaX;
            Y = nuevaY;
        }

        public virtual void Dibujar() { }

        public bool ColisionaCon(Sprite disparo)
        {
            if((disparo.X == X || disparo.X + 1 == X || disparo.X == X + 1 || disparo.X + 1== X + 1) && disparo.Y == Y)
                return true;

            return false;
        }

        public void Disparar(Disparo disparo)
        {
            disparo.Crear(X, Y);
        }
    }
}
