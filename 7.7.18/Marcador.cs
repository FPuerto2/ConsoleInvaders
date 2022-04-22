using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._7._18
{
    class Marcador
    {
        int puntos, vidas;

        public Marcador(int vidasIniciales)
        {
            vidas = vidasIniciales;
        }

        public void SumarPuntos(int puntosASumar)
        {
            puntos += puntosASumar;
        }

        public void RestarVida()
        {
            vidas -= 1;
        }

        public int GetPuntos()
        {
            return puntos;
        }

        public int GetVidas()
        {
            return vidas;
        }
    }
}
