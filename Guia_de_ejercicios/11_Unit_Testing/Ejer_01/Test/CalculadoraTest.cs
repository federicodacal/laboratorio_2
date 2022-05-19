using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using System;

namespace Test
{
    [TestClass]
    public class CalculadoraTest
    {
        [TestMethod]
        public void Add1_StringDeDosNumerosSeparadosPorComa_DeberiaRetornarLaSuma()
        {
            // Arrange
            int expected = 6;
            string cadena = "1,5";

            // Act
            int actual = Calculadora.Add_I(cadena);

            // Assert
            Assert.AreEqual(expected, actual);
            Console.WriteLine(actual);
        }

        [TestMethod]
        public void Add1_StringVacio_DeberiaRetornarCero()
        {
            // Arrange
            int expected = 0;
            string cadena = "";

            // Act
            int actual = Calculadora.Add_I(cadena);

            // Assert
            Assert.AreEqual(expected, actual);
            Console.WriteLine(actual);
        }

        [TestMethod]
        public void Add1_StringConNumeroSeparadoPorComaDeNoNumerico_DeberiaRetornarElNumero()
        {
            // Arrange
            int expected = 3;
            string cadena = "3,hola mundo";

            // Act
            int actual = Calculadora.Add_I(cadena);

            // Assert
            Assert.AreEqual(expected, actual);
            Console.WriteLine(actual);
        }

        [TestMethod]
        public void Add2_StringConNumerosSeparadosPorComa_DeberiaRetornarSuSuma()
        {
            // Arrange
            int expected = 18;
            string cadena = "3,4,1,10";

            // Act
            int actual = Calculadora.Add_II(cadena);

            // Assert
            Assert.AreEqual(expected, actual);
            Console.WriteLine(actual);
        }

        [TestMethod]
        public void Add3_StringConNumerosSeparadosPorComa_DeberiaRetornarSuSuma()
        {
            // Arrange
            int expected = 20;
            string cadena = "1,4,5,10";

            // Act
            int actual = Calculadora.Add_III(cadena);

            // Assert
            Assert.AreEqual(expected, actual);
            Console.WriteLine(actual);
        }

        [TestMethod]
        [ExpectedException(typeof(NegativoNoPermitidoException))]
        public void Add3_StringDeNumerosConNumeroNegativo_DeberiaLanzarNegativoException()
        {
            // Arrange
            string cadena = "1,-4,5,10";

            // Act
            int actual = Calculadora.Add_III(cadena);

            // Assert
            Console.WriteLine(actual);
        }
    }
}
