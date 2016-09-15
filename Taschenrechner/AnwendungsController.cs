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
            //Abfrage der Zahlen und der Operation durch den view 
            view.HoleEingabenVomBenutzer();

            //Berechnung ausführen
            model.Berechne();

            view.GibResultatAus();
            view.WarteAufEndeDurchBenutzer();
        }
    }
}
