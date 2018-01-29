using NUnit.Framework;

namespace PlutoRover.Tests
{
    [TestFixture]
    public class RoverTests
    {
        [TestCase(0, 0, "N", "F", 0, 1, "N")]
        [TestCase(0, 0, "N", "FF", 0, 2, "N")]
        [TestCase(0, 0, "N", "B", 0, -1, "N")]
        [TestCase(0, 0, "S", "B", 0, 1, "S")]
        [TestCase(0, 0, "N", "L", 0, 0, "W")]
        [TestCase(0, 0, "N", "R", 0, 0, "E")]
        [TestCase(0, 0, "N", "LL", 0, 0, "S")]
        [TestCase(0, 0, "N", "RR", 0, 0, "S")]
        [TestCase(0, 0, "N", "RRRR", 0, 0, "N")]
        [TestCase(0, 0, "S", "LLLL", 0, 0, "S")]
        [TestCase(0, 99, "N", "F", 0, 0, "N")]
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
    }
}
