namespace AdventOfCode2020.Days
{
    internal class Day7Part1 : Day7
    {
        internal Day7Part1(string filePath) : base(filePath)
        {
        }

        internal override int Calculate()
        {
            var tempresult = GetNewColours(new List<string> { ShinyGoldenBagName });
            while (tempresult.Any())
            {
                BagsWhichCanContainGoldBag.AddRange(tempresult);
                tempresult = GetNewColours(tempresult);
            }
            return BagsWhichCanContainGoldBag.Count;
        }

        private List<string> GetNewColours(List<string> colourNames)
        {
            var filteredBagColours = new List<string>();

            foreach (var bagRule in BagRules)
            {
                if (bagRule.Value.Where(m => colourNames.Contains(m.Key)).Any())
                {
                    if (!filteredBagColours.Contains(bagRule.Key) && !BagsWhichCanContainGoldBag.Contains(bagRule.Key))
                    {
                        filteredBagColours.Add(bagRule.Key);
                    }
                }
            }

            return filteredBagColours;
        }

    }
}