using System;

namespace _22FIFA
{
    class OL
    {
        public OL (int domicile, string nom, int mouvant, string Equipe, int pts, int exterieur, int spectateur)
        {
            Console.Clear();
            Console.WriteLine("COMPOSITION OL (4-2-3-1)"); // Annonce du dispositif lyonnais
            string ol1 = "CORNET";
            string ol2 = "KONE";
            string ol3 = "DIOMANDE";
            string ol4 = "DUBOIS";
            string ol5 = "MENDES";
            string ol6 = "AOUAR";
            string ol7 = "TOKO-EKAMBI";
            string ol8 = "CHERKI";
            string ol9 = "PAQUETA";
            string ol10 = "DEMBELE";
            string ol10bis = "DEMBELE (P)";
            Console.WriteLine(" ");
            Console.WriteLine("              1-LOPES");
            Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("14- " + ol4 + "  2- " + ol3 + " 28- " + ol2 + " 27- " + ol1);
            Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("       8- " + ol6 + "            23- " + ol5);
            Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("  18- " + ol8 + "   12- " + ol9 + "      7- " + ol7);
            Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("              11- " + ol10);
            Console.ReadLine();
            Console.Clear();
            if (nom != " ")
            {
                Console.WriteLine("1- TITULAIRE ");
                Console.WriteLine("2- REMPLACANT");
                Console.WriteLine(" ");
                Console.Write(nom + " : ");
                string titulaire = (Console.ReadLine());
                Console.Clear();
                switch (titulaire)
                {
                    case "1":
                        Console.WriteLine("[...]TITULAIRE : " + nom + "[...]");
                        break;
                    default:
                        Console.WriteLine("[...]REMPLACANT : " + nom + "[...]");
                        if (mouvant > 10 & Equipe == "A.S.S.E")
                        {
                            pts = pts - 1;
                        }
                        break;
                }
                Console.ReadLine();
                Console.Clear();
            }
            int buteur = 0;
            int x = 0;
            int y = 1;
            string name = " ";
            string name2 = " ";
            string name3 = " ";
            string name4 = " ";
            Console.WriteLine("  OL       " + Equipe);
            Console.WriteLine("  " + x + "         0");
            Console.ReadLine();
            Console.Clear();
            while (y < exterieur)
            {
                Console.WriteLine("  OL       " + Equipe);
                Console.WriteLine("  " + x + "         " + y);
                Console.ReadLine();
                Console.Clear();
                y = y + 1;
            }
            Console.WriteLine("  OL       " + Equipe);
            Console.WriteLine("  " + x + "         " + y);
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("AFFLUENCE : " + spectateur); // Affichage de l'affluence unique du match
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("  OL       " + Equipe);
            Console.WriteLine("  " + x + "         " + y);
            Console.ReadLine();
            Console.Clear();
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
                    name = ol3;
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
                    name = ol10bis;
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
                    name2 = ol3;
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
                    name4 = ol10bis;
                }
                Console.WriteLine("  OL       " + Equipe);
                Console.WriteLine("  " + x + "         " + y);
                Console.WriteLine(" ");
                Console.WriteLine(name);
                Console.WriteLine(name2);
                Console.WriteLine(name3);
                Console.WriteLine(name4);
                Console.Clear();
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
    }
}
