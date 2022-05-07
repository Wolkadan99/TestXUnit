using TextXUnit;
using Xunit;

namespace CalculadoraTestProject
{
    public class CalculadoraTest
    {
        [Fact]
        public void SomarTest()
        {
            Assert.Equal(4, Calculadora.somar(2, 2));
        }
        [Fact]
        public void SubtrairTest()
        {
            Assert.Equal(0, Calculadora.subtrair(2, 2));
        }
        [Fact]
        public void MultiplicarTest()
        {
            Assert.Equal(4, Calculadora.multiplicar(2, 2));
        }
        [Fact]
        public void DividirTest()
        {
            Assert.Equal(1, Calculadora.dividir(2, 2));
        }
    }
}