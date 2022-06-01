using Aplicatie;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AplicatieTests
{
    [TestClass]
    public class UnitTest1
    {
        public Produse Produseanu(string numeleanu, decimal numar, string jugulea, string clr, string categ)
        {
            return new Produse { Id = 0, Nume_Prod = numeleanu, Pret = numar, Firma = jugulea, Culoare = clr, Categorie = categ };
        }

        public Categorii Categoriseanu(string name)
        {
            return new Categorii { IdCat = 0, Nume = name};
        }

        [TestMethod]
        public void TestMethod_1()
        {
            Produse FormProdus = new Produse();
            var model = Produseanu("Ciucalau", 100, "Covrig", "Yawca", "cacat");
            Assert.AreEqual(model.Nume_Prod,"Ciucalau");
        }

        [TestMethod]
        public void TestMethod_2()
        {
            Produse FormProdus = new Produse();
            var model = Produseanu("Ciucalau", 100, "Covrig", "Yawca", "cacat");
            Assert.AreEqual(model.Pret, 100);
        }

        [TestMethod]
        public void TestMethod_3()
        {
            Produse FormProdus = new Produse();
            var model = Produseanu("Ciucalau", 100, "Covrig", "Yawca", "cacat");
            Assert.AreEqual(model.Firma,"Covrig");
        }

        [TestMethod]
        public void TestMethod_4()
        {
            Produse FormProdus = new Produse();
            var model = Produseanu("Ciucalau", 100, "Covrig", "Yawca", "cacat");
            Assert.AreEqual(model.Culoare, "Yawca");
        }

        [TestMethod]
        public void TestMethod_5()
        {
            Produse FormProdus = new Produse();
            var model = Produseanu("Ciucalau", 100, "Covrig", "Yawca", "cacat");
            Assert.AreEqual(model.Categorie, "cacat");
        }

        [TestMethod]
        public void TestMethod_Cat()
        {
            Categorii FormProdus = new Categorii();
            var model_Cat = Categoriseanu("Tigan");
            Assert.AreEqual(model_Cat.Nume, "Tigan");
        }
    }
}
