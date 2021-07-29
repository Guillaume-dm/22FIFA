using System;

namespace _22FIFA
{
    class EquipesRapide
    {
        public EquipesRapide(string Equipe, string Equipe_avant2)
        {
            Console.WriteLine("Choissisez votre équipe : ");
            Console.WriteLine(" 1- ANGERS SCO");
            Console.WriteLine(" 2- GIRONDIENS DE BORDEAUX");
            Console.WriteLine(" 3- SB 29");
            Console.WriteLine(" 4- DFC0");
            Console.WriteLine(" 5- RCL");
            Console.WriteLine(" 6- LOSC");
            Console.WriteLine(" 7- OL");
            Console.WriteLine(" 8- OM");
            Console.WriteLine(" 9- FC METZ");
            Console.WriteLine("10- AS MONACO FC");
            Console.WriteLine("11- FC NANTES");
            Console.WriteLine("12- OGC NICE");
            Console.WriteLine("13- NIMES OLYMPIQUES");
            Console.WriteLine("14- PARIS SAINT-GERMAIN");
            Console.WriteLine("15- SdR");
            Console.WriteLine("16- STADE RENNAIS FC");
            Console.WriteLine("17- A.S.S.E");
            Console.WriteLine("18- RACING CLUB DE STRASBOURG");
            Console.WriteLine("19- ESTAC TROYES");
            Console.WriteLine("20- VALENCIENNES AFC");
            Console.WriteLine(" ");
            Console.Write("Votre saisie : ");
            int casss = Int32.Parse(Console.ReadLine());
            Console.Clear();
            switch (casss) // Swtich du choix de l'équipe
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Selection : SCO d'ANGERS !!!");
                    Equipe = "ANGERS SCO";
                    Equipe_avant2 = " ANGERS";
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Séléction : GIRONDIENS DE BORDEAUX !!!");
                    Equipe = "GIRONDIENS DE BORDEAUX";
                    Equipe_avant2 = "BORDEAU";
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Séléction : STADE BRESTOIS 29 !!!");
                    Equipe = "SB 29";
                    Equipe_avant2 = " SB 29 ";
                    break;
                case 4:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Séléction : DFCO !!!");
                    Equipe = "DFCO";
                    Equipe_avant2 = "  DFCO ";
                    break;
                case 5:
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Séléction : RCL !!!");
                    Equipe = "RCL";
                    Equipe_avant2 = "  RCL  ";
                    break;
                case 6:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Séléction : LOSC !!!");
                    Equipe = "LOSC";
                    Equipe_avant2 = "  LOSC ";
                    break;
                case 7:
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Séléction : OL !!!");
                    Equipe = "OL";
                    Equipe_avant2 = "  OL   ";
                    break;
                case 8:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Séléction : OM !!!");
                    Equipe = "OM";
                    Equipe_avant2 = "  OM   ";
                    break;
                case 9:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Sélection : FC METZ !!!");
                    Equipe = "FC METZ";
                    Equipe_avant2 = "FC METZ";
                    break;
                case 10:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Sélection : AS MONACO FC !!!");
                    Equipe = "AS MONACO FC";
                    Equipe_avant2 = " MONACO";
                    break;
                case 11:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Sélection : FC NANTES !!!");
                    Equipe = "FC NANTES";
                    Equipe_avant2 = " NANTES";
                    break;
                case 12:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Séléction : OGC NICE !!!");
                    Equipe = "OGC NICE";
                    Equipe_avant2 = "  NICE ";
                    break;
                case 13:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Sélection : NIMES OLYMPIQUES !!!");
                    Equipe = "NIMES OLYMPIQUES";
                    Equipe_avant2 = " NIMES ";
                    break;
                case 14:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Séléction : PARIS SAINT-GERMAIN !!!");
                    Equipe = "PARIS SAINT-GERMAIN";
                    Equipe_avant2 = "  PSG  ";
                    break;
                case 15:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Séléction : STADE DE REIMS !!!");
                    Equipe = "STADE DE REIMS";
                    Equipe_avant2 = " REIMS ";
                    break;
                case 16:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Séléction : STADE RENNAIS FC !!!");
                    Equipe = "STADE RENNAIS FC";
                    Equipe_avant2 = " RENNES";
                    break;
                case 17:
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Séléction : ASSE !!!");
                    Equipe = "A.S.S.E";
                    Equipe_avant2 = "A.S.S.E";
                    break;
                case 18:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Séléction : RACING CLUB DE STRASBOURG !!!");
                    Equipe = "RACING CLUB DE STRASBOURG";
                    Equipe_avant2 = " RACING";
                    break;
                case 19:
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("Séléction : ESTAC TROYES !!!");
                    Equipe = "ESTAC TROYES";
                    Equipe_avant2 = " RACING";
                    break;
                case 20:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Séléction : VAFC !!!");
                    Equipe = "VAFC";
                    Equipe_avant2 = " VAFC";
                    break;
            }
        }
    }
}
