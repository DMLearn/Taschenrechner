using System;
using System.Threading;
using System.ComponentModel;

namespace Taschenrechner
{
    class Program
    {
      
        static void Main(string[] args)
        {
            //Objekte für die Klassen von view und model angelegt 
            RechnerModel model = new RechnerModel();
            ConsoleView view = new ConsoleView(model);

            //Abfrage der jeweiligen Zahlen und der Operation durch die Klassen
            view.HoleBenutzerEingabe("Bitte gib die erste Zahl ein: ");
            string ersteZahlAlsString = view.Input;

            view.HoleBenutzerEingabe("Bitte gib die zweite Zahl ein: ");
            string zweiteZahlAlsString = view.Input;

            view.HoleBenutzerEingabe("Bitte gib die Operation ein (+ - * /): ");
            string operation = view.Input;

            //Wandelt den Text zu Gleitkommazahlen
            double ersteZahlAlsDouble = Convert.ToDouble(ersteZahlAlsString);
            double zweiteZahlAlsDouble = Convert.ToDouble(zweiteZahlAlsString);

            //Berechnung ausführen
            model.Berechne(ersteZahlAlsDouble, zweiteZahlAlsDouble, operation);

            view.GibResultatAus(operation);
            view.HoleBenutzerEingabe("-------------------------------------\nZum Beenden bitte eine Taste drücken!");

        }
    }
}
