namespace AdventOfCode2020.Days
{
    internal abstract class Day4
    {
        public List<Dictionary<string, string>> ParsedData { get; set; }

        public Day4(string filePath)
        {
            ParsedData = ReadDataIntoModel(filePath);
        }

        internal void Execute()
        {
            var validPassports = Calculate();
            Console.WriteLine($"Valid passports: {validPassports}");
        }

        internal abstract int Calculate();

        internal bool CheckRequiredFields(Dictionary<string, string> passport)
        {
            var mustHavePassportFields = new List<string> { "byr", "iyr", "eyr", "hgt", "hcl", "ecl", "pid" };

            foreach (var mustHaveField in mustHavePassportFields)
            {
                if (!passport.Keys.Contains(mustHaveField)) return false;
            }
            return true;
        }

        List<Dictionary<string, string>> ReadDataIntoModel(string filePath)
        {
            var result = new List<Dictionary<string, string>>();
            var stringRows = File.ReadAllLines(filePath);

            var passport = new Dictionary<string, string>();
            foreach (var dataRow in stringRows)
            {
                if (string.IsNullOrEmpty(dataRow))
                {
                    if (passport.Keys.Any())
                    {
                        result.Add(passport);
                    }
                    passport = new Dictionary<string, string>();
                    continue;
                }
                var foundDetails = GetPassportDetails(dataRow);
                foundDetails.ToList().ForEach(x => passport.Add(x.Key, x.Value));
            }

            if (passport.Keys.Any())
            {
                result.Add(passport);
            }

            return result;
        }

        Dictionary<string, string> GetPassportDetails(string dataRow)
        {
            var passportDetails = new Dictionary<string, string>();
            var fields = dataRow.Split(" ").Where(m => !string.IsNullOrEmpty(m));
            foreach (var field in fields)
            {
                var seperdatedNameValue = field.Split(':');
                passportDetails.Add(seperdatedNameValue[0], seperdatedNameValue[1]);
            }
            return passportDetails;
        }
    }
}