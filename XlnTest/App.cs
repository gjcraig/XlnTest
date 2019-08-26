using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XlnTest
{
    class App : IApp
    {
        IRobot _robot;
        IInputReader _inputReader;


        public App(IRobot robot, IInputReader inputReader)
        {
            _robot = robot;
            _inputReader = inputReader;
        }

        public void Run()
        {
            string[] gridSizeString;
            int[] gridSize;
            Dictionary<int, string> compass = new Dictionary<int, String>()
            {
                {0, "N"},
                {1, "E"},
                {2, "S"},
                {3, "W"}
            };

            Robot robot1 = new Robot(_inputReader);
            Robot robot2 = new Robot(_inputReader);
            

            Console.WriteLine("Warehouse Size:");
            gridSizeString = Console.ReadLine().Split(' ').ToArray();
            gridSize = Array.ConvertAll(gridSizeString, Int32.Parse);
            robot1.XMax = gridSize[0];
            robot1.YMax = gridSize[1];
            robot2.XMax = gridSize[0];
            robot2.YMax = gridSize[1];

            Console.WriteLine("First Robot Start:");
            string[] robotStartString1 = Console.ReadLine().Split(' ');
            int[] robotStart1 = _inputReader.ReadStart(robotStartString1);

            Console.WriteLine("First Robot Movement Instructions:");
            char[] movementInput1 = Console.ReadLine().ToCharArray();

            Console.WriteLine("Second Robot Start:");
            string[] robotStartString2 = Console.ReadLine().Split(' ');
            int[] robotStart2 = _inputReader.ReadStart(robotStartString2);

            Console.WriteLine("Second Robot Movement Instructions:");
            char[] movementInput2 = Console.ReadLine().ToCharArray();

            // set start conditions
            robot1.X = robotStart1[0];
            robot1.Y = robotStart1[1];
            robot1.Direction = robotStart1[2];
            robot2.X = robotStart2[0];
            robot2.Y = robotStart2[1];
            robot2.Direction = robotStart2[2];

            robot1.MoveRobot(movementInput1);
            robot2.MoveRobot(movementInput2);
            Console.WriteLine("{0} {1} {2}", robot1.X, robot1.Y, compass[robot1.Direction]);
            Console.WriteLine("{0} {1} {2}", robot2.X, robot2.Y, compass[robot2.Direction]);
        }
    }
}
