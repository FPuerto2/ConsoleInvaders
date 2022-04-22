using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._7._18
{
    class Enemigo2 : Enemigo
    {
        public Enemigo2(int nuevaX, int nuevaY) : base(nuevaX, nuevaY)
        {
            imagen = "XX";
        }

        public override void Dibujar()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(X, Y);
            Console.Write(imagen);
            disparo.Dibujar();

        }
    }
}
