namespace AdventOfCode2020.Days
{
    internal class Day7Part2 : Day7
    {
        internal Day7Part2(string filePath) : base(filePath)
        {
        }

        internal override int Calculate()
        {
            var firstBag = BagRules[ShinyGoldenBagName];
            var insideBags = CalculateInsideBags(firstBag);
            var result = firstBag.Sum(m=> m.Value);

            while (insideBags.Any())
            { 
                result += insideBags.Sum(m => m.Value) ;
                insideBags = CalculateInsideBags(insideBags);
            }
            return result;
        }

        private Dictionary<string, int> CalculateInsideBags(Dictionary<string, int> upperBagValues)
        {
            var result = new Dictionary<string, int>();

            foreach (var upperBagValue in upperBagValues)
            {
                var colourRules = BagRules[upperBagValue.Key];
                if (!colourRules.Any()) continue;
                foreach (var colourRule in colourRules)
                {                    
                    if (result.ContainsKey(colourRule.Key))
                    {
                        result[colourRule.Key] += colourRule.Value * upperBagValue.Value;
                    }
                    else
                    {
                        result.Add(colourRule.Key, colourRule.Value * upperBagValue.Value);
                    }
                }
            }
            return result;
        }
    }
}