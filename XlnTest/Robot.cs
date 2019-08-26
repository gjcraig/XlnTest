using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XlnTest
{
    public class Robot : IRobot
    {
        public int X { get; set; }  // x coordinate of robot
        public int Y { get; set; } // y coordinate of robot
        public int XMax { get; set; } // Limit on x coordinate from warehouse size
        public int YMax { get; set; } // Limit on y coordinate from warehouse size
        public int Direction { get; set; } // The compass direction the robot is facing. {0,1,2,3} corresponds to N,E,S,W respectively

        IInputReader _inputReader;

        public Robot(IInputReader inputReader)
        {
            _inputReader = inputReader;
        }

        private double Mod(double a, double b)  // We will need true modulo function
        {
            return a - b * Math.Floor(a / b);
        }

        public void MoveRobot(char[] instructions)
        {
            
            foreach (char arrow in instructions)
            {
                // first check for a turn
                var turn = _inputReader.ReadDirection(arrow);
                Direction += turn;
                Direction = Convert.ToInt32(Mod(Convert.ToDouble(Direction),4));
                // If no turn move forward
                if (turn == 0)
                {
                    if (Direction == 0)  // N
                    {
                        Y += 1;
                    }
                    if (Direction == 1)  // E
                    {
                        X += 1;
                    }
                    if (Direction == 2) // S
                    {
                        Y -= 1;
                    }
                    if (Direction == 3)  // W
                    {
                        X -= 1;
                    }
                }
                // check coordinate are within warehouse domain
                if (X > XMax)
                {
                    X = XMax;
                }
                if (X < 0)
                {
                    X = 0;
                }
                if (Y > YMax)
                {
                    Y = YMax;
                }
                if (Y < 0)
                {
                    Y = 0;
                }
            }   
        }
    }
}
