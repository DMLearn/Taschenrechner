using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner
{
    class ConsoleView
    {
        //Damit der view Zugriff auf die Klasse model hat, wird ein Attribut model angelegt 
        private RechnerModel model;

        //Konstruktur
        public ConsoleView(RechnerModel model)
        {
            this.model = model;
            BenutzerWillBeenden = false;
        }

        public bool BenutzerWillBeenden { get; private set; }

        public void HoleEingabenFuerErsteBerechnungVomNutzer()
        {
            do
            {
                model.ErsteZahl = HoleZahlVomBeutzer();
                ZahleneingabeAufUeberlaufPruefen(model.ErsteZahl);
            } while (model.WerteBereichUeberlauf);

            model.Operation = HoleOperatorVomBeutzer();

            do
            {
                model.ZweiteZahl = HoleZahlVomBeutzer();
                ZahleneingabeAufUeberlaufPruefen(model.ZweiteZahl);
            } while (model.WerteBereichUeberlauf);

        }

        public void HoleEingabenFuerForlaufendeBerechnungVomNutzer()
        {
            string eingabe = HoleNaechsteAktionVomNutzer();

            if (eingabe == "FERTIG")
            {
                BenutzerWillBeenden = true;
            }
            else
            {
                model.ErsteZahl = model.Resultat;
                model.ZweiteZahl = Convert.ToDouble(eingabe);
            }
        }

        private string HoleNaechsteAktionVomNutzer()
        {
            Console.Write( "Bitte gib eine weitere Zahl ein (FERTIG zum Beenden): " );
            return Console.ReadLine();
        }

        private double HoleZahlVomBeutzer()
        {
            string eingabe;
            double zahl;
            Console.Write("Bitte gib eine Zahl für die Berechnung ein: ");
            eingabe = Console.ReadLine();

            while (!Double.TryParse(eingabe, out zahl))
            {
                Console.WriteLine("--------------------");
                Console.WriteLine("Du musst eine gültige Gleikommazahl eingeben!");
                Console.WriteLine("Neben den Ziffern 0-9 sind lediglich die folgenden Sonderzeichen erlaubt: , . -");
                Console.WriteLine("Dabei musst das - als erstes Zeichen vor einer Ziffer eingesetzt werden.");
                Console.WriteLine("Der . fungiert als Trennzeichen an Tausenderstellen.");
                Console.WriteLine("Das , ist das Trennzeichen für die Nachkommastellen. ");
                Console.WriteLine("Alle drei Sonderzeichen sind optional.");
                Console.WriteLine("--------------------");
                Console.Write("Bitte gib eine Zahl für die Berechnung ein: ");
                eingabe = Console.ReadLine();
            }
            return zahl;
        }

        private string HoleOperatorVomBeutzer()
        {
            Console.Write( "Bitte gib die auszuführende Operation ein +,-,*,/ (FERTIG zum Beenden): " );
            return Console.ReadLine();
        }

        /// <summary>
        /// Überprüfen ob die Zahl im zulässigen Bereich liegt. Gibt bei Bedarf einen Fehler an den Nutzer aus. 
        /// </summary>
        /// <param name="zahl"></param>
        private void ZahleneingabeAufUeberlaufPruefen(double zahl)
        {
            model.ZahlenUeberlaufPruefen(zahl);

            if (model.WerteBereichUeberlauf == true)
            {
                Console.WriteLine("--------------------");
                Console.WriteLine("Die eingebene Zahl ist außerhalb des zulässigen Bereichs.");
                Console.WriteLine("Es sind Zahlen im Bereich von {0} bis {1} erlaubt.", model.MinimalerEingabeWert, model.MaximalerEingabeWert);
                Console.WriteLine("--------------------");
            }

        }
     
        /// <summary>
        /// Ausgabe des Ergebniss
        /// </summary>
        /// <param name="resultat"></param>
        /// <param name="operation"></param>
        public void GibResultatAus()
        {
            switch (model.Operation)
            {
                case "+":
                    Console.WriteLine("Die Summe ist: {0}", model.Resultat);
                    break;
                case "-":
                    Console.WriteLine("Die Differenz ist: {0}", model.Resultat);
                    break;
                case "*":
                    Console.WriteLine("Das Produkt ist: {0}", model.Resultat);
                    break;
                case "/":
                    Console.WriteLine("Der Quotient ist: {0}", model.Resultat);
                    break;
                default:
                    Console.WriteLine("Du hast eine ungültige Operation ausgewählt!");
                    break;
            }
        }   
    }
}
