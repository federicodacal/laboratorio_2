using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace Test
{
    [TestClass]
    public class CompetenciaTest
    {
        [TestMethod]
        public void AlInstanciarObjCompetencia_DeberaInstanciarseAtributoDeLista()
        {
            // Arrange
            Competencia c;

            // Act 
            c = new Competencia(4, 4, Competencia.TipoCompetencia.F1);

            // Assert
            Assert.IsNotNull(c.ListaCompetidores);
        }

        [TestMethod]
        [ExpectedException(typeof(CompetenciaNoDisponibleException))]
        public void AlAgregarUnAutoF1ACarreraDeTipoMotoCross_DeberaLanzarCompetenciaException()
        {
            // Arrange
            Competencia c = new Competencia(3, 12, Competencia.TipoCompetencia.MotoCross);
            AutoF1 a = new AutoF1(14, "Fiat");

            // Act 
            _ = c + a;
        }

        [TestMethod]
        public void AlAgregarUnaMotoCrossACarreraDeTipoMotoCross_DeberaAgregarloACompetidores()
        {
            // Arrange
            Competencia c = new Competencia(3, 12, Competencia.TipoCompetencia.MotoCross);
            MotoCross m1 = new MotoCross(14, "Motoneta");
            MotoCross m2 = new MotoCross(18, "Motito");

            // Act 
            _ = c + m1;
            _ = c + m2;

            // Assert
            Assert.AreEqual(2, c.ListaCompetidores.Count);
            Assert.AreSame(m1, c.ListaCompetidores[0]);
            Assert.AreSame(m2, c.ListaCompetidores[1]);
            Assert.IsTrue(c == m1);
            Assert.IsTrue(c == m2);
        }

    }
}
