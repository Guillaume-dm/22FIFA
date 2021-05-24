using System;

namespace _22FIFA
{
    class Diffuseur
    {
        public Diffuseur(int diffuseur)
        {
            if (diffuseur <= 10) // Sert à savoir si la diffusion est exclusive à BeinSport
            {
                Console.WriteLine(" DIFFUSEUR : BEIN SPORT " + diffuseur); // Annonce du diffuseur du match - Chaine BEIN SPORT
            }
            else
            {
                if (diffuseur == 11)
                {
                    Console.WriteLine(" DIFFUSEUR : CANAL+"); // Annonce de la diffusion par Canal+
                }
                if (diffuseur == 12)
                {
                    Console.WriteLine(" DIFFUSEUR : CANAL+ SPORT"); // Annonce de la diffusion par Canal+ Sport
                }
                if (diffuseur == 13)
                {
                    Console.WriteLine(" DIFFUSEUR : L'EQUIPE"); // Annonce de la diffusion par L'Equipe (match amical)
                }
            }
            Console.ReadLine();
        }
    }
}
