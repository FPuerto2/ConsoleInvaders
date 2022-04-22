using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._7._18
{
    class Ovni : Enemigo
    {
        public Ovni(int Xinicial, int Yinicial) : base(Xinicial, Yinicial)
        {
            imagen = "--";
            activo = false;
        }

        public void Activar()
        {
            Random r = new Random();

            if (r.Next(1, 51) == 1)
            {
                activo = true;
                X = 0;
                Y = 2;
            }
        }

        public override bool IsOnEdge()
        {
            if (X == 118)
                return true;

            return false;
        }

        public override void Dibujar()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.SetCursorPosition(X, Y);
            Console.Write(imagen);
        }
    }
}
