using System;

namespace _22FIFA
{
    class Meteo
    {
        public Meteo(int meteo)
        {
            int temperature;
            if (meteo <= 20 & meteo > 0)
            {
                Console.WriteLine(" METEO : Nuageux"); // Annonce de la météo du match : Nuageux
                temperature = new Random().Next(10, 23); // Génère aléatoirement la température du match prévu au coup d'envoi
                Temperature Temp_celcus = new Temperature(temperature);
            }
            else
            {
                if (meteo > 20 & meteo <= 35) // Si le temps n'est pas nuageux
                {
                    Console.WriteLine(" METEO : Ensoillé/variable");  // Annonce de la météo du match : Ensoillé / Variable
                    temperature = new Random().Next(16, 32); // Génère aléatoirement la température du match prévu au coup d'envoi
                    Temperature Temp_celcus = new Temperature(temperature);
                }
                if (meteo > 35 & meteo <= 45)
                {
                    Console.WriteLine(" METEO : Pluvieux"); // Annonce de la météo du match : Pluie
                    temperature = new Random().Next(5, 18); // Génère aléatoirement la température du match prévu au coup d'envoi
                    Temperature Temp_celcus = new Temperature(temperature);
                }
                if (meteo > 45 & meteo <= 48)
                {
                    Console.WriteLine(" METEO : Neige"); // Annonce de la météo du match  : Neige
                    temperature = new Random().Next(-11, 1); // Génère aléatoirement la température du match prévu au coup d'envoi
                    Temperature Temp_celcus = new Temperature(temperature);
                }
            }
            Console.ReadLine();
        }
    }
}
