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
            view.HoleEingabenFuerErsteBerechnungVomNutzer();
            model.Berechne();
            view.GibResultatAus();

            view.HoleEingabenFuerForlaufendeBerechnungVomNutzer();

            while (!view.BenutzerWillBeenden)
            {
                //Berechnung ausführen
                model.Berechne();

                //Ausgabe des Resultats
                view.GibResultatAus();

                //Resultat darstellen
                view.HoleEingabenFuerForlaufendeBerechnungVomNutzer();
            }

        }
    }
}
