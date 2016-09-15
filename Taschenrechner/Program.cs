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
            AnwendungsController controller = new AnwendungsController(view, model);

            controller.Ausfuehren();

        }
    }
}
