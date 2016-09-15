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
            double ersteZahl = view.HoleZahlVomBeutzer();
            string operation = view.HoleOperatorVomBeutzer();
            double zweiteZahl = view.HoleZahlVomBeutzer();

            //Berechnung ausführen
            model.Berechne(ersteZahl, zweiteZahl, operation);

            view.GibResultatAus(operation);
            view.WarteAufEndeDurchBenutzer();
        }
    }
}
