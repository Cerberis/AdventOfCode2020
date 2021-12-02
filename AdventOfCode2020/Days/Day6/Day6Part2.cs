namespace AdventOfCode2020.Days
{
    internal class Day6Part2 : Day6
    {
        internal Day6Part2(string filePath) : base(filePath)
        {
        }

        internal override Dictionary<int, int> ReadDataIntoModel(string filePath)
        {
            var result = new Dictionary<int, int>();
            var stringRows = File.ReadAllLines(filePath);

            int groupNumber = 1;
            var foundDifferentAnswers = new List<char>();
            int groups = 1;
            bool passedFirstLine = false;
            foreach (var dataRow in stringRows)
            {
                if (string.IsNullOrEmpty(dataRow))
                {
                    result.Add(groupNumber, foundDifferentAnswers.Distinct().Count());
                    groupNumber++;
                    foundDifferentAnswers = new List<char>();
                    groups++;
                    passedFirstLine = false;
                    continue;
                }

                if (!foundDifferentAnswers.Any() && passedFirstLine == false)
                {
                    foundDifferentAnswers.AddRange(dataRow.Distinct());
                    passedFirstLine = true;
                }
                else
                {
                    foundDifferentAnswers = FindSameAnsweredQuestions(foundDifferentAnswers, dataRow.Distinct());
                }
            }
            if (foundDifferentAnswers.Any())
            {
                result.Add(groupNumber, foundDifferentAnswers.Distinct().Count());
            }

            return result.ToDictionary(pair => pair.Key, pair => pair.Value); ;
        }

        private List<char> FindSameAnsweredQuestions(List<char> foundDifferentAnswers, IEnumerable<char> answerSheet)
        {
            var foundSameQuestions = new List<char>();
            foreach (var differentLetter in foundDifferentAnswers)
            {
                if (answerSheet.Contains(differentLetter))
                    foundSameQuestions.Add(differentLetter);
            }
            return foundSameQuestions;
        }
    }
}