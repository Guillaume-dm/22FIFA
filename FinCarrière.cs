using System;

namespace _22FIFA
{
    class FinCarrière
    {
        public FinCarrière(string coach, int championnats, int coupes, int l1c, int dl2, int N, int coupe_de_france, int tdc, int saison, int saison_D1FR, int saison_D2FR, int saison_D3FR, int victoire_glb, int nul_glb, int df_glb, int bm_glb, int be_glb, int salaire_entraineur)
        {
            Console.WriteLine("COACH : " + coach);
            salaire_entraineur = salaire_entraineur + victoire_glb * 1000 + nul_glb * 500; // Ajout des primes de résultats
            Console.WriteLine(" ARGENT GAGNE : " + salaire_entraineur + "€"); // Annonce du salaire de l'entraineur touché au cours de l'ensemble de sa carrière
            Console.ReadLine();
            Console.WriteLine("NOMBRE DE SAISONS : " + saison); // Affiche le nombre de saisons effectués
            Console.WriteLine(" DONT LIGUE 1 Uber Eats : " + saison_D1FR); // Dont en première division française
            Console.WriteLine(" DONT Domino's LIGUE 2 : " + saison_D2FR); // Dont en seconde division française
            Console.WriteLine(" DONT NATIONAL FFF : " + saison_D3FR); // Dont en seconde division française
            Console.WriteLine(" ");
            Console.WriteLine("NOMBRE DE VICTOIRES : " + victoire_glb); // Affiche le nombre de victoires lors de la dernière carrière éffectué
            Console.WriteLine("NOMBRE DE MATCHS NULS : " + nul_glb); // Affiche le nombre de matchs nuls lors de la dernière carrière éffectué
            Console.WriteLine("NOMBRE DE DEFAITES : " + df_glb); // Affiche le nombre de défaites lors de la dernière carrière éffectué
            Console.WriteLine(" ");
            Console.WriteLine("NOMBRE DE BUTS MARQUES : " + bm_glb); // Affiche le nombre de buts marqués lors de la dernière carrière effectué
            Console.WriteLine("NOMBRE DE  BUTS ENCAISSES : " + be_glb); // Affiche le nombre de buts encaissés lors de la dernière carrière effectué
            Console.WriteLine(" ");
            if (championnats < 2) // Test pour l'accord au pluriel ou au singulier
            {
                Console.WriteLine("CHAMPIONNAT GAGNE : " + championnats);
                Console.WriteLine(" DONT LIGUE 1 Uber Eats : " + l1c); // Dont en première division française
                Console.WriteLine(" DONT Domino's LIGUE 2 : " + dl2); // Dont en seconde division française
                Console.WriteLine(" DONT NATIONAL FFF : " + N); // Dont en troisième division française
            }
            else
            {
                Console.WriteLine("CHAMPIONNATS GAGNES : " + championnats);
                Console.WriteLine(" DONT LIGUE 1 Conforama : " + l1c); // Dont en première division française
                Console.WriteLine(" DONT Domino's LIGUE 2 : " + dl2); // Dont en seconde division française
                Console.WriteLine(" DONT NATIONAL FFF : " + N); // Dont en troisième division française
            }
            if (coupes < 2) // Test pour savoir si le mot coupe doit être mis au pluriel
            {
                Console.WriteLine("COUPE GAGNEE : " + coupes);
                Console.WriteLine(" DONT COUPE DE FRANCE : " + coupe_de_france);
                Console.WriteLine(" DONT TROPHEE DES CHAMPIONS : " + tdc);
            }
            else
            {
                Console.WriteLine("COUPES GAGNEES : " + coupes);
                Console.WriteLine(" DONT COUPE(S) DE FRANCE : " + coupe_de_france);
                Console.WriteLine(" DONT TROPHEE(S) DES CHAMPIONS : " + tdc);
            }
            double qualitéCV = ((100000*(championnats+coupe_de_france+tdc)+1200*victoire_glb+500*nul_glb)-1000*df_glb)*saison; // Calcul l'indice de qualité du CV
            Console.WriteLine(" INDICE DE QUALITE DE VOTRE CV : " + qualitéCV);
            Console.ReadLine();
            Console.Clear();
        }
    }
}
