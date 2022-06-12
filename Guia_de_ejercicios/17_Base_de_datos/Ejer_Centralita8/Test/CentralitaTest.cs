using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace Test
{
    [TestClass]
    public class CentralitaTest
    {
        [TestMethod]
        public void AlInstanciarObjCentralita_DeberaInstanciarseElAtributoListaDeLlamadas()
        {
            // Arrange
            Centralita c;

            // Act 
            c = new Centralita("Centralita");

            // Assert
            Assert.IsNotNull(c.Llamadas);
        }

        [TestMethod]
        [ExpectedException(typeof(CentralitaException))]
        public void CuandoSeCargaDosLlamadasLocalConMismosNumerosDeOrigenYDestino_DeberaLanzarCentralitaException()
        {
            // Arrange
            Centralita c = new Centralita("Centralita");
            Local l1 = new Local("44445", 10, "49494", 12F);
            Local l2 = new Local("44445", 15, "49494", 15.5F);

            // Act 
            _ = c + l1;
            _ = c + l2;
        }

        [TestMethod]
        [ExpectedException(typeof(CentralitaException))]
        public void CuandoSeCargaDosLlamadasProvincialConMismosNumerosDeOrigenYDestino_DeberaLanzarCentralitaException()
        {
            // Arrange
            Centralita c = new Centralita("Centralita");
            Provincial p1 = new Provincial("40091", Provincial.Franja.Franja_2, 30, "49499");
            Provincial p2 = new Provincial("40091", Provincial.Franja.Franja_1, 35, "49499");

            // Act 
            _ = c + p1;
            _ = c + p2;
        }

        [TestMethod]
        public void LlamadasDeMismoTipoConMismoNumeroDestinoYNumeroOrigen_SonIguales()
        {
            // Arrange
            Provincial p1 = new Provincial("40091", Provincial.Franja.Franja_2, 30, "49499");
            Provincial p2 = new Provincial("40091", Provincial.Franja.Franja_1, 35, "49499");
            Local l1 = new Local("40091", 10, "49499", 12F);
            Local l2 = new Local("40091", 15, "49499", 15.5F);

            // Act 
            bool rta1 = p1 == p2;
            bool rta2 = p1 == l1;
            bool rta3 = p1 == l2;
            bool rta4 = p2 == l1;
            bool rta5 = p2 == l2;
            bool rta6 = l1 == l2;

            // Assert 
            Assert.IsTrue(rta1);
            Assert.IsTrue(rta6);
            Assert.IsFalse(rta2);
            Assert.IsFalse(rta3);
            Assert.IsFalse(rta4);
            Assert.IsFalse(rta5);

        }
    }
}
