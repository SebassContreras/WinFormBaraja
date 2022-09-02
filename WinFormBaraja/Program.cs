using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormBaraja
{
    class Program
    {
        static void Maian()
        {
            Baraja baraja = new Baraja();

            baraja.numCartas();
            baraja.escribeBaraja();
            baraja.Barajar();
            baraja.escribeBaraja();
            baraja.robaCarta();
            baraja.cogeCarta(5);
            baraja.cogeCartaAlAzar();
            

            Console.ReadKey();
        }
    }
}
