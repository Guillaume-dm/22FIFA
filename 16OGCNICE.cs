using System;

namespace _22FIFA
{
    class OGCNICE16
    {
        public OGCNICE16(int domicile, string nom, int mouvant, string Equipe, int pts, int exterieur, int spectateur, string adversaire, int meteo, int diffuseur)
        {
            Console.Clear();
            Diffuseur tv = new Diffuseur(diffuseur);
            Meteo M1 = new Meteo(meteo);
            Console.Clear();
            Console.WriteLine("COMPOSITION OGC NICE (4-4-2 en losange)"); // Annonce de la composition de l'adversaire et son dispositif
            int tps_ad = new Random().Next(2, 6); // Initialisation de la variable pour le temps additionnel de la seconde mi-temps
            int composition = new Random().Next(0, 9);
            int gardien = new Random().Next(0, 10); // Variable pour le choix du gardien niçois
            string nice0 = " ";
            string entrant;
            string sortant;
            if (gardien == 0)
            {
                nice0 = "   30- CARDINALE";
            }
            else // Gardien par défaut
            {
                nice0 = "    1- HASSEN";
            }
            int latéral = new Random().Next(0, 3); // Choix du latéral gauche niçois
            string nice1 = " ";
            string nice1b = " ";
            if (latéral == 0)
            {
                nice1 = " 4- BAYSSE";
                nice1b = "BAYSSE";
            }
            else // Latéral gauche par défaut
            {
                nice1 = "23- RICARDO";
                nice1b = "R.PEREIRA";
            }
            string nice2 = "BOSCAGLI";
            string nice3 = "BODMER";
            string nice4 = "PIED";
            string nice5 = "MENDY";
            string nice6 = "SERI";
            string nice7 = "KOZIELLO";
            string nice8 = "BEN ARFA";
            string nice9 = "GERMAIN";
            string nice10 = "LE BIHAN";
            string nice9bis = "GERMAIN (P)"; // Affichage si pénalty transformé
            Console.WriteLine(" ");
            Console.WriteLine("             " + nice0);
            Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("29- " + nice4 + "  24- " + nice3 + " 33- " + nice2 + "  " + nice1);
            Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("                22- " + nice5);
            Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("      26- " + nice7 + "           6- " + nice6);
            Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("                 9- " + nice8);
            Console.ReadLine();
            Console.WriteLine(" ");
            if (composition == 1)
            {
                nice10 = "MENDY";
                Console.WriteLine("      15- " + nice10 + "          28- " + nice9);
            }
            else // Choix par défaut
            {
                Console.WriteLine("      10- " + nice10 + "           28- " + nice9);
            }
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
            Console.WriteLine("OGC NICE       " + Equipe);
            Console.WriteLine("     " + x + "          0");
            Console.ReadLine();
            Console.Clear();
            int type_m = new Random().Next(1, 3);
            int moment = new Random().Next(1, 6); // Permet de savoir quand l'avertissement va arriver
            if (moment > exterieur & type_m == 1)
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
                if(moment == y)
                {
                    if (carton_jaune >= 1)
                    {
                        int yellow_card = new Random().Next(1, 5); // Définit le scénario du joueur averti
                        string name_yellow = " "; // Initialisation de la variable du joueur qui sera averti
                        if (yellow_card == 1)
                        {
                            name_yellow = nice9;
                            Avertissement a1 = new Avertissement(name_yellow, adversaire);
                        }
                        if (yellow_card == 2)
                        {
                            name_yellow = nice1;
                            Avertissement a1 = new Avertissement(name_yellow, adversaire);
                        }
                        if (yellow_card == 3)
                        {
                            name_yellow = nice2;
                            Avertissement a1 = new Avertissement(name_yellow, adversaire);
                        }
                        if (yellow_card == 4)
                        {
                            name_yellow = nice4;
                            Avertissement a1 = new Avertissement(name_yellow, adversaire);
                        }
                        Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("OGC NICE       " + Equipe);
                        Console.WriteLine("     " + x + "          " + y);
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
                    y = y + 1;
                    Console.WriteLine("OGC NICE       " + Equipe);
                    Console.WriteLine("     " + x + "          " + y);
                    Console.ReadLine();
                    Console.Clear();
                 }
                if (moment == y)
                {
                    if (carton_jaune >= 1)
                    {
                        int yellow_card = new Random().Next(1, 5); // Définit le scénario du joueur averti
                        string name_yellow = " "; // Initialisation de la variable du joueur qui sera averti
                        if (yellow_card == 1)
                        {
                            name_yellow = nice9;
                            Avertissement a1 = new Avertissement(name_yellow, adversaire);
                        }
                        if (yellow_card == 2)
                        {
                            name_yellow = nice1;
                            Avertissement a1 = new Avertissement(name_yellow, adversaire);
                        }
                        if (yellow_card == 3)
                        {
                            name_yellow = nice2;
                            Avertissement a1 = new Avertissement(name_yellow, adversaire);
                        }
                        if (yellow_card == 4)
                        {
                            name_yellow = nice4;
                            Avertissement a1 = new Avertissement(name_yellow, adversaire);
                        }
                        Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("OGC NICE       " + Equipe);
                        Console.WriteLine("     " + x + "          " + y);
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
            else
            {
                if(moment == x)
                {
                    if (carton_jaune >= 1)
                    {
                        int yellow_card = new Random().Next(1, 5); // Définit le scénario du joueur averti
                        string name_yellow = " "; // Initialisation de la variable du joueur qui sera averti
                        if (yellow_card == 1)
                        {
                            name_yellow = nice9;
                            Avertissement a1 = new Avertissement(name_yellow, adversaire);
                        }
                        if (yellow_card == 2)
                        {
                            name_yellow = nice1;
                            Avertissement a1 = new Avertissement(name_yellow, adversaire);
                        }
                        if (yellow_card == 3)
                        {
                            name_yellow = nice2;
                            Avertissement a1 = new Avertissement(name_yellow, adversaire);
                        }
                        if (yellow_card == 4)
                        {
                            name_yellow = nice4;
                            Avertissement a1 = new Avertissement(name_yellow, adversaire);
                        }
                        Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("OGC NICE       " + Equipe);
                        Console.WriteLine("     " + x + "          " + y);
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
                        name = nice1b;
                    }
                    if (buteur == 2)
                    {
                        name = nice2;
                    }
                    if (buteur == 3)
                    {
                        name = nice3;
                    }
                    if (buteur == 4)
                    {
                        name = nice4;
                    }
                    if (buteur == 5)
                    {
                        name = nice5;
                    }
                    if (buteur == 6)
                    {
                        name = nice6;
                    }
                    if (buteur == 7)
                    {
                        name = nice7;
                    }
                    if (buteur == 8)
                    {
                        name = nice8;
                    }
                    if (buteur == 9)
                    {
                        name = nice9;
                    }
                    if (buteur == 10)
                    {
                        name = nice10;
                    }
                    if (buteur == 11)
                    {
                        name = nice9bis;
                    }
                    Console.WriteLine("OGC NICE       " + Equipe);
                    Console.WriteLine("     " + x + "          " + y);
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
                                name_yellow = nice9;
                                Avertissement a1 = new Avertissement(name_yellow, adversaire);
                            }
                            if (yellow_card == 2)
                            {
                                name_yellow = nice1;
                                Avertissement a1 = new Avertissement(name_yellow, adversaire);
                            }
                            if (yellow_card == 3)
                            {
                                name_yellow = nice2;
                                Avertissement a1 = new Avertissement(name_yellow, adversaire);
                            }
                            if (yellow_card == 4)
                            {
                                name_yellow = nice4;
                                Avertissement a1 = new Avertissement(name_yellow, adversaire);
                            }
                            Console.ReadLine();
                            Console.Clear();
                            Console.WriteLine("OGC NICE       " + Equipe);
                            Console.WriteLine("     " + x + "          " + y);
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
                    buteur = new Random().Next(1, 11);
                    x = 2;
                    if (buteur == 1)
                    {
                        name2 = nice1b;
                    }
                    if (buteur == 2)
                    {
                        name2 = nice2;
                    }
                    if (buteur == 3)
                    {
                        name2 = nice3;
                    }
                    if (buteur == 4)
                    {
                        name2 = nice4;
                    }
                    if (buteur == 5)
                    {
                        name2 = nice5;
                    }
                    if (buteur == 6)
                    {
                        name2 = nice6;
                    }
                    if (buteur == 7)
                    {
                        name2 = nice7;
                    }
                    if (buteur == 8)
                    {
                        name2 = nice8;
                    }
                    if (buteur == 9)
                    {
                        name2 = nice9;
                    }
                    if (buteur == 10)
                    {
                        name2 = nice10;
                    }
                    Console.WriteLine("OGC NICE       " + Equipe);
                    Console.WriteLine("     " + x + "          " + y);
                    Console.WriteLine(" ");
                    Console.WriteLine(name);
                    Console.WriteLine(name2);
                    Console.ReadLine();
                    Console.Clear();
                    if(moment == y)
                {
                        if (carton_jaune >= 1)
                        {
                            int yellow_card = new Random().Next(1, 5); // Définit le scénario du joueur averti
                            string name_yellow = " "; // Initialisation de la variable du joueur qui sera averti
                            if (yellow_card == 1)
                            {
                                name_yellow = nice9;
                                Avertissement a1 = new Avertissement(name_yellow, adversaire);
                            }
                            if (yellow_card == 2)
                            {
                                name_yellow = nice1;
                                Avertissement a1 = new Avertissement(name_yellow, adversaire);
                            }
                            if (yellow_card == 3)
                            {
                                name_yellow = nice2;
                                Avertissement a1 = new Avertissement(name_yellow, adversaire);
                            }
                            if (yellow_card == 4)
                            {
                                name_yellow = nice4;
                                Avertissement a1 = new Avertissement(name_yellow, adversaire);
                            }
                            Console.ReadLine();
                            Console.Clear();
                            Console.WriteLine("OGC NICE       " + Equipe);
                            Console.WriteLine("     " + x + "          " + y);
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
                        name3 = nice7;
                    }
                    if (buteur == 8)
                    {
                        name3 = nice8;
                    }
                    if (buteur == 9)
                    {
                        name3 = nice9;
                    }
                    if (buteur == 10)
                    {
                        name3 = nice10;
                    }
                    y = 0;
                    Console.WriteLine("OGC NICE       " + Equipe);
                    Console.WriteLine("     " + x + "          " + y);
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
                                name_yellow = nice9;
                                Avertissement a1 = new Avertissement(name_yellow, adversaire);
                            }
                            if (yellow_card == 2)
                            {
                                name_yellow = nice1;
                                Avertissement a1 = new Avertissement(name_yellow, adversaire);
                            }
                            if (yellow_card == 3)
                            {
                                name_yellow = nice2;
                                Avertissement a1 = new Avertissement(name_yellow, adversaire);
                            }
                            if (yellow_card == 4)
                            {
                                name_yellow = nice4;
                                Avertissement a1 = new Avertissement(name_yellow, adversaire);
                            }
                            Console.ReadLine();
                            Console.Clear();
                            Console.WriteLine("OGC NICE       " + Equipe);
                            Console.WriteLine("     " + x + "          " + y);
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
                        name4 = nice7;
                    }
                    if (buteur == 8)
                    {
                        name4 = nice8;
                    }
                    if (buteur == 9)
                    {
                        name4 = nice9;
                    }
                    if (buteur == 10)
                    {
                        name4 = nice10;
                    }
                    if (buteur == 11)
                    {
                        name4 = nice9bis;
                    }
                    Console.WriteLine("OGC NICE       " + Equipe);
                    Console.WriteLine("     " + x + "          " + y);
                    Console.WriteLine(" ");
                    Console.WriteLine(name);
                    Console.WriteLine(name2);
                    Console.WriteLine(name3);
                    Console.WriteLine(name4);
                    Console.ReadLine();
                    Console.Clear();
                    if(moment == y)
                    {
                        if (carton_jaune >= 1)
                        {
                            int yellow_card = new Random().Next(1, 5); // Définit le scénario du joueur averti
                            string name_yellow = " "; // Initialisation de la variable du joueur qui sera averti
                            if (yellow_card == 1)
                            {
                                name_yellow = nice9;
                                Avertissement a1 = new Avertissement(name_yellow, adversaire);
                            }
                            if (yellow_card == 2)
                            {
                                name_yellow = nice1;
                                Avertissement a1 = new Avertissement(name_yellow, adversaire);
                            }
                            if (yellow_card == 3)
                            {
                                name_yellow = nice2;
                                Avertissement a1 = new Avertissement(name_yellow, adversaire);
                            }
                            if (yellow_card == 4)
                            {
                                name_yellow = nice4;
                                Avertissement a1 = new Avertissement(name_yellow, adversaire);
                            }
                            Console.ReadLine();
                            Console.Clear();
                            Console.WriteLine("OGC NICE       " + Equipe);
                            Console.WriteLine("     " + x + "          " + y);
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
                    buteur = new Random().Next(7, 11);
                    x = 5;
                    if (buteur == 7)
                    {
                        name5 = nice7;
                    }
                    if (buteur == 8)
                    {
                        name5 = nice8;
                    }
                    if (buteur == 9)
                    {
                        name5 = nice9;
                    }
                    if (buteur == 10)
                    {
                        name5 = nice10;
                    }
                    Console.WriteLine("OGC NICE       " + Equipe);
                    Console.WriteLine("     " + x + "          " + y);
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
                            if (yellow_card == 1)
                            {
                                name_yellow = nice9;
                                Avertissement a1 = new Avertissement(name_yellow, adversaire);
                            }
                            if (yellow_card == 2)
                            {
                                name_yellow = nice1;
                                Avertissement a1 = new Avertissement(name_yellow, adversaire);
                            }
                            if (yellow_card == 3)
                            {
                                name_yellow = nice2;
                                Avertissement a1 = new Avertissement(name_yellow, adversaire);
                            }
                            if (yellow_card == 4)
                            {
                                name_yellow = nice4;
                                Avertissement a1 = new Avertissement(name_yellow, adversaire);
                            }
                            Console.ReadLine();
                            Console.Clear();
                            Console.WriteLine("OGC NICE       " + Equipe);
                            Console.WriteLine("     " + x + "          " + y);
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
            Console.WriteLine("OGC NICE       " + Equipe);
            Console.WriteLine("     " + x + "          " + y);
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
            Console.WriteLine("OGC NICE       " + Equipe);
            Console.WriteLine("     " + x + "          " + y);
            Console.WriteLine(" ");
            Console.WriteLine(name);
            Console.WriteLine(name2);
            Console.WriteLine(name3);
            Console.WriteLine(name4);
            Console.WriteLine(name5);
            Console.ReadLine();
            Console.Clear();
            if (composition == 1)
            {
                entrant = "10 LE BIHAN";
                sortant = "15 MENDY";
                Remplacement R1 = new Remplacement(entrant, sortant, adversaire, Equipe);
                nice10 = "LE BIHAN";
            }
            else // Changement par défaut
            {
                entrant = "15 MENDY";
                sortant = "10 LE BIHAN";
                Remplacement R1 = new Remplacement(entrant, sortant, adversaire, Equipe);
                nice10 = "MENDY";
            }
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("OGC NICE       " + Equipe);
            Console.WriteLine("     " + x + "          " + y);
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
                        domicile = domicile - 2; // Modifs du score en différage suite au fait de match
                    }
                    int red_card = new Random().Next(1, 4); // Scénario du joueur expulsé
                    if (red_card == 1)
                    {
                        name_red = nice5;
                        Expulsion e1 = new Expulsion(name_red, adversaire);
                        nice5 = nice8;
                    }
                    if (red_card == 2)
                    {
                        name_red = nice7;
                        Expulsion e1 = new Expulsion(name_red, adversaire);
                        nice7 = nice5;
                    }
                    if (red_card == 3)
                    {
                        name_red = nice6;
                        Expulsion e1 = new Expulsion(name_red, adversaire);
                        nice6 = nice5;
                    }
                    if (red_card == 4)
                    {
                        name_red = nice8;
                        Expulsion e1 = new Expulsion(name_red, adversaire);
                        nice8 = nice5;
                    }
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("OGC NICE       " + Equipe);
                    Console.WriteLine("     " + x + "          " + y);
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
                        name = nice1b;
                    }
                    if (buteur == 2)
                    {
                        name = nice2;
                    }
                    if (buteur == 3)
                    {
                        name = nice3;
                    }
                    if (buteur == 4)
                    {
                        name = nice4;
                    }
                    if (buteur == 5)
                    {
                        name = nice5;
                    }
                    if (buteur == 6)
                    {
                        name = nice6;
                    }
                    if (buteur == 7)
                    {
                        name = nice7;
                    }
                    if (buteur == 8)
                    {
                        name = nice8;
                    }
                    if (buteur == 9)
                    {
                        name = nice9;
                    }
                    if (buteur == 10)
                    {
                        name = nice10;
                    }
                    if (buteur == 11)
                    {
                        name = nice9bis;
                    }
                    Console.WriteLine("OGC NICE       " + Equipe);
                    Console.WriteLine("     " + x + "          " + exterieur);
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
                        name2 = nice1b;
                    }
                    if (buteur == 2)
                    {
                        name2 = nice2;
                    }
                    if (buteur == 3)
                    {
                        name2 = nice3;
                    }
                    if (buteur == 4)
                    {
                        name2 = nice4;
                    }
                    if (buteur == 5)
                    {
                        name2 = nice5;
                    }
                    if (buteur == 6)
                    {
                        name2 = nice6;
                    }
                    if (buteur == 7)
                    {
                        name2 = nice7;
                    }
                    if (buteur == 8)
                    {
                        name2 = nice8;
                    }
                    if (buteur == 9)
                    {
                        name2 = nice9;
                    }
                    if (buteur == 10)
                    {
                        name2 = nice10;
                    }
                    Console.WriteLine("OGC NICE       " + Equipe);
                    Console.WriteLine("     " + x + "          " + exterieur);
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
                        name3 = nice7;
                    }
                    if (buteur == 8)
                    {
                        name3 = nice8;
                    }
                    if (buteur == 9)
                    {
                        name3 = nice9;
                    }
                    if (buteur == 10)
                    {
                        name3 = nice10;
                    }
                    Console.WriteLine("OGC NICE       " + Equipe);
                    Console.WriteLine("     " + x + "          " + exterieur);
                    Console.WriteLine(" ");
                    Console.WriteLine(name);
                    Console.WriteLine(name2);
                    Console.WriteLine(name3);
                    Console.ReadLine();
                    Console.Clear();
                }
                if (domicile > 3)
                {
                    buteur = new Random().Next(7, 12);
                    x = 4;
                    if (buteur == 7)
                    {
                        name4 = nice7;
                    }
                    if (buteur == 8)
                    {
                        name4 = nice8;
                    }
                    if (buteur == 9)
                    {
                        name4 = nice9;
                    }
                    if (buteur == 10)
                    {
                        name4 = nice10;
                    }
                    if (buteur == 11)
                    {
                        name4 = nice9bis;
                    }
                    Console.WriteLine("OGC NICE       " + Equipe);
                    Console.WriteLine("     " + x + "          " + exterieur);
                    Console.WriteLine(" ");
                    Console.WriteLine(name);
                    Console.WriteLine(name2);
                    Console.WriteLine(name3);
                    Console.WriteLine(name4);
                    Console.ReadLine();
                    Console.Clear();
                }
                TempsAdditionnel M2 = new TempsAdditionnel(tps_ad); // Annonce le temps additionnel de la seconde période
                Console.WriteLine("OGC NICE       " + Equipe);
                Console.WriteLine("     " + x + "          " + exterieur);
                Console.WriteLine(" ");
                Console.WriteLine(name);
                Console.WriteLine(name2);
                Console.WriteLine(name3);
                Console.WriteLine(name4);
                Console.ReadLine();
                Console.Clear();
                if (domicile > 4)
                {
                    buteur = new Random().Next(7, 11);
                    x = 5;
                    if (buteur == 7)
                    {
                        name5 = nice7;
                    }
                    if (buteur == 8)
                    {
                        name5 = nice8;
                    }
                    if (buteur == 9)
                    {
                        name5 = nice9;
                    }
                    if (buteur == 10)
                    {
                        name5 = nice10;
                    }
                    Console.WriteLine("OGC NICE       " + Equipe);
                    Console.WriteLine("     " + x + "          " + exterieur);
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
                    Console.WriteLine("OGC NICE       " + Equipe);
                    Console.WriteLine("     " + x + "          " + y);
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
            Console.WriteLine("OGC NICE       " + Equipe);
            Console.WriteLine("     " + domicile + "          " + exterieur);
            Console.WriteLine(" ");
            Console.WriteLine(name); // Récapitulatif final des buteurs
            Console.WriteLine(name2);
            Console.WriteLine(name3);
            Console.WriteLine(name4);
            Console.WriteLine(name5);
            Console.WriteLine(" ");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
