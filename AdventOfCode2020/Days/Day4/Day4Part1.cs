namespace AdventOfCode2020.Days
{
    internal class Day4Part1 : Day4
    {

        internal Day4Part1(string filePath) : base(filePath)
        {
        }

        internal override int Calculate()
        {
            int validPassports = 0;
            foreach (var passport in ParsedData)
            {
                if (CheckRequiredFields(passport))
                    validPassports++;
            }
            return validPassports;
        }
    }
}