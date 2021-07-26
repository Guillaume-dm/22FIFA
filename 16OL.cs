using System;

namespace _22FIFA
{
    class OL16
    {
        public OL16(int domicile, string nom, int mouvant, string Equipe, int pts, int exterieur, int spectateur, string adversaire, int meteo, int diffuseur)
        {
            Console.Clear();
            Console.WriteLine(" DIFFUSEUR : OLTV"); // Annonce du diffuseur du match
            Console.WriteLine(" ");
            Meteo M1 = new Meteo(meteo);
            Console.Clear();
            Console.WriteLine("COMPOSITION OL (4-3-3)"); // Annonce de la composition de l'adversaire et son dispositif
            int tps_ad = new Random().Next(2, 6); // Initialisation de la variable pour le temps additionnel de la seconde mi-temps
            int composition = new Random().Next(1, 5); // Initialisation de la variable qui influe sur le 1er changement pour l'OL
            string ol1 = "MOREL";
            string ol2 = "UMTITI";
            string ol3 = "Y.MAPOU";
            string ol3bis = "YANGA-MBIWA";
            string ol4 = "RAPAEL";
            string ol5 = "FERRI";
            string ol6 = "GONALONS";
            string ol7 = "TOLISSO";
            string ol8 = "VALBUENA";
            string ol9 = "LACAZETTE";
            string ol10 = "BEAUVUE";
            string ol9bis = "LACAZETTE (P)"; // Affichage en cas de pénalty transformé
            string entrant;  // Sert à l'affichage du joueur entrant en cas de remplacements. 
            string sortant; // Sert à l'affichage du joueur sortant en cas de remplacements. 
            Console.WriteLine(" ");
            Console.WriteLine("                1-LOPES"); // Ligne du gardien de but
            Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine(" 13- " + ol4 + "  5- " + ol3 + "  23- " + ol2 + "  15- " + ol1); // Ligne défensive
            Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("   12- " + ol5 + "   21- " + ol6 + "    8- " + ol7); // Ligne des milieux de terrain
            Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine(" 28- " + ol8 + "  10- " + ol9 + "   9- " + ol10); // Ligne des attaquants
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
            Console.WriteLine("  OL       " + Equipe);
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
                            name_yellow = ol8;
                            Avertissement a1 = new Avertissement(name_yellow, adversaire);
                        }
                        if (yellow_card == 2)
                        {
                            name_yellow = ol2;
                            Avertissement a1 = new Avertissement(name_yellow, adversaire);
                        }
                        if (yellow_card == 3)
                        {
                            name_yellow = ol3bis;
                            Avertissement a1 = new Avertissement(name_yellow, adversaire);
                        }
                        if (yellow_card == 4)
                        {
                            name_yellow = ol5;
                            Avertissement a1 = new Avertissement(name_yellow, adversaire);
                        }
                        Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("  OL       " + Equipe);
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
                    Console.WriteLine("  OL       " + Equipe);
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
                                name_yellow = ol8;
                                Avertissement a1 = new Avertissement(name_yellow, adversaire);
                            }
                            if (yellow_card == 2)
                            {
                                name_yellow = ol2;
                                Avertissement a1 = new Avertissement(name_yellow, adversaire);
                            }
                            if (yellow_card == 3)
                            {
                                name_yellow = ol3bis;
                                Avertissement a1 = new Avertissement(name_yellow, adversaire);
                            }
                            if (yellow_card == 4)
                            {
                                name_yellow = ol5;
                                Avertissement a1 = new Avertissement(name_yellow, adversaire);
                            }
                            Console.ReadLine();
                            Console.Clear();
                            Console.WriteLine("  OL       " + Equipe);
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
                            name_yellow = ol8;
                            Avertissement a1 = new Avertissement(name_yellow, adversaire);
                        }
                        if (yellow_card == 2)
                        {
                            name_yellow = ol2;
                            Avertissement a1 = new Avertissement(name_yellow, adversaire);
                        }
                        if (yellow_card == 3)
                        {
                            name_yellow = ol3bis;
                            Avertissement a1 = new Avertissement(name_yellow, adversaire);
                        }
                        if (yellow_card == 4)
                        {
                            name_yellow = ol5;
                            Avertissement a1 = new Avertissement(name_yellow, adversaire);
                        }
                        Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("  OL       " + Equipe);
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
                        name = ol1;
                    }
                    if (buteur == 2)
                    {
                        name = ol2;
                    }
                    if (buteur == 3)
                    {
                        name = ol3bis;
                    }
                    if (buteur == 4)
                    {
                        name = ol4;
                    }
                    if (buteur == 5)
                    {
                        name = ol5;
                    }
                    if (buteur == 6)
                    {
                        name = ol6;
                    }
                    if (buteur == 7)
                    {
                        name = ol7;
                    }
                    if (buteur == 8)
                    {
                        name = ol8;
                    }
                    if (buteur == 9)
                    {
                        name = ol9;
                    }
                    if (buteur == 10)
                    {
                        name = ol10;
                    }
                    if (buteur == 11)
                    {
                        name = ol9bis;
                    }
                    Console.WriteLine("  OL       " + Equipe);
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
                            yellow_card = 1;

                            if (yellow_card == 1)
                            {
                                name_yellow = ol8;
                                Avertissement a1 = new Avertissement(name_yellow, adversaire);
                            }
                            if (yellow_card == 2)
                            {
                                name_yellow = ol2;
                                Avertissement a1 = new Avertissement(name_yellow, adversaire);
                            }
                            if (yellow_card == 3)
                            {
                                name_yellow = ol3bis;
                                Avertissement a1 = new Avertissement(name_yellow, adversaire);
                            }
                            if (yellow_card == 4)
                            {
                                name_yellow = ol5;
                                Avertissement a1 = new Avertissement(name_yellow, adversaire);
                            }
                            Console.ReadLine();
                            Console.Clear();
                            Console.WriteLine("  OL       " + Equipe);
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
                        name2 = ol1;
                    }
                    if (buteur == 2)
                    {
                        name2 = ol2;
                    }
                    if (buteur == 3)
                    {
                        name2 = ol3bis;
                    }
                    if (buteur == 4)
                    {
                        name2 = ol4;
                    }
                    if (buteur == 5)
                    {
                        name2 = ol5;
                    }
                    if (buteur == 6)
                    {
                        name2 = ol6;
                    }
                    if (buteur == 7)
                    {
                        name2 = ol7;
                    }
                    if (buteur == 8)
                    {
                        name2 = ol8;
                    }
                    if (buteur == 9)
                    {
                        name2 = ol9;
                    }
                    if (buteur == 10)
                    {
                        name2 = ol10;
                    }
                    if (buteur == 11)
                    {
                        name2 = ol9bis;
                    }
                    Console.WriteLine("  OL       " + Equipe);
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
                            yellow_card = 1;

                            if (yellow_card == 1)
                            {
                                name_yellow = ol8;
                                Avertissement a1 = new Avertissement(name_yellow, adversaire);
                            }
                            if (yellow_card == 2)
                            {
                                name_yellow = ol2;
                                Avertissement a1 = new Avertissement(name_yellow, adversaire);
                            }
                            if (yellow_card == 3)
                            {
                                name_yellow = ol3bis;
                                Avertissement a1 = new Avertissement(name_yellow, adversaire);
                            }
                            if (yellow_card == 4)
                            {
                                name_yellow = ol5;
                                Avertissement a1 = new Avertissement(name_yellow, adversaire);
                            }
                            Console.ReadLine();
                            Console.Clear();
                            Console.WriteLine("  OL       " + Equipe);
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
                        name3 = ol7;
                    }
                    if (buteur == 8)
                    {
                        name3 = ol8;
                    }
                    if (buteur == 9)
                    {
                        name3 = ol9;
                    }
                    if (buteur == 10)
                    {
                        name3 = ol10;
                    }
                    Console.WriteLine("  OL       " + Equipe);
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
                            yellow_card = 1;

                            if (yellow_card == 1)
                            {
                                name_yellow = ol8;
                                Avertissement a1 = new Avertissement(name_yellow, adversaire);
                            }
                            if (yellow_card == 2)
                            {
                                name_yellow = ol2;
                                Avertissement a1 = new Avertissement(name_yellow, adversaire);
                            }
                            if (yellow_card == 3)
                            {
                                name_yellow = ol3;
                                Avertissement a1 = new Avertissement(name_yellow, adversaire);
                            }
                            if (yellow_card == 4)
                            {
                                name_yellow = ol3bis;
                                Avertissement a1 = new Avertissement(name_yellow, adversaire);
                            }
                            Console.ReadLine();
                            Console.Clear();
                            Console.WriteLine("  OL       " + Equipe);
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
                        name4 = ol7;
                    }
                    if (buteur == 8)
                    {
                        name4 = ol8;
                    }
                    if (buteur == 9)
                    {
                        name4 = ol9;
                    }
                    if (buteur == 10)
                    {
                        name4 = ol10;
                    }
                    if (buteur == 11)
                    {
                        name4 = ol9bis;
                    }
                    Console.WriteLine("  OL       " + Equipe);
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
                                name_yellow = ol8;
                                Avertissement a1 = new Avertissement(name_yellow, adversaire);
                            }
                            if (yellow_card == 2)
                            {
                                name_yellow = ol2;
                                Avertissement a1 = new Avertissement(name_yellow, adversaire);
                            }
                            if (yellow_card == 3)
                            {
                                name_yellow = ol3bis;
                                Avertissement a1 = new Avertissement(name_yellow, adversaire);
                            }
                            if (yellow_card == 4)
                            {
                                name_yellow = ol5;
                                Avertissement a1 = new Avertissement(name_yellow, adversaire);
                            }
                            Console.ReadLine();
                            Console.Clear();
                            Console.WriteLine("  OL       " + Equipe);
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
                        name5 = ol7;
                    }
                    if (buteur == 8)
                    {
                        name5 = ol8;
                    }
                    if (buteur == 9)
                    {
                        name5 = ol9;
                    }
                    if (buteur == 10)
                    {
                        name5 = ol10;
                    }
                    Console.WriteLine("  OL       " + Equipe);
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
                                name_yellow = ol8;
                                Avertissement a1 = new Avertissement(name_yellow, adversaire);
                            }
                            if (yellow_card == 2)
                            {
                                name_yellow = ol2;
                                Avertissement a1 = new Avertissement(name_yellow, adversaire);
                            }
                            if (yellow_card == 3)
                            {
                                name_yellow = ol3bis;
                                Avertissement a1 = new Avertissement(name_yellow, adversaire);
                            }
                            if (yellow_card == 4)
                            {
                                name_yellow = ol5;
                                Avertissement a1 = new Avertissement(name_yellow, adversaire);
                            }
                            Console.ReadLine();
                            Console.Clear();
                            Console.WriteLine("  OL       " + Equipe);
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
            Console.WriteLine("  OL       " + Equipe);
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
            Console.WriteLine("  OL       " + Equipe);
            Console.WriteLine("  " + x + "         " + y);
            Console.WriteLine(" ");
            Console.WriteLine(name);
            Console.WriteLine(name2);
            Console.WriteLine(name3);
            Console.WriteLine(name4);
            Console.WriteLine(name5);
            Console.ReadLine();
            Console.Clear();
            if (composition == 4)
            {
                entrant = "14 DARDER";
                sortant = "8 TOLISSO";
                Remplacement R1 = new Remplacement(entrant, sortant, adversaire, Equipe);
                ol7 = "DARDER";
            }
            else // Changement par défaut
            {
                entrant = "14 DARDER";
                sortant = "12 FERRI";
                Remplacement R1 = new Remplacement(entrant, sortant, adversaire, Equipe);
                ol5 = "DARDER";
            }
            Console.WriteLine("  OL       " + Equipe);
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
                    int red_card = new Random().Next(1, 4); // Choix du scénario du joueur expulsé
                    if (red_card == 1)
                    {
                        name_red = ol6;
                        Expulsion e1 = new Expulsion(name_red, adversaire);
                        ol6 = ol5;
                    }
                    if (red_card == 2)
                    {
                        name_red = ol10;
                        Expulsion e1 = new Expulsion(name_red, adversaire);
                        ol10 = ol9;
                    }
                    if (red_card == 3)
                    {
                        name_red = ol6;
                        Expulsion e1 = new Expulsion(name_red, adversaire);
                        ol6 = ol5;
                    }
                    if (red_card == 4)
                    {
                        name_red = ol7;
                        Expulsion e1 = new Expulsion(name_red, adversaire);
                        ol7 = ol5;
                    }
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("  OL       " + Equipe);
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
                        name = ol1;
                    }
                    if (buteur == 2)
                    {
                        name = ol2;
                    }
                    if (buteur == 3)
                    {
                        name = ol3bis;
                    }
                    if (buteur == 4)
                    {
                        name = ol4;
                    }
                    if (buteur == 5)
                    {
                        name = ol5;
                    }
                    if (buteur == 6)
                    {
                        name = ol6;
                    }
                    if (buteur == 7)
                    {
                        name = ol7;
                    }
                    if (buteur == 8)
                    {
                        name = ol8;
                    }
                    if (buteur == 9)
                    {
                        name = ol9;
                    }
                    if (buteur == 10)
                    {
                        name = ol10;
                    }
                    if (buteur == 11)
                    {
                        name = ol9bis;
                    }
                    Console.WriteLine("  OL       " + Equipe);
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
                        name2 = ol1;
                    }
                    if (buteur == 2)
                    {
                        name2 = ol2;
                    }
                    if (buteur == 3)
                    {
                        name2 = ol3bis;
                    }
                    if (buteur == 4)
                    {
                        name2 = ol4;
                    }
                    if (buteur == 5)
                    {
                        name2 = ol5;
                    }
                    if (buteur == 6)
                    {
                        name2 = ol6;
                    }
                    if (buteur == 7)
                    {
                        name2 = ol7;
                    }
                    if (buteur == 8)
                    {
                        name2 = ol8;
                    }
                    if (buteur == 9)
                    {
                        name2 = ol9;
                    }
                    if (buteur == 10)
                    {
                        name2 = ol10;
                    }
                    Console.WriteLine("  OL       " + Equipe);
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
                        name3 = ol7;
                    }
                    if (buteur == 8)
                    {
                        name3 = ol8;
                    }
                    if (buteur == 9)
                    {
                        name3 = ol9;
                    }
                    if (buteur == 10)
                    {
                        name3 = ol10;
                    }
                    Console.WriteLine("  OL       " + Equipe);
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
                        name4 = ol7;
                    }
                    if (buteur == 8)
                    {
                        name4 = ol8;
                    }
                    if (buteur == 9)
                    {
                        name4 = ol9;
                    }
                    if (buteur == 10)
                    {
                        name4 = ol10;
                    }
                    if (buteur == 11)
                    {
                        name4 = ol9bis;
                    }
                    Console.WriteLine("  OL       " + Equipe);
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
                        name5 = ol7;
                    }
                    if (buteur == 8)
                    {
                        name5 = ol8;
                    }
                    if (buteur == 9)
                    {
                        name5 = ol9;
                    }
                    if (buteur == 10)
                    {
                        name5 = ol10;
                    }
                    Console.WriteLine("  OL       " + Equipe);
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
                    Console.WriteLine("  OL       " + Equipe);
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
                TempsAdditionnel M2 = new TempsAdditionnel(tps_ad);  // Annonce le temps additionnel de la seconde période
            }
            Console.WriteLine("  OL       " + Equipe);
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
