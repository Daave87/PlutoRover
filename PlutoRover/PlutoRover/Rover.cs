
namespace PlutoRover
{
    public class Rover
    {
        public int X { get; set; }
        public int Y { get; set; }
        public string Direction { get; set; }

        public void Go(string input)
        {
            foreach (var c in input)
            {
                ProcessCommand(c);
            }
        }

        private void ProcessCommand(char command)
        {
            if (Direction == "N" && command == 'F')
            {
                Y += 1;
                return;
            }
            if (Direction == "N" && command == 'B')
            {
                Y -= 1;
                return;
            }
            if (Direction == "S" && command == 'F')
            {
                Y -= 1;
                return;
            }
            if (Direction == "S" && command == 'B')
            {
                Y += 1;
                return;
            }
            if (Direction == "N" && command == 'L')
            {
                Direction = "W";
                return;
            }
            if (Direction == "W" && command == 'L')
            {
                Direction = "S";
                return;
            }
            if (Direction == "S" && command == 'L')
            {
                Direction = "E";
                return;
            }
            if (Direction == "E" && command == 'L')
            {
                Direction = "N";
                return;
            }
            if (Direction == "N" && command == 'R')
            {
                Direction = "E";
                return;
            }
            if (Direction == "E" && command == 'R')
            {
                Direction = "S";
                return;
            }
            if (Direction == "S" && command == 'R')
            {
                Direction = "W";
                return;
            }
            if (Direction == "W" && command == 'R')
            {
                Direction = "N";
                return;
            }
        }

        public Rover()
        {
            X = 0;
            Y = 0;
            Direction = "N";
        }
        
        public Rover(int xStart, int yStart, string directionStart)
        {
            X = xStart;
            Y = yStart;
            Direction = directionStart;
        }
    }
}
