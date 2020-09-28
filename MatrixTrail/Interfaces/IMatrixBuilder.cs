namespace MatrixTrail.Interfaces
{
    interface IMatrixBuilder
    {
        int MatrixTrail { get; set; }
        int[,] MatrixArray { get; set; }


        void BuildMatrix(uint rows, uint cols);
    }
}
