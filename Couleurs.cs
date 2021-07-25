using System;

namespace _22FIFA
{
    class Couleurs
    {
        public Couleurs(string Equipe)
        {
            if (Equipe== "A.S.S.E") // Si l'équipe à une couleur dominante vert foncé
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
            }
            if (Equipe == "ANGERS SCO" || Equipe == "OL") // Si l'équipe à une couleur dominante blanche
            {
                Console.ForegroundColor = ConsoleColor.White;
            }
            if (Equipe == "ESTAC TROYES") // Si l'équipe à une couleur dominante bleu foncé
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
            }
            if (Equipe == "FC NANTES") // Si l'équipe à une couleur dominante jaune
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
            }
            if (Equipe == "RACING CLUB DE STRASBOURG" || Equipe == "OM") // Si l'équipe à une couleur dominante bleu cyan
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
            }
            if (Equipe == "VAFC" || Equipe == "OGC NICE" || Equipe == "AS MONACO FC" || Equipe == "LOSC" || Equipe == "DFCO" || Equipe == "SB 29" || Equipe == "STADE DE REIMS") // Si l'équipe à une couleur dominante rouge
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            if (Equipe == "NIMES OLYMPIQUES" || Equipe == "FC METZ") // Si l'équipe à une couleur dominante rouge foncé
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            if (Equipe == "RCL") // Si l'équipe à une couleur dominante jaune foncé
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
            }
           if (Equipe == "GIRONDIENS DE BORDEAUX" || Equipe == "PARIS SAINT-GERMAIN") // Si l'équipe à une couleur dominante bleu
            {
               Console.ForegroundColor = ConsoleColor.Blue;
           }
        }
    }
}
