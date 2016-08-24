using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner_Iteration_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Addieren: Als Benutzer möchte ich zwei Zahlen eingeben und deren Summanden berechnen lassen.
            //Beenden:  Als Benutzer möchte ich die Anwendung zuverlässig beenden können.
            //Starten:  Als Benutzer möchte ich, dass das Programm schnell startet damit schnell und effizient arbeiten kann.

            try
            {
                Console.Write("Erste Zahl eingeben[Int32]: ");
                Int32 erste_zahl = Convert.ToInt32(Console.ReadLine());

                Console.Write("Zweite Zahl eingeben[Int32]: ");
                Int32 zweite_zahl = Convert.ToInt32(Console.ReadLine());

                Int64 ergebniss = erste_zahl + zweite_zahl;
                Console.WriteLine("Das Ergbniss aus {0} + {1} = {2}", erste_zahl, zweite_zahl, ergebniss);

                Console.ReadKey();
            }

            catch (FormatException)
            {
                Console.WriteLine("Die Eingabe entspricht nicht einem Int32-Format.");
                Console.ReadKey();
            }
            catch (OverflowException)
            {
                Console.WriteLine("Die Eingabe ist größer als der maximale Int32-Wert.");
                Console.ReadKey();
            }

        }
        
    }
}
