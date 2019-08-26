namespace XlnTest
{
    public interface IInputReader
    {
        int ReadDirection(char arrow);
        int[] ReadStart(string[] robotStart);
    }
}