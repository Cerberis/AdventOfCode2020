using CommonCode;
namespace AdventOfCode2020.Days
{
    internal class Day2Part1 : Day2
    {

        internal Day2Part1(string path) : base(path)
        {
        }       

        internal override int Calculate()
        {
            foreach (var data in ParsedData)
            {
                int timesFound = data.Password.Length - data.Password.Replace(data.LetterSearched, "").Length;
                data.Valid = timesFound >= data.MinimumTimesFound && timesFound <= data.MaximumTimesFound;
            }
            return ParsedData.Where(m => m.Valid).Count();
        }
    }
}