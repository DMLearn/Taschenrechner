using Microsoft.VisualStudio.TestTools.UnitTesting;
using Taschenrechner;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner.Tests
{
    [TestClass()]
    public class RechnerModelTests
    {
        [TestMethod()]
        public void Berechne_DivisionDurchNull_ErgibtUnendlich()
        {
            RechnerModel model = new RechnerModel();
            model.Operation = "/";
            model.ErsteZahl = 10;
            model.ZweiteZahl = 0;

            model.Berechne();

            Assert.AreEqual( Double.PositiveInfinity, model.Resultat );
        }

        [TestMethod()]
        public void Berechne_Addition_Ergibt()
        {
            RechnerModel model = new RechnerModel();
            model.Operation = "+";
            model.ErsteZahl = 112.21;
            model.ZweiteZahl = 10.50;

            model.Berechne();
            Assert.AreEqual( 122.71, model.Resultat );
        }

        [TestMethod()]
        public void Berechne_Multiplikation_Ergibt()
        {
            RechnerModel model = new RechnerModel();
            model.Operation = "*";
            model.ErsteZahl = 112.21;
            model.ZweiteZahl = 3;

            model.Berechne();
            Assert.AreEqual( 336.63, model.Resultat );
        }

        [TestMethod()]
        public void Berechne_Subtraktion_Ergibt()
        {
            RechnerModel model = new RechnerModel();
            model.Operation = "-";
            model.ErsteZahl = 100.50;
            model.ZweiteZahl = 200.50;

            model.Berechne();
            Assert.AreEqual( -100, model.Resultat );
        }
    }

}