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
        }

        public Rover()
        {
            x = 0;
            y = 0;
            Direction = "N";
        }
    }
}
