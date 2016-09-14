using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner
{
    class RechnerModel
    {

        /// <summary>
        /// Methode ruft die Berchnungsmethode für die jeweilige Operation auf
        /// </summary>
        /// <param name="erste_zahl"></param>
        /// <param name="zweite_zahl"></param>
        /// <param name="operation"></param>
        /// <returns></returns>
        public double Berechne(double erste_zahl, double zweite_zahl, string operation)
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
        private double AddierenZweierZahlen(double erste_zahl, double zweite_zahl)
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
        private double SubtrahierenZweierZahlen(double erste_zahl, double zweite_zahl)
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
        private double MultiplizierenZweierZahlen(double erste_zahl, double zweite_zahl)
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
        private double DividierenZweierZahlen(double erste_zahl, double zweite_zahl)
        {
            double quotient = erste_zahl / zweite_zahl;
            return quotient;
        }

    }
}
