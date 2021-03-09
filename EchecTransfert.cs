using System;

namespace _22FIFA
{
    class EchecTransfert
    {
        public EchecTransfert(string nom, int mouvant, int pts)
        {
            Console.WriteLine("ECHEC DE TRANSFERT : " + nom); // Annonce de l'echec du transfert pour le joueur demandé
            nom = " "; 
            mouvant = 0;
            pts = pts + mouvant;
            Console.WriteLine(nom);
            Console.ReadLine();
        }
    }
}
