using System;

namespace _22FIFA
{
    class HeureCourante
    {
        public HeureCourante(string Date)
        {
            Console.WriteLine("On est le : " + Date);
            Console.ReadLine();
            if (Date == "25-12")//pour savoir si on est le jour de Noël
            {
                Console.ForegroundColor = ConsoleColor.Red; //changement de couleur auto pour Noël
                Console.WriteLine("Joyeux Noël !!!");
                Console.ReadLine();
            }
            if (Date == "01-01")//pour savioir si on est le jour de l'an
            {
                Console.ForegroundColor = ConsoleColor.Yellow; //changement de couleur auto pour le jour de l'an
                Console.WriteLine("Bonne année à toi :)");
                Console.ReadLine();
            }
            Console.Clear();
        }
    }
}
