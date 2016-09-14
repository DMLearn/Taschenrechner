using System;
using System.Threading;
using System.ComponentModel;

namespace Taschenrechner
{
    class Program
    {
      
        static void Main(string[] args)
        {
            
            
            //User Story: Werte addieren
            string ersteZahlAlsString = HoleBenutzerEingabe("Bitte gib die erste Zahl ein: ");
            string zweiteZahlAlsString = HoleBenutzerEingabe("Bitte gib die zweite Zahl ein: ");
            string operation = HoleBenutzerEingabe("Bitte gib die Operation ein (+ - * /): ");

            //Wandel von Text zu Gleitkommazahlen
            double ersteZahlAlsDouble = Convert.ToDouble(ersteZahlAlsString);
            double zweiteZahlAlsDouble = Convert.ToDouble(zweiteZahlAlsString);

            //Berechnung ausführen
            RechnerModel model = new RechnerModel();
            model.Berechne(ersteZahlAlsDouble, zweiteZahlAlsDouble, operation);

            Console.WriteLine("Das Ergebnis aus {0} {3} {1} = {2}", ersteZahlAlsDouble, zweiteZahlAlsDouble, model.Resultat, operation);
            HoleBenutzerEingabe("-------------------------------------\nZum Beenden bitte eine Taste drücken!");

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

    }
}
