﻿using System;
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
        }

        //Eigenschaft für das Attribut input
        public string Input { get; private set; }

        //Konstruktur für das Objekt ConsoleView
        public ConsoleView()
        {
            Input = null;
        }

        /// <summary>
        /// Eingabeforderung an den Nutzer, Eingabe wird als return zurürck gegeben.
        /// </summary>
        /// <param name="ausgabetext"></param>
        /// <returns></returns>
        public void HoleBenutzerEingabe(string ausgabetext)
        {
            Console.Write(ausgabetext);
            Input = Console.ReadLine();

        }     
        
        /// <summary>
        /// Ausgabe des Ergebniss
        /// </summary>
        /// <param name="resultat"></param>
        /// <param name="operation"></param>
        public void GibResultatAus(string operation)
        {
            switch (operation)
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
