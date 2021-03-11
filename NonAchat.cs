using System;

namespace _22FIFA
{
    class NonAchat
    {
        public NonAchat(string nom, int mouvant, int pts)
        {
            nom = " ";
            Console.WriteLine("AUCUN TRANSFERT EFFECTUE...");
            mouvant = 0;
            pts = pts + mouvant;
        }
    }
}
