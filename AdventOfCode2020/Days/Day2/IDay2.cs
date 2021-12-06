using AdventOfCode2020.Models;
using CommonCode.Extensions;

namespace AdventOfCode2020.Days
{
    internal abstract class Day2
    {
        protected char[] SeperatorArray = new char[3] { ' ', '-', ':' };
        public List<Day2Input> ParsedData { get; set; }

        public Day2(string filePath)
        {
            ParsedData = ReadDataIntoModel(filePath);
        }

        internal string Execute()
        {
            var validPassowrdCount = Calculate();
            Console.WriteLine($"Valid password count: {validPassowrdCount}");
            return validPassowrdCount.ToString();
        }

        internal abstract int Calculate();


        List<Day2Input> ReadDataIntoModel(string filePath)
        {
            var result = new List<Day2Input>();
            var stringRows = File.ReadAllLines(filePath).ToList();
            foreach (var stringRow in stringRows)
            {
                var letters = stringRow.Split(SeperatorArray).Where(m=> !string.IsNullOrEmpty(m)).ToArray();
                result.Add(new Day2Input
                {
                    MinimumTimesFound = letters[0].ToInt(),
                    MaximumTimesFound = letters[1].ToInt(),
                    LetterSearched = letters[2],
                    Password = letters[3]
                });
            }

            return result;
        }
    }
}