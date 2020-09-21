using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MatrixTrailCalculator.Tests
{
    [TestClass()]
    public class MatrixBuilderTests
    {
        [TestMethod()]
        public void UserInputValidatorTest()
        {
            //arrange
            var inputreader = new ConsoleInputReader();
            var printer = new ConsolePrinter();
            MatrixBuilder m = new MatrixBuilder(inputreader, printer);

            //act

            int min = 0, max = 100;
            Random random = new Random();

            m.BuildMatrix(random.Next(min, max), random.Next(min, max));

            //assert
            Assert.IsTrue(m.MatrixTrail >= 0);
        }
    }
}