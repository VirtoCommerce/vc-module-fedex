using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VirtoCommerce.FedExModule.Web.Tests
{
    [TestClass]
    public class VolumeConverterTests
    {
        [TestMethod]
        public void SimpleVolumeCorrect()
        {
            double volume = 10 * 10 * 10;

            var dimension = volume.ToCubeDimension();

            Assert.AreEqual(10D, dimension, 0.001);
        }

        [TestMethod]
        public void RectangularVolumeCorrect()
        {
            double volume = 11 * 7 * 10;

            var dimension = volume.ToCubeDimension();

            Assert.AreEqual(9.1656D, dimension, 0.001);
        }

        [TestMethod]
        public void SimpleFractionalVolumeCorrect()
        {
            double volume = 10.5 * 10.5 * 10.5;

            var dimension = volume.ToCubeDimension();

            Assert.AreEqual(10.5D, dimension, 0.001);
        }

        [TestMethod]
        public void RectangularFractionalVolumeCorrect()
        {
            double volume = 10.15 * 11.76 * 7.95;

            var dimension = volume.ToCubeDimension();

            Assert.AreEqual(9.8268D, dimension, 0.001);
        }
    }
}
