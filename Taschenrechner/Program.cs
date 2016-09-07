using System;
using System.Threading;
using System.ComponentModel;

namespace Taschenrechner
{
    class Program
    {
      
        static void Main(string[] args)
        {
            
            try
            {
                //User Story: Werte addieren
                string ersteZahlAlsString = HoleBenutzerEingabe("Bitte gib die erste Zahl ein: ");
                string zweiteZahlAlsString = HoleBenutzerEingabe("Bitte gib die zweite Zahl ein: ");
                string operation = HoleBenutzerEingabe("Bitte gib die Operation ein (+ oder -): ");

                //Wandel von Text zu Gleitkommazahlen
                //TODO: Auslagern in Methode, wenn Struktur umfangreicher geworden ist.
                double ersteZahlAlsDouble = Convert.ToDouble(ersteZahlAlsString);
                double zweiteZahlAlsDouble = Convert.ToDouble(zweiteZahlAlsString);

                double resultat = 0;

                switch(operation)
                {
                    case "+":
                        resultat = AddierenZweierZahlen(ersteZahlAlsDouble, zweiteZahlAlsDouble);
                        Console.WriteLine("Das Ergebniss aus {0} {3} {1} = {2}", ersteZahlAlsDouble, zweiteZahlAlsDouble, resultat, operation);
                        break;
                    case "-":
                        resultat = SubtrahierenZweierZahlen(ersteZahlAlsDouble, zweiteZahlAlsDouble);
                        Console.WriteLine("Das Ergebniss aus {0} {3} {1} = {2}", ersteZahlAlsDouble, zweiteZahlAlsDouble, resultat, operation);
                        break;
                    case "*":
                    case "/":
                        Console.WriteLine("Diese Operation wird bald unterstützt.");
                        break;

                    default: 
                        Console.WriteLine("Du hast ein falsche Auswahl der Operation ausgewählt.");
                        break;
                }

                HoleBenutzerEingabe("-------------------------------------\nZum Beenden bitte eine Taste drücken!");

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
        /// Eingabeforderung an den Nutzer, Eingabe wird als return zurürck gegeben.
        /// </summary>
        /// <param name="ausgabetext"></param>
        /// <returns></returns>
        static string HoleBenutzerEingabe(string ausgabetext)
        {
            Console.Write(ausgabetext);
            string summand = Console.ReadLine();

            return summand;
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

        /// <summary>
        /// Methode subtrahiert zwei Zahlen.
        /// </summary>
        /// <param name="erste_zahl"></param>
        /// <param name="zweite_zahl"></param>
        /// <returns></returns>
        static double SubtrahierenZweierZahlen(double erste_zahl, double zweite_zahl)
        {
            double differenz = erste_zahl - zweite_zahl;
            return differenz;
        }

    }
}
