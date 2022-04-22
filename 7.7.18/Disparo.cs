using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._7._18
{
    class Disparo : Sprite
    {
        bool activo = false;
        bool disparoDeNave;

        public Disparo(bool disparoDeNave)
        {
            imagen = "||";
            this.disparoDeNave = disparoDeNave;
        }

        public void Crear(int nuevaX, int nuevaY)
        {
            if (activo)
                return;

            activo = true;

            X = nuevaX;
            Y = nuevaY;
        }

        public override void Dibujar()
        {
            if (disparoDeNave)
            {
                if (Y == 0)
                    activo = false;

                Y--;
            }

            else
            {
                if (Y == 29)
                    activo = false;
                Y++;
            }

            if (!activo)
                return;


            Console.ForegroundColor = ConsoleColor.Gray;
            Console.SetCursorPosition(X, Y);
            Console.Write(imagen);
        }

        public void Desactivar()
        {
            activo = false;
            X = -5;
            Y = 2;
        }

        public bool IsActivo()
        {
            return activo;
        }

        public bool ColisionaCon(int X2, int Y2)
        {
            if ((X == X2 || X + 1 == X2 || X == X2 + 1 || X + 1 == X2 + 1) && Y == Y2)
                return true;

            return false;
        }
    }
}
