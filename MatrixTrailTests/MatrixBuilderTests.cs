using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MatrixTrailCalculator.Tests
{
    [TestClass()]
    public class MatrixBuilderTests
    {
        [TestMethod()]
        public void BuildMatrixTest()
        {
            var matrix = new MatrixBuilder();

            matrix.BuildMatrix(5, 5);


            Assert.IsTrue(matrix.MatrixTrail > 0);
        }
    }
}