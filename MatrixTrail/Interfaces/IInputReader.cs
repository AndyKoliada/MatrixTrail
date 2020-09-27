namespace MatrixTrailCalculator
{
    public interface IInputReader
    {
        int[,] MatrixArray { get; set; }

        void ReadInput();
    }
}
