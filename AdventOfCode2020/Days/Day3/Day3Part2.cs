namespace AdventOfCode2020.Days
{
    internal class Day3Part2 : Day3
    {
        internal Day3Part2(string filePath, int[] rowInterval, int[] colInterval) : base(filePath, rowInterval, colInterval)
        {
        }

        internal override int Calculate()
        {
            var result = 1;

            for (int colRowPair = 0; colRowPair < RowInterval.Length; colRowPair++)
            {
                Console.WriteLine("-------------------------");
                Console.WriteLine($"RowIncrement: {RowInterval[colRowPair]}, ColIncrement: {ColInterval[colRowPair]}");
                var currentCol = 0;
                for (int row = RowInterval[colRowPair]; row + RowInterval[colRowPair] <= ParsedData.Count; row += RowInterval[colRowPair])
                {
                    currentCol += ColInterval[colRowPair];
                    if (ParsedData[row].Count - 1 < currentCol)
                        currentCol -= ParsedData[row].Count;

                    if (ParsedData[row][currentCol] == '#')
                        ParsedData[row][currentCol] = 'X';
                    else
                        ParsedData[row][currentCol] = 'O';
                }
 
                var treesEncountered = ParsedData.Sum(m => m.Count(n => n == 'X'));
                Console.WriteLine($"Trees encountered: {treesEncountered}");
                result *= treesEncountered;
                RemoveStepsTaken();
            }
            return result;
        }

        void RemoveStepsTaken()
        {
            for (int row = 0; row < ParsedData.Count; row++)
            {
                for (int col = 0; col < ParsedData[row].Count; col++)
                {
                    if (ParsedData[row][col] == 'X')
                        ParsedData[row][col] = '#';
                    else if (ParsedData[row][col] == 'O')
                        ParsedData[row][col] = '.';
                }
            }
        }
    }
}