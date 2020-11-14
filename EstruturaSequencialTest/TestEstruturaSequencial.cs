using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EstruturaSequencialTest
{
    [TestClass]
    public class TestEstruturaSequencial
    {
        [TestMethod]
        public void TestLerDoisInteirosMostrarResultadoSoma() // Exercício 1
        {
            var resultado1 = Utils.SomaValores(10, 30);
            var resultado2 = Utils.SomaValores(-30, 10);
            var resultado3 = Utils.SomaValores(0, 0);

            Assert.AreEqual(40, resultado1);
            Assert.AreEqual(-20, resultado2);
            Assert.AreEqual(0, resultado3);
        }

        [TestMethod]
        public void TestLerRaioDeUmCirculoECalcularArea() // Exercício 2
        {
            var resultado1 = Utils.CalcularAreaCirculo(2.00);
            var resultado2 = Utils.CalcularAreaCirculo(100.64);
            var resultado3 = Utils.CalcularAreaCirculo(150.00);

            Assert.AreEqual("12.5664", resultado1);
            Assert.AreEqual("31819.3103", resultado2);
            Assert.AreEqual("70685.7750", resultado3);
        }

        [TestMethod]
        public void TestLerDoisInteirosMostrarDiferencaDosProdutos() // Exercício 3
        {
            var resultado1 = Utils.CalcularDiferencaDosProdutos(5, 6, 7, 8);
            var resultado2 = Utils.CalcularDiferencaDosProdutos(5, 6, -7, 8);

            Assert.AreEqual(-26, resultado1);
            Assert.AreEqual(86, resultado2);
        }

        [TestMethod]
        public void TestTrazerInformacoesDeUmFuncionario() // Exercício 4
        {
            Funcionario funcionario1 = Utils.InfoFuncionario(25, 100, 5.50);
            Funcionario funcionario2 = Utils.InfoFuncionario(1, 200, 20.50);
            Funcionario funcionario3 = Utils.InfoFuncionario(6, 145, 15.55);

            Assert.AreEqual(25, funcionario1.Codigo);
            Assert.AreEqual(550.00, funcionario1.Salario);
            Assert.AreEqual(1, funcionario2.Codigo);
            Assert.AreEqual(4100.00, funcionario2.Salario);
            Assert.AreEqual(6, funcionario3.Codigo);
            Assert.AreEqual(2254.75, funcionario3.Salario);
        }

        [TestMethod]
        public void TestTrazerInformacoesDeUmFuncionarios() // Exercício 5
        {
            int qtde1 = 1;
            double preco1 = 5.30;

            int qtde2 = 2;
            double preco2 = 5.10;            

            double total;

            total = preco1 * qtde1 + preco2 * qtde2;

            Assert.AreEqual(15.50, total);
        }
    }
}
