using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestProject1.SeresVivos.Animais;
using UnitTestProject1.SeresVivos.Plantas;

namespace UnitTestProject1
{
    [TestClass]
    public class TesteUnitario
    {

        private Leao leaoAfricano;
        private Elefante elefanteIndiano;
        private Gato gatoPersa;
        private HorarioAtual horarioAtual;

        private Arvore pinheiro;
        private Arbusto indestrutivelDoGTA;
        private Muda mudaFrutifera;
      

        [TestInitialize]
        public void TestInitialize()
        {
            leaoAfricano = new Leao(false);
            elefanteIndiano = new Elefante(true);
            gatoPersa = new Gato(true);

            pinheiro = new Arvore(true);
            indestrutivelDoGTA = new Arbusto(true);
            mudaFrutifera = new Muda(false);

           horarioAtual = HorarioAtual.Dia;

           
        }

        [TestMethod]
        public void LeaoLocomover()
        {
            Assert.AreEqual(true, leaoAfricano.Locomover());
        }

        [TestMethod]
        public void GatoLocomover()
        {
            Assert.AreEqual(true, gatoPersa.Locomover());
        }

        [TestMethod]
        public void ElefanteLocomover()
        {
            Assert.AreEqual(true, elefanteIndiano.Locomover());
        }

        [TestMethod]
        public void SomLeao()
        {
            Assert.AreEqual("Rugido", leaoAfricano.EmitirSom());
        }

        [TestMethod]
        public void SomGato()
        {
            Assert.AreEqual("Miado", gatoPersa.EmitirSom());
        }

        [TestMethod]
        public void SomElefante()
        {
            Assert.AreEqual("Barrido", elefanteIndiano.EmitirSom());
        }

        [TestMethod]
        public void AnimalRespirar()
        {
            Assert.AreEqual(true, ((IAnimal)gatoPersa).Respirar());
        }

        [TestMethod]
        public void PlantaRespirar()
        {
            Assert.AreEqual(true, ((IPlanta)pinheiro).Respirar());
        }

        [TestMethod]
        public void SerVivoRespirar()
        {
            Assert.AreEqual(true, ((ISerVivo)elefanteIndiano).Respirar());
            Assert.AreEqual(true, ((ISerVivo)indestrutivelDoGTA).Respirar());
            Assert.AreEqual(true, ((ISerVivo)leaoAfricano).Respirar());
        }

        [TestMethod]
        public void MudaFotossintese()
        {
            Assert.AreEqual(true, mudaFrutifera.Fotossintese(horarioAtual));

        }

        [TestMethod]
        public void ArvoreFotossintese()
        {
            Assert.AreEqual(true, pinheiro.Fotossintese(horarioAtual));

        }

        [TestMethod]
        public void ArbustoFotossintese()
        {
            Assert.AreEqual(true, indestrutivelDoGTA.Fotossintese(horarioAtual));
        }

        [TestMethod]
        public void ChecarPorte()
        {
            Assert.AreEqual(Porte.Grande, pinheiro.Porte);
            Assert.AreEqual(Porte.Medio, indestrutivelDoGTA.Porte);
            Assert.AreEqual(Porte.Pequeno, mudaFrutifera.Porte);
        }


        [TestCleanup]
        public void FinalizarTeste()
        {
            leaoAfricano = null;
            elefanteIndiano = null;
            gatoPersa = null;

            pinheiro = null;
            indestrutivelDoGTA = null;
            mudaFrutifera = null;

            horarioAtual = HorarioAtual.Dia;
        }
    }
}
