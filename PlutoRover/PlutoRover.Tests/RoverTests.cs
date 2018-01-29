using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace PlutoRover.Tests
{
    [TestFixture]
    public class RoverTests
    {
        [TestCase(0, 0, "N", "F", 0, 1, "N")]
        [TestCase(0, 0, "N", "FF", 0, 2, "N")]
        [TestCase(0, 0, "N", "B", 0, 99, "N")]
        [TestCase(0, 0, "S", "B", 0, 1, "S")]
        [TestCase(0, 0, "N", "L", 0, 0, "W")]
        [TestCase(0, 0, "N", "R", 0, 0, "E")]
        [TestCase(0, 0, "N", "LL", 0, 0, "S")]
        [TestCase(0, 0, "N", "RR", 0, 0, "S")]
        [TestCase(0, 0, "N", "RRRR", 0, 0, "N")]
        [TestCase(0, 0, "S", "LLLL", 0, 0, "S")]
        [TestCase(0, 99, "N", "F", 0, 0, "N")]
        [TestCase(99, 99, "N", "FRF", 0, 0, "E")]
        [TestCase(0, 0, "S", "FRF", 99, 99, "W")]
        public void RoverImplementsCommandsCorrectly(int x, int y, string direction, string command, int xFinal, int yFinal, string directionFinal)
        {
            //arrange
            var rover = new Rover(x, y, direction, 100);

            //act
            rover.Go(command);

            //assert
            Assert.That(rover.X == xFinal);
            Assert.That(rover.Y == yFinal);
            Assert.That(rover.Direction == directionFinal);
        }

        [TestCase(0, 0, "N", "F", 0, 0, "N", true)]
        [TestCase(0, 0, "E", "F", 1, 0, "E", false)]
        [TestCase(0, 0, "N", "B", 0, 0, "N", true)]
        [TestCase(0, 0, "W", "F", 0, 0, "W", true)]
        [TestCase(0, 0, "N", "FRF", 0, 0, "N", true)]
        public void RoverReportsEncounteredObstaclesAndStops(int x, int y, string direction, string command, int xFinal, int yFinal, string directionFinal, bool encounteredObstacle)
        {
            var obstacles = new List<Tuple<int, int>>
            {
                new Tuple<int, int>(0, 1),
                new Tuple<int, int>(0, 99),
                new Tuple<int, int>(99, 0)
            };

            //arrange
            var rover = new Rover(x, y, direction, 100, obstacles);

            //act
            rover.Go(command);

            //assert
            Assert.That(rover.X == xFinal);
            Assert.That(rover.Y == yFinal);
            Assert.That(rover.Direction == directionFinal);
            Assert.That(rover.EncounteredObstacle == encounteredObstacle);
        }
    }
}
