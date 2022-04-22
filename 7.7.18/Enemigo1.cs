using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._7._18
{
    class Enemigo1 : Enemigo
    {
        public Enemigo1(int nuevaX, int nuevaY) : base(nuevaX, nuevaY)
        {
            imagen = "][";
        }

        public override void Dibujar()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(X, Y);
            Console.Write(imagen);

            disparo.Dibujar();
        }
    }
}
