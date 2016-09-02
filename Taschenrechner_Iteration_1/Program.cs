using System;
using System.Threading;
using System.ComponentModel;

namespace Taschenrechner_Iteration_1
{
    class Program
    {

        private static BackgroundWorker worker = new BackgroundWorker();
        
        static void Main(string[] args)
        {
            //Addieren: Als Benutzer möchte ich zwei Zahlen eingeben und deren Summanden berechnen lassen.
            //Beenden:  Als Benutzer möchte ich die Anwendung zuverlässig beenden können.
            //Starten:  Als Benutzer möchte ich, dass das Programm schnell startet damit schnell und effizient arbeiten kann.

            //worker = new BackgroundWorker();
            /*worker.DoWork += worker_DoWork;
            worker.WorkerReportsProgress = true;
            worker.RunWorkerAsync();*/

            try
            {
                //User Story: Werte addieren
                Console.Write("Erste Zahl eingeben: ");
                float erste_zahl = Convert.ToSingle(Console.ReadLine());

                //Wandel von Text zu Gleitkommazahlen
                Console.Write("Zweite Zahl eingeben: ");
                float zweite_zahl = Convert.ToSingle(Console.ReadLine());

                //Wandel von Text zu Gleitkommazahlen
                float ergebniss = erste_zahl + zweite_zahl;
                Console.WriteLine("Das Ergebniss aus {0} + {1} = {2}", erste_zahl, zweite_zahl, ergebniss);

                Console.ReadKey();
            }

            catch (FormatException)
            {
                Console.WriteLine("Die Eingabe entspricht nicht einem Zahlenformat.");
                Console.ReadKey();
            }
            catch (OverflowException)
            {
                Console.WriteLine("Die Eingabe ist größer als der maximale mögliche Zahlenwert.");
                Console.ReadKey();
            }

        }
        /// <summary>
        /// Check for cancelation by the user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /*static void worker_DoWork (object sender, DoWorkEventArgs e)
        {
            if (Console.ReadKey(true).Key == ConsoleKey.Escape)
            {
                Console.WriteLine("\n------------------------------------------");
                Console.WriteLine("Programm wurde durch den Anwender beendet!");
                Console.WriteLine("Taste drücken um das Programm zu verlassen.");
                Console.ReadKey();
                System.Environment.Exit(0);
            }
        }*/



    }
}
