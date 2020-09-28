namespace MatrixTrail.Interfaces
{
    public interface IInputReader
    {
        uint RowsInput { get; set; }
        uint ColsInput { get; set; }

        void ReadInput();
    }
}
