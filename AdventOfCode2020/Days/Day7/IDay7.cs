namespace AdventOfCode2020.Days
{
    internal abstract class Day7
    {
        public Dictionary<string, Dictionary<string, int>> BagRules { get; set; }
        public List<string> BagsWhichCanContainGoldBag { get; set; }
        protected const string ShinyGoldenBagName = "shiny gold";
        public Day7(string filePath)
        {
            ReadDataIntoModel(filePath);
            BagsWhichCanContainGoldBag = new List<string>();
        }

        internal abstract int Calculate();

        internal string Execute()
        {
            var result = Calculate();
            Console.WriteLine($"Result: {result}");
            return result.ToString();
        }

        internal void ReadDataIntoModel(string filePath)
        {
            BagRules = new Dictionary<string, Dictionary<string, int>>();
            var rulesRows = File.ReadAllLines(filePath);

            foreach (var ruleRow in rulesRows)
            {
                var bagWithInsides = ruleRow.Split("bags contain");

                BagRules.Add(bagWithInsides[0].Trim(), GetBagInsides(bagWithInsides[1]));
            }
        }

        private Dictionary<string, int> GetBagInsides(string ruleRow)
        {
            var result = new Dictionary<string, int>();
            var bagsWithInsides = ruleRow.Split(',');

            foreach (var bagWithInsides in bagsWithInsides)
            {
                var rule = GetBagRule(bagWithInsides);
                if (rule != null)
                {
                    result.Add(rule.Value.bagColour, rule.Value.quantity);
                }
            }
            return result;
        }

        private (string bagColour, int quantity)? GetBagRule(string bagWithInsides)
        {
            var words = bagWithInsides.Split(' ').Where(s => !string.IsNullOrEmpty(s) && !s.Contains("bag")).ToList();

            int.TryParse(words[0], out var quantity);
            if (quantity == 0) return null;
            var colourString = string.Join(" ", words.Skip(1)).Trim();

            return new(colourString, quantity);
        }
    }
}