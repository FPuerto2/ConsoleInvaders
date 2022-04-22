using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._7._18
{
    class Enemigo3 : Enemigo
    {
        public Enemigo3(int nuevaX, int nuevaY) : base(nuevaX, nuevaY)
        {
            imagen = "}{";
        }

        public override void Dibujar()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(X, Y);
            Console.Write(imagen);

            disparo.Dibujar();
        }
    }
}
