using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MatrixTrail.Tests
{
    [TestClass()]
    public class MatrixGeneratorTests
    {
        [TestMethod()]
        public void UserInputValidatorTest()
        {
            //arrange
            Matrix m = new Matrix();

            //act

            int min = 0, max = 100;
            Random random = new Random();

            m.MatrixArrayBuilder(random.Next(min, max), random.Next(min, max));

            //assert
            Assert.IsTrue(m.MatrixTrail >= 0);
        }
    }
}