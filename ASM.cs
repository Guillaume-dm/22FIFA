using System;

namespace _22FIFA
{
    class ASM
    {
        public ASM(int domicile, string achat1, string achat2, string achat3, int mouvant, string Equipe, int pts, int exterieur, int spectateur, string adversaire)
        {
            Console.Clear();
            Console.WriteLine("COMPOSITION AS MONACO FC (4-2-3-1)"); // Annonce de la composition de l'adversaire et son dispositif
            int tps_ad = new Random().Next(2, 6); // Initialisation de la variable pour le temps additionnel  de la seconde mi-temps
            int composition = new Random().Next(0, 2);
            int choix_d = new Random().Next(0, 2); // Défini le choix du défenseur central gauche monégasque
            string asm1 = "BOLLO-TOURE";
            string asm2 = "PAVLOVIC";
            string asm3 = "BADIASHILE";
            string asm4 = "AGUILAR";
            string asm5 = "TCHOUAMENI";
            string asm6 = "AHOULOU";
            string asm7 = "MARTINS";
            string asm8 = "GOLOVIN";
            string asm9 = "GEUBBELS";
            string asm10 = "BEN YEDDER";
            string asm10bis = "BEN YEDDER (P)";
            string entrant;  // Sert à l'affichage du joueur entrant en cas de remplacements. 
            string sortant; // Sert à l'affichage du joueur sortant en cas de remplacements. 
            Console.WriteLine(" ");
            Console.WriteLine("                   40-LECOMPTE"); // Ligne du gardien de but
            Console.ReadLine();
            Console.WriteLine(" ");
            if (choix_d == 0)
            {
                asm2 = "DISASI";
                Console.WriteLine("26- " + asm4 + " 32- " + asm3 + " 20- " + asm2 + "  2- " + asm1);
            }
            else // Cas où le défenseur central gauche est celui par défaut
            {
                Console.WriteLine("26- " + asm4 + " 32- " + asm3 + " 21- " + asm2 + "  2- " + asm1);
            }
            Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("       - " + asm6 + "             8- " + asm5); // Ligne des milieux récupérateurs
            Console.ReadLine();
            Console.WriteLine(" ");
            if (composition == 1)
            {
                asm9 = "DIOP";
                Console.WriteLine("    17- " + asm8 + "        - " + asm9 + "    11- " + asm7);
            }
            else
            {
                Console.WriteLine("    10- " + asm8 + "     20- " + asm9 + "   11- " + asm7);
            }
            Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("                  9- " + asm10);
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
            int x = 0; // Mise à 0 du compteur pas à pas pour l'équipe à domicile
            int y = 0; // Mise à 0 du compteur pas à pas pour l'équipe à l'extérieur
            string name = " "; // Initialisation des différents potentiels buteurs
            string name2 = " ";
            string name3 = " ";
            string name4 = " ";
            Console.WriteLine(" AS MONACO FC       " + Equipe);
            Console.WriteLine("        " + x + "            0");
            Console.ReadLine();
            Console.Clear();
            int type_m = new Random().Next(1, 3);
            if (type_m == 1)
            {
                while (y < exterieur)
                {
                    y = y + 1;
                    Console.WriteLine(" AS MONACO FC       " + Equipe);
                    Console.WriteLine("        " + x + "            " + y);
                    Console.ReadLine();
                    Console.Clear();
                }
            }
            else
            {
                y = 0;
                if (domicile > 0)
                {
                    x = 1;
                    buteur = new Random().Next(1, 12);
                    if (buteur == 1)
                    {
                        name = asm1;
                    }
                    if (buteur == 2)
                    {
                        name = asm2;
                    }
                    if (buteur == 3)
                    {
                        name = asm3;
                    }
                    if (buteur == 4)
                    {
                        name = asm4;
                    }
                    if (buteur == 5)
                    {
                        name = asm5;
                    }
                    if (buteur == 6)
                    {
                        name = asm6;
                    }
                    if (buteur == 7)
                    {
                        name = asm7;
                    }
                    if (buteur == 8)
                    {
                        name = asm8;
                    }
                    if (buteur == 9)
                    {
                        name = asm9;
                    }
                    if (buteur == 10)
                    {
                        name = asm10;
                    }
                    if (buteur == 11)
                    {
                        name = asm10bis;
                    }
                    Console.WriteLine(" AS MONACO FC       " + Equipe);
                    Console.WriteLine("        " + x + "            " + y);
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
                        name2 = asm1;
                    }
                    if (buteur == 2)
                    {
                        name2 = asm2;
                    }
                    if (buteur == 3)
                    {
                        name2 = asm3;
                    }
                    if (buteur == 4)
                    {
                        name2 = asm4;
                    }
                    if (buteur == 5)
                    {
                        name2 = asm5;
                    }
                    if (buteur == 6)
                    {
                        name2 = asm6;
                    }
                    if (buteur == 7)
                    {
                        name2 = asm7;
                    }
                    if (buteur == 8)
                    {
                        name2 = asm8;
                    }
                    if (buteur == 9)
                    {
                        name2 = asm9;
                    }
                    if (buteur == 10)
                    {
                        name2 = asm10;
                    }
                    Console.WriteLine(" AS MONACO FC       " + Equipe);
                    Console.WriteLine("        " + x + "            " + y);
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
                        name3 = asm7;
                    }
                    if (buteur == 8)
                    {
                        name3 = asm8;
                    }
                    if (buteur == 9)
                    {
                        name3 = asm9;
                    }
                    if (buteur == 10)
                    {
                        name3 = asm10;
                    }
                    y = 0;
                    Console.WriteLine(" AS MONACO FC       " + Equipe);
                    Console.WriteLine("        " + x + "            " + y);
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
                        name4 = asm7;
                    }
                    if (buteur == 8)
                    {
                        name4 = asm8;
                    }
                    if (buteur == 9)
                    {
                        name4 = asm9;
                    }
                    if (buteur == 10)
                    {
                        name4 = asm10;
                    }
                    if (buteur == 11)
                    {
                        name4 = asm10bis;
                    }
                    Console.WriteLine(" AS MONACO FC       " + Equipe);
                    Console.WriteLine("        " + x + "            " + y);
                    Console.WriteLine(" ");
                    Console.WriteLine(name);
                    Console.WriteLine(name2);
                    Console.WriteLine(name3);
                    Console.WriteLine(name4);
                    Console.ReadLine();
                    Console.Clear();
                }
            }
            Console.WriteLine(" AS MONACO FC       " + Equipe);
            Console.WriteLine("        " + x + "            " + y);
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
            Console.WriteLine(" AS MONACO FC       " + Equipe);
            Console.WriteLine("        " + x + "            " + y);
            Console.WriteLine(" ");
            Console.WriteLine(name);
            Console.WriteLine(name2);
            Console.WriteLine(name3);
            Console.WriteLine(name4);
            Console.ReadLine();
            Console.Clear();
            if (composition == 0)
            {
                entrant = "   DIOP";
                sortant = "13 GEUBBELS";
                Remplacement R1 = new Remplacement(entrant, sortant, adversaire, Equipe);
                asm9 = "DIOP";
            }
            else
            {
                entrant = "13 GEUBBELS";
                sortant = "   DIOP";
                Remplacement R1 = new Remplacement(entrant, sortant, adversaire, Equipe);
                asm9 = "GEUBBELS";
            }
            Console.WriteLine(" AS MONACO FC       " + Equipe);
            Console.WriteLine("        " + x + "            " + y);
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
                        Console.WriteLine("CARTON ROUGE - AS MONACO FC       ");
                        Console.WriteLine("  " + asm8);
                        asm8 = "BEN YEDDER";
                    }
                    if (red_card == 2)
                    {
                        Console.WriteLine("CARTON ROUGE - AS MONACO FC       ");
                        Console.WriteLine("  " + asm8);
                        asm9 = "BEN YEDDER";
                    }
                    if (red_card == 3)
                    {
                        Console.WriteLine("CARTON ROUGE - AS MONACO FC       ");
                        Console.WriteLine("  " + asm10);
                        asm10 = "BALDE";
                        asm10bis = "GOLOVIN (P)";
                    }
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine(" AS MONACO FC       " + Equipe);
                    Console.WriteLine("        " + x + "            " + y);
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
                        name = asm1;
                    }
                    if (buteur == 2)
                    {
                        name = asm2;
                    }
                    if (buteur == 3)
                    {
                        name = asm3;
                    }
                    if (buteur == 4)
                    {
                        name = asm4;
                    }
                    if (buteur == 5)
                    {
                        name = asm5;
                    }
                    if (buteur == 6)
                    {
                        name = asm6;
                    }
                    if (buteur == 7)
                    {
                        name = asm7;
                    }
                    if (buteur == 8)
                    {
                        name = asm8;
                    }
                    if (buteur == 9)
                    {
                        name = asm9;
                    }
                    if (buteur == 10)
                    {
                        name = asm10;
                    }
                    if (buteur == 11)
                    {
                        name = asm10bis;
                    }
                    Console.WriteLine(" AS MONACO FC       " + Equipe);
                    Console.WriteLine("        " + x + "            " + exterieur);
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
                        name2 = asm1;
                    }
                    if (buteur == 2)
                    {
                        name2 = asm2;
                    }
                    if (buteur == 3)
                    {
                        name2 = asm3;
                    }
                    if (buteur == 4)
                    {
                        name2 = asm4;
                    }
                    if (buteur == 5)
                    {
                        name2 = asm5;
                    }
                    if (buteur == 6)
                    {
                        name2 = asm6;
                    }
                    if (buteur == 7)
                    {
                        name2 = asm7;
                    }
                    if (buteur == 8)
                    {
                        name2 = asm8;
                    }
                    if (buteur == 9)
                    {
                        name2 = asm9;
                    }
                    if (buteur == 10)
                    {
                        name2 = asm10;
                    }
                    Console.WriteLine(" AS MONACO FC       " + Equipe);
                    Console.WriteLine("        " + x + "            " + exterieur);
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
                        name3 = asm7;
                    }
                    if (buteur == 8)
                    {
                        name3 = asm8;
                    }
                    if (buteur == 9)
                    {
                        name3 = asm9;
                    }
                    if (buteur == 10)
                    {
                        name3 = asm10;
                    }
                    TempsAdditionnel M2 = new TempsAdditionnel(tps_ad);
                    Console.WriteLine(" AS MONACO FC       " + Equipe);
                    Console.WriteLine("        " + x + "            " + exterieur);
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
                        name4 = asm7;
                    }
                    if (buteur == 8)
                    {
                        name4 = asm8;
                    }
                    if (buteur == 9)
                    {
                        name4 = asm9;
                    }
                    if (buteur == 10)
                    {
                        name4 = asm10;
                    }
                    if (buteur == 11)
                    {
                        name4 = asm10bis;
                    }
                    Console.WriteLine(" AS MONACO FC       " + Equipe);
                    Console.WriteLine("        " + x + "            " + exterieur);
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
                    Console.WriteLine(" AS MONACO FC       " + Equipe);
                    Console.WriteLine("        " + x + "            " + y);
                    Console.WriteLine(" ");
                    Console.WriteLine(name);
                    Console.WriteLine(name2);
                    Console.WriteLine(name3);
                    Console.WriteLine(name4);
                    Console.ReadLine();
                    Console.Clear();
                    y = y + 1;
                }
                TempsAdditionnel M2 = new TempsAdditionnel(tps_ad);
                Console.WriteLine(" AS MONACO FC       " + Equipe);
                Console.WriteLine("        " + domicile + "            " + exterieur);
                Console.WriteLine(" ");
                Console.WriteLine(name);
                Console.WriteLine(name2);
                Console.WriteLine(name3);
                Console.WriteLine(name4);
                Console.WriteLine(" ");
                Console.ReadLine();
                Console.Clear();
            }
            Console.WriteLine(" AS MONACO FC       " + Equipe);
            Console.WriteLine("        " + domicile + "            " + exterieur);
            Console.WriteLine(" ");
            Console.WriteLine(name); // Récapitulatif final des buteurs
            Console.WriteLine(name2);
            Console.WriteLine(name3);
            Console.WriteLine(name4);
            Console.WriteLine(" ");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
