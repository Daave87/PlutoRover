
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
            }
            if (Direction == "N" && command == 'B')
            {
                Y -= 1;
            }
            if (Direction == "S" && command == 'F')
            {
                Y -= 1;
            }
            if (Direction == "S" && command == 'B')
            {
                Y += 1;
            }
            if (command == 'L' && Direction == "N")
            {
                Direction = "W";
            }
            if (command == 'R' && Direction == "N")
            {
                Direction = "E";
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
