using CommonCode.Extensions;
using System.Linq;

namespace AdventOfCode2020.Days
{
    internal class Day4Part2 : Day4
    {
        internal Day4Part2(string filePath) : base(filePath)
        {
        }

        internal override int Calculate()
        {
            int validPassports = 0;
            foreach (var passport in ParsedData)
            {
                if (!CheckRequiredFields(passport))
                    continue;
                if (CheckFieldsvalidations(passport))
                    validPassports++;
            }
            return validPassports;
        }



        private bool CheckFieldsvalidations(Dictionary<string, string> passport)
        {

            foreach (var passportDetail in passport)
            {
                switch (passportDetail.Key)
                {
                    case "byr":
                        if (!ValidateDigit(passportDetail.Value.ToInt(), 1920, 2002))
                            return false;
                        break;
                    case "iyr":
                        if (!ValidateDigit(passportDetail.Value.ToInt(), 2010, 2020))
                            return false;
                        break;
                    case "eyr":
                        if (!ValidateDigit(passportDetail.Value.ToInt(), 2020, 2030))
                            return false;
                        break;
                    case "hgt":
                        if (!ValidateHeight(passportDetail.Value))
                            return false;
                        break;
                    case "hcl":
                        if (!ValidateHairColour(passportDetail.Value))
                            return false;
                        break;
                    case "ecl":
                        if (!ValidateColour(passportDetail.Value))
                            return false;
                        break;
                    case "pid":
                        if (!ValidatePassport(passportDetail.Value))
                            return false;
                        break;
                }
            }
            return true;
        }

        private bool ValidateHairColour(string value)
        {
            var availableSymbols = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'a', 'b', 'c', 'd', 'e', 'f' };
            if (!value.StartsWith("#")) return false;
            if (value.Length != 7) return false;
            if (value.Length != 7) return false;
            return value.Any(letter => !availableSymbols.Contains(letter));
        }

        private bool ValidatePassport(string value)
        {
            if (value.Length != 9) return false;
            return int.TryParse(value, out _);
        }

        private bool ValidateColour(string value)
        {
            var requiredColours = new string[] { "amb", "blu", "brn", "gry", "grn", "hzl", "oth" };
            return requiredColours.Contains(value);
        }

        private bool ValidateHeight(string value)
        {
            if (value.EndsWith("cm"))
            {
                return ValidateDigit(value.Replace("cm", "").ToInt(), 150, 193);
            }
            else if (value.EndsWith("in"))
            {
                return ValidateDigit(value.Replace("in", "").ToInt(), 59, 76);
            }
            return false;
        }

        private bool ValidateDigit(int digit, int minrange, int maxRange)
        {
            return digit >= minrange && digit <= maxRange;
        }
    }
}