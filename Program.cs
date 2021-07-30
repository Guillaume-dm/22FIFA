using System;

namespace _22FIFA // Base du programme commune à chaque composant
{
    class Program
    {
        static void Main(string[] args)
        {
            HC(); // Renvoie la méthode de la date système
            string lieu = " "; // Mise à vide du nom de la ville du stade en carrière
            int victoire_glb = 0; // Initiation du compteur global de victoires
            int nul_glb = 0; // Mise à 0 du compteur de match nul en mode carrière
            int df_glb = 0; // Mise à 0 du compteur de défaite en mode carrière
            int bm_glb = 0; // Mise à 0 du compteur de but marqué en mode carrière
            int be_glb = 0; // Mise à 0 du compteur de but encaissé en mode carrière
            int price = 1; // Sert à definir le prix des joueurs en mode carrière
            string saisie = "Anonyme"; // Pour le message de l'entraineur + nom
            bool D1 = true; // Test de 1er + division
            string Equipe = ""; // Stock l'équipe que l'on a choisie
            String division = " "; // Stock la division en cours
            String nom = " ";
            string team = " ";
            string adversaire = " "; // Adversaire de la J1
            int mouvant = 0; // Qualité de transfert en pts
            int domicile = 0; // Nombre de buts
            int pts = 0; // Compteur de pts
            int pts_avant = 0;
            string qualification = " ";
            string qualification2 = " ";
            string Equipe_avant = " "; // Sert uniquement à savoir si l'équipe doit jouer le trophée des champions en mode carrière
            string Equipe_avant2 = " "; // Affichage sous 7 bits de votre club
            string Equipe_promu = " "; // Equipe affichant la promotion en D1
            int spectateur; // Variable de spectateurs par match
            int ouverture = 0; // Gère la journée d'ouverture en D1
            int def_v; // Gère les grandes générations aléatoire d'équipes
            int attention = 0; // Pour la division
            int l1c = 0; // Compteur de D1
            int dl2 = 0; // Compteur de D2
            int N = 0; // Compteur de championnat de NATIONAL FFF gagné
            int montee = 0; // Pour la promotion
            int national = 0; // Variable de l'élimination ou non en Coupe de Françe
            string coach = " "; // Récupère le nom du coach pour les statistiques de fin
            string achat1 = " ";
            string achat2 = " ";
            string achat3 = " ";
            int verif1 = 0; // Sert à vérifier si le joueur a bel et bien était acheté ou prolongé
            Console.WriteLine("22FIFA - MODES DISPONIBLES"); // Nom du programme
            Console.WriteLine(" ");
            Console.WriteLine(" 1- CARRIERE AUTO");
            Console.WriteLine(" 2- CARRIERE VISITEUR");
            Console.WriteLine(" 3- MATCH RAPIDE 22");
            Console.WriteLine(" 4- ARCHIVES MATCHS RAPIDES");
            Console.WriteLine(" 5- CREDITS");
            Console.WriteLine(" 6- REDEMANDER LA DATE COURANTE");
            Console.WriteLine(" ");
            Console.Write("Votre mode : ");
            string Utilisateur = (Console.ReadLine()); // Sert à déterminer le mode choisi par l'utilisateur
            Console.Clear();
            switch (Utilisateur) // Switch de la séléction des modes de l'utilisateur
            {
                case "1":
                    Console.WriteLine("Salut, " + System.Environment.UserName + " (" + System.Environment.UserDomainName + ")"); // Récupère le nom de session et l'affiche
                    coach = System.Environment.UserName;
                    break;
                case "3":
                    int dom = new Random().Next(0, 5); // Initiation du score final en 2 temps
                    int ext = new Random().Next(0, 5);
                    dom = new Random().Next(0, 6); // Initiation du score final en 2 temps
                    ext = new Random().Next(0, 4); // 4 car max-ext est égal à 3 buts
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
                    while (casss < 1 & montee == 0 || casss > 20 & montee == 0)
                    {
                        Console.Write("! Veillez resaisir une valeur correcte : "); // Redemande une valeur correcte à l'utiisateur
                        casss = Int32.Parse(Console.ReadLine());
                    }
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
                    //string fin = "MERCI D'AVOIR JOUE"; // Initiasion du message de fin
                    Console.WriteLine(" ");
                    Console.WriteLine("MODE MATCH RAPIDE 22 ; ");
                    Console.WriteLine("Votre adversaire : ");
                    Console.WriteLine(" 1- AS MONACO FC");
                    Console.WriteLine(" 2- A.S.S.E");
                    Console.WriteLine(" 3- OL");
                    Console.WriteLine(" 4- MONTPELLIER HERAULT SPORTING CLUB");
                    Console.WriteLine(" ");
                    Console.Write("Votre sélection : ");
                    int adv = Int32.Parse(Console.ReadLine()); // Permet de définir l'adversaire demandé par l'utilisateur
                    while (adv < 1 & adv > 5) // Si il n'existe pas d'adversaire au nombre souhaité
                    {
                        Console.Write("! Veillez resaisir une valeur correcte : ");
                        adv = Int32.Parse(Console.ReadLine());
                    }
                    switch (adv)
                    {
                        case 1:
                            Console.Read();
                            Console.WriteLine("  AMICAL VS AS MONACO FC :");
                            Console.WriteLine("LIEU : STADE LOUIS-II"); // Annonce du lieu du match amical
                            spectateur = new Random().Next(0, 18524); // Génère aléatoirement l'affluence du match
                            adversaire = "AS MONACO FC";
                            Console.ReadLine();
                            ASM J1 = new ASM(dom, achat1, achat2, achat3, mouvant, Equipe, pts, ext, spectateur, adversaire);
                            Exit(adversaire); // Force la sortie du programme
                            break;
                        case 2:
                            Console.Read();
                            Console.WriteLine("  AMICAL VS A.S.S.E :");
                            Console.WriteLine("LIEU : ENVOL-STADIUM (42160- ANDREZIEUX-BOUTHEON)"); // Annonce du lieu du match amical
                            spectateur = new Random().Next(0, 5001); // Génère aléatoirement l'affluence du match
                            adversaire = "A.S.S.E";
                            Console.ReadLine();
                            ASSE A1 = new ASSE(dom, achat1, achat2, achat3, mouvant, Equipe, pts, ext, spectateur, adversaire);
                            Exit(adversaire); // Force la sortie du programme
                            break;
                        case 3:
                            Console.Read();
                            Console.WriteLine("  AMICAL VS OL :");
                            Console.WriteLine("LIEU : STADE DARRAGON (03200- VICHY)"); // Annonce du lieu du match amical
                            spectateur = new Random().Next(0, 4612); // Génère aléatoirement l'affluence du match
                            adversaire = "OL";
                            Console.ReadLine();
                            OL AOL = new OL(dom, nom, mouvant, Equipe, pts, ext, spectateur);
                            Exit(adversaire); // Force la sortie du programme
                            break;
                        case 4:
                            Console.Read();
                            Console.WriteLine("  AMICAL VS MONTPELLIER HERAULT SPORTING CLUB : ");
                            Console.WriteLine("LIEU : STADE DE LA MOISSON (34080- MONTPELLIER)"); // Annonce du lieu du match amical
                            spectateur = new Random().Next(0, 32901); // Génère aléatoirement l'affluence du match
                            adversaire = "MONTPELLIER";
                            Console.ReadLine();
                            MHSC AMHSC = new MHSC(dom, nom, mouvant, Equipe, pts, ext, spectateur);
                            Exit(adversaire); // Force la sortie du programme
                            break;
                    }
                    break;
                case "4":
                    Console.WriteLine("MODE MATCH RAPIDE EN ARCHIVES : ");
                    Console.WriteLine(" ");
                    dom = new Random().Next(0, 6); // Initiation du score final en 2 temps
                    ext = new Random().Next(0, 4); // 4 car max-ext est égal à 3 buts
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
                    casss = Int32.Parse(Console.ReadLine());
                    while (casss < 1 & montee == 0 || casss > 20 & montee == 0)
                    {
                        Console.Write("! Veillez resaisir une valeur correcte : ");
                        casss = Int32.Parse(Console.ReadLine());
                    }
                    while (casss < 2 & montee == 1 || casss > 20 & montee == 1)
                    {
                        Console.Write("! Veillez resaisir une valeur correcte : ");
                        casss = Int32.Parse(Console.ReadLine());
                    }
                    Console.Clear();
                    switch (casss) // Swtich du choix de l'équipe
                    {
                        case 1:
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Sélection : SCO d'ANGERS !!!");
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
                    Console.WriteLine("Votre adversaire V16 : ");
                    Console.WriteLine(" 1- A.S.S.E (17 Janvier 2016 - 1 à 0 contre OL)");
                    Console.WriteLine(" 2- ATLETICO DE MADRID (Finaliste Ligue des Champions");
                    Console.WriteLine(" 3- FC BARCELONE (21 Novembre 2015 - 4 à 0 contre Réal Madric CF)");
                    Console.WriteLine(" 4- OL (8 Novembre 2015 - 3 à 0 contre A.S.S.E)");
                    Console.WriteLine(" 5- OGC NICE (23 Septembre 2015 - 6 à 1 contre Girondiens de Bordeaux)");
                    Console.WriteLine(" 6- PARIS SAINT-GERMAIN (25 Octobre 2015 - 4 à 1 contre l'A.S.S.E)");
                    Console.WriteLine(" 7- REAL MADRID CF (Vainqueur Ligue des Champions)");
                    Console.WriteLine(" 8- TFC (12 Mars 2016 - 4 à 0 contre les Girondiens de Bordeaux)");
                    Console.WriteLine(" 9- ESTAC TROYES (13 Mars 2016 - 0 à 9 contre le PARIS SAINT-GERMAIN)");
                    Console.WriteLine(" ");
                    Console.Write("Votre sélection : ");
                    adv = Int32.Parse(Console.ReadLine());
                    int meteo = new Random().Next(1, 46); // Permet de définir le temps extérieur du match
                    int diffuseur = new Random().Next(1, 14); // Permet de définir le temps extérieur du match
                    while (adv < 1 || adv > 9) // Si il n'existe pas d'adversaire au nombre souhaité
                    {
                        Console.Write("! Veillez resaisir une valeur correcte : ");
                        adv = Int32.Parse(Console.ReadLine());
                    }
                    switch (adv)
                    {
                        case 1:
                            Console.Read();
                            Console.WriteLine("  AMICAL VS A.S.S.E :");
                            Console.WriteLine("LIEU : GEOFFROY-GUICHARD (42000- SAINT-ETIENNE)"); // Annonce le lieu du match amical
                            spectateur = new Random().Next(18001, 38001); // Génère aléatoirement l'affluence du match
                            adversaire = "A.S.S.E";
                            Console.ReadLine();
                            ASSE16 V16 = new ASSE16(dom, nom, mouvant, Equipe, pts, ext, spectateur, adversaire, meteo, diffuseur);
                            Exit(adversaire);
                            break;
                        case 3:
                            Console.Read();
                            Console.WriteLine("  AMICAL VS FC BARCELONE :");
                            Console.WriteLine("LIEU : CAMP NOU (ESP- BARCELONE)"); // Annonce le lieu du match amical
                            spectateur = new Random().Next(25000, 99354); // Génère aléatoirement l'affluence du match
                            adversaire = "FCB";
                            Console.ReadLine();
                            FCB16 MatchCatalan = new FCB16(dom, nom, mouvant, Equipe, pts, ext, spectateur, adversaire, meteo, diffuseur);
                            Exit(adversaire);
                            break;
                        case 4:
                            Console.Read();
                            Console.WriteLine("  AMICAL VS OL :");
                            Console.WriteLine("LIEU : STADE DE GERLAND (69007- LYON)"); // Annonce le lieu du match amical
                            spectateur = new Random().Next(23051, 43051); // Génère aléatoirement l'affluence du match
                            adversaire = "OL";
                            Console.ReadLine();
                            OL16 V15 = new OL16(dom, nom, mouvant, Equipe, pts, ext, spectateur, adversaire, meteo, diffuseur);
                            Exit(adversaire);
                            break;
                        case 5:
                            Console.Read();
                            Console.WriteLine("  AMICAL VS OGC NICE :");
                            Console.WriteLine("LIEU : ALLIANZ RIVERIA (06200- NICE)"); // Annonce le lieu du match amical
                            spectateur = new Random().Next(15000, 35624); // Génère aléatoirement l'affluence du match
                            adversaire = "OGC NICE";
                            Console.ReadLine();
                            OGCNICE16 VG = new OGCNICE16(dom, nom, mouvant, Equipe, pts, ext, spectateur, adversaire, meteo, diffuseur);
                            Exit(adversaire);
                            break;
                        case 6:
                            Console.Read();
                            Console.WriteLine("  AMICAL VS PARIS SAINT-GERMAIN :");
                            Console.WriteLine("LIEU : PARC DES PRINCES (75016- PARIS)"); // Annonce le lieu du match amical
                            spectateur = new Random().Next(36000, 47929); // Génère aléatoirement l'affluence du match
                            adversaire = "PARIS SAINT-GERMAIN";
                            Console.ReadLine();
                            PSG16 VPDP = new PSG16(dom, nom, mouvant, Equipe, pts, ext, spectateur, adversaire, meteo, diffuseur);
                            Exit(adversaire);
                            break;
                        case 7:
                            Console.Read();
                            Console.WriteLine("  AMICAL VS REAL MADRID CF :");
                            Console.WriteLine("LIEU : STADE SANTIAGO-BERNABEU (42000- MADRID)"); // Annonce le lieu du match amical
                            spectateur = new Random().Next(29000, 81044); // Génère aléatoirement l'affluence du match
                            adversaire = "REAL MADRID CF";
                            Console.ReadLine();
                            REAL16 V16ESP = new REAL16(dom, nom, mouvant, Equipe, pts, ext, spectateur, adversaire, meteo, diffuseur);
                            Exit(adversaire);
                            break;
                        case 8:
                            Console.Read();
                            Console.WriteLine("  AMICAL VS TFC :");
                            Console.WriteLine("LIEU : STADIUM TFC (31028- TOULOUSE)"); // Annonce le lieu du match amical
                            spectateur = new Random().Next(8100, 33150); // Génère aléatoirement l'affluence du match
                            adversaire = "TFC";
                            Console.ReadLine();
                            TFC16 MatchGaronne = new TFC16(dom, nom, mouvant, Equipe, pts, ext, spectateur, adversaire, meteo, diffuseur);
                            Exit(adversaire);
                            break;
                        case 9:
                            Console.Read();
                            Console.WriteLine("  AMICAL VS ESTAC TROYES :");
                            Console.WriteLine("LIEU : STADE DE L'AUBE (10000- TROYES)"); // Annonce le lieu du match amical
                            spectateur = new Random().Next(8000, 20400); // Génère aléatoirement l'affluence du match
                            adversaire = "ESTAC TROYES";
                            Console.ReadLine();
                            ESTAC16 VN = new ESTAC16(dom, nom, mouvant, Equipe, pts, ext, spectateur, adversaire, meteo, diffuseur);
                            Exit(adversaire);
                            break;
                        default:
                            Console.Read();
                            Console.WriteLine("  AMICAL VS OL :");
                            Console.WriteLine("LIEU : STADE DE GERLAND (69007- LYON)");
                            spectateur = new Random().Next(18000, 41001); // Génère aléatoirement l'affluence du match
                            adversaire = "OL";
                            Console.ReadLine();
                            OL16 V155 = new OL16(dom, nom, mouvant, Equipe, pts, ext, spectateur, adversaire, meteo, diffuseur);
                            Exit(adversaire);
                            break;
                    }
                    break;
                case "5": // Cas où l'utilisateur veut voir les crédits du programme
                    Credit p1 = new Credit("Crédit");
                    break;
                case "6": // Si l'utilisateur veut revoir la date du jour
                    HC();
                    Exit(adversaire); // Force la sortie forcé de l'application
                    break;
                case "2":
                default: // Option 2 inclus et tout les cas non indexés ci-dessus (7 ou plus, 0 ou moins, etc)
                    Console.Write("Votre sexe (F-M) : ");
                    string Sexe = (Console.ReadLine());
                    Console.Clear();
                    switch (Sexe) // Définit le sexe du joueur
                    {
                        case "F":
                        case "f":
                        case "♀":
                            Console.Write("Veuillez saisir votre prénom, chère entraineuse : "); // Si le joueur est féminin
                            saisie = Console.ReadLine();
                            break;
                        case "M":
                        case "m":
                        case "♂":
                        default: // Accord au masculin, par défaut
                            Console.Write("Veuillez saisir votre prénom, cher entraineur : "); // Si le joueur est masculin
                            saisie = Console.ReadLine();
                            break;
                    }
                    coach = saisie; // Récupère le nom de l'entraineur qui vient d'être donné
                    Console.Clear();
                    Console.WriteLine("Langue / Language : ");
                    Console.WriteLine(" 1- English");
                    Console.WriteLine(" 2- Français");
                    Console.WriteLine(" 3- Italien");
                    Console.WriteLine(" 4- Arabe");
                    Console.WriteLine(" ");
                    Console.Write("Votre langue de jeu : ");
                    int lang = Int32.Parse(Console.ReadLine()); // Variable du choix de la langue
                    while (lang < 1 & lang > 5) // Si il n'existe pas d'adversaire au nombre souhaité
                    {
                        Console.Write("! Veillez resaisir une valeur correcte : ");
                        lang = Int32.Parse(Console.ReadLine());
                    }
                    Console.Clear();
                    switch (lang) // Définit la langue demandé par le joueur
                    {
                        case 1:
                            Console.WriteLine("Hello " + saisie); // Si le joueur est anglais
                            break;
                        case 2:
                            Console.WriteLine("Bonjour " + saisie); // Si le joueur est français
                            break;
                        case 3:
                            Console.WriteLine("Buongirno " + saisie); // Si le joueur est italien
                            break;
                        case 4:
                            Console.WriteLine("Selem " + saisie); // Si le joueur est arabe
                            break;
                        default:
                            Console.WriteLine("Selem " + saisie); // Langue choisi par défaut
                            break;
                    }
                    break;
            }
            string[] tableau = new string[6];
            int salaire_entraineur = 0;
            int saison = 1; // Compteur de saisons
            int saison_D1FR = 0; // Initiation du compteur de saisons passés en D1 française
            int saison_D2FR = 0; // Initiation du compteur de saisons passés en D2 française
            int saison_D3FR = 0; // Initiation du compteur de saisons passés en D3 française
            int championnats = 0; // Mise à 0 du compteur de championnats gagnés
            int coupes = 0; // Mise à 0 du compteur de coupes gagnées
            int coupe_de_france = 0; // Compteur de Coupes de Françe
            int tdc = 0; // Compteur de Trophées des Champions
            int exterieur = 0;
            bool D2 = true;
            int changement_d = 0; // Variable permettant la relégation une division par une division
            string Equipe_promuNAT = " "; // Récupère l'équipe qui monte de NATIONAL FFF en Domino's Ligue 2
            string Equipe_descenteD1 = " "; // Récupère l'équipe qui monte de NATIONAL FFF en Domino's Ligue 2
            int nb_transfert; // Sert à compter le nombre de transfert et achats au cours de la saison, lors du mercato estival
            int cumulable = 0; // Sert à compter le nombre de fois où les transferts n'ont pas été intégralement épuisé
            while (saison < 6 & attention < 3) // Test si le nombre de saisons possibles est atteint
            {
                Console.ResetColor();
                int budjet; // Indique le budjet du club
                budjet = 0; // Mise à 0 du bujet du club
                Console.WriteLine("C'est votre saison n° " + saison); // Annonce le numéro de saison en cours consécutif
                Console.WriteLine("Veillez saisir votre championnat : ");
                if (attention == 0)
                {
                    Console.WriteLine("1- LIGUE 1 Uber Eats, 2- Domino's LIGUE 2, 3-NATIONAL FFF");
                }
                if (attention == 1)  // Si l'utlisateur vient de faire une mauvaise saison en D1
                {
                    Console.WriteLine("2- Domino's LIGUE 2, 3- NATIONAL FFF");
                }
                if (attention == 2)  // Si l'utlisateur vient de faire une mauvaise saison en D2
                {
                    Console.WriteLine("3- NATIONAL FFF");
                }
                Console.WriteLine(" ");
                Console.Write("Votre choix : ");
                int cass = Int32.Parse(Console.ReadLine());
                while (cass < 1 || cass > 3)
                {
                    Console.Write("! Veillez resaisir un choix possible : ");
                    cass = Int32.Parse(Console.ReadLine());
                }
                while (cass == 1 & attention >= 1 || cass == 2 & attention >=2 )
                {
                    Console.Write("! Veillez resaisir un choix possible : ");
                    cass = Int32.Parse(Console.ReadLine());
                }
                switch (cass)
                {
                    case 1:
                        division = "LIGUE 1 Uber Eats"; // Mise à jour de la division
                        saison_D1FR = saison_D1FR + 1; // Incrémentation de notre compteur de D1 française
                        Console.Clear();
                        Console.WriteLine("LIGUE 1 Uber Eats -");
                        if (Equipe_promu == " ") // Marche seulement si il n'y pas eu de promotion lors du game en cours
                        {
                            Console.WriteLine(" 1- ANGERS SCO");
                        }
                        Console.WriteLine(" 2- GIRONDIENS DE BORDEAUX");
                        Console.WriteLine(" 3- SB 29");
                        Console.WriteLine(" 4- DFCO");
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
                        ;
                        if (Equipe_promu != " " & montee == 1)
                        {
                            Console.WriteLine("19- " + Equipe_promu);
                        }
                        Console.WriteLine(" ");
                        Console.Write("Votre saisie : ");
                        int casss = Int32.Parse(Console.ReadLine());
                        while (casss < 1 & montee == 0 || casss > 18 & montee == 0)
                        {
                            Console.Write("! Veillez resaisir une valeur correcte : ");
                            casss = Int32.Parse(Console.ReadLine());
                        }
                        while (casss < 2 & montee == 1 || casss > 19 & montee == 1)
                        {
                            Console.Write("! Veillez resaisir une valeur correcte : ");
                            casss = Int32.Parse(Console.ReadLine());
                        }
                        Console.Clear();
                        switch (casss) // Swtich du choix de l'équipe
                        {
                            case 1:
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("Salut, bienenue au SCO d'ANGERS !!!");
                                Equipe = "ANGERS SCO";
                                Equipe_avant2 = " ANGERS";
                                budjet = 20000000;
                                break;
                            case 2:
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.WriteLine("Salut, bienenue au GIRONDIENS DE BORDEAUX !!!");
                                Equipe = "GIRONDIENS DE BORDEAUX";
                                Equipe_avant2 = "BORDEAU";
                                budjet = 50000000;
                                break;
                            case 3:
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Salut, bienenue au STADE BRESTOIS 29 !!!");
                                Equipe = "SB 29";
                                Equipe_avant2 = " SB 29 ";
                                budjet = 20000000;
                                break;
                            case 4:
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Salut, bienenue au DFCO !!!");
                                Equipe = "DFCO";
                                Equipe_avant2 = "  DFCO ";
                                budjet = 20000000;
                                break;
                            case 5:
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine("Salut, bienenue au RCL !!!");
                                Equipe = "RCL";
                                Equipe_avant2 = "  RCL  ";
                                budjet = 20000000;
                                break;
                            case 6:
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Salut, bienenue au LOSC !!!");
                                Equipe = "LOSC";
                                Equipe_avant2 = "  LOSC ";
                                budjet = 80000000;
                                break;
                            case 7:
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("Salut, bienenue à l'OL !!!");
                                Equipe = "OL";
                                Equipe_avant2 = "  OL   ";
                                budjet = 100000000;
                                break;
                            case 8:
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("Salut, bienenue à l'OM !!!");
                                Equipe = "OM";
                                Equipe_avant2 = "  OM   ";
                                budjet = 100000000;
                                break;
                            case 9:
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("Salut, bienenue au FC METZ !!!");
                                Equipe = "FC METZ";
                                Equipe_avant2 = "FC METZ";
                                budjet = 20000000;
                                break;
                            case 10:
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Salut, bienenue à l'AS MONACO FC !!!");
                                Equipe = "AS MONACO FC";
                                Equipe_avant2 = " MONACO";
                                budjet = 90000000;
                                break;
                            case 11:
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("Salut, bienenue au FC NANTES !!!");
                                Equipe = "FC NANTES";
                                Equipe_avant2 = " NANTES";
                                budjet = 30000000;
                                break;
                            case 12:
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Salut, bienenue à l'OGC NICE !!!");
                                Equipe = "OGC NICE";
                                Equipe_avant2 = "  NICE ";
                                budjet = 40000000;
                                break;
                            case 13:
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("Salut, bienenue à Nimes !!!");
                                Equipe = "NIMES OLYMPIQUES";
                                Equipe_avant2 = " NIMES ";
                                budjet = 20000000;
                                break;
                            case 14:
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.WriteLine("Salut, bienenue au PARIS SAINT-GERMAIN !!!");
                                Equipe = "PARIS SAINT-GERMAIN";
                                Equipe_avant2 = "  PSG  ";
                                budjet = 400000000;
                                break;
                            case 15:
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Salut, bienenue au STADE DE REIMS !!!");
                                Equipe = "STADE DE REIMS";
                                Equipe_avant2 = " REIMS ";
                                budjet = 20000000;
                                break;
                            case 16:
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Salut, bienenue au STADE RENNAIS FC !!!");
                                Equipe = "STADE RENNAIS FC";
                                Equipe_avant2 = " RENNES";
                                budjet = 35000000;
                                break;
                            case 17:
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                Console.WriteLine("Salut, bienenue à l'ASSE !!!");
                                Equipe = "A.S.S.E";
                                Equipe_avant2 = "A.S.S.E";
                                budjet = 40000000;
                                break;
                            case 18:
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("Salut, bienenue au RACING CLUB DE STRASBOURG !!!");
                                Equipe = "RACING CLUB DE STRASBOURG";
                                Equipe_avant2 = " RACING";
                                budjet = 20000000;
                                break;
                            case 19:
                                if (Equipe_promu == "AC AJACCIO")
                                {
                                    Equipe = "ACA";
                                    Equipe_avant2 = "  ACA  ";
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Salut, rebienenue à l'AC AJACCIO !!!");
                                }
                                if (Equipe_promu == "A.J AUXERRE")
                                {
                                    Equipe = "A.J AUXERRE";
                                    Equipe_avant2 = "AUXERRE";
                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    Console.WriteLine("Salut, bienenue à l'A.J AUXERRE !!!");
                                }
                                if (Equipe_promu == "CLERMONT FOOT 63")
                                {
                                    Equipe = "CLERMONT FOOT 63";
                                    Equipe_avant2 = "CLERMON";
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine("Salut, bienenue au CLERMONT FOOT 63 !!!");
                                }
                                if (Equipe_promu == "GF 38")
                                {
                                    Equipe = "GF 38";
                                    Equipe_promu = " GF 38 ";
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    Console.WriteLine("Salut, bienenue au GF 38 !!!");
                                }
                                if (Equipe_promu == "EAG")
                                {
                                    Equipe = "EAG";
                                    Equipe_avant2 = "  EAG  ";
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Salut, bienenue à l'EN AVANT DE GUIMGUIMP !!!");
                                }
                                if (Equipe_promu == "HAC")
                                {
                                    Equipe = "HAC";
                                    Equipe_avant2 = "  HAC  ";
                                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                                    Console.WriteLine("Salut, bienenue au HAC !!!");
                                }
                                if (Equipe_promu == "PARIS FC")
                                {
                                    Equipe = "PARIS FC";
                                    Equipe_avant2 = "  PFC  ";
                                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                                    Console.WriteLine("Salut, bienenue au PARIS FC !!!");
                                }
                                if (Equipe_promu == "ASNL")
                                {
                                    Equipe = "ASNL";
                                    Equipe_avant2 = "  ASNL ";
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Salut, bienenue à l'ASNL !!!");
                                }
                                if (Equipe_promu == "SC BASTIA")
                                {
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    Console.WriteLine("Salut, bienenue au SC BASTIA !!!");
                                    Equipe = "SC BASTIA";
                                    Equipe_avant2 = " BASTIA";
                                }
                                if (Equipe_promu == "F.C SETE")
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("Salut, bienenue au F.C.SETE !!!");
                                    Equipe = "F.C SETE";
                                    Equipe_avant2 = "FC SETE";
                                    break;
                                }
                                if (Equipe_promu == "FC ANNECY")
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Salut, bienenue au FC ANNECY !!!");
                                    Equipe = "FC ANNECY";
                                    Equipe_avant2 = " ANNECY";
                                }
                                if (Equipe_promu == "ORLEANS LOIRET FOOTBALL")
                                {
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine("Salut, bienenue au ORLEANS LOIRET FOOTBALL !!!");
                                    Equipe = "ORLEANS LOIRET FOOTBALL";
                                    Equipe_avant2 = "ORLEANS";
                                }
                                if (Equipe_promu == "STADE BRIOCHIN")
                                {
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine("Salut, bienenue au STADE BRIOCHIN !!!");
                                    Equipe = "STADE BRIOCHIN";
                                    Equipe_avant2 = "STADE B";
                                }
                                if (Equipe_promu == "USC")
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                                    Console.WriteLine("Salut, bienenue à l'USC !!!");
                                    Equipe = "USC";
                                    Equipe_avant2 = "  USC  ";
                                }
                                if (Equipe_promu == "SL")
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                                    Console.WriteLine("Salut, bienenue au SL !!!");
                                    Equipe = "SL";
                                    Equipe_avant2 = "  SL   ";
                                }
                                budjet = 20000000;
                                break;
                        }
                        if (Equipe_avant2 == Equipe & saison>1) // CORRECTION A  APPROTE
                        {
                            salaire_entraineur = salaire_entraineur + 15000 * 12;
                            budjet = budjet + 3000000; // Ajout de la bonification des droits TV si l'équipe entrainé était identique à la saison S-1 et qu'elle sait maintenue
                        }
                        break;
                    case 2:
                        division = "Domino's LIGUE 2"; // Mise à jour de la division
                        saison_D2FR = saison_D2FR + 1; // Incrémentation de notre compteur de D2 française
                        Console.Clear();
                        Console.WriteLine("Domino's LIGUE 2 -");
                        Console.WriteLine(" 1- AC AJACCIO");
                        Console.WriteLine(" 2- A.J AUXERRE");
                        Console.WriteLine(" 3- CLERMONT FOOT 63");
                        Console.WriteLine(" 4- GF 38");
                        Console.WriteLine(" 5- EAG");
                        Console.WriteLine(" 6- HAC");
                        Console.WriteLine(" 7- PARIS FC");
                        Console.WriteLine(" 8- ASNL");
                        if (saison > 1 & D2 == true & Equipe_promuNAT != " ")
                        {
                            Console.WriteLine(" 9- "+Equipe_promuNAT);
                        }
                        if (saison > 1 & Equipe_descenteD1 != " ")
                        {
                            Console.WriteLine(" 9- " + Equipe_descenteD1);
                            budjet = 18000000; // Mise à jour du budjet après la descente de l'équipe
                        }
                        Console.WriteLine(" ");
                        Console.Write("Votre saisie : ");
                        casss = Int32.Parse(Console.ReadLine());
                        while (casss < 1 || casss > 9 || casss > 8 & Equipe_promuNAT == " " & Equipe_descenteD1 == " ") // Vérification de la saisie d'une équipe correcte
                        {
                            Console.Write("! Veillez resaisir une valeur correcte : ");
                            casss = Int32.Parse(Console.ReadLine());
                        }
                        Console.Clear();
                        switch (casss) // Swtich du choix de l'équipe
                        {
                            case 1:
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Salut, bienenue à l'AC AJACCIO !!!");
                                Equipe = "AC AJACCIO";
                                Equipe_avant2 = "  ACA  ";
                                budjet = 11000000;
                                break;
                            case 2:
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("Salut, bienenue à l'A.J AUXERRE !!!");
                                Equipe = "A.J AUXERRE";
                                Equipe_avant2 = "AUXERRE";
                                budjet = 11000000;
                                break;
                            case 3:
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("Salut, bienenue au CLERMONT FOOT 63 !!!");
                                Equipe = "CLERMONT FOOT 63";
                                Equipe_avant2 = "CLERMON";
                                budjet = 11000000;
                                break;
                            case 4:
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.WriteLine("Salut, bienenue au GF 38 !!!");
                                Equipe = "GF 38";
                                Equipe_avant2 = " GF 38 ";
                                budjet = 11000000;
                                break;
                            case 5:
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Salut, bienenue à l'EN AVANT DE GUIMGUIMP !!!");
                                Equipe = "EAG";
                                Equipe_avant2 = "EAG";
                                budjet = 18000000;
                                break;
                            case 6:
                                Console.ForegroundColor = ConsoleColor.DarkBlue;
                                Console.WriteLine("Salut, bienenue au HAC !!!");
                                Equipe = "HAC";
                                Equipe_avant2 = "  HAC  ";
                                budjet = 12000000;
                                break;
                            case 7:
                                Console.ForegroundColor = ConsoleColor.DarkBlue;
                                Console.WriteLine("Salut, bienenue au PARIS FC !!!");
                                Equipe = "PARIS FC";
                                Equipe_avant2 = "  PFC  ";
                                budjet = 12000000;
                                break;
                            case 8:
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Salut, bienenue à l'ASNL !!!");
                                Equipe = "ASNL";
                                Equipe_avant2 = "  ASNL ";
                                budjet = 12000000;
                                break;
                            case 9:
                                if (Equipe_descenteD1 == "ANGERS SCO")
                                {
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine("Salut, bienenue au SCO d'ANGERS !!!");
                                    Equipe = "ANGERS SCO";
                                    Equipe_avant2 = " ANGERS";
                                    budjet = 17500000;
                                    break;
                                }
                                if (Equipe_descenteD1 == "GIRONDIENS DE BORDEAUX")
                                {
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    Console.WriteLine("Salut, bienenue au GIRONDIENS DE BORDEAUX !!!");
                                    Equipe = "GIRONDIENS DE BORDEAUX";
                                    Equipe_avant2 = "BORDEAU";
                                    budjet = 18500000;
                                    break;
                                }
                                if (Equipe_descenteD1 == "SB 29")
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Salut, bienenue au STADE BRESTOIS 29 !!!");
                                    Equipe = "SB 29";
                                    Equipe_avant2 = " SB 29 ";
                                    budjet = 18000000;
                                    break;
                                }
                                if (Equipe_descenteD1 == "DFCO")
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Salut, bienenue au DFCO !!!");
                                    Equipe = "DFCO";
                                    Equipe_avant2 = "  DFCO ";
                                    budjet = 18000000;
                                    break;
                                }
                                if (Equipe_descenteD1 == "RCL")
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                                    Console.WriteLine("Salut, bienenue au RCL !!!");
                                    Equipe = "RCL";
                                    Equipe_avant2 = "  RCL  ";
                                    budjet = 18000000;
                                    break;
                                }
                                if (Equipe_descenteD1 == "LOSC")
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Salut, bienenue au LOSC !!!");
                                    Equipe = "LOSC";
                                    Equipe_avant2 = "  LOSC ";
                                    budjet = 20000000;
                                    break;
                                }
                                if (Equipe_descenteD1 == "OL")
                                {
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine("Salut, bienenue à l'OL !!!");
                                    Equipe = "OL";
                                    Equipe_avant2 = "  OL   ";
                                    budjet = 20500000;
                                    break;
                                }
                                if (Equipe_descenteD1 == "OM")
                                {
                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    Console.WriteLine("Salut, bienenue à l'OM !!!");
                                    Equipe = "OM";
                                    Equipe_avant2 = "  OM   ";
                                    budjet = 20500000;
                                    break;
                                }
                                if (Equipe_descenteD1 == " FC METZ")
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine("Salut, bienenue au FC METZ !!!");
                                    Equipe = "FC METZ";
                                    Equipe_avant2 = "FC METZ";
                                    budjet = 18000000;
                                    break;
                                }
                                if (Equipe_descenteD1 == "AS MONACO FC")
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Salut, bienenue à l'AS MONACO FC !!!");
                                    Equipe = "AS MONACO FC";
                                    Equipe_avant2 = " MONACO";
                                    budjet = 20000000;
                                    break;
                                }
                                if (Equipe_descenteD1 == "FC NANTES")
                                {
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine("Salut, bienenue au FC NANTES !!!");
                                    Equipe = "FC NANTES";
                                    Equipe_avant2 = " NANTES";
                                    budjet = 18000000;
                                    break;
                                }
                                if (Equipe_descenteD1 == "OGC NICE")
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Salut, bienenue à l'OGC NICE !!!");
                                    Equipe = "OGC NICE";
                                    Equipe_avant2 = "  NICE ";
                                    budjet = 18500000;
                                    break;
                                }
                                if (Equipe_descenteD1 == "NIMES OLYMPIQUES")
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine("Salut, bienenue à Nimes !!!");
                                    Equipe = "NIMES OLYMPIQUES";
                                    Equipe_avant2 = " NIMES ";
                                    budjet = 17000000;
                                    break;
                                }
                                if (Equipe_descenteD1 == "PARIS SAINT-GERMAIN")
                                {
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    Console.WriteLine("Salut, bienenue au PARIS SAINT-GERMAIN !!!");
                                    Equipe = "PARIS SAINT-GERMAIN";
                                    Equipe_avant2 = "  PSG  ";
                                    budjet = 21000000;
                                    break;
                                }
                                if (Equipe_descenteD1 == "STADE DE REIMS")
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Salut, bienenue au STADE DE REIMS !!!");
                                    Equipe = "STADE DE REIMS";
                                    Equipe_avant2 = " REIMS ";
                                    budjet = 18000000;
                                    break;
                                }
                                if (Equipe_descenteD1 == "STADE RENNAIS FC")
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Salut, bienenue au STADE RENNAIS FC !!!");
                                    Equipe = "STADE RENNAIS FC";
                                    Equipe_avant2 = " RENNES";
                                    budjet = 19000000;
                                    break;
                                }
                                if (Equipe_descenteD1 == "A.S.S.E")
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                                    Console.WriteLine("Salut, bienenue à l'ASSE !!!");
                                    Equipe = "A.S.S.E";
                                    Equipe_avant2 = "A.S.S.E";
                                    budjet = 19000000;
                                    break;
                                }
                                if (Equipe_descenteD1 == "RACING CLUB DE STRASBOURG")
                                {
                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    Console.WriteLine("Salut, bienenue au RACING CLUB DE STRASBOURG !!!");
                                    Equipe = "RACING CLUB DE STRASBOURG";
                                    Equipe_avant2 = " RACING";
                                    budjet = 18000000;
                                    break;
                                }
                                if (Equipe_promuNAT == "SC BASTIA")
                                {
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    Console.WriteLine("Salut, bienenue au SC BASTIA !!!");
                                    Equipe = "SC BASTIA";
                                    Equipe_avant2 = " BASTIA";
                                    budjet = 9000000;
                                }
                                if (Equipe_promuNAT == "F.C SETE")
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("Salut, bienenue au F.C.SETE !!!");
                                    Equipe = "F.C SETE";
                                    Equipe_avant2 = "FC SETE";
                                    budjet = 8000000;
                                    break;
                                }
                                if (Equipe_promuNAT == "FC ANNECY")
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Salut, bienenue au FC ANNECY !!!");
                                    Equipe = "FC ANNECY";
                                    Equipe_avant2 = " ANNECY";
                                    budjet = 8000000;
                                }
                                if (Equipe_promuNAT == "ORLEANS LOIRET FOOTBALL")
                                {
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine("Salut, bienenue au ORLEANS LOIRET FOOTBALL !!!");
                                    Equipe = "ORLEANS LOIRET FOOTBALL";
                                    Equipe_avant2 = "ORLEANS";
                                    budjet = 9500000;
                                }
                                if (Equipe_promuNAT == "STADE BRIOCHIN")
                                {
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine("Salut, bienenue au STADE BRIOCHIN !!!");
                                    Equipe = "STADE BRIOCHIN";
                                    Equipe_avant2 = "STADE B";
                                    budjet = 8000000;
                                }
                                if (Equipe_promuNAT == "USC")
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                                    Console.WriteLine("Salut, bienenue à l'USC !!!");
                                    Equipe = "USC";
                                    Equipe_avant2 = "  USC  ";
                                    budjet = 10000000;
                                }
                                if (Equipe_promuNAT == "SL")
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                                    Console.WriteLine("Salut, bienenue au SL !!!");
                                    Equipe = "SL";
                                    Equipe_avant2 = "  SL   ";
                                    budjet = 10000000;
                                }
                                break;
                        }
                        break;
                    case 3:
                        division = "NATIONAL FFF"; // Mise à jour de la division
                        saison_D3FR = saison_D3FR + 1; // Incrémentation de notre compteur de D2 française
                        Console.Clear();
                        Console.WriteLine("NATIONAL FFF -");
                        Console.WriteLine(" 1- SC BASTIA");
                        Console.WriteLine(" 2- FC SETE");
                        Console.WriteLine(" 3- FC ANNECY");
                        Console.WriteLine(" 4- ORLEANS LOIRET FOOTBALL");
                        Console.WriteLine(" 5- STADE BRIOCHIN");
                        Console.WriteLine(" 6- USC");
                        Console.WriteLine(" 7- SL");
                        if (D2 == false & saison>1)
                        {
                            Console.WriteLine(" 8- " + Equipe); //Montre la possibilité de reporendre son ex-équipe de Domino's LIGUE 2
                        }
                        Console.WriteLine(" ");
                        Console.Write("Votre saisie : ");
                        casss = Int32.Parse(Console.ReadLine());
                        while (casss < 1 || casss > 8) // Bloque les possibles saisies incorectes pour le choix de l'équipe de NATIONAL FFF
                        {
                            Console.Write("! Veillez resaisir une valeur correcte : ");
                            casss = Int32.Parse(Console.ReadLine());
                        }
                        while (casss > 7 & D2 == true) // Bloque les possibles saisies incorectes pour le choix de l'équipe de NATIONAL FFF
                        {
                            Console.Write("! Veillez resaisir une valeur correcte : ");
                            casss = Int32.Parse(Console.ReadLine());
                        }
                        Console.Clear();
                        switch (casss) // Swtich du choix de l'équipe
                        {
                            case 1:
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.WriteLine("Salut, bienenue au SC BASTIA !!!");
                                Equipe = "SC BASTIA";
                                Equipe_avant2 = " BASTIA";
                                budjet = 5000000;
                                break;
                            case 2:
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Salut, bienenue au F.C.SETE !!!");
                                Equipe = "F.C SETE";
                                Equipe_avant2 = "FC SETE";
                                budjet = 4000000;
                                break;
                            case 3:
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Salut, bienenue au FC ANNECY !!!");
                                Equipe = "FC ANNECY";
                                Equipe_avant2 = " ANNECY";
                                budjet = 5000000;
                                break;
                            case 4:
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("Salut, bienenue au ORLEANS LOIRET FOOTBALL !!!");
                                Equipe = "ORLEANS LOIRET FOOTBALL";
                                Equipe_avant2 = "ORLEANS";
                                budjet = 5500000;
                                break;
                            case 5:
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("Salut, bienenue au STADE BRIOCHIN !!!");
                                Equipe = "STADE BRIOCHIN";
                                Equipe_avant2 = "STADE B";
                                budjet = 4000000;
                                break;
                            case 6:
                                Console.ForegroundColor = ConsoleColor.DarkBlue;
                                Console.WriteLine("Salut, bienenue à l'USC !!!");
                                Equipe = "USC";
                                Equipe_avant2 = "  USC  ";
                                budjet = 5000000;
                                break;
                            case 7:
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine("Salut, bienenue au SL !!!");
                                Equipe = "SL";
                                Equipe_avant2 = "  SL   ";
                                budjet = 5000000;
                                break;
                            case 8: // Cas où l'utilisateur choisi l'équipe qui l'a relegué en NATIONAL FFF
                                Console.WriteLine("Salut, bienenue au " + Equipe_avant2 + " !!!");
                                budjet = 8000000;
                                break;
                        }
                        break;
                }
                Console.WriteLine("BUDJET : " + budjet + " $"); // Rappel du budjet du club choisi
                Console.ReadLine();
                Console.Clear();
                if (division == "LIGUE 1 Uber Eats")
                {
                    pts = new Random().Next(0, 82); // Calcul du nombre de pts hors transfert
                }
                else
                {
                    pts = new Random().Next(0, 85); // Calcul du nombre de pts hors transfert
                }
                tableau[saison] = Equipe; //Ajout de l'équipe actuelle dans le tableau
                mouvant = 0; // Remise à 0 de l'impact des recrues sur le club
                changement_d = 0; // Mise à 0 du bujet du club
                nb_transfert = 0 - cumulable; // Remet à la valeur donné annulement le nombre de transfert
                achat1 = " ";
                achat2 = " ";
                achat3 = " ";
                while (budjet > 0 & nb_transfert < 3)
                {
                    Console.WriteLine("Lieu de recrutement / Prolongation de contrat :");
                    int budjeti = budjet; // Créer une sauvegarde du budjet initial
                    Console.WriteLine(" 1- SECTEUR SUD-EST");
                    Console.WriteLine(" 2- SECTEUR SUD-OUEST");
                    Console.WriteLine(" 3- SECTEUR NORD-EST");
                    Console.WriteLine(" 4- SECTEUR NORD-OUEST");
                    Console.WriteLine(" 5- EUROPE");
                    Console.WriteLine(" 6- MODE RECHERCHE");
                    Console.WriteLine(" ");
                    Console.WriteLine(" 9- FIN DES TRANSFERTS");
                    Console.WriteLine(" ");
                    Console.Write("SECTEUR : ");
                    string recrutement = (Console.ReadLine());
                    switch (recrutement)
                    {
                        case "1":
                            Console.Clear();
                            Console.WriteLine("BUDJET : " + budjet + " $"); // Rappel du budjet du club choisi
                            Console.WriteLine(" ");
                            Console.WriteLine("AC AJACCIO");
                            Console.WriteLine("  1- G.KALULU*");
                            Console.WriteLine("DFCO");
                            Console.WriteLine("  2- C.HOUNTONDJI*");
                            Console.WriteLine("OL");
                            Console.WriteLine("  3- M.DEPAY*");
                            Console.WriteLine("  4- K.TETE*");
                            Console.WriteLine("OM");
                            Console.WriteLine("  5- J.AMAVI*");
                            Console.WriteLine("  6- V.GERMAIN");
                            Console.WriteLine("  7- SE.KHAOUI*");
                            Console.WriteLine("  8- M.SANSON*");
                            Console.WriteLine("  9- F.THAUVIN*");
                            Console.WriteLine("AS MONACO FC");
                            Console.WriteLine("  10- JORGE*");
                            Console.WriteLine("OGC NICE");
                            Console.WriteLine("  11-W.CYPRIEN*");
                            Console.WriteLine("  12-M.SARR*");
                            Console.WriteLine("ASSE");
                            Console.WriteLine("  14- B.BENKHEDIM*");
                            Console.WriteLine("  15- W.KHAZRI*");
                            Console.WriteLine("  16- R.HAMOUMA");
                            Console.WriteLine("  17- J.PORSAN-CLEMENCE*");
                            Console.WriteLine(" ");
                            Console.Write("Votre transfert : ");
                            verif1 = 0;
                            string transfert = (Console.ReadLine());
                            Console.Clear();
                            switch (transfert)
                            {
                                case "1":
                                    nom = "G.KALULU*";
                                    price = 3500000;
                                    if (nom != achat1 & nom != achat2 & price < budjet)
                                    {
                                        Console.WriteLine("Vous avez acheté : " + nom);
                                        mouvant = mouvant + new Random().Next(0, 2);
                                        budjet = budjet - price;
                                    }
                                    else
                                    {
                                        EchecTransfert p1 = new EchecTransfert(nom, 0, pts);
                                        verif1 = 1;
                                    }
                                    break;
                                case "2":
                                    nom = "C.HOUNTONDJI*";
                                    price = 20000000;
                                    if (nom != achat1 & nom != achat2 & price < budjet)
                                    {
                                        Console.WriteLine("Vous avez acheté : " + nom);
                                        mouvant = mouvant + new Random().Next(0, 8);
                                        budjet = budjet - price;
                                    }
                                    else
                                    {
                                        EchecTransfert p1 = new EchecTransfert(nom, 0, pts);
                                        verif1 = 1;
                                    }
                                    break;
                                case "3":
                                    nom = "M.DEPAY*";
                                    price = 60000000;
                                    if (nom != achat1 & nom != achat2 & price < budjet)
                                    {
                                        Console.WriteLine("Vous avez acheté : " + nom);
                                        mouvant = mouvant + new Random().Next(0, 8);
                                        budjet = budjet - price;
                                    }
                                    else
                                    {
                                        EchecTransfert p1 = new EchecTransfert(nom, 0, pts);
                                        verif1 = 1;
                                    }
                                    break;
                                case "4":
                                    nom = "K.TETE*";
                                    price = 50000000;
                                    if (nom != achat1 & nom != achat2 & price < budjet)
                                    {
                                        Console.WriteLine("Vous avez acheté : " + nom);
                                        mouvant = mouvant + new Random().Next(0, 8);
                                        budjet = budjet - price;
                                    }
                                    else
                                    {
                                        EchecTransfert p1 = new EchecTransfert(nom, 0, pts);
                                        verif1 = 1;
                                    }
                                    break;
                                case "5":
                                    nom = "J.AMAVI*";
                                    price = 30000000;
                                    if (nom != achat1 & nom != achat2 & price < budjet)
                                    {
                                        Console.WriteLine("Vous avez acheté : " + nom);
                                        mouvant = mouvant + new Random().Next(0, 9);
                                        budjet = budjet - price;
                                    }
                                    else
                                    {
                                        EchecTransfert p1 = new EchecTransfert(nom, 0, pts);
                                        verif1 = 1;
                                    }
                                    break;
                                case "6":
                                    nom = "V.GERMAIN*";
                                    price = 20000000;
                                    if (nom != achat1 & nom != achat2 & price < budjet)
                                    {
                                        Console.WriteLine("Vous avez acheté : " + nom);
                                        mouvant = mouvant + new Random().Next(0, 31);
                                        budjet = budjet - price;
                                    }
                                    else
                                    {
                                        EchecTransfert p1 = new EchecTransfert(nom, 0, pts);
                                        verif1 = 1;
                                    }
                                    break;
                                case "7":
                                    nom = "SE.KHAOUI*";
                                    price = 20000000;
                                    if (nom != achat1 & nom != achat2 & price < budjet)
                                    {
                                        Console.WriteLine("Vous avez acheté : " + nom);
                                        mouvant = mouvant + new Random().Next(0, 13);
                                        budjet = budjet - price;
                                    }
                                    else
                                    {
                                        EchecTransfert p1 = new EchecTransfert(nom, 0, pts);
                                        verif1 = 1;
                                    }
                                    break;
                                case "8":
                                    nom = "M.SANSON*";
                                    price = 40000000;
                                    if (nom != achat1 & nom != achat2 & price < budjet)
                                    {
                                        Console.WriteLine("Vous avez acheté : " + nom);
                                        mouvant = mouvant + new Random().Next(0, 21);
                                        budjet = budjet - price;
                                    }
                                    else
                                    {
                                        EchecTransfert p1 = new EchecTransfert(nom, 0, pts);
                                        verif1 = 1;
                                    }
                                    break;
                                case "9":
                                    nom = "F.THAUVIN*";
                                    price = 60000000;
                                    if (nom != achat1 & nom != achat2 & price < budjet)
                                    {
                                        Console.WriteLine("Vous avez acheté : " + nom);
                                        mouvant = mouvant + new Random().Next(0, 31);
                                        budjet = budjet - price;
                                    }
                                    else
                                    {
                                        EchecTransfert p1 = new EchecTransfert(nom, 0, pts);
                                        verif1 = 1;
                                    }
                                    break;
                                case "10":
                                    nom = "JORGE*";
                                    price = 60000000;
                                    if (nom != achat1 & nom != achat2 & price < budjet)
                                    {
                                        Console.WriteLine("Vous avez acheté : " + nom);
                                        mouvant = mouvant + new Random().Next(0, 8);
                                        budjet = budjet - price;
                                    }
                                    else
                                    {
                                        EchecTransfert p1 = new EchecTransfert(nom, 0, pts);
                                        verif1 = 1;
                                    }
                                    break;
                                case "11":
                                    nom = "W.CYPRIEN*";
                                    price = 50000000;
                                    if (nom != achat1 & nom != achat2 & price < budjet)
                                    {
                                        Console.WriteLine("Vous avez acheté : " + nom);
                                        mouvant = mouvant + new Random().Next(0, 8);
                                        budjet = budjet - price;
                                    }
                                    else
                                    {
                                        EchecTransfert p1 = new EchecTransfert(nom, 0, pts);
                                        verif1 = 1;
                                    }
                                    break;
                                case "13":
                                    nom = "B.SRARFI*";
                                    price = 20000000;
                                    if (nom != achat1 & nom != achat2 & price < budjet)
                                    {
                                        Console.WriteLine("Vous avez acheté : " + nom);
                                        mouvant = mouvant + new Random().Next(0, 8);
                                        budjet = budjet - price;
                                    }
                                    else
                                    {
                                        EchecTransfert p1 = new EchecTransfert(nom, 0, pts);
                                        verif1 = 1;
                                    }
                                    break;
                                case "14":
                                    nom = "B.BENKHEDIM";
                                    price = 3000000;
                                    if (nom != achat1 & nom != achat2 & price < budjet)
                                    {
                                        Console.WriteLine("Vous avez acheté : " + nom);
                                        mouvant = mouvant + new Random().Next(0, 2);
                                        budjet = budjet - price;
                                    }
                                    else
                                    {
                                        EchecTransfert p1 = new EchecTransfert(nom, 0, pts);
                                        verif1 = 1;
                                    }
                                    break;
                                case "15":
                                    nom = "W.KHAZRI*";
                                    price = 35000000;
                                    if (nom != achat1 & nom != achat2 & price < budjet)
                                    {
                                        Console.WriteLine("Vous avez acheté : " + nom);
                                        mouvant = mouvant + new Random().Next(0, 31);
                                        budjet = budjet - price;
                                    }
                                    else
                                    {
                                        EchecTransfert p1 = new EchecTransfert(nom, 0, pts);
                                        verif1 = 1;
                                    }
                                    break;
                                case "16":
                                    nom = "R.HAMOUMA";
                                    price = 2000000;
                                    if (nom != achat1 & nom != achat2 & price < budjet)
                                    {
                                        Console.WriteLine("Vous avez acheté : " + nom);
                                        mouvant = mouvant + new Random().Next(5, 26);
                                        budjet = budjet - price;
                                    }
                                    else
                                    {
                                        EchecTransfert p1 = new EchecTransfert(nom, 0, pts);
                                        verif1 = 1;
                                    }
                                    break;
                                case "17":
                                    nom = "J.PORSAN-CLEMENTE*";
                                    price = 3000000;
                                    if (nom != achat1 & nom != achat2 & price < budjet)
                                    {
                                        Console.WriteLine("Vous avez acheté : " + nom);
                                        mouvant = mouvant + new Random().Next(0, 8);
                                        budjet = budjet - price;
                                    }
                                    else
                                    {
                                        EchecTransfert p1 = new EchecTransfert(nom, 0, pts);
                                        verif1 = 1;
                                    }
                                    break;
                                default:
                                    NonAchat pA = new NonAchat(nom, 0, pts);
                                    price = 999999999;
                                    break;
                            }
                            break;
                        case "2":
                            Console.Clear();
                            Console.WriteLine("BUDJET : " + budjet + " $"); // Rappel du budjet du club choisi
                            Console.WriteLine(" ");
                            Console.WriteLine("GIRONDIENS DE BORDEAUX");
                            Console.WriteLine("  1- N.DE PREVILLE*");
                            Console.WriteLine("  2- V.JOVANOVIC*");
                            Console.WriteLine("  3- F.KAMANO*");
                            Console.WriteLine("  4- PABLO*");
                            Console.WriteLine("  5- Y.SABALY*");
                            Console.WriteLine("MONTPELLIER HERAULT SPORTING CLUB");
                            Console.WriteLine("  6- K.DOLLY*");
                            Console.WriteLine("  7- P.MENDES");
                            Console.WriteLine("NIMES OLYMPIQUE");
                            Console.WriteLine("  8- S.ALAKOUCH*");
                            Console.WriteLine("  9- S.BEN AMAR*");
                            Console.WriteLine("TFC");
                            Console.WriteLine("  10- A.ADIL*");
                            Console.WriteLine("  11- K.AMIAN*");
                            Console.WriteLine("  12- I.SANGARE*");
                            Console.WriteLine(" ");
                            Console.Write("Votre transfert : ");
                            string transfert2 = (Console.ReadLine());
                            Console.Clear();
                            switch (transfert2)
                            {
                                case "1":
                                    nom = "N.DE PREVILLE*";
                                    price = 40000000;
                                    if (budjet >= 40000000)
                                    {
                                        Console.WriteLine("Vous avez acheté : " + nom);
                                        mouvant = new Random().Next(2, 30);
                                        pts = pts + mouvant;
                                        budjet = budjet - 40000000;
                                    }
                                    else
                                    {
                                        EchecTransfert p1 = new EchecTransfert(nom, 0, pts);
                                    }
                                    break;
                                case "2":
                                    price = 20000000;
                                    nom = "V.JOVANOVIC*";
                                    Console.WriteLine("Vous avez acheté : " + nom);
                                    mouvant = new Random().Next(0, 4);
                                    pts = pts + mouvant;
                                    budjet = budjet - 20000000;
                                    break;
                                case "3":
                                    nom = "F.KAMANO*";
                                    price = 30000000;
                                    if (budjet >= 30000000)
                                    {
                                        Console.WriteLine("Vous avez acheté : " + nom);
                                        mouvant = new Random().Next(2, 30);
                                        pts = pts + mouvant;
                                        budjet = budjet - 30000000;
                                    }
                                    else
                                    {
                                        EchecTransfert p1 = new EchecTransfert(nom, 0, pts);
                                    }
                                    break;
                                case "4":
                                    nom = "PABLO*";
                                    price = 40000000;
                                    if (budjet >= 40000000)
                                    {
                                        Console.WriteLine("Vous avez acheté : " + nom);
                                        mouvant = new Random().Next(1, 7);
                                        pts = pts + mouvant;
                                        budjet = budjet - 40000000;
                                    }
                                    else
                                    {
                                        EchecTransfert p1 = new EchecTransfert(nom, 0, pts);
                                    }
                                    break;
                                case "5":
                                    nom = "Y.SABALY*";
                                    price = 20000000;
                                    Console.WriteLine("Vous avez acheté : " + nom);
                                    mouvant = new Random().Next(0, 4);
                                    pts = pts + mouvant;
                                    budjet = budjet - 20000000;
                                    break;
                                case "6":
                                    nom = "K.DOLLY*";
                                    price = 20000000;
                                    Console.WriteLine("Vous avez acheté : " + nom);
                                    mouvant = new Random().Next(0, 5);
                                    pts = pts + mouvant;
                                    budjet = budjet - 20000000;
                                    break;
                                case "7":
                                    nom = "P.MENDES*";
                                    price = 21000000;
                                    Console.WriteLine("Vous avez acheté : " + nom);
                                    mouvant = new Random().Next(0, 4);
                                    pts = pts + mouvant;
                                    budjet = budjet - 21000000;
                                    break;
                                case "8":
                                    nom = "S.ALAKOUCH*";
                                    price = 20000000;
                                    Console.WriteLine("Vous avez acheté : " + nom);
                                    mouvant = new Random().Next(0, 4);
                                    pts = pts + mouvant;
                                    budjet = budjet - 20000000;
                                    break;
                                case "9":
                                    nom = "S.BEN AMAR*";
                                    price = 3000000;
                                    Console.WriteLine("Vous avez acheté : " + nom);
                                    mouvant = 0;
                                    pts = pts + mouvant;
                                    budjet = budjet - 3000000;
                                    break;
                                case "10":
                                    nom = "A.ADIL*";
                                    price = 3000000;
                                    Console.WriteLine("Vous avez acheté : " + nom);
                                    mouvant = 0;
                                    pts = pts + mouvant;
                                    budjet = budjet - 3000000;
                                    break;
                                case "11":
                                    nom = "K.AMIAN*";
                                    price = 30000000;
                                    if (budjet >= 30000000)
                                    {
                                        Console.WriteLine("Vous avez acheté : " + nom);
                                        mouvant = new Random().Next(0, 4);
                                        pts = pts + mouvant;
                                        budjet = budjet - 30000000;
                                    }
                                    else
                                    {
                                        EchecTransfert p1 = new EchecTransfert(nom, 0, pts);
                                    }
                                    break;
                                case "12":
                                    nom = "I.SANGARE*";
                                    price = 40000000;
                                    if (budjet >= 40000000)
                                    {
                                        Console.WriteLine("Vous avez acheté : " + nom);
                                        mouvant = new Random().Next(0, 5);
                                        pts = pts + mouvant;
                                        budjet = budjet - 40000000;
                                    }
                                    else
                                    {
                                        EchecTransfert p1 = new EchecTransfert(nom, 0, pts);
                                    }
                                    break;
                                default:
                                    NonAchat pA = new NonAchat(nom, 0, pts);
                                    price = 99999999;
                                    break;
                            }
                            break;
                        case "3":
                            Console.Clear();
                            Console.WriteLine("BUDJET : " + budjet + " $"); // Rappel du budjet du club choisi
                            Console.WriteLine(" ");
                            Console.WriteLine("AJ AUXERRE");
                            Console.WriteLine("  1- A.NGANDO*");
                            Console.WriteLine("  2- H.SAKHI*");
                            Console.WriteLine("DFCO");
                            Console.WriteLine("  3- N.AGUERD*");
                            Console.WriteLine("STADE DE REIMS");
                            Console.WriteLine("  4- A.DISASI*");
                            Console.WriteLine("RACING CLUB DE STRASBOURG");
                            Console.WriteLine("  5- N.DA COSTA*");
                            Console.WriteLine("  6- B.KAMARA*");
                            Console.WriteLine("  7- K.LALA");
                            Console.WriteLine("ESTAC TROYES");
                            Console.WriteLine("  8- R.RAVELOSON*");
                            Console.WriteLine(" ");
                            Console.Write("Votre transfert : ");
                            transfert = (Console.ReadLine());
                            Console.Clear();
                            switch (transfert)
                            {
                                case "1":
                                    nom = "A.NGANDO*";
                                    price = 3000000;
                                    if (nom != achat1 & nom != achat2 & price < budjet)
                                    {
                                        Console.WriteLine("Vous avez acheté : " + nom);
                                        mouvant = mouvant + new Random().Next(1, 8);
                                        budjet = budjet - price;
                                    }
                                    else
                                    {
                                        EchecTransfert p1 = new EchecTransfert(nom, 0, pts);
                                        verif1 = 1;
                                    }
                                    break;
                                case "2":
                                    nom = "H.SAKHI*";
                                    price = 20000000;
                                    if (nom != achat1 & nom != achat2 & price < budjet)
                                    {
                                        Console.WriteLine("Vous avez acheté : " + nom);
                                        mouvant = mouvant + new Random().Next(0, 16);
                                        budjet = budjet - price;
                                    }
                                    else
                                    {
                                        EchecTransfert p1 = new EchecTransfert(nom, 0, pts);
                                        verif1 = 1;
                                    }
                                    break;
                                case "3":
                                    nom = "N.AGUERD*";
                                    price = 3000000;
                                    if (nom != achat1 & nom != achat2 & price < budjet)
                                    {
                                        Console.WriteLine("Vous avez acheté : " + nom);
                                        mouvant = mouvant + new Random().Next(0, 7);
                                        budjet = budjet - price;
                                    }
                                    else
                                    {
                                        EchecTransfert p1 = new EchecTransfert(nom, 0, pts);
                                        verif1 = 1;
                                    }
                                    break;
                                case "4":
                                    nom = "A.DISASI*";
                                    price = 25000000;
                                    if (nom != achat1 & nom != achat2 & price < budjet)
                                    {
                                        Console.WriteLine("Vous avez acheté : " + nom);
                                        mouvant = mouvant + new Random().Next(0, 3);
                                        budjet = budjet - price;
                                    }
                                    else
                                    {
                                        EchecTransfert p1 = new EchecTransfert(nom, 0, pts);
                                        verif1 = 1;
                                    }
                                    break;
                                case "5":
                                    nom = "N.DA COSTA*";
                                    price = 20000000;
                                    if (nom != achat1 & nom != achat2 & price < budjet)
                                    {
                                        Console.WriteLine("Vous avez acheté : " + nom);
                                        mouvant = mouvant + new Random().Next(1, 22);
                                        budjet = budjet - price;
                                    }
                                    else
                                    {
                                        EchecTransfert p1 = new EchecTransfert(nom, 0, pts);
                                        verif1 = 1;
                                    }
                                    break;
                                case "6":
                                    nom = "B.KAMARA*";
                                    price = 3000000;
                                    if (nom != achat1 & nom != achat2 & price < budjet)
                                    {
                                        Console.WriteLine("Vous avez acheté : " + nom);
                                        mouvant = mouvant + new Random().Next(0, 11);
                                        budjet = budjet - price;
                                    }
                                    else
                                    {
                                        EchecTransfert p1 = new EchecTransfert(nom, 0, pts);
                                        verif1 = 1;
                                    }
                                    break;
                                case "7":
                                    nom = "K.LALA";
                                    price = 30000000;
                                    if (nom != achat1 & nom != achat2 & price < budjet)
                                    {
                                        Console.WriteLine("Vous avez acheté : " + nom);
                                        mouvant = mouvant + new Random().Next(0, 20);
                                        budjet = budjet - price;
                                    }
                                    else
                                    {
                                        EchecTransfert p1 = new EchecTransfert(nom, 0, pts);
                                        verif1 = 1;
                                    }
                                    break;
                                case "8":
                                    nom = "R.RAVELOSON*";
                                    price = 20000000;
                                    if (nom != achat1 & nom != achat2 & price < budjet)
                                    {
                                        Console.WriteLine("Vous avez acheté : " + nom);
                                        mouvant = mouvant + new Random().Next(0, 11);
                                        budjet = budjet - price;
                                    }
                                    else
                                    {
                                        EchecTransfert p1 = new EchecTransfert(nom, 0, pts);
                                        verif1 = 1;
                                    }
                                    break;
                                default:
                                    NonAchat pA = new NonAchat(nom, 0, pts);
                                    price = 999999999;
                                    break;
                            }
                            break;
                        case "5":
                            Console.Clear();
                            Console.WriteLine("BUDJET : " + budjet + " $"); // Rappel du budjet du club choisi
                            Console.WriteLine(" ");
                            Console.WriteLine("HERTA BERLIN (ALL)");
                            Console.WriteLine("  1- K.REKIK*");
                            Console.WriteLine("EVERTON (ANG)");
                            Console.WriteLine("  2- R.RODRIGUEZ*");
                            Console.WriteLine("WOLVERHAMPTON (ANG)");
                            Console.WriteLine("  3- R.SAISS*");
                            Console.WriteLine("BETIS SEVILLE (ESP)");
                            Console.WriteLine("  4- A.MANDI*");
                            Console.WriteLine("BENEVENTO (ITA)");
                            Console.WriteLine("  5- B.DABO*");
                            Console.WriteLine(" ");
                            Console.Write("Votre transfert : ");
                            string transfert3 = (Console.ReadLine());
                            Console.Clear();
                            switch (transfert3)
                            {
                                case "1":
                                    nom = "K.REKIK*";
                                    price = 20000000;
                                    if (nom != achat1 & nom != achat2 & price < budjet)
                                    {
                                        Console.WriteLine("Vous avez acheté : " + nom);
                                        mouvant = mouvant + new Random().Next(0, 8);
                                        budjet = budjet - price;
                                    }
                                    else
                                    {
                                        EchecTransfert p1 = new EchecTransfert(nom, 0, pts);
                                        verif1 = 1;
                                    }
                                    break;
                                case "2":
                                    nom = "R.RODRIGUEZ*";
                                    price = 30000000;
                                    if (nom != achat1 & nom != achat2 & price < budjet)
                                    {
                                        Console.WriteLine("Vous avez acheté : " + nom);
                                        mouvant = mouvant + new Random().Next(0, 31);
                                        budjet = budjet - price;
                                    }
                                    else
                                    {
                                        EchecTransfert p1 = new EchecTransfert(nom, 0, pts);
                                        verif1 = 1;
                                    }
                                    break;
                                case "3":
                                    nom = "R.SAISS*";
                                    price = 20000000;
                                    if (nom != achat1 & nom != achat2 & price < budjet)
                                    {
                                        Console.WriteLine("Vous avez acheté : " + nom);
                                        mouvant = mouvant + new Random().Next(0, 10);
                                        budjet = budjet - price;
                                    }
                                    else
                                    {
                                        EchecTransfert p1 = new EchecTransfert(nom, 0, pts);
                                        verif1 = 1;
                                    }
                                    break;
                                case "4":
                                    nom = "A.MANDI*";
                                    price = 40000000;
                                    if (nom != achat1 & nom != achat2 & price < budjet)
                                    {
                                        Console.WriteLine("Vous avez acheté : " + nom);
                                        mouvant = mouvant + new Random().Next(0, 15);
                                        budjet = budjet - price;
                                    }
                                    else
                                    {
                                        EchecTransfert p1 = new EchecTransfert(nom, 0, pts);
                                        verif1 = 1;
                                    }
                                    break;
                                case "5":
                                    nom = "B.DABO*";
                                    price = 20000000;
                                    if (nom != achat1 & nom != achat2 & price < budjet)
                                    {
                                        Console.WriteLine("Vous avez acheté : " + nom);
                                        mouvant = mouvant + new Random().Next(0, 12);
                                        budjet = budjet - price;
                                    }
                                    else
                                    {
                                        EchecTransfert p1 = new EchecTransfert(nom, 0, pts);
                                        verif1 = 1;
                                    }
                                    break;
                                default:
                                    NonAchat pA = new NonAchat(nom, 0, pts);
                                    price = 999999999;
                                    break;
                            }
                            break;
                        case "6":
                            Console.Clear();
                            Console.WriteLine("BUDJET : " + budjet + " $"); // Rappel du budjet du club choisi
                            Console.WriteLine(" ");
                            Console.WriteLine("RECHERCHE PAR NOM"); // Annonce du fonctionnement de la recherche
                            Console.Write("RECHERCHE ? ");
                            string sherch_t = (Console.ReadLine());
                            if (sherch_t == "DIONY") // Si le joueur cherché existe dans cette catégorie de joueur au potentiel maximum
                            {
                                Console.WriteLine(" JOUEUR RETROUVE : " + sherch_t); // Annonce du fontionnement de la recherche
                                nom = "L.DIONY";
                                price = 20000000;
                                if (nom != achat1 & nom != achat2 & price < budjet)
                                {
                                    Console.WriteLine("Vous avez acheté : " + nom);
                                    mouvant = mouvant + new Random().Next(0, 31);
                                    budjet = budjet - price;
                                }
                                else
                                {
                                    EchecTransfert p1 = new EchecTransfert(nom, 0, pts);
                                    verif1 = 1;
                                }
                                break;
                            }
                            break;
                        case "9":
                            nb_transfert = 3;
                            cumulable = cumulable + 1;
                            break;
                        default:
                            NonAchat pAAAAA = new NonAchat(nom, 0, pts);
                            break;
                    }
                    nb_transfert = nb_transfert + 1;  // Incrémentation du compteur de transfert
                    if (nb_transfert == 1 & verif1 == 0)
                    {
                        achat1 = nom;
                    }
                    if (nb_transfert == 2 & verif1 == 0)
                    {
                        if (achat1 == nom)  // Test pour savoir si le joueur a déjà été achété ou prolongé
                        {
                            Console.WriteLine("DEJA  ACHETE !!!");
                        }
                        else
                        {
                            achat2 = nom;
                        }
                    }
                    if (nb_transfert == 3 & verif1 == 0)
                    {
                        if (achat1 == nom || achat2 == nom) // Test pour savoir si le joueur a déjà été achété ou prolongé
                        {
                            Console.WriteLine("DEJA  ACHETE !!!");
                        }
                        else
                        {
                            achat3 = nom;
                        }
                    }
                    Console.WriteLine(" ");
                    if (mouvant > 30)
                    {
                        mouvant = 30;
                    }
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine(Equipe + ", CONTRAT POUR : "); // Rappel la liste des nouveaux contrats
                    Console.WriteLine(" " + achat1); // Rappel le 1er joueur prolongé/acheté
                    Console.WriteLine(" " + achat2); // Rappel le 2nd joueur prolongé/acheté
                    Console.WriteLine(" " + achat3); // Rappel le 3ème joueur prolongé/acheté
                    Console.WriteLine(" ");
                    Console.ReadLine();
                    Console.WriteLine("NOUVEAU BUDJET : " + budjet + " $"); // Affichage du budjet après transfert
                    if (price > budjeti)
                    {
                        nom = " ";
                    }
                    Console.ReadLine();
                    Console.Clear();
                }
                Console.WriteLine("STAGE D'ETE");
                Console.WriteLine("  1- SAINT-JEAN-BONNEFONDS (42)");
                Console.WriteLine("  2- LE CHAMBON-SUR-LIGNON (43)");
                Console.WriteLine("  3- ALBERTVILLE(74)");
                Console.WriteLine("  4- EVIAN-LES-BAINS (74)");
                Console.WriteLine("  5- MURCIE (ESP)");
                Console.WriteLine("  6- LOS ANGELES (USA)");
                Console.WriteLine(" ");
                Console.Write("Votre choix : ");
                string amical = (Console.ReadLine());
                Console.Clear();
                switch (amical) // Switch du lieu de stage
                {
                    case "1":
                        if (Equipe != "A.S.S.E") // Condition bloquant les amicaux ASSE VS ASSE
                        {
                            lieu = "SAINT-JEAN-BONNEFONDS (42)";
                            Console.WriteLine("LIEU DU STAGE : " + lieu); // Annonce le lieu du stage d'été
                            Console.ReadLine();
                            Console.Clear();
                            Console.WriteLine("  AMICAL VS A.S.S.E :");
                            Console.WriteLine("LIEU : ENVOL-STADIUM (42160- ANDREZIEUX-BOUTHEON)"); // Annonce du lieu du match
                            domicile = new Random().Next(0, 5);
                            exterieur = new Random().Next(0, 5);
                            spectateur = new Random().Next(0, 5001);
                            Console.ReadLine();
                            adversaire = "ASSE";
                            ASSE A1 = new ASSE(domicile, achat1, achat2, achat3, mouvant, Equipe, pts, exterieur, spectateur, adversaire);
                            bm_glb = bm_glb + exterieur; // On ajoute les buts marqués lors du dernier match au compteur de buts marqués
                            be_glb = be_glb + domicile; // On ajoute les buts encaissés lors du dernier match au compteur de buts encaissés
                            if (exterieur > domicile) // Si notre équipe à gagné un match
                            {
                                victoire_glb = victoire_glb + 1; // On incrémente le compteur de victoire final de +1
                            }
                            if (exterieur == domicile)
                            {
                                nul_glb = nul_glb + 1; // On incrémente le compteur de match nul final de +1
                            }
                            if (exterieur < domicile) // On ajoute les buts encaaissés lors du dernier match au compteur de buts encaissés
                            {
                                df_glb = df_glb + 1; // On incrémente le compteur de défaite final de +1
                            }
                        }
                        if (Equipe != "OL") // Condition bloquant les amicaux OL VS OL
                        {
                            domicile = new Random().Next(0, 5);
                            exterieur = new Random().Next(0, 5);
                            spectateur = new Random().Next(0, 4612);
                            Console.WriteLine("  AMICAL VS OL :");
                            Console.WriteLine("LIEU : STADE DARRAGON (03200- VICHY)"); // Annonce du lieu du match
                            Console.ReadLine();
                            adversaire = "OL";
                            OL A1 = new OL(domicile, nom, mouvant, Equipe, pts, exterieur, spectateur);
                            bm_glb = bm_glb + exterieur; // On ajoute les buts marqués lors du dernier match au compteur de buts marqués
                            be_glb = be_glb + domicile; // On ajoute les buts encaissés lors du dernier match au compteur de buts encaissés
                            if (exterieur > domicile) // Si notre équipe à gagné un match
                            {
                                victoire_glb = victoire_glb + 1; // On incrémente le compteur de victoire final de +1
                            }
                            if (exterieur == domicile)
                            {
                                nul_glb = nul_glb + 1; // On incrémente le compteur de match nul final de +1
                            }
                            if (exterieur < domicile) // On ajoute les buts encaaissés lors du dernier match au compteur de buts encaissés
                            {
                                df_glb = df_glb + 1; // On incrémente le compteur de défaite final de +1
                            }
                        }
                        break;
                    case "2":
                        lieu = "LE CHAMBON-SUR-LIGNON (43)";
                        Console.WriteLine("LIEU DU STAGE : " + lieu); // Annonce le lieu du stage d'été
                        Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("  AMICAL VS MONTPELLIER HERAULT SPORTING CLUB :");
                        Console.WriteLine("LIEU : STADE DU VIOUZOU (43000- ESPALY-SAINT-MARCEL)"); // Annonce du lieu du match
                        Console.ReadLine();
                        domicile = new Random().Next(0, 5);
                        exterieur = new Random().Next(0, 5);
                        spectateur = new Random().Next(0, 3600);
                        adversaire = "MHSC";
                        MHSC M1 = new MHSC(domicile, nom, mouvant, Equipe, pts, exterieur, spectateur);
                        bm_glb = bm_glb + exterieur; // On ajoute les buts marqués lors du dernier match au compteur de buts marqués
                        be_glb = be_glb + domicile; // On ajoute les buts encaissés lors du dernier match au compteur de buts encaissés
                        if (exterieur > domicile) // Si notre équipe à gagné un match
                        {
                            victoire_glb = victoire_glb + 1; // On incrémente le compteur de victoire final de +1
                        }
                        if (exterieur == domicile)
                        {
                            nul_glb = nul_glb + 1; // On incrémente le compteur de match nul final de +1
                        }
                        if (exterieur < domicile) // On ajoute les buts encaaissés lors du dernier match au compteur de buts encaissés
                        {
                            df_glb = df_glb + 1; // On incrémente le compteur de défaite final de +1
                        }
                        break;
                    case "3":
                        lieu = "ALBERTVILLE (74)";
                        Console.WriteLine("LIEU DU STAGE : " + lieu); // Annonce le lieu du stage d'été
                        Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine(Equipe + " : PAS DE MATCHS AMICAUX");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case "4":
                        lieu = "EVIAN-LES-BAINS (74)";
                        Console.WriteLine("LIEU DU STAGE : " + lieu); // Annonce le lieu du stage d'été
                        Console.ReadLine();
                        Console.Clear();
                        if (Equipe != "AS MONACO FC") // Condition bloquant les amicaux AS MONACO FC VS AS MONACO FC
                        {
                            domicile = new Random().Next(0, 5);
                            exterieur = new Random().Next(0, 5);
                            spectateur = new Random().Next(0, 15715);
                            Console.WriteLine("  AMICAL VS AS MONACO FC :");
                            Console.WriteLine("LIEU : PARC DES SPORTS D'EVIAN (74000- ANNECY)"); // Annonce du lieu du match
                            Console.ReadLine();
                            ASM A1 = new ASM(domicile, achat1, achat2, achat3, mouvant, Equipe, pts, exterieur, spectateur, adversaire);
                            bm_glb = bm_glb + exterieur; // On ajoute les buts marqués lors du dernier match au compteur de buts marqués
                            be_glb = be_glb + domicile; // On ajoute les buts encaissés lors du dernier match au compteur de buts encaissés
                            if (exterieur > domicile) // Si notre équipe à gagné un match
                            {
                                victoire_glb = victoire_glb + 1; // On incrémente le compteur de victoire final de +1
                            }
                            if (exterieur == domicile)
                            {
                                nul_glb = nul_glb + 1; // On incrémente le compteur de match nul final de +1
                            }
                            if (exterieur < domicile) // On ajoute les buts encaaissés lors du dernier match au compteur de buts encaissés
                            {
                                df_glb = df_glb + 1; // On incrémente le compteur de défaite final de +1
                            }
                        }
                        else
                        {
                            Console.WriteLine(Equipe + " : PAS DE MATCHS AMICAUX");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        break;
                    case "5":
                        lieu = "MURCIE (ESP)";
                        Console.WriteLine("LIEU DU STAGE : " + lieu); // Annonce le lieu du stage d'été
                        Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine(Equipe + " : PAS DE MATCHS AMICAUX");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case "6":
                        lieu = "LOS ANGELES (USA)";
                        Console.WriteLine("LIEU DU STAGE : " + lieu); // Annonce le lieu du stage d'été
                        Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine(Equipe + " : PAS DE MATCHS AMICAUX");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine(Equipe + " : PAS DE MATCHS AMICAUX");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                }
                adversaire = " ";
                if (Equipe == qualification || D1 == true && Equipe == Equipe_avant)
                {
                    domicile = new Random().Next(0, 4); // Variable permettant de définir le nombre de buts encaissés à l'issue du Trophée des champions
                    exterieur = new Random().Next(0, 4);  // Variable permettant de définir le nombre de buts marqués à l'issue du Trophée des champions
                    int tab = new Random().Next(0, 2); // Variable qui sert à définir la vainqueur du Trophée des champions en cas de tirs aux buts
                    spectateur = new Random().Next(0, 81339);
                    Tdc Trophée1 = new Tdc(domicile, Equipe, exterieur, spectateur, Equipe_avant, qualification, tab, Equipe_avant2, qualification2);
                    Console.ReadLine();
                    Console.Clear();
                    if (domicile > exterieur || tab == 1 && domicile == exterieur)
                    {
                        tdc = tdc + 1; // Incrémente +1 au compteur de trophée des champions
                    }
                    qualification = " ";
                }
                if (Equipe == "A.S.S.E" & saison % 2 == 1 & division == "LIGUE 1 Uber Eats")
                {
                    ouverture = new Random().Next(2, 5);
                }
                if (Equipe == "OL" & saison % 2 == 1 & division == "LIGUE 1 Uber Eats")
                {
                    ouverture = new Random().Next(1, 4);
                }
                if (Equipe == "AS MONACO FC" & saison % 2 == 1 & division == "LIGUE 1 Uber Eats")
                {
                    ouverture = new Random().Next(1, 5);
                    while (ouverture == 2)
                    {
                        ouverture = new Random().Next(1, 5);
                    }
                }
                if (Equipe != "OL" & Equipe != "AS MONACO FC" & Equipe != "A.S.S.E" & saison % 2 == 1 & division == "LIGUE 1 Uber Eats")
                {
                    ouverture = new Random().Next(1, 5);
                }
                if (saison % 2 == 0)
                {
                    ouverture = 0;
                }
                if (ouverture == 1)
                {
                    if (Equipe == "PARIS SAINT-GERMAIN")
                    {
                        domicile = new Random().Next(0, 4);
                        exterieur = new Random().Next(0, 6);
                        spectateur = new Random().Next(27500, 41966);
                    }
                    else
                    {
                        domicile = new Random().Next(0, 5);
                        exterieur = new Random().Next(0, 5);
                        spectateur = new Random().Next(1000, 41966);
                    }
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("   JOURNEE 1, LIGUE 1 Uber Eats VS A.S.S.E :"); // Annonce de la première journée de championnat
                    Console.WriteLine("LIEU : STADE GEOFFROY-GUICHARD (42000- SAINT-ETIENNE)"); // Annonce du lieu de la journée
                    Console.ReadLine();
                    adversaire = "A.S.S.E";
                    ASSE J1 = new ASSE(domicile, achat1, achat2, achat3, mouvant, Equipe, pts, exterieur, spectateur, adversaire);
                    bm_glb = bm_glb + exterieur; // On ajoute les buts marqués lors du dernier match au compteur de buts marqués
                    be_glb = be_glb + domicile; // On ajoute les buts encaissés lors du dernier match au compteur de buts encaissés
                    if (exterieur > domicile) // Si notre équipe à gagné un match
                    {
                        victoire_glb = victoire_glb + 1; // On incrémente le compteur de victoire final de +1
                    }
                    if (exterieur == domicile)
                    {
                        nul_glb = nul_glb + 1; // On incrémente le compteur de match nul final de +1
                    }
                    if (exterieur < domicile) // On ajoute les buts encaaissés lors du dernier match au compteur de buts encaissés
                    {
                        df_glb = df_glb + 1; // On incrémente le compteur de défaite final de +1
                    }
                }
                if (ouverture == 2)
                {
                    spectateur = new Random().Next(0, 18524);
                    if (Equipe == "PARIS SAINT-GERMAIN")
                    {
                        domicile = new Random().Next(0, 4);
                        exterieur = new Random().Next(0, 6);
                    }
                    else
                    {
                        domicile = new Random().Next(0, 5);
                        exterieur = new Random().Next(0, 5);
                    }
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("   JOURNEE 1, LIGUE 1 Uber Eats VS AS MONACO FC :"); // Annonce de la première journée de championnat
                    Console.WriteLine("LIEU : STADE LOUIS-II (MONACO)"); // Annonce du lieu de la journée
                    Console.ReadLine();
                    ASM J1 = new ASM(domicile, achat1, achat2, achat3, mouvant, Equipe, pts, exterieur, spectateur, adversaire);
                    bm_glb = bm_glb + exterieur; // On ajoute les buts marqués lors du dernier match au compteur de buts marqués
                    be_glb = be_glb + domicile; // On ajoute les buts encaissés lors du dernier match au compteur de buts encaissés
                    if (exterieur > domicile) // Si notre équipe à gagné un match
                    {
                        victoire_glb = victoire_glb + 1; // On incrémente le compteur de victoire final de +1
                    }
                    if (exterieur == domicile)
                    {
                        nul_glb = nul_glb + 1; // On incrémente le compteur de match nul final de +1
                    }
                    if (exterieur < domicile) // On ajoute les buts encaaissés lors du dernier match au compteur de buts encaissés
                    {
                        df_glb = df_glb + 1; // On incrémente le compteur de défaite final de +1
                    }
                    adversaire = "AS MONACO FC";
                }
                if (ouverture == 3)
                {
                    spectateur = new Random().Next(0, 32901);
                    if (Equipe == "PARIS SAINT-GERMAIN")
                    {
                        domicile = new Random().Next(0, 4);
                        exterieur = new Random().Next(0, 6);
                    }
                    else
                    {
                        domicile = new Random().Next(0, 5);
                        exterieur = new Random().Next(0, 5);
                    }
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("   JOURNEE 1, LIGUE 1 Uber Eats VS MONTPELLIER HERAULT SC :"); // Annonce de la première journée de championnat
                    Console.WriteLine("LIEU : STADE DE LA MOISSON (34080- MONTPELLIER)"); // Annonce du lieu de la journée
                    Console.ReadLine();
                    MHSC J1 = new MHSC(domicile, nom, mouvant, Equipe, pts, exterieur, spectateur);
                    adversaire = "MONTPELLIER";
                    bm_glb = bm_glb + exterieur; // On ajoute les buts marqués lors du dernier match au compteur de buts marqués
                    be_glb = be_glb + domicile; // On ajoute les buts encaissés lors du dernier match au compteur de buts encaissés
                    if (exterieur > domicile) // Si notre équipe à gagné un match
                    {
                        victoire_glb = victoire_glb + 1; // On incrémente le compteur de victoire final de +1
                    }
                    if (exterieur == domicile)
                    {
                        nul_glb = nul_glb + 1; // On incrémente le compteur de match nul final de +1
                    }
                    if (exterieur < domicile) // On ajoute les buts encaaissés lors du dernier match au compteur de buts encaissés
                    {
                        df_glb = df_glb + 1; // On incrémente le compteur de défaite final de +1
                    }
                }
                if (ouverture == 4)
                {
                    if (Equipe == "PARIS SAINT-GERMAIN")
                    {
                        domicile = new Random().Next(0, 4);
                        exterieur = new Random().Next(0, 6);
                        spectateur = new Random().Next(45000, 59168);
                        exterieur = 5;
                    }
                    else
                    {
                        domicile = new Random().Next(0, 5);
                        exterieur = new Random().Next(0, 5);
                        spectateur = new Random().Next(1000, 59168);
                    }
                    Console.WriteLine("  JOURNEE 1, LIGUE 1 Uber Eats VS OL :"); // Annonce de la première journée de championnat
                    Console.WriteLine("LIEU : GROUPAMA STADIUM"); // Annonce du lieu de la journée
                    Console.ReadLine();
                    OL J1 = new OL(domicile, nom, mouvant, Equipe, pts, exterieur, spectateur);
                    adversaire = "OL";
                    bm_glb = bm_glb + exterieur; // On ajoute les buts marqués lors du dernier match au compteur de buts marqués
                    be_glb = be_glb + domicile; // On ajoute les buts encaissés lors du dernier match au compteur de buts encaissés
                    if (exterieur > domicile) // Si notre équipe à gagné un match
                    {
                        victoire_glb = victoire_glb + 1; // On incrémente le compteur de victoire final de +1
                    }
                    if (exterieur == domicile)
                    {
                        nul_glb = nul_glb + 1; // On incrémente le compteur de match nul final de +1
                    }
                    if (exterieur < domicile) // On ajoute les buts encaaissés lors du dernier match au compteur de buts encaissés
                    {
                        df_glb = df_glb + 1; // On incrémente le compteur de défaite final de +1
                    }
                }
                int pt = 0;
                if (saison % 2 == 1 & division == "LIGUE 1 Uber Eats")
                {
                    if (domicile > exterieur & saison == 1)
                    {
                        pt = 0;
                        Console.WriteLine("1er : " + adversaire + " (3 pts)");
                        Console.WriteLine("[...]");
                        Console.WriteLine("20ème : " + Equipe + " (0 pt)");
                    }
                    if (domicile == exterieur & saison == 1)
                    {
                        pt = 1;
                        Console.WriteLine("1er : " + Equipe + " (1 pt)");
                        Console.WriteLine("2ème : " + adversaire + " (1 pt)");
                    }
                    if (domicile < exterieur & saison == 1)
                    {
                        pt = 3;
                        Console.WriteLine("1er : " + Equipe + " (3 pts)");
                        Console.WriteLine("[...]");
                        Console.WriteLine("20ème : " + adversaire + " (0 pt)");
                    }
                    if (saison % 2 == 1)
                    {
                        pts = pts + pt;
                        Console.ReadLine();
                        Console.Clear();
                    }
                }
                team = " ";
                if (division == "LIGUE 1 Uber Eats") // Test si le club joue en D1 française
                {
                    national = new Random().Next(1, 65); // L'équipe rentre en lice en 32° de finale
                    salaire_entraineur = salaire_entraineur + 15000 * 12;
                }
                if (division == "Domino's LIGUE 2") // Test si le club joue en D2 française
                {
                    national = new Random().Next(1, 129); // L'équipe rentre en lice en 64° de finale
                    salaire_entraineur = salaire_entraineur + 5000 * 12;
                }
                if (division == "NATIONAL FFF") // Test si le club joue en D3 française
                {
                    national = new Random().Next(1, 257); // L'équipe rentre en lice en 128° de finale
                    salaire_entraineur = salaire_entraineur + 2000 * 12;
                }
                string tour = "";
                if (national == 1)
                {
                    Console.WriteLine("VAINQUEUR DE LA COUPE DE FRANCE : " + Equipe); // Annonce du vainqueur de la Coupe de France de l'équipe choisi
                    coupe_de_france = coupe_de_france + 1;
                    if (Equipe == "LOSC")
                    {
                        team = "LOSC";
                        qualification2 = "  LOSC ";
                    }
                    if (Equipe == "A.S.S.E")
                    {
                        team = "A.S.S.E";
                        qualification2 = "A.S.S.E";
                    }
                    if (Equipe == "FC METZ")
                    {
                        team = "FC METZ";
                        qualification2 = "FC METZ";
                    }
                    if (Equipe == "ANGERS SCO")
                    {
                        team = "ANGERS SCO";
                        qualification2 = " ANGERS";
                    }
                    if (Equipe == "GIRONDIENS DE BORDEAUX")
                    {
                        team = "GIRONDIENS DE BORDEAUX";
                        qualification2 = "BORDEAU";
                    }
                    if (Equipe == "SB 29")
                    {
                        team = "SB 29";
                        qualification2 = " SB 29 ";
                    }
                    if (Equipe == "DFCO")
                    {
                        team = "DFCO";
                        qualification2 = "  DFCO ";
                    }
                    if (Equipe == "RCL")
                    {
                        team = "RCL";
                        qualification2 = "  RCL  ";
                    }
                    if (Equipe == "OL")
                    {
                        team = "OL";
                        qualification2 = "  OL   ";
                    }
                    if (Equipe == "OM")
                    {
                        team = "OM";
                        qualification2 = "  OM   ";
                    }
                    if (Equipe == "AS MONACO FC")
                    {
                        team = "AS MONACO FC";
                        qualification2 = " MONACO";
                    }
                    if (Equipe == "FC NANTES")
                    {
                        team = "FC NANTES";
                        qualification2 = " NANTES";
                    }
                    if (Equipe == "OGC NICE")
                    {
                        team = "OGC NICE";
                        qualification2 = "  NICE ";
                    }
                    if (Equipe == "NIMES OLYMPIQUES")
                    {
                        team = "NIMES OLYMPIQUES";
                        qualification2 = " NIMES ";
                    }
                    if (Equipe == "PARIS SAINT-GERMAIN")
                    {
                        team = "PARIS SAINT-GERMAIN";
                        qualification2 = "  PSG  ";
                    }
                    if (Equipe == "STADE DE REIMS")
                    {
                        team = "STADE DE REIMS";
                        qualification2 = " REIMS ";
                    }
                    if (Equipe == "STADE RENNAIS FC")
                    {
                        team = "STADE RENNAIS FC";
                        qualification2 = " RENNES";
                    }
                    if (Equipe == "RACING CLUB DE STRASBOURG")
                    {
                        team = "RACING CLUB DE STRASBOURG";
                        qualification2 = " RACING";
                    }
                    if (Equipe == "SC BASTIA")
                    {
                        team = "SC BASTIA";
                        qualification2 = " BASTIA";
                    }
                    if (Equipe == "F.C SETE")
                    {
                        team = "F.C SETE";
                        qualification2 = "FC SETE";
                    }
                    if (Equipe == "FC ANNECY")
                    {
                        team = "FC ANNECY";
                        qualification2 = " ANNECY";
                    }
                    if (Equipe == "ORLEANS LOIRET FOOTBALL")
                    {
                        team = "ORLEANS LOIRET FOOTBALL";
                        qualification2 = "ORLEANS";
                    }
                    if (Equipe == "STADE BRIOCHIN")
                    {
                        team = "STADE BRIOCHIN";
                        qualification2 = "STADE B";
                    }
                    if (Equipe == "USC")
                    {
                        team = "USC";
                        qualification2= "  USC  ";
                    }
                    if (Equipe == "SL")
                    {
                        team = "SL";
                        qualification2 = "  SL   ";
                    }
                    if (Equipe == "AC AJACCIO")
                    {
                        team = "ACA";
                        qualification2 = "  ACA  ";
                    }
                    if (Equipe == "A.J AUXERRE")
                    {
                        team = "A.J AUXERRE";
                        qualification2 = "AUXERRE";
                    }
                    if (Equipe == "CLERMONT FOOT 63")
                    {
                        team = "CLERMONT FOOT 63";
                        qualification2 = "CLERMON";
                    }
                    if (Equipe == "GF 38")
                    {
                        team = "GF 38";
                        qualification2 = " GF 38 ";
                    }
                    if (Equipe == "EAG")
                    {
                        team = "EAG";
                        qualification2 = "  EAG  ";
                    }
                    if (Equipe == "HAC")
                    {
                        team = "HAC";
                        qualification2 = "  HAC  ";
                    }
                    if (Equipe == "PARIS FC")
                    {
                        team = "PARIS FC";
                        qualification2 = "  PFC  ";
                    }
                    if (Equipe == "ASNL")
                    {
                        team = "ASNL";
                        qualification2 = "  ASNL ";
                    }
                    qualification = team;
                }
                else
                {
                    if (national == 3 || national == 4)
                    {
                        tour = "DEMI-FINALE";
                    }
                    if (national == 2)
                    {
                        tour = "FINALE";
                    }
                    if (national >= 5 & national < 9)
                    {
                        tour = "QUART DE FINALE";
                    }
                    if (national > 8 & national < 17)
                    {
                        tour = "8° DE FINALE";
                    }
                    if (national > 16 & national < 33)
                    {
                        tour = "16° DE FINALE";
                    }
                    if (national >= 33 & national < 65)
                    {
                        tour = "32° DE FINALE";
                    }
                    if (national > 64 & national < 129)
                    {
                        tour = "64° DE FINALE"; // Tour accesible uniquement si l'équipe évolue soit en NATIONAL FFF, soit en Domino's LIGUE 2
                    }
                    if (national > 128)
                    {
                        tour = "128° DE FINALE"; // Tour accesible uniquement si l'équipe évolue en NATIONAL FFF
                    }
                    Console.WriteLine(Equipe + " ELIMINE EN " + tour); // Annonce du moment de l'élimination de son équipe en coupe de France
                    def_v = new Random().Next(-8, 51); // Génère le vainqueur de la coupe de France aléatoirement
                    while (team == Equipe || team == " ") // Vérifie si il y a une incohérence dans le vainqueur de la Coupe de France
                    {
                        def_v = new Random().Next(-7, 51); // Redemande la génération d'un nouveau vainqueur de Coupe de France si le précedant était incohérant
                        if (def_v == 1)
                        {
                            team = "ANGERS SCO";
                            qualification2 = " ANGERS";
                        }
                        if (def_v == 2)
                        {
                            team = "GIRONDIENS DE BORDEAUX";
                            qualification2 = "BORDEAU";
                        }
                        if (def_v == 3)
                        {
                            team = "SB 29";
                            qualification2 = " SB 29 ";
                        }
                        if (def_v == 4)
                        {
                            team = "DFCO";
                            qualification2 = "  DFCO ";
                        }
                        if (def_v == 5)
                        {
                            team = "LOSC";
                            qualification2 = "  LOSC ";
                        }
                        if (def_v == 6)
                        {
                            team = "OL";
                            qualification2 = "  OL   ";
                        }
                        if (def_v == 7)
                        {
                            team = "OM";
                            qualification2 = "  OM   ";
                        }
                        if (def_v == 8)
                        {
                            team = "FC METZ";
                            qualification2 = "FC METZ";
                        }
                        if (def_v == 9)
                        {
                            team = "AS MONACO FC";
                            qualification2 = " MONACO";
                        }
                        if (def_v == 10)
                        {
                            team = "FC NANTES";
                            qualification2 = " NANTES";
                        }
                        if (def_v == 11)
                        {
                            team = "OGC NICE";
                            qualification2 = "  NICE ";
                        }
                        if (def_v == 12)
                        {
                            team = "NIMES OLYMPIQUES";
                            qualification2 = " NIMES ";
                        }
                        if (def_v == 13 || def_v < 1)
                        {
                            team = "PARIS SAINT-GERMAIN";
                            qualification2 = "  PSG  ";
                        }
                        if (def_v == 14)
                        {
                            team = "STADE DE REIMS";
                            qualification2 = " REIMS ";
                        }
                        if (def_v == 15)
                        {
                            team = "STADE RENNAIS FC";
                            qualification2 = " RENNES";
                        }
                        if (def_v == 16)
                        {
                            team = "A.S.S.E";
                            qualification2 = "A.S.S.E";
                        }
                        if (def_v == 17)
                        {
                            team = "RACING CLUB DE STRASBOURG";
                            qualification2 = " RACING";
                        }
                        if (def_v == 18)
                        {
                            team = "TFC";
                            qualification2 = "  TFC  ";
                        }
                        if (def_v == 19)
                        {
                            team = "AMIENS SC";
                            qualification2 = " AMIENS";
                        }
                        if (def_v == 20)
                        {
                            team = "MONTPELLIER HERAULT SPORTING CLUB";
                            qualification2 = "  MHSC ";
                        }
                        if (def_v == 21)
                        {
                            team = "FC LORIENT";
                            qualification2 = "LORIENT";
                        }
                        if (def_v == 22)
                        {
                            team = "PARIS FC";
                            qualification2 = "  PFC  ";
                        }
                        if (def_v == 23)
                        {
                            team = "QUEVILLY";
                            qualification2 = "QUEVILL";
                        }
                        if (def_v == 24)
                        {
                            team = "TOURS FC";
                            qualification2 = " TOURS ";
                        }
                        if (def_v == 25)
                        {
                            team = "ASNL";
                            qualification2 = " ASNL  ";
                        }
                        if (def_v == 26)
                        {
                            team = "CHAMOIS NIORTAIS";
                            qualification2 = "CHAMOIS";
                        }
                        if (def_v == 27)
                        {
                            team = "RED STAR FC";
                            qualification2 = "REDSTAR";
                        }
                        if (def_v == 28)
                        {
                            team = "US RAON-L'ETAPE";
                            qualification2 = " US RAON";
                        }
                        if (def_v == 29)
                        {
                            team = "LE PUY FOOT AUVERGNE";
                            qualification2 = " LE PUY";
                        }
                        if (def_v == 29)
                        {
                            team = "RODEZ AVEYRON FOOTBALL";
                            qualification2 = " RODEZ ";
                        }
                        if (def_v == 30)
                        {
                            team = "TRELISSAC FC";
                            qualification2 = "TRELISS";
                        }
                        if (def_v == 31)
                        {
                            team = "US BOULOGNE FC";
                            qualification2 = "BOULOGNE";
                        }
                        if (def_v == 32)
                        {
                            team = "U.S. CONCARNEAU";
                            qualification2 = "CONCARN";
                        }
                        if (def_v == 33)
                        {
                            team = "VANNES OLYMPIQUE CLUB";
                            qualification2 = "  VOC  ";
                        }
                        if (def_v == 34)
                        {
                            team = "FBBP 01";
                            qualification2 = "FBBP 01";
                        }
                        if (def_v == 35)
                        {
                            team = "C.A.BASTIA";
                            qualification2 = "CA BAST";
                        }
                        if (def_v == 36)
                        {
                            team = "SAS FOOTBALL EPINAL";
                            qualification2 = " EPINAL";
                        }
                        if (def_v == 37)
                        {
                            team = "VENDEE LES HERBIERS FOOTBALL";
                            qualification2 = "HERBIER";
                        }
                        if (def_v == 38)
                        {
                            team = "FC CHAMBLY 1989 OISE";
                            qualification2 = "CHAMBLY";
                        }
                        if (def_v == 39)
                        {
                            team = "ENTENTE SANNOIS SAINT GRATIEN";
                            qualification2 = "SANNOIS";
                        }
                        if (def_v == 40)
                        {
                            team = "LE MANS FC";
                            qualification2 = "LE MANS";
                        }
                        if (def_v == 40)
                        {
                            team = "CLUB SPORTIF SEDAN ARDENNES";
                            qualification2 = " SEDAN ";
                        }
                        if (def_v == 41)
                        {
                            team = "FOOTBALL CLUB ISTRES OUEST PROVENCE";
                            qualification2 = " ISTRES";
                        }
                        if (def_v == 42)
                        {
                            team = "ATHLETIC CLUB ARLESIEN";
                            qualification2 = "  ARLES ";
                        }
                        if (def_v == 43)
                        {
                            team = "GF 38";
                            qualification2 = " GF 38 ";
                        }
                        if (def_v == 44)
                        {
                            team = "RCL";
                            qualification2 = "  RCL  ";
                        }
                        if (def_v == 45)
                        {
                            team = "LBC";
                            qualification2 = "  LBC  ";
                        }
                        if (def_v == 46)
                        {
                            team = "SC BASTIA";
                            qualification2 = "SC BAST";
                        }
                        if (def_v == 47)
                        {
                            team = "A.J AUXERRE";
                            qualification2 = "AUXERRE";
                        }
                        if (def_v == 48)
                        {
                            team = "VAFC";
                            qualification2 = " VAFC  ";
                        }
                        if (def_v == 49)
                        {
                            team = "HAC";
                            qualification2 = "  HAC  ";
                        }
                        if (def_v == 50)
                        {
                            team = "EAG";
                            qualification2 = "  EAG  ";
                        }
                    }
                    Console.WriteLine("VAINQUEUR : " + team);
                    qualification = team;
                }
                Console.ReadLine();
                Console.Clear();
                if (pts == 113) // Gestion d'un cas réel impossible
                {
                    pts = 112;
                }
                Console.WriteLine("PTS : " + pts); // Annonce des pts de la saison
                pts_avant = pts;
                Equipe_avant = " "; // Incrémentatation de manière à fermer l'accès au Trophée des champions
                if (pts >= 80) // Test permettant de définir si l'équipe choisi est championne de son championnat
                {
                    Equipe_avant = Equipe; // Incrémentation de manière à ouvrir l'accès au Trophée des champions
                    Console.WriteLine("1er : " + Equipe); // Annonce de la première place de l'équipe choisie
                    if (pts == 112)
                    {
                        Console.WriteLine("(37-1-0)");
                    }
                    if (pts == 114)
                    {
                        Console.WriteLine("(38-0-0)");
                    }
                    if (division == "LIGUE 1 Uber Eats")
                    {
                        l1c = l1c + 1;
                        D1 = true;
                    }
                    if (division == "Domino's LIGUE 2")
                    {
                        dl2 = dl2 + 1;
                        D1 = false;
                    }
                    if (division == "NATIONAL FFF")
                    {
                        N = N + 1;
                        D1 = false;
                    }
                }
                if (pts >= 66 & division == "Domino's LIGUE 2") // On teste si l'équipe choisi de D2 sera promue en D1
                {
                    montee = 1;
                    attention = 0; // On remonte le prestige de l'entraineur suite à notre promotion
                    D1 = false;
                    Equipe_promu = Equipe;
                }
                if (pts >= 66 & division == "NATIONAL FFF") // On teste si l'équipe choisi de D3 sera promue en D2
                {
                    // montee = 1;
                    attention = 1; // On remonte le prestige de l'entraineur suite à notre promotion
                    D1 = false;
                    D2 = true;
                    Equipe_promuNAT = Equipe; //On récupère l'équipe qui monte en Domino's Ligue 2 depuis le NATIONAL FFF
                }
                if (pts < 15)
                {
                    Console.WriteLine("20ème : " + Equipe);
                    if (pts == 5)
                    {
                        int cas = new Random().Next(1, 3);
                        if (cas == 1)
                        {
                            Console.WriteLine("(0-5-33)");
                        }
                        else
                        {
                            Console.WriteLine("(1-2-35)");
                        }
                    }
                    if (pts == 4)
                    {
                        int cas = new Random().Next(1, 3);
                        if (cas == 1)
                        {
                            Console.WriteLine("(0-4-34)");
                        }
                        else
                        {
                            Console.WriteLine("(1-1-36)");
                        }
                    }
                    if (pts == 3)
                    {
                        int cas = new Random().Next(1, 3);
                        if (cas == 1)
                        {
                            Console.WriteLine("(0-3-35)");
                        }
                        else
                        {
                            Console.WriteLine("(1-0-37)");
                        }
                    }
                    if (pts == 2)
                    {
                        Console.WriteLine("(0-2-36)");
                    }
                    if (pts == 1)
                    {
                        Console.WriteLine("(0-1-37)");
                    }
                    if (pts == 0)
                    {
                        Console.WriteLine("(0-0-38)");
                    }
                }
                if (pts < 40 & pts >= 15 & division == "LIGUE 1 Uber Eats")
                {
                    int classement2 = new Random().Next(19, 21); // Permet de définir la place de votre équipe en cas de relégation
                    int relegation = new Random().Next(1, 3);
                    int pts1 = new Random().Next(16, 41);
                    int pts2 = new Random().Next(16, 41);
                    while (pts1 <= pts || pts1 < pts2 || pts2 < pts)
                    {
                        pts1 = new Random().Next(16, 41);
                        pts2 = new Random().Next(16, 41);
                    }
                    if (relegation == 1)
                    {
                        Console.WriteLine("18ème : FC LORIENT (" + pts1 + " PTS)");
                    }
                    else
                    {
                        Console.WriteLine("18ème : MONTPELLIER HERAULT SC (" + pts1 + " PTS)");
                    }
                    if (classement2 == 19)
                    {
                        while (pts2 > pts)
                        {
                            pts2 = new Random().Next(16, 41);
                        }
                        Console.WriteLine("19ème : " + Equipe + " (" + pts + " PTS)");
                        if (relegation == 1)
                        {
                            Console.WriteLine("20ème : MONTPELLIER HERAULT SC (" + pts2 + " PTS)");
                        }
                        else
                        {
                            Console.WriteLine("20ème : FC LORIENT (" + pts2 + " PTS)");
                        }
                    }
                    else
                    {
                        while (pts2 <= pts)
                        {
                            pts2 = new Random().Next(16, 41);
                        }
                        if (relegation == 1)
                        {
                            Console.WriteLine("19ème : MONTPELLIER HERAULT SC (" + pts2 + " PTS)");
                        }
                        else
                        {
                            Console.WriteLine("19ème : FC LORIENT (" + pts2 + " PTS)");
                        }
                        Console.WriteLine("20ème : " + Equipe + " (" + pts + " PTS)");
                    }
                }
                if (pts < 40 & pts >= 15 & division == "Domino's LIGUE 2")
                {
                    if (attention == 1)
                    {
                        def_v = new Random().Next(1, 22);
                    }
                    else
                    {
                        def_v = new Random().Next(1, 20);
                    }
                    team = " ";
                    int classement2 = new Random().Next(19, 21); // Détérmine le classement de rélégation lors d'une saison en division inférieure. 
                    int relegation = new Random().Next(1, 3);
                    int pts1 = new Random().Next(16, 41);
                    int pts2 = new Random().Next(16, 41);
                    while (team == Equipe || team == " ")
                    {
                        def_v = new Random().Next(1, 21);
                        if (def_v == 1)
                        {
                            team = "AC AJACCIO";
                        }
                        if (def_v == 2)
                        {
                            team = "A.J AUXERRE";
                        }
                        if (def_v == 3)
                        {
                            team = "ASC"; // MODIFS V21
                        }
                        if (def_v == 4)
                        {
                            team = "ASNL";
                        }
                        if (def_v == 5)
                        {
                            team = "CHAMOIS NIORTAIS FC";
                        }
                        if (def_v == 6)
                        {
                            team = "LA BERRICHONNE DE CHATEAUROUX";
                        }
                        if (def_v == 7)
                        {
                            team = "CLERMONT FOOT 63";
                        }
                        if (def_v == 8)
                        {
                            team = "EAG";
                        }
                        if (def_v == 9)
                        {
                            team = "ESTAC TROYES";
                        }
                        if (def_v == 10)
                        {
                            team = "FC CHAMBLY 1929 OISE";
                        }
                        if (def_v == 11)
                        {
                            team = "FCSM";
                        }
                        if (def_v == 12)
                        {
                            team = "GF 38";
                        }
                        if (def_v == 13)
                        {
                            team = "HAC";
                        }
                        if (def_v == 14)
                        {
                            team = "PARIS FC";
                        }
                        if (def_v == 15)
                        {
                            team = "PAU FC";
                        }
                        if (def_v == 16)
                        {
                            team = "RODEZ AVEYRON FOOTBALL 1929";
                        }
                        if (def_v == 17)
                        {
                            team = "STADE MALHERBE DE CAEN";
                        }
                        if (def_v == 18)
                        {
                            team = "TFC"; // MODIFS V21
                        }
                        if (def_v == 19)
                        {
                            team = "VAFC";
                        }
                        if (def_v == 20)
                        {
                            team = "MONTPELLIER HERAULT SPORTING CLUB";
                        }
                    }
                    while (pts1 <= pts || pts1 < pts2 || pts2 < pts)
                    {
                        pts1 = new Random().Next(16, 41);
                        pts2 = new Random().Next(16, 41);
                    }
                    if (relegation == 1)
                    {
                        Console.WriteLine("18ème : " + team + " (" + pts1 + " PTS)");
                    }
                    else
                    {
                        Console.WriteLine("18ème : USL DUNKERQUE (" + pts1 + " PTS)");
                    }
                    if (classement2 == 19)
                    {
                        while (pts2 > pts)
                        {
                            pts2 = new Random().Next(16, 41);
                        }
                        Console.WriteLine("19ème : " + Equipe + " (" + pts + " PTS)");
                        if (relegation == 1)
                        {
                            Console.WriteLine("20ème : USL DUNKERQUE (" + pts2 + " PTS)");
                        }
                        else
                        {
                            Console.WriteLine("20ème : " + team + " (" + pts2 + " PTS)");
                        }
                    }
                    else
                    {
                        while (pts2 <= pts)
                        {
                            pts2 = new Random().Next(16, 41);
                        }
                        if (relegation == 1)
                        {
                            Console.WriteLine("19ème : USL DUNKERQUE (" + pts2 + " PTS)");
                        }
                        else
                        {
                            Console.WriteLine("19ème : " + team + " (" + pts2 + " PTS)");
                        }
                        Console.WriteLine("20ème : " + Equipe + " (" + pts + " PTS)");
                    }
                }
                if (division == "LIGUE 1 Uber Eats" & pts >= 40)  // Test si l'équipe s'est maintenue en première division française
                {
                    Console.WriteLine("Votre équipe s'est maintenue en " + division + " !!!");
                }
                if (division == "Domino's LIGUE 2" & pts >= 40)  // Test si l'équipe s'est maintenue en première division française
                {
                    Console.WriteLine("Votre équipe s'est maintenue en " + division + " !!!");
                }
                if (pts < 40)
                {
                    Console.WriteLine(" ");
                    if (division == "LIGUE 1 Uber Eats")
                    {
                        attention = 1; // Changement du niveau de prestige de l'entraineur
                        division = "Domino's LIGUE 2";
                        changement_d = 1;
                        Equipe_descenteD1 = Equipe; // Prend l'équipe qui descend
                        Console.WriteLine(Equipe + " descend en " + division + "..."); // Annonce la descente de l'équipe en Domino's Ligue 2
                    }
                    if (division == "Domino's LIGUE 2" & changement_d == 0)
                    {
                        attention = 2; // Changement du niveau de prestige de l'entraineur
                        division = "NATIONAL FFF";
                        changement_d = 1;
                        Console.WriteLine(Equipe + " descend en " + division + "..."); // Annonce la descente de l'équipe en National 1
                        D2 = false;
                    }
                    if (division == "NATIONAL FFF" & changement_d == 0)
                    {
                        D3Classement MonDernierClassement = new D3Classement(Equipe, pts);
                        attention = 3; // Changement du niveau de prestige de l'entraineur
                        division = "NATIONAL 2 FFF"; // Mise à jour de la division pour la future saison de l'équipe actuelle
                        changement_d = 1;
                        Console.WriteLine(Equipe + " descend en " + division + "..."); // Annonce la descente de l'équipe en National 1
                    }
                }
                saison = saison + 1; // Incrémentation du nombre de saison joué
                Console.ReadLine();
                Console.Clear();
            }
            Console.WriteLine("FIN DE CARRIERE..."); // Annonce la fin de la carrière en tant qu'entraineur
            championnats = l1c + dl2; // Somme de l'ensemble des championnats
            coupes = coupe_de_france + tdc; // Calcul le nombre de coupes remportés
            saison = saison - 1; // On met la variable saison à sa valeur réelle pour le futur affichage
            FinCarrière MaCarrièrefin = new FinCarrière(coach, championnats, coupes, l1c, dl2, N, coupe_de_france, tdc, saison, saison_D1FR, saison_D2FR, saison_D3FR,  victoire_glb, nul_glb, df_glb, bm_glb, be_glb, salaire_entraineur); //Renvoie les stats de fin de la carrière 
            Console.WriteLine("EQUIPES COACHEES :");
            Console.WriteLine(" " + tableau[1]); // Renvoie l'équipe pris en saison 1
            if (tableau[1] != tableau[2] & saison > 1)
            {
                Console.WriteLine(" > " + tableau[2]); // Renvoie l'équipe pris en saison 2
            }
            if (tableau[1] == tableau[2] & saison > 1)
            {
                Console.WriteLine(" " + tableau[2]); // Renvoie l'équipe pris en saison 2
            }
            if (tableau[2] != tableau[3] & saison > 2)
            {
                Console.WriteLine(" > " + tableau[3]); // Renvoie l'équipe pris en saison 3
            }
            if (tableau[2] == tableau[3] & saison > 2)
            {
                Console.WriteLine(" " + tableau[3]); // Renvoie l'équipe pris en saison 3
            }
            if (tableau[3] != tableau[4] & saison > 3)
            {
                Console.WriteLine(" > " + tableau[4]); // Renvoie l'équipe pris en saison 4
            }
            if (tableau[3] == tableau[4] & saison > 3)
            {
                Console.WriteLine(" " + tableau[4]); // Renvoie l'équipe pris en saison 4
            }
            if (tableau[4] != tableau[5] & saison > 4)
            {
                Console.WriteLine(" > " + tableau[5]); // Renvoie l'équipe pris en saison 5
            }
            if (tableau[4] == tableau[5] & saison > 4)
            {
                Console.WriteLine(" " + tableau[5]); // Renvoie l'équipe pris en saison 5
            }
            Console.ReadLine();
            Console.Clear();
            Credit p2 = new Credit("test"); // Renvoie les crédits
        }

        static void Exit(string sortie) // Méthode qui force la sortie du programme pour éviter un mode non demandé en secondaire
        {
            Program.Exit(sortie);
        }

        static void HC() // Méthode pour aller dans l'objet qui gère la date système
        {
            string Date = DateTime.Now.ToString("dd-MM"); // Récuère la date courante sur le format Date + Mois
            HeureCourante maintenant = new HeureCourante(Date);
        }
    }
}
