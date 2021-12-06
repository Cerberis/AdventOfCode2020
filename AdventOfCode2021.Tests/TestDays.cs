using AdventOfCode2020.Enumerations;
using NUnit.Framework;

namespace AdventOfCode2020.Tests
{
    public class TestDays
    {
        [Test]
        public void Day1Part1()
        {
            //Assign
            var runmode = RunMode.Day1Part1;
            var expectedResult = "964875";

            //Act
            var result = RunModeHandler.Execute(runmode);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void Day1Part2()
        {
            //Assign
            var runmode = RunMode.Day1Part2;
            var expectedResult = "158661360";

            //Act
            var result = RunModeHandler.Execute(runmode);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void Day2Part1()
        {
            //Assign
            var runmode = RunMode.Day2Part1;
            var expectedResult = "506";

            //Act
            var result = RunModeHandler.Execute(runmode);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void Day2Part2()
        {
            //Assign
            var runmode = RunMode.Day2Part2;
            var expectedResult = "443";

            //Act
            var result = RunModeHandler.Execute(runmode);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void Day3Part1()
        {
            //Assign
            var runmode = RunMode.Day3Part1;
            var expectedResult = "193";

            //Act
            var result = RunModeHandler.Execute(runmode);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void Day3Part2()
        {
            //Assign
            var runmode = RunMode.Day3Part2;
            var expectedResult = "1355323200";

            //Act
            var result = RunModeHandler.Execute(runmode);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void Day4Part1()
        {
            //Assign
            var runmode = RunMode.Day4Part1;
            var expectedResult = "219";

            //Act
            var result = RunModeHandler.Execute(runmode);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void Day4Part2()
        {
            //Assign
            var runmode = RunMode.Day4Part2;
            var expectedResult = "127";

            //Act
            var result = RunModeHandler.Execute(runmode);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void Day5Part1()
        {
            //Assign
            var runmode = RunMode.Day5Part1;
            var expectedResult = "874";

            //Act
            var result = RunModeHandler.Execute(runmode);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void Day5Part2()
        {
            //Assign
            var runmode = RunMode.Day5Part2;
            var expectedResult = "594";

            //Act
            var result = RunModeHandler.Execute(runmode);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void Day6Part1()
        {
            //Assign
            var runmode = RunMode.Day6Part1;
            var expectedResult = "6351";

            //Act
            var result = RunModeHandler.Execute(runmode);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void Day6Part2()
        {
            //Assign
            var runmode = RunMode.Day6Part2;
            var expectedResult = "3143";

            //Act
            var result = RunModeHandler.Execute(runmode);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void Day7Part1()
        {
            //Assign
            var runmode = RunMode.Day7Part1;
            var expectedResult = "257";

            //Act
            var result = RunModeHandler.Execute(runmode);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void Day7Part2()
        {
            //Assign
            var runmode = RunMode.Day7Part2;
            var expectedResult = "1038";

            //Act
            var result = RunModeHandler.Execute(runmode);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

         [Test]
        public void Day8Part1()
        {
            //Assign
            var runmode = RunMode.Day8Part1;
            var expectedResult = "1744";

            //Act
            var result = RunModeHandler.Execute(runmode);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void Day8Part2()
        {
            //Assign
            var runmode = RunMode.Day8Part2;
            var expectedResult = "1174";

            //Act
            var result = RunModeHandler.Execute(runmode);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}