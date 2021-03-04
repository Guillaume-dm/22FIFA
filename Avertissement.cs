using System;

namespace _22FIFA
{
    class Avertissement
    {
        public Avertissement(string name_yellow, string Equipe)
        {
            Console.WriteLine("CARTON JAUNE - " + Equipe);
            Console.WriteLine("  " + name_yellow);
        }
    }
}
