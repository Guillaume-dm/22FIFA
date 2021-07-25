using System;

namespace _22FIFA
{
    class Remplacement
    {
        public Remplacement(string entrant, string sortant, string adversaire, string Equipe)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("CHANGEMENT " + adversaire + "(1/3)"); // Annonce du changement à la mi-temps pour l'OL
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("CHANGEMENT " + adversaire + "(1/3)");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("< " + sortant);
            Console.ReadLine();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("CHANGEMENT " + adversaire + "(1/3)");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("< " + sortant);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("> " + entrant);
            Console.ReadLine();
            Console.Clear();
            Couleurs R1 = new Couleurs(Equipe);
        }
    }
}
