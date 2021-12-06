namespace AdventOfCode2020.Days
{
    internal abstract class Day5
    {
        protected const int SeatRowCount = 128;
        public List<string> ParsedData { get; set; }

        public Day5(string filePath)
        {
            ParsedData = ReadDataIntoModel(filePath);
        }

        internal abstract int Calculate();

        internal string Execute()
        {
            var highestSeatId = Calculate();
            Console.WriteLine($"Highest seat ID: {highestSeatId}");
            return highestSeatId.ToString();
        }

        internal  int CalculatedSeatId(int personsRow, int personsSeat)
        {
            return 8 * personsRow + personsSeat;
        }

        internal  (int lowestRow, int highestRow) CalculateSegment((int lowestRow, int highestRow) segments, char boardingPassData)
        {
            int range = (segments.highestRow - segments.lowestRow + 1) / 2;
            switch (boardingPassData)
            {
                case 'F':
                case 'L':
                    return new(segments.lowestRow, segments.highestRow - range);
                case 'B':
                case 'R':
                    return new(segments.lowestRow + range, segments.highestRow);
                default:
                    throw new Exception($"{boardingPassData} i  bad value");
            }
        }

        List<string> ReadDataIntoModel(string filePath)
        {
            var result = new List<string>();
            return File.ReadAllLines(filePath).Where(m => !string.IsNullOrEmpty(m)).ToList();
        }
    }
}