using System;

namespace _22FIFA
{
    class ASSE
    {
        public ASSE(int domicile, string achat1, string achat2, string achat3, int mouvant, string Equipe, int pts, int exterieur, int spectateur, string adversaire)
        { 
            Console.Clear();
            Console.WriteLine("COMPOSITION ASSE (4-2-3-1)"); // Annonce de la composition d'équipe de l'adversaire
            int tps_ad = new Random().Next(2, 6); // Initialisation de la variable pour le temps additionnel  de la seconde mi-temps
            int composition = new Random().Next(0, 9); 
            int gardien = new Random().Next(0, 7); // Choix du gardien stéphanois
            string asse0 = " ";
            if (gardien == 0) {  // Cas où le gardien remplacent est titularisé
                asse0 = "   40- BAJIC";
            }
            else // Gardien par déaut
            {
                asse0 = "   30- MOULIN";
            }
            int latéral = new Random().Next(0, 3); // Choix du latéral gauche stéphanois
            string asse1 = " ";
            string asse1b = " ";
            if (latéral == 0)
            {
                asse1 = "27- MACON";
                asse1b = "MACON";
            }
            else // Latéral gauche stéphanois par défaut
            {
                asse1 = "11- G.SILVA";
                asse1b = "G.SILVA";
            }
            string asse2 = "MOUKOUDI";
            string asse3 = "SOW";
            string asse4 = "PALENCIA";
            string asse5 = "GOURNA-DOUATH";
            string asse6 = "YOUSSOUF";
            string asse7 = "CAMARA";
            string asse8 = "KRASSO";
            string asse9 = "BOUANGA";
            string asse10 = "ABI";
            string asse9bis = "BOUANGA (P)"; // Sert à l'affichage en cas de pénalty stéphanois transformé
            string entrant;  // Sert à l'affichage du joueur entrant en cas de remplacements. 
            string sortant; // Sert à l'affichage du joueur sortant en cas de remplacements. 
            Console.WriteLine(" ");
            Console.WriteLine("             " + asse0); // Ligne du gardien de but
            Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("23- " + asse4 + "   35- " + asse3 + "  2- " + asse2 + "  " + asse1); // Ligne défensive
            Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("      28- " + asse6 + "           33- " + asse5); // Ligne des millieux récupérateurs
            Console.ReadLine();
            Console.WriteLine(" ");
            if (composition == 0)
            {
                asse8 = "BOUDEBOUZ";
                Console.WriteLine("  7- " + asse8 + "    20- " + asse9 + "      8- " + asse7);
            }
            else
            {
                Console.WriteLine("   14- " + asse8 + "    20- " + asse9 + "     18- " + asse7);
            }
            Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("                  31- " + asse10); // Attaquant de pointe
            Console.ReadLine();
            Console.Clear();
            if (achat1 != " ")
            {
                Console.WriteLine("1- TITULAIRE ");
                Console.WriteLine("2- REMPLACANT");
                Console.WriteLine(" ");
                Console.Write(achat1 + " : ");
                string titulaire = (Console.ReadLine());
                Console.Clear();
                switch (titulaire)
                {
                    case "1":
                        Console.WriteLine("[...]TITULAIRE : " + achat1 + "[...]");
                        break;
                    default:
                        Console.WriteLine("[...]REMPLACANT : " + achat1 + "[...]");
                        if (mouvant > 6)
                        {
                            pts = pts - 1;
                        }
                        break;
                }
                Console.ReadLine();
                Console.Clear();
            }
            if (achat2 != " ")
            {
                Console.WriteLine("1- TITULAIRE ");
                Console.WriteLine("2- REMPLACANT");
                Console.WriteLine(" ");
                Console.Write(achat2 + " : ");
                string titulaire = (Console.ReadLine());
                Console.Clear();
                switch (titulaire)
                {
                    case "1":
                        Console.WriteLine("[...]TITULAIRE : " + achat2 + "[...]");
                        break;
                    default:
                        Console.WriteLine("[...]REMPLACANT : " + achat2 + "[...]");
                        if (mouvant > 6)
                        {
                            // pts = pts - 1;
                        }
                        break;
                }
                Console.ReadLine();
                Console.Clear();
            }
            if (achat3 != " ")
            {
                Console.WriteLine("1- TITULAIRE ");
                Console.WriteLine("2- REMPLACANT");
                Console.WriteLine(" ");
                Console.Write(achat3 + " : ");
                string titulaire = (Console.ReadLine());
                Console.Clear();
                switch (titulaire)
                {
                    case "1":
                        Console.WriteLine("[...]TITULAIRE : " + achat3 + "[...]");
                        break;
                    default:
                        Console.WriteLine("[...]REMPLACANT : " + achat3 + "[...]");
                        if (mouvant > 6)
                        {
                            // pts = pts - 1;
                        }
                        break;
                }
                Console.ReadLine();
                Console.Clear();
            }
            int buteur = 0;
            int x = 0;
            int y = 0;
            string name = " "; // Initialisation à vide des différentes variables de noms de buteurs
            string name2 = " ";
            string name3 = " ";
            string name4 = " ";
            Console.WriteLine(" A.S.S.E       " + Equipe);
            Console.WriteLine("     " + x + "          0");
            Console.ReadLine();
            Console.Clear();
            int type_m = new Random().Next(1, 3);
            int moment = new Random().Next(1, 6); // Permet de savoir quand l'avertissement va arriver
            int carton_jaune = new Random().Next(0, 2); // Défini le nombre de carton jaune du match
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
                            name_yellow = asse1b;
                            Avertissement a1 = new Avertissement(name_yellow, adversaire);
                        }
                        if (yellow_card == 2)
                        {
                            name_yellow = asse2;
                            Avertissement a1 = new Avertissement(name_yellow, adversaire);
                        }
                        if (yellow_card == 3)
                        {
                            name_yellow = asse6;
                            Avertissement a1 = new Avertissement(name_yellow, adversaire);
                        }
                        if (yellow_card == 4)
                        {
                            name_yellow = asse7;
                            Avertissement a1 = new Avertissement(name_yellow, adversaire);
                        }
                        Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine(" A.S.S.E       " + Equipe);
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
                    Console.WriteLine(" A.S.S.E       " + Equipe);
                    Console.WriteLine("     " + x + "          " + y);
                    Console.ReadLine();
                    Console.Clear();
                    if (moment == y)
                    {
                        if (carton_jaune >= 1)
                        {
                            int yellow_card = new Random().Next(1, 5); // Définit le scénario du joueur averti
                            string name_yellow = " "; // Initialisation de la variable du joueur qui sera averti;
                            if (yellow_card == 1)
                            {
                                name_yellow = asse1b;
                                Avertissement a1 = new Avertissement(name_yellow, adversaire);
                            }
                            if (yellow_card == 2)
                            {
                                name_yellow = asse2;
                                Avertissement a1 = new Avertissement(name_yellow, adversaire);
                            }
                            if (yellow_card == 3)
                            {
                                name_yellow = asse6;
                                Avertissement a1 = new Avertissement(name_yellow, adversaire);
                            }
                            if (yellow_card == 4)
                            {
                                name_yellow = asse7;
                                Avertissement a1 = new Avertissement(name_yellow, adversaire);
                            }
                            Console.ReadLine();
                            Console.Clear();
                            Console.WriteLine(" A.S.S.E       " + Equipe);
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
                            name_yellow = asse1b;
                            Avertissement a1 = new Avertissement(name_yellow, adversaire);
                        }
                        if (yellow_card == 2)
                        {
                            name_yellow = asse2;
                            Avertissement a1 = new Avertissement(name_yellow, adversaire);
                        }
                        if (yellow_card == 3)
                        {
                            name_yellow = asse6;
                            Avertissement a1 = new Avertissement(name_yellow, adversaire);
                        }
                        if (yellow_card == 4)
                        {
                            name_yellow = asse7;
                            Avertissement a1 = new Avertissement(name_yellow, adversaire);
                        }
                        Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine(" A.S.S.E       " + Equipe);
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
                        name = asse1b;
                    }
                    if (buteur == 2)
                    {
                        name = asse2;
                    }
                    if (buteur == 3)
                    {
                        name = asse3;
                    }
                    if (buteur == 4)
                    {
                        name = asse4;
                    }
                    if (buteur == 5)
                    {
                        name = asse5;
                    }
                    if (buteur == 6)
                    {
                        name = asse6;
                    }
                    if (buteur == 7)
                    {
                        name = asse7;
                    }
                    if (buteur == 8)
                    {
                        name = asse8;
                    }
                    if (buteur == 9)
                    {
                        name = asse9;
                    }
                    if (buteur == 10)
                    {
                        name = asse10;
                    }
                    if (buteur == 11)
                    {
                        name = asse9bis;
                    }
                    Console.WriteLine(" A.S.S.E       " + Equipe);
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
                            string name_yellow = " "; // Initialisation de la variable du joueur qui sera averti;
                            if (yellow_card == 1)
                            {
                                name_yellow = asse1b;
                                Avertissement a1 = new Avertissement(name_yellow, adversaire);
                            }
                            if (yellow_card == 2)
                            {
                                name_yellow = asse2;
                                Avertissement a1 = new Avertissement(name_yellow, adversaire);
                            }
                            if (yellow_card == 3)
                            {
                                name_yellow = asse6;
                                Avertissement a1 = new Avertissement(name_yellow, adversaire);
                            }
                            if (yellow_card == 4)
                            {
                                name_yellow = asse7;
                                Avertissement a1 = new Avertissement(name_yellow, adversaire);
                            }
                            Console.ReadLine();
                            Console.Clear();
                            Console.WriteLine(" A.S.S.E       " + Equipe);
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
                        name2 = asse1b;
                    }
                    if (buteur == 2)
                    {
                        name2 = asse2;
                    }
                    if (buteur == 3)
                    {
                        name2 = asse3;
                    }
                    if (buteur == 4)
                    {
                        name2 = asse4;
                    }
                    if (buteur == 5)
                    {
                        name2 = asse5;
                    }
                    if (buteur == 6)
                    {
                        name2 = asse6;
                    }
                    if (buteur == 7)
                    {
                        name2 = asse7;
                    }
                    if (buteur == 8)
                    {
                        name2 = asse8;
                    }
                    if (buteur == 9)
                    {
                        name2 = asse9;
                    }
                    if (buteur == 10)
                    {
                        name2 = asse10;
                    }
                    Console.WriteLine(" A.S.S.E       " + Equipe);
                    Console.WriteLine("     " + x + "          " + y);
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
                            string name_yellow = " "; // Initialisation de la variable du joueur qui sera averti;
                            if (yellow_card == 1)
                            {
                                name_yellow = asse1b;
                                Avertissement a1 = new Avertissement(name_yellow, adversaire);
                            }
                            if (yellow_card == 2)
                            {
                                name_yellow = asse2;
                                Avertissement a1 = new Avertissement(name_yellow, adversaire);
                            }
                            if (yellow_card == 3)
                            {
                                name_yellow = asse6;
                                Avertissement a1 = new Avertissement(name_yellow, adversaire);
                            }
                            if (yellow_card == 4)
                            {
                                name_yellow = asse7;
                                Avertissement a1 = new Avertissement(name_yellow, adversaire);
                            }
                            Console.ReadLine();
                            Console.Clear();
                            Console.WriteLine(" A.S.S.E       " + Equipe);
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
                        name3 = asse7;
                    }
                    if (buteur == 8)
                    {
                        name3 = asse8;
                    }
                    if (buteur == 9)
                    {
                        name3 = asse9;
                    }
                    if (buteur == 10)
                    {
                        name3 = asse10;
                    }
                    y = 0;
                    Console.WriteLine(" A.S.S.E       " + Equipe);
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
                            string name_yellow = " "; // Initialisation de la variable du joueur qui sera averti;
                            if (yellow_card == 1)
                            {
                                name_yellow = asse1b;
                                Avertissement a1 = new Avertissement(name_yellow, adversaire);
                            }
                            if (yellow_card == 2)
                            {
                                name_yellow = asse2;
                                Avertissement a1 = new Avertissement(name_yellow, adversaire);
                            }
                            if (yellow_card == 3)
                            {
                                name_yellow = asse6;
                                Avertissement a1 = new Avertissement(name_yellow, adversaire);
                            }
                            if (yellow_card == 4)
                            {
                                name_yellow = asse7;
                                Avertissement a1 = new Avertissement(name_yellow, adversaire);
                            }
                            Console.ReadLine();
                            Console.Clear();
                            Console.WriteLine(" A.S.S.E       " + Equipe);
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
                        name4 = asse7;
                    }
                    if (buteur == 8)
                    {
                        name4 = asse8;
                    }
                    if (buteur == 9)
                    {
                        name4 = asse9;
                    }
                    if (buteur == 10)
                    {
                        name4 = asse10;
                    }
                    if (buteur == 11)
                    {
                        name4 = asse9bis;
                    }
                    Console.WriteLine(" A.S.S.E       " + Equipe);
                    Console.WriteLine("     " + x + "          " + y);
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
                            string name_yellow = " "; // Initialisation de la variable du joueur qui sera averti;
                            if (yellow_card == 1)
                            {
                                name_yellow = asse1b;
                                Avertissement a1 = new Avertissement(name_yellow, adversaire);
                            }
                            if (yellow_card == 2)
                            {
                                name_yellow = asse2;
                                Avertissement a1 = new Avertissement(name_yellow, adversaire);
                            }
                            if (yellow_card == 3)
                            {
                                name_yellow = asse6;
                                Avertissement a1 = new Avertissement(name_yellow, adversaire);
                            }
                            if (yellow_card == 4)
                            {
                                name_yellow = asse7;
                                Avertissement a1 = new Avertissement(name_yellow, adversaire);
                            }
                            Console.ReadLine();
                            Console.Clear();
                            Console.WriteLine(" A.S.S.E       " + Equipe);
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
            Console.WriteLine(" A.S.S.E       " + Equipe);
            Console.WriteLine("     " + x + "          " + y);
            Console.WriteLine(" ");
            Console.WriteLine(name);
            Console.WriteLine(name2);
            Console.WriteLine(name3);
            Console.WriteLine(name4);
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("AFFLUENCE : " + spectateur); // Affichage unique de l'affluence du match
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine(" A.S.S.E       " + Equipe);
            Console.WriteLine("     " + x + "          " + y);
            Console.WriteLine(" ");
            Console.WriteLine(name);
            Console.WriteLine(name2);
            Console.WriteLine(name3);
            Console.WriteLine(name4);
            Console.ReadLine();
            Console.Clear();
            if (composition == 0)
            {
                entrant = " 14 KRASSO";
                sortant = " 7 BOUDEBOUZ";
                Remplacement R1 = new Remplacement(entrant, sortant, adversaire, Equipe);
                asse8 = "KRASSO";
            }
            else
            {
                entrant = " 7 BOUDEBOUZ";
                sortant = "14 KRASSO";
                Remplacement R1 = new Remplacement(entrant, sortant, adversaire, Equipe);
                asse8 = "BOUDEBOUZ";
            }
            Console.WriteLine(" A.S.S.E       " + Equipe);
            Console.WriteLine("     " + x + "          " + y);
            Console.WriteLine(" ");
            Console.WriteLine(name);
            Console.WriteLine(name2);
            Console.WriteLine(name3);
            Console.WriteLine(name4);
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
                    if (domicile > 0)
                    {
                        domicile = domicile - 1;
                    }
                    int red_card = new Random().Next(1, 4);
                    if (red_card == 1)
                    {
                        Console.WriteLine("CARTON ROUGE - A.S.S.E       ");
                        Console.WriteLine("  " + asse9);
                        asse9 = "ABI";
                        asse9bis = "NORDIN (P)";
                    }
                    if (red_card > 1)
                    {
                        if (composition == 1)
                        {
                            Console.WriteLine("CARTON ROUGE - A.S.S.E       ");
                            Console.WriteLine("  " + asse8);
                            asse8 = "BOUANGA";
                            asse9 = "ABI";
                            asse10 = "ABI";
                        }
                        else
                        {
                            Console.WriteLine("CARTON ROUGE - A.S.S.E       ");
                            Console.WriteLine("  " + asse9);
                            asse9 = "ABI";
                            asse9bis = "NORDIN (P)";
                        }
                    }
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine(" A.S.S.E       " + Equipe);
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
                        name = asse1b;
                    }
                    if (buteur == 2)
                    {
                        name = asse2;
                    }
                    if (buteur == 3)
                    {
                        name = asse3;
                    }
                    if (buteur == 4)
                    {
                        name = asse4;
                    }
                    if (buteur == 5)
                    {
                        name = asse5;
                    }
                    if (buteur == 6)
                    {
                        name = asse6;
                    }
                    if (buteur == 7)
                    {
                        name = asse7;
                    }
                    if (buteur == 8)
                    {
                        name = asse8;
                    }
                    if (buteur == 9)
                    {
                        name = asse9;
                    }
                    if (buteur == 10)
                    {
                        name = asse10;
                    }
                    if (buteur == 11)
                    {
                        name = asse9bis;
                    }
                    Console.WriteLine(" A.S.S.E       " + Equipe);
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
                        name2 = asse1b;
                    }
                    if (buteur == 2)
                    {
                        name2 = asse2;
                    }
                    if (buteur == 3)
                    {
                        name2 = asse3;
                    }
                    if (buteur == 4)
                    {
                        name2 = asse4;
                    }
                    if (buteur == 5)
                    {
                        name2 = asse5;
                    }
                    if (buteur == 6)
                    {
                        name2 = asse6;
                    }
                    if (buteur == 7)
                    {
                        name2 = asse7;
                    }
                    if (buteur == 8)
                    {
                        name2 = asse8;
                    }
                    if (buteur == 9)
                    {
                        name2 = asse9;
                    }
                    if (buteur == 10)
                    {
                        name2 = asse10;
                    }
                    Console.WriteLine(" A.S.S.E       " + Equipe);
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
                        name3 = asse7;
                    }
                    if (buteur == 8)
                    {
                        name3 = asse8;
                    }
                    if (buteur == 9)
                    {
                        name3 = asse9;
                    }
                    if (buteur == 10)
                    {
                        name3 = asse10;
                    }
                    Console.WriteLine(" A.S.S.E       " + Equipe);
                    Console.WriteLine("     " + x + "          " + exterieur);
                    Console.WriteLine(" ");
                    Console.WriteLine(name);
                    Console.WriteLine(name2);
                    Console.WriteLine(name3);
                    Console.ReadLine();
                    Console.Clear();
                }
                TempsAdditionnel M2 = new TempsAdditionnel(tps_ad);
                Console.WriteLine(" A.S.S.E       " + Equipe);
                Console.WriteLine("     " + x + "          " + exterieur);
                Console.WriteLine(" ");
                Console.WriteLine(name);
                Console.WriteLine(name2);
                Console.WriteLine(name3);
                Console.WriteLine(name4);
                Console.ReadLine();
                Console.Clear();
                if (domicile > 3)
                {
                    buteur = new Random().Next(7, 12);
                    x = 4;
                    if (buteur == 7)
                    {
                        name4 = asse7;
                    }
                    if (buteur == 8)
                    {
                        name4 = asse8;
                    }
                    if (buteur == 9)
                    {
                        name4 = asse9;
                    }
                    if (buteur == 10)
                    {
                        name4 = asse10;
                    }
                    if (buteur == 11)
                    {
                        name4 = asse9bis;
                    }
                    Console.WriteLine(" A.S.S.E       " + Equipe);
                    Console.WriteLine("     " + x + "          " + exterieur);
                    Console.WriteLine(" ");
                    Console.WriteLine(name);
                    Console.WriteLine(name2);
                    Console.WriteLine(name3);
                    Console.WriteLine(name4);
                    Console.ReadLine();
                    Console.Clear();
                }
            }
            else
            {
                y = 1;
                while (y < exterieur)
                 {
                    Console.WriteLine(" A.S.S.E       " + Equipe);
                    Console.WriteLine("     " + x + "          " + y);
                    Console.WriteLine(" ");
                    Console.WriteLine(name);
                    Console.WriteLine(name2);
                    Console.WriteLine(name3);
                    Console.WriteLine(name4);
                    Console.ReadLine();
                    Console.Clear();
                    y = y + 1;
                 }
                TempsAdditionnel M2 = new TempsAdditionnel (tps_ad);
                y = y - 1;
                Console.WriteLine(" A.S.S.E       " + Equipe);
                Console.WriteLine("     " + x + "          " + y);
                Console.WriteLine(" ");
                Console.WriteLine(name);
                Console.WriteLine(name2);
                Console.WriteLine(name3);
                Console.WriteLine(name4);
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine(" A.S.S.E       " + Equipe);
                Console.WriteLine("     " + domicile + "          " + exterieur);
                Console.WriteLine(" ");
                Console.WriteLine(name);
                Console.WriteLine(name2);
                Console.WriteLine(name3);
                Console.WriteLine(name4);
                Console.WriteLine(" ");
                Console.ReadLine();
                Console.Clear();
            }
            Console.WriteLine(" A.S.S.E       " + Equipe);
            Console.WriteLine("     " + domicile + "          " + exterieur);
            Console.WriteLine(" ");
            Console.WriteLine(name);
            Console.WriteLine(name2);
            Console.WriteLine(name3);
            Console.WriteLine(name4);
            Console.WriteLine(" ");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
