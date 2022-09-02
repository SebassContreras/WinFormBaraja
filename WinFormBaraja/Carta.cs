using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormBaraja
{
    class Carta
    {
        int numero;
        int palo;
        string[] palos = { "Diamantes", "Picas", "Corazones", "treboles" };
        string[] tipo = { "As", "Jota", "Reina", "Rey" };

        public Carta(int n, int p)
        {
            numero = n;
            palo = p;
        }

        public string escribeCarta()
        {
            string cartas;
            switch (numero)
            {
                case 1:
                  cartas = tipo[0] + " de " + palos[palo];
                    break;
                case 10:
                    cartas =tipo[1] + " de " + palos[palo];
                    break;
                case 11:
                    cartas = tipo[2] + " de " + palos[palo];
                    break;
                case 12:
                    cartas = tipo[3] + " de " + palos[palo];
                    break;
                default:
                    cartas = numero + " de " + palos[palo];
                    break;
            }
            return cartas;

        }
    }
}
