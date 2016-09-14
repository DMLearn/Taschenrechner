using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner
{
    class ConsoleView
    {
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
    }
}
