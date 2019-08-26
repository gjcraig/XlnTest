using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XlnTest
{
    public class InputReader : IInputReader
    {
        public int ReadDirection(char arrow)
        {
            if (arrow.Equals('<'))
            {
                return -1;
            }
            if (arrow.Equals('>'))
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public int[] ReadStart(string[] robotStart)
        {
            for(int i = 0; i < robotStart.Length; i++)
            {
                if (robotStart[i].Equals("N"))
                {
                    robotStart[i] = "0";
                }
                if (robotStart[i].Equals("E"))
                {
                    robotStart[i] = "1";
                }
                if (robotStart[i].Equals("S"))
                {
                    robotStart[i] = "2";
                }
                if (robotStart[i].Equals("W"))
                {
                    robotStart[i] = "3";
                }
            }

            return Array.ConvertAll(robotStart, Int32.Parse);
        }
    }
}
