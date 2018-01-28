using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlutoRover
{
    public class Rover
    {
        public int x { get; set; }
        public int y { get; set; }
        public string Direction { get; set; }

        public void Go(string command)
        {
            if (Direction == "N" && command == "F")
            {
                y += 1;
            }
            if (Direction == "N" && command == "B")
            {
                y -= 1;
            }
            if (Direction == "S" && command == "F")
            {
                y -= 1;
            }
            if (Direction == "S" && command == "B")
            {
                y += 1;
            }
            if (command == "L" && Direction == "N")
            {
                Direction = "E";
            }
        }

        public Rover()
        {
            x = 0;
            y = 0;
            Direction = "N";
        }
        
        public Rover(int xStart, int yStart, string directionStart)
        {
            x = xStart;
            y = yStart;
            Direction = directionStart;
        }
    }
}
