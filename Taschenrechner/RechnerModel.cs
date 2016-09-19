using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner
{
    public class RechnerModel
    {
        //Eigenschaft für das Attribut resultat
        public double Resultat { get; private set; }
        public string Operation { get; set; }
        public double ErsteZahl { get; set; }
        public double ZweiteZahl { get; set; }

        //Konstruktur für das Objekt RechnerModel
        public RechnerModel()
        {
            Resultat = 0;
            Operation = "unbekannt";
        }


        /// <summary>
        /// Methode ruft die Berchnungsmethode für die jeweilige Operation auf
        /// </summary>
        /// <param name="erste_zahl"></param>
        /// <param name="zweite_zahl"></param>
        /// <param name="operation"></param>
        /// <returns></returns>
        public void Berechne()
        {

            switch (Operation)
            {
                case "+":
                    Resultat = AddierenZweierZahlen(ErsteZahl, ZweiteZahl);
                    break;
                case "-":
                    Resultat = SubtrahierenZweierZahlen( ErsteZahl, ZweiteZahl );
                    break;
                case "*":
                    Resultat = MultiplizierenZweierZahlen( ErsteZahl, ZweiteZahl );
                    break;
                case "/":
                    Resultat = DividierenZweierZahlen( ErsteZahl, ZweiteZahl );
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
