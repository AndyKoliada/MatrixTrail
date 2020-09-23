using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MatrixTrailCalculator.Tests
{
    [TestClass()]
    public class MatrixBuilderTests
    {
        [TestMethod()]
        public void BuildMatrixTest()
        {
            var reader = new ConsoleInputReader();
            var printer = new ConsolePrinter();
            var matrix = new MatrixBuilder(reader, printer);

            
            matrix.BuildMatrix(reader.ReadInput());


            Assert.IsTrue(matrix.GetType() != reader.GetType());
        }
    }
}