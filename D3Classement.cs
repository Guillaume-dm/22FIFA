using System;

namespace _22FIFA
{
    class D3Classement
    {
        public D3Classement(string Equipe, int pts)
        {
            int place = 18; // Place par défaut si relégation en NATIONAL 2
            if (pts > 21) // On vérifie si le nombre de points obtenus est satisfaisant pour ne pas finir lanterne rouge du championnat
            {
                place = new Random().Next(15, 19);
            }
            int des1 = new Random().Next(1, 8);
            int des2 = new Random().Next(1, 8);
            int des3 = new Random().Next(1, 8);
            int pts1 = new Random().Next(21, 41); // Génère le nombre de point pour une des équipes de descente
            int pts2 = new Random().Next(21, 41); // Génère le nombre de point pour une des équipes de descente
            int pts3 = new Random().Next(21, 41); // Génère le nombre de point pour une des équipes de descente
            string D4A = " "; // Permettera de stocker la première équipe qui descendera en NATIONAL 2
            string D4B = " "; // Permettera de stocker la seconde équipe qui descendera en NATIONAL 2
            string D4C = " "; // Permettera de stocker la troisième équipe qui descendera en NATIONAL 2
            while (pts1 <= pts2 || pts2 <= pts3 || pts3 >= pts1)
            {
                pts1 = new Random().Next(21, 41);
                pts2 = new Random().Next(21, 41);
                pts3 = new Random().Next(21, 41);
            }
            while (D4A == Equipe || D4A == " ") // On vérifie qu'il y a 0 incohérence
            {
                des1 = new Random().Next(1, 8); // On redemande de générer une autre équipe que la précédante, cette dernière étant incohérente
                if (des1 == 1)
                {
                    D4A = "SC BASTIA";
                }
                if (des1 == 2)
                {
                    D4A = "F.C SETE";
                }
                if (des1 == 3)
                {
                    D4A = "FC ANNECY";
                }
                if (des1 == 4)
                {
                    D4A = "ORLEANS LOIRET FOOTBALL";
                }
                if (des1 == 5)
                {
                    D4A = "STADE BRIOCHIN";
                }
                if (des1 == 6)
                {
                    D4A = "USC";
                }
                if (des1 == 7)
                {
                    D4A = "SL";
                }
            }
            while (D4B == Equipe || D4B == D4A || D4B == " ") // On vérifie qu'il y a 0 incohérence
            {
                des2 = new Random().Next(1, 8); // On redemande de générer une autre équipe que la précédante, cette dernière étant incohérente
                if (des2 == 1)
                {
                    D4B = "SC BASTIA";
                }
                if (des2 == 2)
                {
                    D4B = "F.C SETE";
                }
                if (des2 == 3)
                {
                    D4B = "FC ANNECY";
                }
                if (des2 == 4)
                {
                    D4B = "ORLEANS LOIRET FOOTBALL";
                }
                if (des2 == 5)
                {
                    D4B = "STADE BRIOCHIN";
                }
                if (des2 == 6)
                {
                    D4B = "USC";
                }
                if (des2 == 7)
                {
                    D4B = "SL";
                }
            }
            while (D4C == Equipe || D4C == D4A || D4C == D4B || D4C == " ") // On vérifie qu'il y a 0 incohérence
            {
                des3 = new Random().Next(1, 8); // On redemande de générer une autre équipe que la précédante, cette dernière étant incohérente
                if (des3 == 1)
                {
                    D4C = "SC BASTIA";
                }
                if (des3 == 2)
                {
                    D4C = "F.C SETE";
                }
                if (des3 == 3)
                {
                    D4C = "FC ANNECY";
                }
                if (des3 == 4)
                {
                    D4C = "ORLEANS LOIRET FOOTBALL";
                }
                if (des3 == 5)
                {
                    D4C = "STADE BRIOCHIN";
                }
                if (des3 == 6)
                {
                    D4C = "USC";
                }
                if (des3 == 7)
                {
                    D4C = "SL";
                }
            }
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("SONT RELEGUES EN NATIONAL 2 : ");
            Console.WriteLine(" [...]");
            if (pts>=pts1 & pts1>=pts2 & pts2 >= pts3)
            {
                Console.WriteLine(" 15°- " + Equipe + " : " + pts + " PTS");
                Console.WriteLine(" 16°- " + D4A + " : " + pts1 + " PTS");
                Console.WriteLine(" 17°- " + D4B + " : " + pts2 + " PTS");
                Console.WriteLine(" 18°- " + D4C + " : " + pts3 + " PTS");
                Console.ReadLine();
            }
            if (pts1 >= pts & pts >= pts2 & pts2 >= pts3)
            {
                Console.WriteLine(" 15°- " + D4A + " : " + pts1 + " PTS");
                Console.WriteLine(" 16°- " + Equipe + " : " + pts + " PTS");
                Console.WriteLine(" 17°- " + D4B + " : " + pts2 + " PTS");
                Console.WriteLine(" 18°- " + D4C + " : " + pts3 + " PTS");
                Console.ReadLine();
            }
            if (pts1 >= pts2 & pts2 >= pts & pts >= pts3)
            {
                Console.WriteLine(" 15°- " + D4A + " : " + pts1 + " PTS");
                Console.WriteLine(" 16°- " + D4B + " : " + pts2 + " PTS");
                Console.WriteLine(" 17°- " + Equipe + " : " + pts + " PTS");
                Console.WriteLine(" 18°- " + D4C + " : " + pts3 + " PTS");
                Console.ReadLine();
            }
            if (pts1 >= pts2 & pts2 >= pts3 & pts3 >= pts)
            {
                Console.WriteLine(" 15°- " + D4A + " : " + pts1 + " PTS");
                Console.WriteLine(" 16°- " + D4B + " : " + pts2 + " PTS");
                Console.WriteLine(" 17°- " + D4C + " : " + pts3 + " PTS");
                Console.WriteLine(" 18°- " + Equipe + " : " + pts + " PTS");
                Console.ReadLine();
            }
        }
    }
}
