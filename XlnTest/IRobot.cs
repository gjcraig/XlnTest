namespace XlnTest
{
    public interface IRobot
    {
        int Direction { get; set; }
        int X { get; set; }
        int XMax { get; set; }
        int Y { get; set; }
        int YMax { get; set; }

        void moveRobot(char[] movementString);
    }
}