
namespace PlutoRover
{
    public class Rover
    {
        public int X { get; set; }
        public int Y { get; set; }
        public string Direction { get; set; }

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

        public void Go(string input)
        {
            foreach (var c in input)
            {
                ProcessCommand(c);
            }
        }

        private void ProcessCommand(char command)
        {
            switch (command)
            {
                case 'F':
                    GoForward();
                    break;
                case 'B':
                    GoBackwards();
                    break;
                case 'L':
                    TurnLeft();
                    break;
                case 'R':
                    TurnRight();
                    break;
            }
        }

        private void GoForward()
        {
            switch (Direction)
            {
                case "N":
                    Y += 1;
                    break;
                case "E":
                    X += 1;
                    break;
                case "S":
                    Y -= 1;
                    break;
                case "W":
                    X -= 1;
                    break;
            }
        }

        private void GoBackwards()
        {
            switch (Direction)
            {
                case "N":
                    Y -= 1;
                    break;
                case "E":
                    X -= 1;
                    break;
                case "S":
                    Y += 1;
                    break;
                case "W":
                    X += 1;
                    break;
            }
        }

        private void TurnLeft()
        {
            switch (Direction)
            {
                case "N":
                    Direction = "W";
                    break;
                case "W":
                    Direction = "S";
                    break;
                case "S":
                    Direction = "E";
                    break;
                case "E":
                    Direction = "N";
                    break;
            }
        }

        private void TurnRight()
        {
            switch (Direction)
            {
                case "N":
                    Direction = "E";
                    break;
                case "E":
                    Direction = "S";
                    break;
                case "S":
                    Direction = "W";
                    break;
                case "W":
                    Direction = "N";
                    break;
            }
        }
    }
}
