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
                string operation = HoleBenutzerEingabe("Bitte gib die Operation ein (+ - * /): ");

                //Wandel von Text zu Gleitkommazahlen
                double ersteZahlAlsDouble = Convert.ToDouble(ersteZahlAlsString);
                double zweiteZahlAlsDouble = Convert.ToDouble(zweiteZahlAlsString);

                double resultat = 0;
                resultat = Berechnung(ersteZahlAlsDouble, zweiteZahlAlsDouble, operation);

                Console.WriteLine("Das Ergebnis aus {0} {3} {1} = {2}", ersteZahlAlsDouble, zweiteZahlAlsDouble, resultat, operation);
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
            string input = Console.ReadLine();

            return input;
        }

        /// <summary>
        /// Methode ruft die Berchnungsmethode für die jeweilige Operation auf
        /// </summary>
        /// <param name="erste_zahl"></param>
        /// <param name="zweite_zahl"></param>
        /// <param name="operation"></param>
        /// <returns></returns>
        static double Berechnung(double erste_zahl, double zweite_zahl, string operation)
        {
            double resultat = 0;

            switch (operation)
            {
                case "+":
                    resultat = AddierenZweierZahlen(erste_zahl, zweite_zahl);
                    break;
                case "-":
                    resultat = SubtrahierenZweierZahlen(erste_zahl, zweite_zahl);
                    break;
                case "*":
                    resultat = MultiplizierenZweierZahlen(erste_zahl, zweite_zahl);
                    break;
                case "/":
                    resultat = DividierenZweierZahlen(erste_zahl, zweite_zahl);
                    break;
                default:
                    resultat = 0;
                    break;
            }

            return resultat;
        }

        /// <summary>
        /// Methode addiert zwei Zahlen.
        /// </summary>
        /// <param name="erste_zahl"></param>
        /// <param name="zweite_zahl"></param>
        static double AddierenZweierZahlen(double erste_zahl, double zweite_zahl)
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

        /// <summary>
        /// Methode multipliziert zwei Zahlen
        /// </summary>
        /// <param name="erste_zahl"></param>
        /// <param name="zweite_zahl"></param>
        /// <returns></returns>
        static double MultiplizierenZweierZahlen(double erste_zahl, double zweite_zahl)
        {
            double produkt = erste_zahl * zweite_zahl;
            return produkt;
        }

        /// <summary>
        /// Methode dividiert zwei Zahlen
        /// </summary>
        /// <param name="erste_zahl"></param>
        /// <param name="zweite_zahl"></param>
        /// <returns></returns>
        static double DividierenZweierZahlen(double erste_zahl, double zweite_zahl)
        {
            double quotient = erste_zahl / zweite_zahl;
            return quotient;
        }


    }
}
