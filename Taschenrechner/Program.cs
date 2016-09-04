using System;
using System.Threading;
using System.ComponentModel;

namespace Taschenrechner
{
    class Program
    {

        private static BackgroundWorker worker = new BackgroundWorker();
        
        static void Main(string[] args)
        {
            //Addieren: Als Benutzer möchte ich zwei Zahlen eingeben und deren Summanden berechnen lassen.
            //Beenden:  Als Benutzer möchte ich die Anwendung zuverlässig beenden können.
            //Starten:  Als Benutzer möchte ich, dass das Programm schnell startet damit schnell und effizient arbeiten kann.

            try
            {
                //User Story: Werte addieren
                Console.Write("Erste Zahl eingeben: ");
                double erste_zahl = Convert.ToDouble(Console.ReadLine());

                //Wandel von Text zu Gleitkommazahlen
                Console.Write("Zweite Zahl eingeben: ");
                double zweite_zahl = Convert.ToDouble(Console.ReadLine());

                //Wandel von Text zu Gleitkommazahlen
                double ergebniss = AddierenZweierZahlen(erste_zahl, zweite_zahl);
                Console.WriteLine("Das Ergebniss aus {0} + {1} = {2}", erste_zahl, zweite_zahl, ergebniss);

                WarteAufBenutzerEingabe();

            }

            catch (FormatException)
            {
                Console.WriteLine("Die Eingabe entspricht nicht einem Zahlenformat.");
                Console.ReadKey();
            }
            catch (OverflowException)
            {
                Console.WriteLine("Die Eingabe ist größer als der maximale mögliche Zahlenwert.");
                Console.ReadKey();
            }

        }

        /// <summary>
        /// Funktion wartet bis der Benutzer eine Taste betätigt hat.
        /// </summary>
        static void WarteAufBenutzerEingabe()
        {
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Zum Beenden bitte eine Taste drücken!");
            Console.ReadLine();
        }

        /// <summary>
        /// Methode addiert zwei Zahlen.
        /// </summary>
        /// <param name="erste_zahl"></param>
        /// <param name="zweite_zahl"></param>
        static double AddierenZweierZahlen(double erste_zahl, double zweite_zahl )
        {
            double summe = erste_zahl + zweite_zahl;
            return summe;
        }

    }
}
