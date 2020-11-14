using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EstruturaCondicionalTest
{
    [TestClass]
    public class TestEstruturaCondicional
    {
        [TestMethod]
        public void TestLerInteiroVerificaSeENegativoOuNao() // Exercício 01
        {
            var entrada1 = -10;
            var entrada2 = 8;
            var entrada3 = 0;

            var resultado1 = Utils.VerificaNegativoOuNaoNegativo(entrada1);
            var resultado2 = Utils.VerificaNegativoOuNaoNegativo(entrada2);
            var resultado3 = Utils.VerificaNegativoOuNaoNegativo(entrada3);

            Assert.AreEqual("Negativo", resultado1);
            Assert.AreEqual("Nao Negativo", resultado2);
            Assert.AreEqual("Nao Negativo", resultado3);
        }

        [TestMethod]
        public void TestLerInteiroVerificaSeEParOuImpar() // Exercício 02
        {
            var entrada1 = 12;
            var entrada2 = -27;
            var entrada3 = 0;

            var resultado1 = Utils.VerificaParOuImpar(entrada1);
            var resultado2 = Utils.VerificaParOuImpar(entrada2);
            var resultado3 = Utils.VerificaParOuImpar(entrada3);

            Assert.AreEqual("Par", resultado1);
            Assert.AreEqual("Impar", resultado2);
            Assert.AreEqual("Par", resultado3);
        }

        [TestMethod]
        public void TestLer2InteiroVerificaSeSaoMultiplos() // Exercício 03
        {
            var resultado1 = Utils.VerificaSeSaoMultiplos(6, 24);
            var resultado2 = Utils.VerificaSeSaoMultiplos(6, 25);
            var resultado3 = Utils.VerificaSeSaoMultiplos(24, 6);

            Assert.AreEqual("Sao Multiplos", resultado1);
            Assert.AreEqual("Nao Sao Multiplos", resultado2);
            Assert.AreEqual("Sao Multiplos", resultado3);
        }

        [TestMethod]
        public void TestLerHoraInicialEFinalCalcularDiferenca() // Exercício 04
        {
            var resultado1 = Utils.CalculaDiferencaHoraInicialEFinal(16, 2);
            var resultado2 = Utils.CalculaDiferencaHoraInicialEFinal(0, 0);
            var resultado3 = Utils.CalculaDiferencaHoraInicialEFinal(2, 16);

            Assert.AreEqual(10, resultado1);
            Assert.AreEqual(24, resultado2);
            Assert.AreEqual(14, resultado3);
        }

        [TestMethod]
        public void TestLerCodigoEQuantidadeCalcularValorTotal() // Exercício 05
        {
            var resultado1 = Utils.CalcularTotal(3, 2);
            var resultado2 = Utils.CalcularTotal(2, 3);
            var resultado3 = Utils.CalcularTotal(5, 4);

            Assert.AreEqual(10, resultado1);
            Assert.AreEqual(13.5, resultado2);
            Assert.AreEqual(6, resultado3);
        }

        [TestMethod]
        public void TestLerUmValorEVerificarIntervalo() // Exercício 06
        {
            var resultado1 = Utils.VerificaIntervalo(25.01);
            var resultado2 = Utils.VerificaIntervalo(25.00);
            var resultado3 = Utils.VerificaIntervalo(100.00);
            var resultado4 = Utils.VerificaIntervalo(-25.02);

            Assert.AreEqual("Intervalo [25,50]", resultado1);
            Assert.AreEqual("Intervalo [0,25]", resultado2);
            Assert.AreEqual("Intervalo [75,100]", resultado3);
            Assert.AreEqual("Fora de intervalo", resultado4);
        }

        [TestMethod]
        public void TestVerificarCoordenadasDeUmPlanoCartesiano() // Exercício 07
        {
            var resultado1 = Utils.VerificaCoordenadas(0.1, 0.1);
            var resultado2 = Utils.VerificaCoordenadas(-0.1, 1.1);            
            var resultado3 = Utils.VerificaCoordenadas(-0.2, -0.5);
            var resultado4 = Utils.VerificaCoordenadas(4.5, -2.2);
            var resultado5 = Utils.VerificaCoordenadas(0.0, 0.0);

            Assert.AreEqual("Q1", resultado1);
            Assert.AreEqual("Q2", resultado2);
            Assert.AreEqual("Q3", resultado3);
            Assert.AreEqual("Q4", resultado4);
            Assert.AreEqual("Origem", resultado5);
        }

        [TestMethod]
        public void TestCalculaImposto() // Exercício 08
        {
            var resultado1 = Utils.CalculaImposto(3002.00);
            var resultado2 = Utils.CalculaImposto(1701.12);
            var resultado3 = Utils.CalculaImposto(4520.00);

            Assert.AreEqual(80.36, resultado1);
            Assert.AreEqual(0, resultado2);
            Assert.AreEqual(355.60, resultado3);
        }


    }
}
