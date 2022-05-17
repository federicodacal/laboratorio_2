using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace Test
{
    [TestClass]
    public class CalculadoraTest
    {
        [TestMethod]
        public void Dividir_CuandoElDivisorEsCero_DeberiaRetornarDoubleMinValue()
        {
            // Arrange - Preparar el caso de prueba
            double divisor = 0;
            Calculadora calculadora = new Calculadora();
            double resultadoEsperado = double.MinValue;

            // Act - Invocar al método a probar
            double resultadoActual = calculadora.Dividir(2, divisor);

            // Assert - Verifico que el resultado sea el esperado
            Assert.AreEqual(resultadoEsperado, resultadoActual);
        }

        [TestMethod]
        public void Dividir_CuandoElDivisorNoEsCero_DeberiaRetornarResultadoDivision()
        {
            // Arrange - Preparar el caso de prueba
            double divisor = 2;
            Calculadora calculadora = new Calculadora();
            double resultadoEsperado = 1;

            // Act - Invocar al método a probar
            double resultadoActual = calculadora.Dividir(2, divisor);

            // Assert - Verifico que el resultado sea el esperado
            Assert.AreEqual(resultadoEsperado, resultadoActual);
        }

    }
}
