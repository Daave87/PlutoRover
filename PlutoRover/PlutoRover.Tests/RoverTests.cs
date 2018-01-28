﻿using NUnit.Framework;

namespace PlutoRover.Tests
{
    [TestFixture]
    public class RoverTests
    {
        [Test]
        public void ForwardCommandWhenFacingNorthIncreasesYByOne()
        {
            //arrange
            var rover = new Rover();

            //act
            rover.Go("F");

            //assert
            Assert.That(rover.X == 0);
            Assert.That(rover.Y == 1);
            Assert.That(rover.Direction == "N");
        }
        
        [Test]
        public void ForwardCommandTwiceWhenFacingNorthIncreasesYByTwo()
        {
            //arrange
            var rover = new Rover();

            //act
            rover.Go("F");
            rover.Go("F");
            
            //assert
            Assert.That(rover.X == 0);
            Assert.That(rover.Y == 2);
            Assert.That(rover.Direction == "N");
        }

        [Test]
        public void BackwardsCommandTwiceWhenFacingNorthDecreasesYByOne()
        {
            //arrange
            var rover = new Rover();

            //act
            rover.Go("B");

            //assert
            Assert.That(rover.X == 0);
            Assert.That(rover.Y == -1);
            Assert.That(rover.Direction == "N");
        }

        [Test]
        public void BackwardsCommandWhenFacingSouthIncreasesYByOne()
        {
            //arrange
            var rover = new Rover(0, 0, "S");

            //act
            rover.Go("B");

            //assert
            Assert.That(rover.X == 0);
            Assert.That(rover.Y == 1);
            Assert.That(rover.Direction == "S");
        }

        [Test]
        public void LeftCommandWhenFacingNorthMakesDirectionEqualWest()
        {
            //arrange
            var rover = new Rover();

            //act
            rover.Go("L");

            //assert
            Assert.That(rover.X == 0);
            Assert.That(rover.Y == 0);
            Assert.That(rover.Direction == "W");
        }

        [Test]
        public void RightCommandWhenFacingNorthMakesDirectionEqualEast()
        {
            //arrange
            var rover = new Rover();

            //act
            rover.Go("R");

            //assert
            Assert.That(rover.X == 0);
            Assert.That(rover.Y == 0);
            Assert.That(rover.Direction == "E");
        }

        [Test]
        public void MultipleCommandsCanBeExecutedAtOne()
        {
            //arrange
            var rover = new Rover();

            //act
            rover.Go("FF");

            //assert
            Assert.That(rover.X == 0);
            Assert.That(rover.Y == 2);
            Assert.That(rover.Direction == "N");
        }
    }
}
