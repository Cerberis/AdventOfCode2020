namespace AdventOfCode2020.Days
{
    internal abstract class Day3
    {
        public int[] RowInterval { get; set; }
        public int[] ColInterval { get; set; }
        public List<List<char>> ParsedData { get; set; }

        public Day3(string filePath, int[] rowInterval, int[] colInterval)
        {
            ParsedData = ReadDataIntoModel(filePath);
            RowInterval = rowInterval;
            ColInterval = colInterval;
        }

        internal string Execute()
        {
            var treesEncountered = Calculate();
            Console.WriteLine($"Trees encountered: {treesEncountered}");
            return treesEncountered.ToString();
        }

       internal abstract int Calculate();

        List<List<char>> ReadDataIntoModel(string filePath)
        {
            var result = new List<List<char>>();
            var stringRows = File.ReadAllLines(filePath).ToList();
            foreach (var stringRow in stringRows)
            {
                result.Add(stringRow.ToList());
            }
            return result;
        }

       protected void PrintWalkedPath(List<List<char>> data)
        {
            data.ForEach(m => Console.WriteLine(new string(m.ToArray())));
        }
    }
}