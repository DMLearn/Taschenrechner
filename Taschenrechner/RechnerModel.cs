using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner
{
    class RechnerModel
    {
        //Eigenschaft für das Attribut Resultat
        public double Resultat { get; private set; }
        
        //Konstruktur für das Objekt RechnerModel
        public RechnerModel()
        {
            Resultat = 0;
        }


        /// <summary>
        /// Methode ruft die Berchnungsmethode für die jeweilige Operation auf
        /// </summary>
        /// <param name="erste_zahl"></param>
        /// <param name="zweite_zahl"></param>
        /// <param name="operation"></param>
        /// <returns></returns>
        public void Berechne(double erste_zahl, double zweite_zahl, string operation)
        {
            switch (operation)
            {
                case "+":
                    Resultat = AddierenZweierZahlen(erste_zahl, zweite_zahl);
                    break;
                case "-":
                    Resultat = SubtrahierenZweierZahlen(erste_zahl, zweite_zahl);
                    break;
                case "*":
                    Resultat = MultiplizierenZweierZahlen(erste_zahl, zweite_zahl);
                    break;
                case "/":
                    Resultat = DividierenZweierZahlen(erste_zahl, zweite_zahl);
                    break;
                default:
                    Resultat = 0;
                    break;
            }

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
