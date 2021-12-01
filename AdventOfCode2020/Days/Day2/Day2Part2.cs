using AdventOfCode2020.Models;

namespace AdventOfCode2020.Days
{
    internal class Day2Part2 : Day2
    {
        internal Day2Part2(string path) : base(path)
        {
        }

        internal override int Calculate()
        {
            foreach (var data in ParsedData)
            {
                if (data.Password.Length < 3) continue;
                if (HaveBothValidSymbols(data)) continue;
                if (HaveNoValidSymbols(data)) continue;
                data.Valid = true;
            }
            return ParsedData.Where(m => m.Valid).Count();
        }

        private bool HaveBothValidSymbols(Day2Input input)
        {
            return HaveValidSymbol(input.Password, input.MinimumTimesFound - 1, input.LetterSearched.First()) && HaveValidSymbol(input.Password, input.MaximumTimesFound - 1, input.LetterSearched.First());
        }

        private bool HaveNoValidSymbols(Day2Input input)
        {
            return !HaveValidSymbol(input.Password, input.MinimumTimesFound - 1, input.LetterSearched.First()) && !HaveValidSymbol(input.Password, input.MaximumTimesFound - 1, input.LetterSearched.First());
        }

        private bool HaveValidSymbol(string password, int index, char letter)
        {
            return password[index] == letter;
        }
    }
}