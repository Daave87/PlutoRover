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
            Assert.That(rover.x == 0);
            Assert.That(rover.y == 1);
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
            Assert.That(rover.x == 0);
            Assert.That(rover.y == 2);
            Assert.That(rover.Direction == "N");
        }
    }
}
