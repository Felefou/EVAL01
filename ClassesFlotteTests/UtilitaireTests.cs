using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassesFlotte;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesFlotte.Tests
{
    [TestClass()]
    public class UtilitaireTests
    {
        [TestMethod()]
        public void ChargeUtileTest()
        {
            Utilitaire uti = new Utilitaire("AA-123-BB", "Essence", 8, 0, 0, 15);

            Assert.AreEqual(0, uti.ChargeUtile(), "La différence des deux équivaut à 0");
            uti.setPtac(20);
            uti.setPav(10);

            Assert.AreEqual(10, uti.ChargeUtile(), "La différence des deux équivaut à 10");
        }

        [TestMethod()]
        public void PrevoirEntretienTest()
        {
            // Cas n°1 : Le véhicule a un an et il doit être révisé.
            Utilitaire uti = new Utilitaire("AA-123-BB", "Essence", 8, 1800, 1200, 15);
            uti.AjouterEntretien(new Entretien(new DateTime(2021, 07, 01), 14000, "RAS"));

            Assert.AreEqual(true, uti.PrevoirEntretien());

            // Cas n°2 : Le véhicule n'a pas un an et il n'a donc pas besoin d'être révisé.

            Utilitaire uti2 = new Utilitaire("AA-123-BB", "Essence", 8, 1800, 1200, 15);
            uti2.AjouterEntretien(new Entretien(new DateTime(2022, 10, 10), 14000, "RAS"));

            Assert.AreEqual(false, uti2.PrevoirEntretien());


        }
    }
}