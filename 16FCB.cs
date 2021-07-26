using System;

namespace _22FIFA
{
    class FCB16
    {
        public FCB16(int domicile, string nom, int mouvant, string Equipe, int pts, int exterieur, int spectateur, string adversaire, int meteo, int diffuseur)
        {
            Console.Clear();
            Diffuseur tv = new Diffuseur(diffuseur);
            Meteo M1 = new Meteo(meteo);
            Console.Clear();
            Console.WriteLine("COMPOSITION FC BARCELONE (4-3-3)"); // Annonce de la composition de l'adversaire et son dispositif
            int tps_ad = new Random().Next(2, 6); // Initialisation de la variable pour le temps additionnel de la seconde mi-temps
            int composition = new Random().Next(1, 5); // Initialisation de la variable qui influe sur le 1er changement pour l'OL
            string fcb1 = "JORDI ALBA";
            string fcb2 = "MASCHERANO";
            string fcb3 = "PIQUE";
            string fcb4 = "DANI ALVES";
            string fcb5 = "RAKITIC";
            string fcb6 = "BUSQUETS";
            string fcb7 = "INIESTA";
            string fcb8 = "S.ROBERTO";
            string fcb9 = "SUAREZ";
            string fcb10 = "NEYMAR JR";
            string fcb9bis;  // Sert à l'affichage du joueur marquant en pénalty si le cas se produit. 
            string entrant;  // Sert à l'affichage du joueur entrant en cas de remplacements. 
            string sortant;  // Sert à l'affichage du joueur sortant en cas de remplacements. 
            int tireur_pénalty = new Random().Next(0, 2); // Initialisation de la variable qui influe sur le 1er changement pour l'OL
            if (tireur_pénalty == 0)
            {
                fcb9bis = "SUAREZ (P)"; // Affichage en cas de pénalty transformé
            }
            else
            {
                fcb9bis = "NEYMAR JR (P)"; // Affichage en cas de pénalty transformé
            }
            Console.WriteLine(" ");
            Console.WriteLine("                   13-BRAVO"); // Ligne du gardien de but
            Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine(" 6- " + fcb4 + "  3- " + fcb3 + "  14- " + fcb2 + "  18- " + fcb1); // Ligne défensive
            Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("       4- " + fcb5 + "    5- " + fcb6 + "    8- " + fcb7); // Ligne des milieux de terrain
            Console.ReadLine();
            Console.WriteLine(" ");
            if (composition == 1)
            {
                fcb8 = "MESSI";
                Console.WriteLine("   10- " + fcb8 + " 9- " + fcb9 + "  11- " + fcb10); // Ligne des attaquants
            }
            else
            {
                fcb8 = "S.ROBERTO";
                Console.WriteLine("      20- " + fcb8 + "  9- " + fcb9 + "    11- " + fcb10); // Ligne des attaquants
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
            Console.WriteLine(" FCB       " + Equipe);
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
                        int yellow_card = new Random().Next(1, 10); // Définit le scénario du joueur averti
                        string name_yellow = " "; // Initialisation de la variable du joueur qui sera averti;
                        if (yellow_card == 1)
                        {
                            name_yellow = fcb1;
                            Avertissement a1 = new Avertissement(name_yellow, adversaire);
                        }
                        if (yellow_card == 2)
                        {
                            name_yellow = fcb8;
                            Avertissement a1 = new Avertissement(name_yellow, adversaire);
                        }
                        if (yellow_card == 3)
                        {
                            name_yellow = fcb9;
                            Avertissement a1 = new Avertissement(name_yellow, adversaire);
                        }
                        if (yellow_card == 4)
                        {
                            name_yellow = fcb10;
                            Avertissement a1 = new Avertissement(name_yellow, adversaire);
                        }
                        if (yellow_card == 5)
                        {
                            name_yellow = fcb2;
                            Avertissement a1 = new Avertissement(name_yellow, adversaire);
                        }
                        if (yellow_card == 6)
                        {
                            name_yellow = fcb3;
                            Avertissement a1 = new Avertissement(name_yellow, adversaire);
                        }
                        if (yellow_card == 7)
                        {
                            name_yellow = fcb5;
                            Avertissement a1 = new Avertissement(name_yellow, adversaire);
                        }
                        if (yellow_card == 8)
                        {
                            name_yellow = fcb6;
                            Avertissement a1 = new Avertissement(name_yellow, adversaire);
                        }
                        if (yellow_card == 9)
                        {
                            name_yellow = fcb7;
                            Avertissement a1 = new Avertissement(name_yellow, adversaire);
                        }
                        Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine(" FCB       " + Equipe);
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
                    Console.WriteLine(" FCB       " + Equipe);
                    Console.WriteLine("  " + x + "         " + y);
                    Console.ReadLine();
                    Console.Clear();
                    y = y + 1;
                    if (moment == y)
                    {
                        if (carton_jaune >= 1)
                        {
                            int yellow_card = new Random().Next(1, 10); // Définit le scénario du joueur averti
                            string name_yellow = " "; // Initialisation de la variable du joueur qui sera averti;
                            if (yellow_card == 1)
                            {
                                name_yellow = fcb1;
                                Avertissement a1 = new Avertissement(name_yellow, adversaire);
                            }
                            if (yellow_card == 2)
                            {
                                name_yellow = fcb8;
                                Avertissement a1 = new Avertissement(name_yellow, adversaire);
                            }
                            if (yellow_card == 3)
                            {
                                name_yellow = fcb9;
                                Avertissement a1 = new Avertissement(name_yellow, adversaire);
                            }
                            if (yellow_card == 4)
                            {
                                name_yellow = fcb10;
                                Avertissement a1 = new Avertissement(name_yellow, adversaire);
                            }
                            if (yellow_card == 5)
                            {
                                name_yellow = fcb2;
                                Avertissement a1 = new Avertissement(name_yellow, adversaire);
                            }
                            if (yellow_card == 6)
                            {
                                name_yellow = fcb3;
                                Avertissement a1 = new Avertissement(name_yellow, adversaire);
                            }
                            if (yellow_card == 7)
                            {
                                name_yellow = fcb5;
                                Avertissement a1 = new Avertissement(name_yellow, adversaire);
                            }
                            if (yellow_card == 8)
                            {
                                name_yellow = fcb6;
                                Avertissement a1 = new Avertissement(name_yellow, adversaire);
                            }
                            if (yellow_card == 9)
                            {
                                name_yellow = fcb7;
                                Avertissement a1 = new Avertissement(name_yellow, adversaire);
                            }
                            Console.ReadLine();
                            Console.Clear();
                            Console.WriteLine(" FCB       " + Equipe);
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
                            name_yellow = fcb1;
                            Avertissement a1 = new Avertissement(name_yellow, adversaire);
                        }
                        if (yellow_card == 2)
                        {
                            name_yellow = fcb8;
                            Avertissement a1 = new Avertissement(name_yellow, adversaire);
                        }
                        if (yellow_card == 3)
                        {
                            name_yellow = fcb9;
                            Avertissement a1 = new Avertissement(name_yellow, adversaire);
                        }
                        if (yellow_card == 4)
                        {
                            name_yellow = fcb10;
                            Avertissement a1 = new Avertissement(name_yellow, adversaire);
                        }
                        if (yellow_card == 5)
                        {
                            name_yellow = fcb2;
                            Avertissement a1 = new Avertissement(name_yellow, adversaire);
                        }
                        if (yellow_card == 6)
                        {
                            name_yellow = fcb3;
                            Avertissement a1 = new Avertissement(name_yellow, adversaire);
                        }
                        if (yellow_card == 7)
                        {
                            name_yellow = fcb5;
                            Avertissement a1 = new Avertissement(name_yellow, adversaire);
                        }
                        if (yellow_card == 8)
                        {
                            name_yellow = fcb6;
                            Avertissement a1 = new Avertissement(name_yellow, adversaire);
                        }
                        if (yellow_card == 9)
                        {
                            name_yellow = fcb7;
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
                        name = fcb1;
                    }
                    if (buteur == 2)
                    {
                        name = fcb2;
                    }
                    if (buteur == 3)
                    {
                        name = fcb3;
                    }
                    if (buteur == 4)
                    {
                        name = fcb4;
                    }
                    if (buteur == 5)
                    {
                        name = fcb5;
                    }
                    if (buteur == 6)
                    {
                        name = fcb6;
                    }
                    if (buteur == 7)
                    {
                        name = fcb7;
                    }
                    if (buteur == 8)
                    {
                        name = fcb8;
                    }
                    if (buteur == 9)
                    {
                        name = fcb9;
                    }
                    if (buteur == 10)
                    {
                        name = fcb10;
                    }
                    if (buteur == 11)
                    {
                        name = fcb9bis;
                    }
                    Console.WriteLine(" FCB       " + Equipe);
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
                                name_yellow = fcb1;
                                Avertissement a1 = new Avertissement(name_yellow, adversaire);
                            }
                            if (yellow_card == 2)
                            {
                                name_yellow = fcb8;
                                Avertissement a1 = new Avertissement(name_yellow, adversaire);
                            }
                            if (yellow_card == 3)
                            {
                                name_yellow = fcb9;
                                Avertissement a1 = new Avertissement(name_yellow, adversaire);
                            }
                            if (yellow_card == 4)
                            {
                                name_yellow = fcb10;
                                Avertissement a1 = new Avertissement(name_yellow, adversaire);
                            }
                            if (yellow_card == 5)
                            {
                                name_yellow = fcb2;
                                Avertissement a1 = new Avertissement(name_yellow, adversaire);
                            }
                            if (yellow_card == 6)
                            {
                                name_yellow = fcb3;
                                Avertissement a1 = new Avertissement(name_yellow, adversaire);
                            }
                            if (yellow_card == 7)
                            {
                                name_yellow = fcb5;
                                Avertissement a1 = new Avertissement(name_yellow, adversaire);
                            }
                            if (yellow_card == 8)
                            {
                                name_yellow = fcb6;
                                Avertissement a1 = new Avertissement(name_yellow, adversaire);
                            }
                            if (yellow_card == 9)
                            {
                                name_yellow = fcb7;
                                Avertissement a1 = new Avertissement(name_yellow, adversaire);
                            }
                            Console.ReadLine();
                            Console.Clear();
                            Console.WriteLine(" FCB       " + Equipe);
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
                        name2 = fcb1;
                    }
                    if (buteur == 2)
                    {
                        name2 = fcb2;
                    }
                    if (buteur == 3)
                    {
                        name2 = fcb3;
                    }
                    if (buteur == 4)
                    {
                        name2 = fcb4;
                    }
                    if (buteur == 5)
                    {
                        name2 = fcb5;
                    }
                    if (buteur == 6)
                    {
                        name2 = fcb6;
                    }
                    if (buteur == 7)
                    {
                        name2 = fcb7;
                    }
                    if (buteur == 8)
                    {
                        name2 = fcb8;
                    }
                    if (buteur == 9)
                    {
                        name2 = fcb9;
                    }
                    if (buteur == 10)
                    {
                        name2 = fcb10;
                    }
                    if (buteur == 11)
                    {
                        name2 = fcb9bis;
                    }
                    Console.WriteLine(" FCB       " + Equipe);
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
                                name_yellow = fcb1;
                                Avertissement a1 = new Avertissement(name_yellow, adversaire);
                            }
                            if (yellow_card == 2)
                            {
                                name_yellow = fcb8;
                                Avertissement a1 = new Avertissement(name_yellow, adversaire);
                            }
                            if (yellow_card == 3)
                            {
                                name_yellow = fcb9;
                                Avertissement a1 = new Avertissement(name_yellow, adversaire);
                            }
                            if (yellow_card == 4)
                            {
                                name_yellow = fcb10;
                                Avertissement a1 = new Avertissement(name_yellow, adversaire);
                            }
                            if (yellow_card == 5)
                            {
                                name_yellow = fcb2;
                                Avertissement a1 = new Avertissement(name_yellow, adversaire);
                            }
                            if (yellow_card == 6)
                            {
                                name_yellow = fcb3;
                                Avertissement a1 = new Avertissement(name_yellow, adversaire);
                            }
                            if (yellow_card == 7)
                            {
                                name_yellow = fcb5;
                                Avertissement a1 = new Avertissement(name_yellow, adversaire);
                            }
                            if (yellow_card == 8)
                            {
                                name_yellow = fcb6;
                                Avertissement a1 = new Avertissement(name_yellow, adversaire);
                            }
                            if (yellow_card == 9)
                            {
                                name_yellow = fcb7;
                                Avertissement a1 = new Avertissement(name_yellow, adversaire);
                            }
                            Console.ReadLine();
                            Console.Clear();
                            Console.WriteLine(" FCB       " + Equipe);
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
                        name3 = fcb5;
                    }
                    if (buteur == 8)
                    {
                        name3 = fcb8;
                    }
                    if (buteur == 9)
                    {
                        name3 = fcb9;
                    }
                    if (buteur == 10)
                    {
                        name3 = fcb10;
                    }
                    Console.WriteLine(" FCB       " + Equipe);
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
                                name_yellow = fcb1;
                                Avertissement a1 = new Avertissement(name_yellow, adversaire);
                            }
                            if (yellow_card == 2)
                            {
                                name_yellow = fcb8;
                                Avertissement a1 = new Avertissement(name_yellow, adversaire);
                            }
                            if (yellow_card == 3)
                            {
                                name_yellow = fcb9;
                                Avertissement a1 = new Avertissement(name_yellow, adversaire);
                            }
                            if (yellow_card == 4)
                            {
                                name_yellow = fcb10;
                                Avertissement a1 = new Avertissement(name_yellow, adversaire);
                            }
                            if (yellow_card == 5)
                            {
                                name_yellow = fcb2;
                                Avertissement a1 = new Avertissement(name_yellow, adversaire);
                            }
                            if (yellow_card == 6)
                            {
                                name_yellow = fcb3;
                                Avertissement a1 = new Avertissement(name_yellow, adversaire);
                            }
                            if (yellow_card == 7)
                            {
                                name_yellow = fcb5;
                                Avertissement a1 = new Avertissement(name_yellow, adversaire);
                            }
                            if (yellow_card == 8)
                            {
                                name_yellow = fcb6;
                                Avertissement a1 = new Avertissement(name_yellow, adversaire);
                            }
                            if (yellow_card == 9)
                            {
                                name_yellow = fcb7;
                                Avertissement a1 = new Avertissement(name_yellow, adversaire);
                            }
                            Console.ReadLine();
                            Console.Clear();
                            Console.WriteLine(" FCB       " + Equipe);
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
                        name4 = fcb5;
                    }
                    if (buteur == 8)
                    {
                        name4 = fcb8;
                    }
                    if (buteur == 9)
                    {
                        name4 = fcb9;
                    }
                    if (buteur == 10)
                    {
                        name4 = fcb10;
                    }
                    if (buteur == 11)
                    {
                        name4 = fcb9bis;
                    }
                    Console.WriteLine(" FCB       " + Equipe);
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
                            if (yellow_card == 1)
                            {
                                name_yellow = fcb1;
                                Avertissement a1 = new Avertissement(name_yellow, adversaire);
                            }
                            if (yellow_card == 2)
                            {
                                name_yellow = fcb8;
                                Avertissement a1 = new Avertissement(name_yellow, adversaire);
                            }
                            if (yellow_card == 3)
                            {
                                name_yellow = fcb9;
                                Avertissement a1 = new Avertissement(name_yellow, adversaire);
                            }
                            if (yellow_card == 4)
                            {
                                name_yellow = fcb10;
                                Avertissement a1 = new Avertissement(name_yellow, adversaire);
                            }
                            if (yellow_card == 5)
                            {
                                name_yellow = fcb2;
                                Avertissement a1 = new Avertissement(name_yellow, adversaire);
                            }
                            if (yellow_card == 6)
                            {
                                name_yellow = fcb3;
                                Avertissement a1 = new Avertissement(name_yellow, adversaire);
                            }
                            if (yellow_card == 7)
                            {
                                name_yellow = fcb5;
                                Avertissement a1 = new Avertissement(name_yellow, adversaire);
                            }
                            if (yellow_card == 8)
                            {
                                name_yellow = fcb6;
                                Avertissement a1 = new Avertissement(name_yellow, adversaire);
                            }
                            if (yellow_card == 9)
                            {
                                name_yellow = fcb7;
                                Avertissement a1 = new Avertissement(name_yellow, adversaire);
                            }
                            Console.ReadLine();
                            Console.Clear();
                            Console.WriteLine(" FCB       " + Equipe);
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
                        name5 = fcb7;
                    }
                    if (buteur == 8)
                    {
                        name5 = fcb8;
                    }
                    if (buteur == 9)
                    {
                        name5 = fcb9;
                    }
                    if (buteur == 10)
                    {
                        name5 = fcb10;
                    }
                    Console.WriteLine(" FCB       " + Equipe);
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
                            if (yellow_card == 1)
                            {
                                name_yellow = fcb1;
                                Avertissement a1 = new Avertissement(name_yellow, adversaire);
                            }
                            if (yellow_card == 2)
                            {
                                name_yellow = fcb8;
                                Avertissement a1 = new Avertissement(name_yellow, adversaire);
                            }
                            if (yellow_card == 3)
                            {
                                name_yellow = fcb9;
                                Avertissement a1 = new Avertissement(name_yellow, adversaire);
                            }
                            if (yellow_card == 4)
                            {
                                name_yellow = fcb10;
                                Avertissement a1 = new Avertissement(name_yellow, adversaire);
                            }
                            if (yellow_card == 5)
                            {
                                name_yellow = fcb2;
                                Avertissement a1 = new Avertissement(name_yellow, adversaire);
                            }
                            if (yellow_card == 6)
                            {
                                name_yellow = fcb3;
                                Avertissement a1 = new Avertissement(name_yellow, adversaire);
                            }
                            if (yellow_card == 7)
                            {
                                name_yellow = fcb5;
                                Avertissement a1 = new Avertissement(name_yellow, adversaire);
                            }
                            if (yellow_card == 8)
                            {
                                name_yellow = fcb6;
                                Avertissement a1 = new Avertissement(name_yellow, adversaire);
                            }
                            if (yellow_card == 9)
                            {
                                name_yellow = fcb7;
                                Avertissement a1 = new Avertissement(name_yellow, adversaire);
                            }
                            Console.ReadLine();
                            Console.Clear();
                            Console.WriteLine(" FCB       " + Equipe);
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
            Console.WriteLine(" FCB       " + Equipe);
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
            Console.WriteLine(" FCB       " + Equipe);
            Console.WriteLine("  " + x + "         " + y);
            Console.WriteLine(" ");
            Console.WriteLine(name);
            Console.WriteLine(name2);
            Console.WriteLine(name3);
            Console.WriteLine(name4);
            Console.WriteLine(name5);
            Console.ReadLine();
            Console.Clear();
            if (composition > 1)
            {
                entrant = "10 MESSI";
                sortant = "20 S.ROBERTO";
                Remplacement R1 = new Remplacement(entrant, sortant, adversaire, Equipe);
                fcb8 = "MESSI";
            }
            else // Changement par défaut
            {
                sortant = "10 MESSI";
                entrant = "20 S.ROBERTO";
                Remplacement R1 = new Remplacement(entrant, sortant, adversaire, Equipe);
                fcb8 = "S.ROBERTO";
            }
            Console.WriteLine(" FCB       " + Equipe);
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
                        name_red = fcb9;
                        Expulsion e1 = new Expulsion(name_red, adversaire);
                        fcb9 = fcb10;
                        fcb9bis = "NEYMAR JR (P)";
                    }
                    if (red_card == 2)
                    {
                        name_red = fcb10;
                        Expulsion e1 = new Expulsion(name_red, adversaire);
                        fcb10 = fcb7;
                        fcb9bis = "SUAREZ (P)";
                    }
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine(" FCB       " + Equipe);
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
                        name = fcb1;
                    }
                    if (buteur == 2)
                    {
                        name = fcb2;
                    }
                    if (buteur == 3)
                    {
                        name = fcb3;
                    }
                    if (buteur == 4)
                    {
                        name = fcb4;
                    }
                    if (buteur == 5)
                    {
                        name = fcb5;
                    }
                    if (buteur == 6)
                    {
                        name = fcb6;
                    }
                    if (buteur == 7)
                    {
                        name = fcb7;
                    }
                    if (buteur == 8)
                    {
                        name = fcb8;
                    }
                    if (buteur == 9)
                    {
                        name = fcb9;
                    }
                    if (buteur == 10)
                    {
                        name = fcb10;
                    }
                    if (buteur == 11)
                    {
                        name = fcb9bis;
                    }
                    Console.WriteLine(" FCB       " + Equipe);
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
                        name2 = fcb1;
                    }
                    if (buteur == 2)
                    {
                        name2 = fcb2;
                    }
                    if (buteur == 3)
                    {
                        name2 = fcb3;
                    }
                    if (buteur == 4)
                    {
                        name2 = fcb4;
                    }
                    if (buteur == 5)
                    {
                        name2 = fcb5;
                    }
                    if (buteur == 6)
                    {
                        name2 = fcb6;
                    }
                    if (buteur == 7)
                    {
                        name2 = fcb7;
                    }
                    if (buteur == 8)
                    {
                        name2 = fcb8;
                    }
                    if (buteur == 9)
                    {
                        name2 = fcb9;
                    }
                    if (buteur == 10)
                    {
                        name2 = fcb10;
                    }
                    Console.WriteLine(" FCB       " + Equipe);
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
                        name3 = fcb5;
                    }
                    if (buteur == 8)
                    {
                        name3 = fcb8;
                    }
                    if (buteur == 9)
                    {
                        name3 = fcb9;
                    }
                    if (buteur == 10)
                    {
                        name3 = fcb10;
                    }
                    Console.WriteLine(" FCB       " + Equipe);
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
                        name4 = fcb5;
                    }
                    if (buteur == 8)
                    {
                        name4 = fcb8;
                    }
                    if (buteur == 9)
                    {
                        name4 = fcb9;
                    }
                    if (buteur == 10)
                    {
                        name4 = fcb10;
                    }
                    if (buteur == 11)
                    {
                        name4 = fcb9bis;
                    }
                    Console.WriteLine(" FCB        " + Equipe);
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
                        name5 = fcb7;
                    }
                    if (buteur == 8)
                    {
                        name5 = fcb8;
                    }
                    if (buteur == 9)
                    {
                        name5 = fcb9;
                    }
                    if (buteur == 10)
                    {
                        name5 = fcb10;
                    }
                    Console.WriteLine(" FCB       " + Equipe);
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
                    Console.WriteLine(" FCB       " + Equipe);
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
            Console.WriteLine(" FCB       " + Equipe);
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
