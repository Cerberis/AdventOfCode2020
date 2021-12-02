namespace AdventOfCode2020.Days
{
    internal class Day3Part1 : Day3
    {

        internal Day3Part1(string filePath, int[] rowInterval, int[] colInterval) : base(filePath, rowInterval, colInterval)
        {
        }

        internal override int Calculate()
        {
            var result = 1;
            for (int colRowPair = 0; colRowPair < RowInterval.Length; colRowPair++)
            {
                var currentCol = 0;
                for (int row = 1; row < ParsedData.Count; row += RowInterval[colRowPair])
                {
                    currentCol += ColInterval[colRowPair];
                    if (ParsedData[row].Count - 1 < currentCol)
                        currentCol -= ParsedData[row].Count;

                    if (ParsedData[row][currentCol] == '#')
                        ParsedData[row][currentCol] = 'X';
                    else
                        ParsedData[row][currentCol] = 'O';
                }
                //PrintWalkedPath(ParsedData);
                var treesEncountered = ParsedData.Sum(m => m.Count(n => n == 'X'));
                Console.WriteLine($"RowIncrement: {RowInterval[colRowPair]}, ColIncrement: {ColInterval[colRowPair]}, Trees encountered: {treesEncountered}");
                result *= treesEncountered;
            }
            return result;
        }
    }
}