using System;

namespace _22FIFA
{
    class Tdc
    {
        public Tdc (int domicile, string Equipe, int exterieur, int spectateur, string Equipe_avant, string qualification, int tab, string Equipe_avant2, string qualification2)
        {
            int cas = 0;
            while (Equipe == qualification & Equipe == Equipe_avant || qualification2 == Equipe_avant2)
            {
                int nba = new Random().Next(1, 4);
                if (nba == 1)
                {
                    Equipe_avant = "OL";
                    Equipe_avant2 = "   OL  ";
                }
                if (nba == 2)
                {
                    Equipe_avant = "AS MONACO FC";
                    Equipe_avant2 = " MONACO";
                }
                if (nba == 3)
                {
                    Equipe_avant = "PARIS SAINT-GERMAIN";
                    Equipe_avant2 = "  PSG  ";
                }
            }
            if (Equipe == qualification)
            {
                cas = 2;
            }
            else
            {
                cas = 1;
            }
            Console.WriteLine("TROPHEE DES CHAMPIONS : ");
            Console.WriteLine("LIEU : STADE DE FRANCE A SAINT-DENIS (93200)"); // Annonce du lieu du match
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("REPRSENTANT DE LA COUPE DE FRANCE : " + qualification); // Rappel du répresentant de coupe de Françe
            Console.WriteLine("REPRSENTANT DE LA LIGUE 1 Uber Eats : " + Equipe_avant); // Rappel du représentant de Ligue 1 Uber Etats
            int x = 0;
            int y = 0;
            Console.ReadLine();
            Console.Clear();
            if (cas == 2)
            {
                Console.WriteLine(qualification2 + "   " + Equipe_avant2);
                Console.WriteLine("   " + x + "         " + y);
                Console.ReadLine();
                Console.Clear();
                int type_m = new Random().Next(1, 3);
                if (type_m == 1)
                {
                    while (y < exterieur)
                     {
                         y = y + 1;
                         Console.WriteLine(qualification2 + "   " + Equipe_avant2);
                         Console.WriteLine("   " + x + "         " + y);
                         Console.ReadLine();
                         Console.Clear();
                     }
                }
                else
                {
                    while (x < domicile)
                     {
                         x = x + 1;
                         Console.WriteLine(qualification2 + "   " + Equipe_avant2);
                         Console.WriteLine("   " + x + "         " + y);
                         Console.ReadLine();
                         Console.Clear();
                     }
                }
                Console.WriteLine(qualification2 + "   " + Equipe_avant2);
                Console.WriteLine("   " + x + "         " + y);
                Console.WriteLine(" ");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("AFFLUENCE : " + spectateur); // Annonce de l'affluence unique du match
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine(qualification2 + "   " + Equipe_avant2);
                Console.WriteLine("   " + x + "         " + y);
                Console.WriteLine(" ");
                Console.ReadLine();
                Console.Clear();
                if (type_m == 1)
                {
                    while (x < domicile)
                     {
                         x = x + 1;
                         Console.WriteLine(qualification2 + "   " + Equipe_avant2);
                         Console.WriteLine("   " + x + "         " + y);
                         Console.ReadLine();
                         Console.Clear();
                     }
                }
                else
                {
                    while (y < exterieur)
                     {
                         y = y + 1;
                         Console.WriteLine(qualification2 + "   " + Equipe_avant2);
                         Console.WriteLine("   " + x + "         " + y);
                         Console.ReadLine();
                         Console.Clear();
                     }
                }
                Console.WriteLine(qualification2 + "   " + Equipe_avant2);
                Console.WriteLine("   " + x + "         " + y);
                Console.ReadLine();
                Console.Clear();
                if (exterieur == domicile)
                {
                    Console.WriteLine("TIRS AU BUTS DU TROPHEE DES CHAMPIONS"); // Annonce de la séance des tirs aux buts
                    Console.ReadLine();
                    Console.Clear();
                    if (tab == 1)
                    {
                        Console.WriteLine("VAINQUEUR DU TROPHEE DES CHAMPIONS : " + Equipe + " (TAB)");
                    }
                    else
                    {
                        Console.WriteLine("FINALISTE DU TROPHEE DES CHAMPIONS : " + Equipe);
                    }
                }
                if (exterieur > domicile)
                {
                    Console.WriteLine("FINALISTE DU TROPHEE DES CHAMPIONS : " + Equipe);
                }
                if (domicile > exterieur)
                {
                    Console.WriteLine("VAINQUEUR DU TROPHEE DES CHAMPIONS : " + Equipe);
                }
                Console.ReadLine();
                Console.Clear();
            }
            else
            {
                Console.WriteLine(qualification2 + "   " + Equipe_avant2);
                Console.WriteLine("   " + x + "         " + y);
                Console.ReadLine();
                Console.Clear();
                int type_m = new Random().Next(1, 3);
                if (type_m == 1)
                {
                    while (y < exterieur)
                     {
                         y = y + 1;
                         Console.WriteLine(qualification2 + "   " + Equipe_avant2);
                         Console.WriteLine("   " + x + "         " + y);
                         Console.ReadLine();
                         Console.Clear();
                     }
                }
                else
                {
                    while (x < domicile)
                     {
                         x = x + 1;
                         Console.WriteLine(qualification2 + "   " + Equipe_avant2);
                         Console.WriteLine("   " + x + "         " + y);
                         Console.ReadLine();
                         Console.Clear();
                     }
                }
                Console.WriteLine(qualification2 + "   " + Equipe_avant2);
                Console.WriteLine("   " + x + "         " + y);
                Console.WriteLine(" ");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("AFFLUENCE : " + spectateur); // Affichage unique de l'affluence du match
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine(qualification2 + "   " + Equipe_avant2);
                Console.WriteLine("   " + x + "         " + y);
                Console.WriteLine(" ");
                Console.ReadLine();
                Console.Clear();
                if (type_m == 1)
                {
                    while (x < domicile)
                     {
                         x = x + 1;
                         Console.WriteLine(qualification2 + "   " + Equipe_avant2);
                         Console.WriteLine("   " + x + "         " + y);
                         Console.ReadLine();
                         Console.Clear();
                     }
                }
                else
                {
                    while (y < exterieur)
                     {
                         y = y + 1;
                         Console.WriteLine(qualification2 + "   " + Equipe_avant2);
                         Console.WriteLine("   " + x + "         " + y);
                         Console.ReadLine();
                         Console.Clear();
                     }
                }
                Console.WriteLine(qualification2 + "   " + Equipe_avant2);
                Console.WriteLine("   " + x + "         " + y);
                Console.ReadLine();
                Console.Clear();
                if (exterieur == domicile)
                {
                    Console.WriteLine("TIRS AU BUTS DU TROPHEE DES CHAMPIONS"); // Annonce du début de la séance des tirs au buts
                    Console.ReadLine();
                    Console.Clear();
                    if (tab == 1)
                    {
                        Console.WriteLine("VAINQUEUR DU TROPHEE DES CHAMPIONS : " + Equipe + "(TAB)");
                    }
                    else
                    {
                        Console.WriteLine("FINALISTE DU TROPHEE DES CHAMPIONS : " + Equipe);
                    }
                }
                if (domicile > exterieur)
                {
                    Console.WriteLine("FINALISTE DU TROPHEE DES CHAMPIONS : " + Equipe);
                }
                if (exterieur > domicile)
                {
                    Console.WriteLine("VAINQUEUR DU TROPHEE DES CHAMPIONS : " + Equipe);
                }
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
