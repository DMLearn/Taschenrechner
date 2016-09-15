using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner
{
    class AnwendungsController
    {
        private ConsoleView view;
        private RechnerModel model;

        //Konstruktor
        public AnwendungsController(ConsoleView view, RechnerModel model)
        {
            this.model = model;
            this.view = view;
        }

        public void Ausfuehren()
        {
            //Abfrage der jeweiligen Zahlen und der Operation durch die Klassen
            string ersteZahlAlsString = view.HoleZahlVomBeutzer();
            string operation = view.HoleOperatorVomBeutzer();
            string zweiteZahlAlsString = view.HoleZahlVomBeutzer();

            //Wandelt den Text zu Gleitkommazahlen
            double ersteZahlAlsDouble = Convert.ToDouble(ersteZahlAlsString);
            double zweiteZahlAlsDouble = Convert.ToDouble(zweiteZahlAlsString);

            //Berechnung ausführen
            model.Berechne(ersteZahlAlsDouble, zweiteZahlAlsDouble, operation);

            view.GibResultatAus(operation);
            view.WarteAufEndeDurchBenutzer();
        }
    }
}
