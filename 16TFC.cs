using System;

namespace _22FIFA
{
    class TFC16
    {
        public TFC16(int domicile, string nom, int mouvant, string Equipe, int pts, int exterieur, int spectateur, string adversaire, int meteo, int diffuseur)
        {
            Console.Clear();
            Diffuseur tv = new Diffuseur(diffuseur);
            Meteo M1 = new Meteo(meteo);
            Console.Clear();
            Console.WriteLine("COMPOSITION TFC (4-3-3)"); // Annonce de la composition de l'adversaire et son dispositif
            int tps_ad = new Random().Next(2, 6); // Initialisation de la variable pour le temps additionnel de la seconde mi-temps
            int composition = new Random().Next(1, 5); // Initialisation de la variable qui influe sur le 1er changement pour l'OL
            string tfc1 = "MOUBANDJE";
            string tfc2 = "TISSERAND";
            string tfc3 = "DIOP";
            string tfc4 = "AKPA-AKPRO";
            string tfc5 = "DOUMBIA";
            string tfc6 = "DIDOT";
            string tfc7 = "BLIN";
            string tfc8 = "REGATTIN";
            string tfc9 = "BEN YEDDER";
            string tfc10 = "BRAITHWAITE";
            string tfc9bis = "BEN YEDDER (P)"; // Affichage en cas de pénalty transformé
            string entrant;  // Sert à l'affichage du joueur entrant en cas de remplacements. 
            string sortant; // Sert à l'affichage du joueur sortant en cas de remplacements. 
            Console.WriteLine(" ");
            Console.WriteLine("                  40-LAFONT"); // Ligne du gardien de but
            Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine(" 7- " + tfc4 + "  5- " + tfc3 + "  26- " + tfc2 + "  29- " + tfc1); // Ligne défensive
            Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("       4- " + tfc5 + "    8- " + tfc6 + "     27- " + tfc7); // Ligne des milieux de terrain
            Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("   28- " + tfc8 + "  10- " + tfc9 + "   9- " + tfc10); // Ligne des attaquants
            Console.ReadLine();
            Console.Clear();
            int buteur = 0;
            int x = 0; // Mise à 0 du compteur pas à pas pour l'équipe à domicile
            int y = 0; // Mise à 0 du compteur pas à pas pour l'équipe à l'extérieur
            string name = " "; // Initialisation des différents potentiels buteurs
            string name2 = " ";
            string name3 = " ";
            string name4 = " ";
            string name5 = " ";
            Console.WriteLine(" TFC       " + Equipe);
            Console.WriteLine("  " + x + "         0");
            Console.ReadLine();
            Console.Clear();
            int type_m = new Random().Next(1, 3);
            int moment = new Random().Next(1, 6); // Permet de savoir quand l'avertissement va arriver
            if (moment > exterieur & type_m == 1 || moment > domicile & type_m == 2)
            {
                moment = exterieur; // On rabaisse la variable pour que l'avertissement soit donné
            }
            else
            {
                if (moment > domicile & type_m == 2)
                {
                    moment = domicile; // On rabaisse la variable pour que l'avertissement soit donné
                }
            }
            int carton_jaune = new Random().Next(0, 2); // Défini le nombre de carton jaune du match
            if (type_m == 1)
            {
                if (moment == y)
                {
                    if (carton_jaune >= 1)
                    {
                        int yellow_card = new Random().Next(1, 5); // Définit le scénario du joueur averti
                        string name_yellow = " "; // Initialisation de la variable du joueur qui sera averti;
                        if (yellow_card == 1)
                        {
                            name_yellow = tfc1;
                            Avertissement a1 = new Avertissement(name_yellow, adversaire);
                        }
                        if (yellow_card == 2)
                        {
                            name_yellow = tfc2;
                            Avertissement a1 = new Avertissement(name_yellow, adversaire);
                        }
                        if (yellow_card == 3)
                        {
                            name_yellow = tfc3;
                            Avertissement a1 = new Avertissement(name_yellow, adversaire);
                        }
                        if (yellow_card == 4)
                        {
                            name_yellow = tfc4;
                            Avertissement a1 = new Avertissement(name_yellow, adversaire);
                        }
                        Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine(" TFC       " + Equipe);
                        Console.WriteLine("  " + x + "         " + y);
                        Console.WriteLine(" ");
                        Console.WriteLine(name);
                        Console.WriteLine(name2);
                        Console.WriteLine(name3);
                        Console.WriteLine(name4);
                        Console.ReadLine();
                        Console.Clear();
                    }
                }
                while (y < exterieur)
                {
                    Console.WriteLine(" TFC       " + Equipe);
                    Console.WriteLine("  " + x + "         " + y);
                    Console.ReadLine();
                    Console.Clear();
                    y = y + 1;
                    if (moment == y)
                    {
                        if (carton_jaune >= 1)
                        {
                            int yellow_card = new Random().Next(1, 5); // Définit le scénario du joueur averti
                            string name_yellow = " "; // Initialisation de la variable du joueur qui sera averti;
                            if (yellow_card == 1)
                            {
                                name_yellow = tfc1;
                                Avertissement a1 = new Avertissement(name_yellow, adversaire);
                            }
                            if (yellow_card == 2)
                            {
                                name_yellow = tfc2;
                                Avertissement a1 = new Avertissement(name_yellow, adversaire);
                            }
                            if (yellow_card == 3)
                            {
                                name_yellow = tfc3;
                                Avertissement a1 = new Avertissement(name_yellow, adversaire);
                            }
                            if (yellow_card == 4)
                            {
                                name_yellow = tfc4;
                                Avertissement a1 = new Avertissement(name_yellow, adversaire);
                            }
                            Console.ReadLine();
                            Console.Clear();
                            Console.WriteLine(" TFC       " + Equipe);
                            Console.WriteLine("  " + x + "         " + y);
                            Console.WriteLine(" ");
                            Console.WriteLine(name);
                            Console.WriteLine(name2);
                            Console.WriteLine(name3);
                            Console.WriteLine(name4);
                            Console.ReadLine();
                            Console.Clear();
                        }
                    }
                }
            }
            else
            {
                if (moment == y)
                {
                    if (carton_jaune >= 1)
                    {
                        int yellow_card = new Random().Next(1, 5); // Définit le scénario du joueur averti
                        string name_yellow = " "; // Initialisation de la variable du joueur qui sera averti;
                        if (yellow_card == 1)
                        {
                            name_yellow = tfc1;
                            Avertissement a1 = new Avertissement(name_yellow, adversaire);
                        }
                        if (yellow_card == 2)
                        {
                            name_yellow = tfc2;
                            Avertissement a1 = new Avertissement(name_yellow, adversaire);
                        }
                        if (yellow_card == 3)
                        {
                            name_yellow = tfc3;
                            Avertissement a1 = new Avertissement(name_yellow, adversaire);
                        }
                        if (yellow_card == 4)
                        {
                            name_yellow = tfc4;
                            Avertissement a1 = new Avertissement(name_yellow, adversaire);
                        }
                        Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine(" TFC       " + Equipe);
                        Console.WriteLine("  " + x + "         " + y);
                        Console.WriteLine(" ");
                        Console.WriteLine(name);
                        Console.WriteLine(name2);
                        Console.WriteLine(name3);
                        Console.WriteLine(name4);
                        Console.ReadLine();
                        Console.Clear();
                    }
                }
                if (domicile > 0)
                {
                    x = 1;
                    buteur = new Random().Next(1, 12);
                    if (buteur == 1)
                    {
                        name = tfc1;
                    }
                    if (buteur == 2)
                    {
                        name = tfc2;
                    }
                    if (buteur == 3)
                    {
                        name = tfc3;
                    }
                    if (buteur == 4)
                    {
                        name = tfc4;
                    }
                    if (buteur == 5)
                    {
                        name = tfc5;
                    }
                    if (buteur == 6)
                    {
                        name = tfc6;
                    }
                    if (buteur == 7)
                    {
                        name = tfc7;
                    }
                    if (buteur == 8)
                    {
                        name = tfc8;
                    }
                    if (buteur == 9)
                    {
                        name = tfc9;
                    }
                    if (buteur == 10)
                    {
                        name = tfc10;
                    }
                    if (buteur == 11)
                    {
                        name = tfc9bis;
                    }
                    Console.WriteLine(" TFC       " + Equipe);
                    Console.WriteLine("  " + x + "         " + y);
                    Console.WriteLine(" ");
                    Console.WriteLine(name);
                    Console.ReadLine();
                    Console.Clear();
                    if (moment == y)
                    {
                        if (carton_jaune >= 1)
                        {
                            int yellow_card = new Random().Next(1, 5); // Définit le scénario du joueur averti
                            string name_yellow = " "; // Initialisation de la variable du joueur qui sera averti
                            if (yellow_card == 1)
                            {
                                name_yellow = tfc1;
                                Avertissement a1 = new Avertissement(name_yellow, adversaire);
                            }
                            if (yellow_card == 2)
                            {
                                name_yellow = tfc2;
                                Avertissement a1 = new Avertissement(name_yellow, adversaire);
                            }
                            if (yellow_card == 3)
                            {
                                name_yellow = tfc3;
                                Avertissement a1 = new Avertissement(name_yellow, adversaire);
                            }
                            if (yellow_card == 4)
                            {
                                name_yellow = tfc4;
                                Avertissement a1 = new Avertissement(name_yellow, adversaire);
                            }
                            Console.ReadLine();
                            Console.Clear();
                            Console.WriteLine(" TFC       " + Equipe);
                            Console.WriteLine("  " + x + "         " + y);
                            Console.WriteLine(" ");
                            Console.WriteLine(name);
                            Console.WriteLine(name2);
                            Console.WriteLine(name3);
                            Console.WriteLine(name4);
                            Console.ReadLine();
                            Console.Clear();
                        }
                    }
                }
                if (domicile > 1)
                {
                    x = 2;
                    buteur = new Random().Next(1, 12);
                    if (buteur == 1)
                    {
                        name2 = tfc1;
                    }
                    if (buteur == 2)
                    {
                        name2 = tfc2;
                    }
                    if (buteur == 3)
                    {
                        name2 = tfc3;
                    }
                    if (buteur == 4)
                    {
                        name2 = tfc4;
                    }
                    if (buteur == 5)
                    {
                        name2 = tfc5;
                    }
                    if (buteur == 6)
                    {
                        name2 = tfc6;
                    }
                    if (buteur == 7)
                    {
                        name2 = tfc7;
                    }
                    if (buteur == 8)
                    {
                        name2 = tfc8;
                    }
                    if (buteur == 9)
                    {
                        name2 = tfc9;
                    }
                    if (buteur == 10)
                    {
                        name2 = tfc10;
                    }
                    if (buteur == 11)
                    {
                        name2 = tfc9bis;
                    }
                    Console.WriteLine(" TFC       " + Equipe);
                    Console.WriteLine("  " + x + "         " + y);
                    Console.WriteLine(" ");
                    Console.WriteLine(name);
                    Console.WriteLine(name2);
                    Console.ReadLine();
                    Console.Clear();
                    if (moment == y)
                    {
                        if (carton_jaune >= 1)
                        {
                            int yellow_card = new Random().Next(1, 5); // Définit le scénario du joueur averti
                            string name_yellow = " "; // Initialisation de la variable du joueur qui sera averti
                            if (yellow_card == 1)
                            {
                                name_yellow = tfc1;
                                Avertissement a1 = new Avertissement(name_yellow, adversaire);
                            }
                            if (yellow_card == 2)
                            {
                                name_yellow = tfc2;
                                Avertissement a1 = new Avertissement(name_yellow, adversaire);
                            }
                            if (yellow_card == 3)
                            {
                                name_yellow = tfc3;
                                Avertissement a1 = new Avertissement(name_yellow, adversaire);
                            }
                            if (yellow_card == 4)
                            {
                                name_yellow = tfc4;
                                Avertissement a1 = new Avertissement(name_yellow, adversaire);
                            }
                            Console.ReadLine();
                            Console.Clear();
                            Console.WriteLine(" TFC       " + Equipe);
                            Console.WriteLine("  " + x + "         " + y);
                            Console.WriteLine(" ");
                            Console.WriteLine(name);
                            Console.WriteLine(name2);
                            Console.WriteLine(name3);
                            Console.WriteLine(name4);
                            Console.ReadLine();
                            Console.Clear();
                        }
                    }
                }
                if (domicile > 2)
                {
                    buteur = new Random().Next(7, 11);
                    x = 3;
                    if (buteur == 7)
                    {
                        name3 = tfc5;
                    }
                    if (buteur == 8)
                    {
                        name3 = tfc8;
                    }
                    if (buteur == 9)
                    {
                        name3 = tfc9;
                    }
                    if (buteur == 10)
                    {
                        name3 = tfc10;
                    }
                    Console.WriteLine(" TFC       " + Equipe);
                    Console.WriteLine("  " + x + "         " + y);
                    Console.WriteLine(" ");
                    Console.WriteLine(name);
                    Console.WriteLine(name2);
                    Console.WriteLine(name3);
                    Console.ReadLine();
                    Console.Clear();
                    if (moment == y)
                    {
                        if (carton_jaune >= 1)
                        {
                            int yellow_card = new Random().Next(1, 5); // Définit le scénario du joueur averti
                            string name_yellow = " "; // Initialisation de la variable du joueur qui sera averti
                            if (yellow_card == 1)
                            {
                                name_yellow = tfc1;
                                Avertissement a1 = new Avertissement(name_yellow, adversaire);
                            }
                            if (yellow_card == 2)
                            {
                                name_yellow = tfc2;
                                Avertissement a1 = new Avertissement(name_yellow, adversaire);
                            }
                            if (yellow_card == 3)
                            {
                                name_yellow = tfc3;
                                Avertissement a1 = new Avertissement(name_yellow, adversaire);
                            }
                            if (yellow_card == 4)
                            {
                                name_yellow = tfc4;
                                Avertissement a1 = new Avertissement(name_yellow, adversaire);
                            }
                            Console.ReadLine();
                            Console.Clear();
                            Console.WriteLine(" TFC       " + Equipe);
                            Console.WriteLine("  " + x + "         " + y);
                            Console.WriteLine(" ");
                            Console.WriteLine(name);
                            Console.WriteLine(name2);
                            Console.WriteLine(name3);
                            Console.WriteLine(name4);
                            Console.ReadLine();
                            Console.Clear();
                        }
                    }
                }
                if (domicile > 3)
                {
                    buteur = new Random().Next(7, 12);
                    x = 4;
                    if (buteur == 7)
                    {
                        name4 = tfc5;
                    }
                    if (buteur == 8)
                    {
                        name4 = tfc8;
                    }
                    if (buteur == 9)
                    {
                        name4 = tfc9;
                    }
                    if (buteur == 10)
                    {
                        name4 = tfc10;
                    }
                    if (buteur == 11)
                    {
                        name4 = tfc9bis;
                    }
                    Console.WriteLine(" TFC       " + Equipe);
                    Console.WriteLine("  " + x + "         " + y);
                    Console.WriteLine(" ");
                    Console.WriteLine(name);
                    Console.WriteLine(name2);
                    Console.WriteLine(name3);
                    Console.WriteLine(name4);
                    Console.ReadLine();
                    Console.Clear();
                    if (moment == y)
                    {
                        if (carton_jaune >= 1)
                        {
                            int yellow_card = new Random().Next(1, 5); // Définit le scénario du joueur averti
                            string name_yellow = " "; // Initialisation de la variable du joueur qui sera averti
                            yellow_card = 1;

                            if (yellow_card == 1)
                            {
                                name_yellow = tfc1;
                                Avertissement a1 = new Avertissement(name_yellow, adversaire);
                            }
                            if (yellow_card == 2)
                            {
                                name_yellow = tfc2;
                                Avertissement a1 = new Avertissement(name_yellow, adversaire);
                            }
                            if (yellow_card == 3)
                            {
                                name_yellow = tfc3;
                                Avertissement a1 = new Avertissement(name_yellow, adversaire);
                            }
                            if (yellow_card == 4)
                            {
                                name_yellow = tfc4;
                                Avertissement a1 = new Avertissement(name_yellow, adversaire);
                            }
                            Console.ReadLine();
                            Console.Clear();
                            Console.WriteLine(" TFC       " + Equipe);
                            Console.WriteLine("  " + x + "         " + y);
                            Console.WriteLine(" ");
                            Console.WriteLine(name);
                            Console.WriteLine(name2);
                            Console.WriteLine(name3);
                            Console.WriteLine(name4);
                            Console.ReadLine();
                            Console.Clear();
                        }
                    }
                }
                if (domicile > 4)
                {
                    buteur = new Random().Next(7, 11);
                    x = 5;
                    if (buteur == 7)
                    {
                        name5 = tfc7;
                    }
                    if (buteur == 8)
                    {
                        name5 = tfc8;
                    }
                    if (buteur == 9)
                    {
                        name5 = tfc9;
                    }
                    if (buteur == 10)
                    {
                        name5 = tfc10;
                    }
                    Console.WriteLine(" TFC       " + Equipe);
                    Console.WriteLine("  " + x + "         " + y);
                    Console.WriteLine(" ");
                    Console.WriteLine(name);
                    Console.WriteLine(name2);
                    Console.WriteLine(name3);
                    Console.WriteLine(name4);
                    Console.WriteLine(name5);
                    Console.ReadLine();
                    Console.Clear();
                    if (moment == y)
                    {
                        if (carton_jaune >= 1)
                        {
                            int yellow_card = new Random().Next(1, 5); // Définit le scénario du joueur averti
                            string name_yellow = " "; // Initialisation de la variable du joueur qui sera averti
                            yellow_card = 1;

                            if (yellow_card == 1)
                            {
                                name_yellow = tfc1;
                                Avertissement a1 = new Avertissement(name_yellow, adversaire);
                            }
                            if (yellow_card == 2)
                            {
                                name_yellow = tfc2;
                                Avertissement a1 = new Avertissement(name_yellow, adversaire);
                            }
                            if (yellow_card == 3)
                            {
                                name_yellow = tfc3;
                                Avertissement a1 = new Avertissement(name_yellow, adversaire);
                            }
                            if (yellow_card == 4)
                            {
                                name_yellow = tfc4;
                                Avertissement a1 = new Avertissement(name_yellow, adversaire);
                            }
                            Console.ReadLine();
                            Console.Clear();
                            Console.WriteLine(" TFC       " + Equipe);
                            Console.WriteLine("  " + x + "         " + y);
                            Console.WriteLine(" ");
                            Console.WriteLine(name);
                            Console.WriteLine(name2);
                            Console.WriteLine(name3);
                            Console.WriteLine(name4);
                            Console.ReadLine();
                            Console.Clear();
                        }
                    }
                }
            }
            Console.WriteLine(" TFC       " + Equipe);
            Console.WriteLine("  " + x + "         " + y);
            Console.WriteLine(" ");
            Console.WriteLine(name);
            Console.WriteLine(name2);
            Console.WriteLine(name3);
            Console.WriteLine(name4);
            Console.WriteLine(name5);
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("AFFLUENCE : " + spectateur); // Affichage unique de l'affluence du match
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine(" TFC       " + Equipe);
            Console.WriteLine("  " + x + "         " + y);
            Console.WriteLine(" ");
            Console.WriteLine(name);
            Console.WriteLine(name2);
            Console.WriteLine(name3);
            Console.WriteLine(name4);
            Console.WriteLine(name5);
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("CHANGEMENT TFC (1/3)"); // Annonce du changement de mi-temps du TFC
            Console.ReadLine();
            Console.Clear();
            if (composition == 4)
            {
                entrant = "18 TREJO";
                sortant = " 4 DOUMBIA";
                Remplacement R1 = new Remplacement(entrant, sortant, adversaire, Equipe);
                tfc5 = "TREJO";
            }
            else // Changement par défaut
            {
                entrant = "18 TREJO";
                sortant = " 27 BLIN";
                Remplacement R1 = new Remplacement(entrant, sortant, adversaire, Equipe);
                tfc7 = "TREJO";
            }
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine(" TFC       " + Equipe);
            Console.WriteLine("  " + x + "         " + y);
            Console.WriteLine(" ");
            Console.WriteLine(name);
            Console.WriteLine(name2);
            Console.WriteLine(name3);
            Console.WriteLine(name4);
            Console.WriteLine(name5);
            Console.ReadLine();
            Console.Clear();
            if (type_m == 1)
            {
                int carton_rouge;
                if (domicile != 2)
                {
                    carton_rouge = new Random().Next(1, 6);
                }
                else
                {
                    carton_rouge = new Random().Next(1, 5);
                }
                if (carton_rouge == 1)
                {
                    string name_red;
                    if (domicile > 1)
                    {
                        domicile = domicile - 2; // Modifs en raison du fait de match
                    }
                    int red_card = new Random().Next(1, 5); // Choix du scénario du joueur expulsé
                    if (red_card == 1)
                    {
                        name_red = tfc5;
                        Expulsion e1 = new Expulsion(name_red, adversaire);
                        tfc5 = tfc8;
                    }
                    if (red_card == 2)
                    {
                        name_red = tfc6;
                        Expulsion e1 = new Expulsion(name_red, adversaire);
                        tfc6 = tfc7;
                    }
                    if (red_card == 3)
                    {
                        name_red = tfc9;
                        Expulsion e1 = new Expulsion(name_red, adversaire);
                        tfc9 = tfc10;
                        tfc9bis = "BRAITHWAITE"; // Changement de tireur de pénalty car expulsion
                    }
                    if (red_card == 4)
                    {
                        name_red = tfc8;
                        Expulsion e1 = new Expulsion(name_red, adversaire);
                        tfc8 = tfc10;
                    }
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine(" TFC       " + Equipe);
                    Console.WriteLine("  " + x + "         " + y);
                    Console.WriteLine(" ");
                    Console.WriteLine(name);
                    Console.WriteLine(name2);
                    Console.WriteLine(name3);
                    Console.WriteLine(name4);
                    Console.ReadLine();
                    Console.Clear();
                }
                if (domicile > 0)
                {
                    x = 1;
                    buteur = new Random().Next(1, 12);
                    if (buteur == 1)
                    {
                        name = tfc1;
                    }
                    if (buteur == 2)
                    {
                        name = tfc2;
                    }
                    if (buteur == 3)
                    {
                        name = tfc3;
                    }
                    if (buteur == 4)
                    {
                        name = tfc4;
                    }
                    if (buteur == 5)
                    {
                        name = tfc5;
                    }
                    if (buteur == 6)
                    {
                        name = tfc6;
                    }
                    if (buteur == 7)
                    {
                        name = tfc7;
                    }
                    if (buteur == 8)
                    {
                        name = tfc8;
                    }
                    if (buteur == 9)
                    {
                        name = tfc9;
                    }
                    if (buteur == 10)
                    {
                        name = tfc10;
                    }
                    if (buteur == 11)
                    {
                        name = tfc9bis;
                    }
                    Console.WriteLine(" TFC       " + Equipe);
                    Console.WriteLine("  " + x + "         " + y);
                    Console.WriteLine(" ");
                    Console.WriteLine(name);
                    Console.ReadLine();
                    Console.Clear();
                }
                if (domicile > 1)
                {
                    buteur = new Random().Next(1, 11);
                    x = 2;
                    if (buteur == 1)
                    {
                        name2 = tfc1;
                    }
                    if (buteur == 2)
                    {
                        name2 = tfc2;
                    }
                    if (buteur == 3)
                    {
                        name2 = tfc3;
                    }
                    if (buteur == 4)
                    {
                        name2 = tfc4;
                    }
                    if (buteur == 5)
                    {
                        name2 = tfc5;
                    }
                    if (buteur == 6)
                    {
                        name2 = tfc6;
                    }
                    if (buteur == 7)
                    {
                        name2 = tfc7;
                    }
                    if (buteur == 8)
                    {
                        name2 = tfc8;
                    }
                    if (buteur == 9)
                    {
                        name2 = tfc9;
                    }
                    if (buteur == 10)
                    {
                        name2 = tfc10;
                    }
                    Console.WriteLine(" TFC       " + Equipe);
                    Console.WriteLine("  " + x + "         " + y);
                    Console.WriteLine(" ");
                    Console.WriteLine(name);
                    Console.WriteLine(name2);
                    Console.ReadLine();
                    Console.Clear();
                }
                if (domicile > 2)
                {
                    buteur = new Random().Next(7, 11);
                    x = 3;
                    if (buteur == 7)
                    {
                        name3 = tfc5;
                    }
                    if (buteur == 8)
                    {
                        name3 = tfc8;
                    }
                    if (buteur == 9)
                    {
                        name3 = tfc9;
                    }
                    if (buteur == 10)
                    {
                        name3 = tfc10;
                    }
                    Console.WriteLine(" TFC       " + Equipe);
                    Console.WriteLine("  " + x + "         " + y);
                    Console.WriteLine(" ");
                    Console.WriteLine(name);
                    Console.WriteLine(name2);
                    Console.WriteLine(name3);
                    Console.WriteLine(name4);
                    Console.ReadLine();
                    Console.Clear();
                }
                if (domicile > 3)
                {
                    buteur = new Random().Next(7, 12);
                    x = 4;
                    if (buteur == 7)
                    {
                        name4 = tfc5;
                    }
                    if (buteur == 8)
                    {
                        name4 = tfc8;
                    }
                    if (buteur == 9)
                    {
                        name4 = tfc9;
                    }
                    if (buteur == 10)
                    {
                        name4 = tfc10;
                    }
                    if (buteur == 11)
                    {
                        name4 = tfc9bis;
                    }
                    Console.WriteLine(" TFC       " + Equipe);
                    Console.WriteLine("  " + x + "         " + y);
                    Console.WriteLine(" ");
                    Console.WriteLine(name);
                    Console.WriteLine(name2);
                    Console.WriteLine(name3);
                    Console.WriteLine(name4);
                    Console.ReadLine();
                    Console.Clear();
                }
                TempsAdditionnel M2 = new TempsAdditionnel(tps_ad); // Annonce le temps additionnel de la seconde période
                if (domicile > 4)
                {
                    buteur = new Random().Next(7, 11);
                    x = 5;
                    if (buteur == 7)
                    {
                        name5 = tfc7;
                    }
                    if (buteur == 8)
                    {
                        name5 = tfc8;
                    }
                    if (buteur == 9)
                    {
                        name5 = tfc9;
                    }
                    if (buteur == 10)
                    {
                        name5 = tfc10;
                    }
                    Console.WriteLine(" TFC       " + Equipe);
                    Console.WriteLine("  " + x + "         " + y);
                    Console.WriteLine(" ");
                    Console.WriteLine(name);
                    Console.WriteLine(name2);
                    Console.WriteLine(name3);
                    Console.WriteLine(name4);
                    Console.WriteLine(name5);
                    Console.ReadLine();
                    Console.Clear();
                }
            }
            else
            {
                y = 1;
                while (y <= exterieur)
                {
                    Console.WriteLine(" TFC       " + Equipe);
                    Console.WriteLine("  " + x + "         " + y);
                    Console.WriteLine(" ");
                    Console.WriteLine(name);
                    Console.WriteLine(name2);
                    Console.WriteLine(name3);
                    Console.WriteLine(name4);
                    Console.WriteLine(name5);
                    Console.ReadLine();
                    Console.Clear();
                    y = y + 1;
                }
                TempsAdditionnel M2 = new TempsAdditionnel(tps_ad); // Annonce le temps additionnel de la seconde période
            }
            Console.WriteLine(" TFC       " + Equipe);
            Console.WriteLine("  " + domicile + "         " + exterieur);
            Console.WriteLine(" ");
            Console.WriteLine(name); // Récapitulatif final des buteurs
            Console.WriteLine(name2);
            Console.WriteLine(name3);
            Console.WriteLine(name4);
            Console.WriteLine(name5);
            Console.ReadLine();
            Console.Clear();
        }
    }
}
