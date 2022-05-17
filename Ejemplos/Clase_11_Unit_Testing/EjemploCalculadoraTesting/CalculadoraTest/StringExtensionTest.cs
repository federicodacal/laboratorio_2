using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Test
{
    [TestClass]
    public class StringExtensionTest
    {
        [TestMethod]
        public void ContarVocales_CuandoNoTieneVocales_DeberiaRetornarCero()
        {
            // Arrange
            int expected = 0;
            string text = "tyqrtyl plrpw";

            // Act
            int actual = StringExtension.ContarVocales(text);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ContarVocales_CuandoTieneDosVocalesMinus_DeberiaRetornarDos()
        {
            // Arrange
            int expected = 2;
            string text = "casa";

            // Act
            int actual = StringExtension.ContarVocales(text);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ContarVocales_CuandoTieneDosVocalesMayus_DeberiaRetornarDos()
        {
            // Arrange
            int expected = 2;
            string text = "cAsA";

            // Act
            int actual = StringExtension.ContarVocales(text);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ContarVocales_CuandoElTextoEsNulo_DeberiaRetornarCero()
        {
            // Arrange
            int expected = 0;
            string text = null;

            // Act
            int actual = StringExtension.ContarVocales(text);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }


}
