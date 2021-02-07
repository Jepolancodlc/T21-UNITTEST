using Microsoft.VisualStudio.TestTools.UnitTesting;
using T21_UnitTest;

namespace CalculadoraTests
{
    [TestClass]
    public class UnitTest1
    {
        Geometria g = new Geometria();
        [TestMethod]
        public void areacuadradoTest()
        {
         
            int r = g.areacuadrado(2);
            Assert.AreEqual(4, r);
        }
        [TestMethod()]
        public void areaCirculoTest()
        {
         
            double r = g.areaCirculo(8);
            Assert.AreEqual(201.0624, r);
        }

        [TestMethod()]
        public void areatrianguloTest()
        {
         
            int r = g.areatriangulo(4, 2);
            Assert.AreEqual(4, r);
        }

        [TestMethod()]
        public void arearectanguloTest()
        {
            int r = g.arearectangulo(4, 6);
            Assert.AreEqual(24, r);
        }

        [TestMethod()]
        public void areapentagonoTest()
        {
            int r = g.areapentagono(4, 10);
            Assert.AreEqual(20, r);
        }

        [TestMethod()]
        public void arearomboTest()
        {
           
            int r = g.arearombo(4, 6);
            Assert.AreEqual(12, r);
        }

        [TestMethod()]
        public void arearomboideTest()
        {
            int r = g.arearomboide(5, 5);
            Assert.AreEqual(25, r);
        }

        [TestMethod()]
        public void areatrapecioTest()
        {
           
            int r = g.areatrapecio(5, 10, 2);
            Assert.AreEqual(14, r);
        }
    }
}
