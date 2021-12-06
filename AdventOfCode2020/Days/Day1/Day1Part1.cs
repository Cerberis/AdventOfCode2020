using CommonCode;

namespace AdventOfCode2020.Days
{
    internal class Day1Part1 : Day1
    {
        internal Day1Part1(string filePath, int sumToMake) : base(filePath, sumToMake)
        {
        }

        internal override string Execute()
        {           
            var timesDepthIncreased = Calculate(2);
            Console.WriteLine($"Multiplied sum: {timesDepthIncreased}");
            return timesDepthIncreased.ToString();
        }
    }
}