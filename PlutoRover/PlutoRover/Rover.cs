
using System;
using System.Collections.Generic;
using System.Linq;

namespace PlutoRover
{
    public class Rover
    {
        public int X { get; set; }
        public int Y { get; set; }
        public string Direction { get; set; }

        public bool EncounteredObstacle = false;

        private readonly int _gridSize;
        private List<Tuple<int, int>>  _obstacles;

        public Rover(int gridSize)
        {
            _gridSize = gridSize;
            X = 0;
            Y = 0;
            Direction = "N";
            _obstacles = new List<Tuple<int, int>>();
        }

        public Rover(int xStart, int yStart, string directionStart, int gridSize)
        {
            X = xStart;
            Y = yStart;
            Direction = directionStart;
            _gridSize = gridSize;
            _obstacles = new List<Tuple<int, int>>();
        }

        public Rover(int xStart, int yStart, string directionStart, int gridSize, List<Tuple<int,int>> obstacles)
        {
            X = xStart;
            Y = yStart;
            Direction = directionStart;
            _gridSize = gridSize;
            _obstacles = obstacles;
        }

        public void Go(string input)
        {
            foreach (var c in input)
            {
                if (!EncounteredObstacle)
                {
                    ProcessCommand(c);
                }
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
                    GoNorth();
                    break;
                case "E":
                    GoEast();
                    break;
                case "S":
                    GoSouth();
                    break;
                case "W":
                    GoWest();
                    break;
            }
        }
        
        private void GoBackwards()
        {
            switch (Direction)
            {
                case "N":
                    GoSouth();
                    break;
                case "E":
                    GoWest();
                    break;
                case "S":
                    GoNorth();
                    break;
                case "W":
                    GoEast();
                    break;
            }
        }

        private void GoWest()
        {
            X -= 1;
            if (X < 0)
            {
                X = _gridSize - 1;
            }
        }

        private void GoSouth()
        {
            Y -= 1;
            if (Y < 0)
            {
                Y = _gridSize - 1;
            }

            if (_obstacles.Any(x => x.Item1 == X && x.Item2 == Y))
            {
                GoNorth();
                EncounteredObstacle = true;
            }
        }

        private void GoEast()
        {
            X += 1;
            if (X >= _gridSize)
            {
                X = 0;
            }
        }

        private void GoNorth()
        {
            Y += 1;
            if (Y >= _gridSize)
            {
                Y = 0;
            }

            if (_obstacles.Any(x => x.Item1 == X && x.Item2 == Y))
            {
                GoSouth();
                EncounteredObstacle = true;
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
