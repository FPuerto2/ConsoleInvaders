using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._7._18
{
    class Nave : Sprite
    {

        public Nave() : this(70, 29) { }

        public Nave(int nuevaX, int nuevaY)
        {
            imagen = "/\\";
            X = nuevaX;
            Y = nuevaY;
        }

        public void MoverDerecha()
        {
            if(X + 5 <= 118)
                X += 5;
        }

        public void MoverIzquierda()
        {
            if(X - 5 >= 0)
                X -= 5;
        }

        public override void Dibujar()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(X, Y);
            Console.Write(imagen);
        }
    }
}
