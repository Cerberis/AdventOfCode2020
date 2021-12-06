using CommonCode;

namespace AdventOfCode2020.Days
{
    internal class Day1Part2 : Day1
    {
        internal Day1Part2(string filePath, int sumToMake) : base(filePath, sumToMake)
        {
        }

        internal override string Execute()
        {
            var timesDepthIncreased = Calculate(3);
            Console.WriteLine($"Multiplied sum: {timesDepthIncreased}");
            return timesDepthIncreased.ToString();
        }
    }
}