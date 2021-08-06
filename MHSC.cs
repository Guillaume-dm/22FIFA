using System;

namespace _22FIFA
{
    class MHSC
    {
        public MHSC(int domicile, string nom, int mouvant, string Equipe, int pts, int exterieur, int spectateur)
        {
            Console.Clear();
            if (nom != " ")
            {
                Console.WriteLine("1- TITULAIRE ");
                Console.WriteLine("2- REMPLACANT");
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
                        if (mouvant > 3)
                        {
                            pts = pts - 1;
                        }
                        break;
                }
                Console.ReadLine();
                Console.Clear();
            }
            Console.WriteLine("COMPOSITION MONTPELLIER HERAULT SC (3-4-1-2)");
            string mhsc1 = "SOUQUET";
            string mhsc2 = "COZZA";
            string mhsc3 = "OYONGO";
            string mhsc4 = "SUAREZ";
            string mhsc5 = "SAVANIER";
            string mhsc6 = "LE TALLEC";
            string mhsc7 = "FERRI";
            string mhsc8 = "MOLLET";
            string mhsc9 = "DELORT";
            string mhsc10 = "LABORDE";
            string mhsc9bis = "DELORT (P)";
            Console.WriteLine(" ");
            Console.WriteLine("             16-BERTAUD");
            Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("  2- " + mhsc1 + "   31- " + mhsc2 + "   8- " + mhsc3);
            Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("24- " + mhsc4 + " 11- " + mhsc5 + " 14- " + mhsc6 + " 12- " + mhsc7);
            Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("               25- " + mhsc8);
            Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("     9- " + mhsc9 + "             10- " + mhsc10);
            Console.ReadLine();
            Console.Clear();
            int buteur = 0;
            int x = 0;
            int y = 1;
            string name = " ";//initialisation des différents potentiels buteurs
            string name2 = " ";
            string name3 = " ";
            string name4 = " ";
            Console.WriteLine("MONTPELLIER        " + Equipe);
            Console.WriteLine("     " + x + "              0");
            Console.ReadLine();
            Console.Clear();
            while (y < exterieur)
            {
                Console.WriteLine("MONTPELLIER        " + Equipe);
                Console.WriteLine("     " + x + "              " + y);
                Console.ReadLine();
                Console.Clear();
                y = y + 1;
            }
            Console.WriteLine("MONTPELLIER        " + Equipe);
            Console.WriteLine("     " + x + "              " + exterieur);
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("AFFLUENCE : " + spectateur);
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("MONTPELLIER        " + Equipe);
            Console.WriteLine("     " + x + "              " + exterieur);
            Console.ReadLine();
            Console.Clear();
            if (domicile > 0)
            {
                x = 1;
                buteur = new Random().Next(1, 12);
                if (buteur == 1)
                {
                    name = mhsc1;
                }
                if (buteur == 2)
                {
                    name = mhsc2;
                }
                if (buteur == 3)
                {
                    name = mhsc3;
                }
                if (buteur == 4)
                {
                    name = mhsc4;
                }
                if (buteur == 5)
                {
                    name = mhsc5;
                }
                if (buteur == 6)
                {
                    name = mhsc6;
                }
                if (buteur == 7)
                {
                    name = mhsc7;
                }
                if (buteur == 8)
                {
                    name = mhsc8;
                }
                if (buteur == 9)
                {
                    name = mhsc9;
                }
                if (buteur == 10)
                {
                    name = mhsc10;
                }
                if (buteur == 11)
                {
                    name = mhsc9bis;
                }
                Console.WriteLine("MONTPELLIER        " + Equipe);
                Console.WriteLine("     " + x + "              " + exterieur);
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
                    name2 = mhsc1;
                }
                if (buteur == 2)
                {
                    name2 = mhsc2;
                }
                if (buteur == 3)
                {
                    name2 = mhsc3;
                }
                if (buteur == 4)
                {
                    name2 = mhsc4;
                }
                if (buteur == 5)
                {
                    name2 = mhsc5;
                }
                if (buteur == 6)
                {
                    name2 = mhsc6;
                }
                if (buteur == 7)
                {
                    name2 = mhsc7;
                }
                if (buteur == 8)
                {
                    name2 = mhsc8;
                }
                if (buteur == 9)
                {
                    name2 = mhsc9;
                }
                if (buteur == 10)
                {
                    name2 = mhsc10;
                }
                Console.WriteLine("MONTPELLIER        " + Equipe);
                Console.WriteLine("     " + x + "              " + exterieur);
                Console.WriteLine(" ");
                Console.WriteLine(name);
                Console.WriteLine(name2);
                Console.ReadLine();
                Console.Clear();
            }
            if (domicile > 2)
            {
                buteur = new Random().Next(8, 11);
                x = 3;
                if (buteur == 8)
                {
                    name3 = mhsc8;
                }
                if (buteur == 9)
                {
                    name3 = mhsc9;
                }
                if (buteur == 10)
                {
                    name3 = mhsc10;
                }
                Console.WriteLine("MONTPELLIER        " + Equipe);
                Console.WriteLine("     " + x + "              " + exterieur);
                Console.WriteLine(" ");
                Console.WriteLine(name);
                Console.WriteLine(name2);
                Console.WriteLine(name3);
                Console.ReadLine();
                Console.Clear();
            }
            if (domicile > 3)
            {
                buteur = new Random().Next(8, 12);
                x = 4;
                if (buteur == 8)
                {
                    name4 = mhsc8;
                }
                if (buteur == 9)
                {
                    name4 = mhsc9;
                }
                if (buteur == 10)
                {
                    name4 = mhsc10;
                }
                if (buteur == 11)
                {
                    name4 = mhsc9bis;
                }
                Console.WriteLine("MONTPELLIER        " + Equipe);
                Console.WriteLine("     " + x + "              " + exterieur);
                Console.WriteLine(" ");
                Console.WriteLine(name);
                Console.WriteLine(name2);
                Console.WriteLine(name3);
                Console.WriteLine(name4);
                Console.Clear();
            }
            Console.WriteLine("MONTPELLIER        " + Equipe);
            Console.WriteLine("     " + domicile + "              " + exterieur);
            Console.WriteLine(" ");
            Console.WriteLine(name);//recapitulatif final des buteurs
            Console.WriteLine(name2);
            Console.WriteLine(name3);
            Console.WriteLine(name4);
            Console.ReadLine();
            Console.Clear();
        }
    }
}
