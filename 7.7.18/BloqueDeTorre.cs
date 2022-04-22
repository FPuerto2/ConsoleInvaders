using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._7._18
{
    class BloqueDeTorre : Sprite
    {
        protected bool activo = true;
        public BloqueDeTorre(int nuevaX, int nuevaY)
        {
            imagen = "██";
            X = nuevaX;
            Y = nuevaY;
        }
        
        public bool IsActivo()
        {
            return activo;
        }

        public void Desactivar()
        {
            activo = false;
            Y = -5;
        }
        
        public override void Dibujar()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition(X, Y);
            Console.Write(imagen);
        }
    }
}
