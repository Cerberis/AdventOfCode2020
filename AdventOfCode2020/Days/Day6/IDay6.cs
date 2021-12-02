namespace AdventOfCode2020.Days
{
    internal abstract class Day6
    {
        public Dictionary<int, int> ParsedData { get; set; }

        public Day6(string filePath)
        {
            ParsedData = ReadDataIntoModel(filePath);
        }

        internal int Calculate()
        {
            return ParsedData.Sum(m => m.Value);
        }

        internal void Execute()
        {
            Console.WriteLine($"Result: {Calculate()}");
        }

        internal abstract Dictionary<int, int> ReadDataIntoModel(string filePath);
    }
}