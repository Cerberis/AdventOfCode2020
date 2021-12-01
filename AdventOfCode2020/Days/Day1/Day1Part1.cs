using CommonCode;

namespace AdventOfCode2020.Days
{
    internal class Day1Part1 : Day1
    {
       internal Day1Part1(int sumToMake) : base(sumToMake)
        {
        }

        internal override void Execute()
        {
            var depthArray = FileReaders.ReadDataFileAsIntArray(@"D:\Projektai\AdventOfCode2020\AdventOfCode2020\Days\Day1\Part1Data.txt");
            IntArray = depthArray;
            var timesDepthIncreased = Calculate(2);
            Console.WriteLine($"Multiplied sum: {timesDepthIncreased}");
        }
    }
}
