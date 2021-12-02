namespace AdventOfCode2020.Days
{
    internal class Day6Part1 : Day6
    {

        internal Day6Part1(string filePath) : base(filePath)
        {
        }

        internal override Dictionary<int, int> ReadDataIntoModel(string filePath)
        {
            var result = new Dictionary<int, int>();
            var stringRows = File.ReadAllLines(filePath);

            int groupNumber = 1;
            var foundDifferentAnswers = new List<char>();
            foreach (var dataRow in stringRows)
            {
                if (string.IsNullOrEmpty(dataRow))
                {
                    result.Add(groupNumber, foundDifferentAnswers.Distinct().Count());

                    groupNumber++;
                    foundDifferentAnswers = new List<char>();
                    continue;
                }
                foundDifferentAnswers.AddRange(dataRow.Distinct());
            }
            if (foundDifferentAnswers.Any())
            {
                result.Add(groupNumber, foundDifferentAnswers.Distinct().Count());
            }

            return result;
        }
    }
}