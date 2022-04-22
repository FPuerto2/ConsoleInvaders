using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._7._18
{
    class TorreDefensiva
    {
        int X, Y = 24;

        BloqueDeTorre[] bloques = new BloqueDeTorre[8];

        public TorreDefensiva(int nuevaX)
        {
            X = nuevaX;

            bloques[0] = new BloqueDeTorre(X, Y);
            bloques[1] = new BloqueDeTorre(X + 2, Y);
            bloques[2] = new BloqueDeTorre(X + 4, Y);
            bloques[3] = new BloqueDeTorre(X + 6, Y);
            bloques[4] = new BloqueDeTorre(X, Y + 1);
            bloques[5] = new BloqueDeTorre(X + 2, Y + 1);
            bloques[6] = new BloqueDeTorre(X + 4, Y + 1);
            bloques[7] = new BloqueDeTorre(X + 6, Y + 1);
        }

        public void DibujarTorre()
        {
            for (int i = 0; i < 8; i++)
                if (bloques[i].IsActivo())
                    bloques[i].Dibujar();
        }

        public bool ComprobarColision(Disparo disparoNave, BloqueDeEnemigos enemigos)
        {

            for (int i = 0; i < 8; i++)
                if (enemigos.ComprobarColisionEnemiga(bloques[i]) && bloques[i].IsActivo())
                    bloques[i].Desactivar();

            for (int i = 0; i < 8; i++)
            {
                if (bloques[i].ColisionaCon(disparoNave) && bloques[i].IsActivo())
                {
                    bloques[i].Desactivar();
                    return true;
                }
            }

            return false;
        }
    }
}
