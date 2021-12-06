using AdventOfCode2020.Enumerations;

namespace AdventOfCode2020.Days
{
    internal class Day8Part1 : Day8
    {
        internal Day8Part1(string filePath) : base(filePath)
        {
        }

        internal override int Calculate()
        {
            var usedOperations = new List<int>();
            var accumulator = 0;
            for (int operationIndex = 0; operationIndex < ParsedData.Count; operationIndex++)
            {
                if (CheckIfOperationUsedBefore(usedOperations, operationIndex))
                    break;

                switch (ParsedData[operationIndex].Key)
                {
                    case GameOperation.acc:
                        accumulator += ParsedData[operationIndex].Value;
                        break;
                    case GameOperation.jmp:
                        operationIndex += ParsedData[operationIndex].Value - 1;
                        break;
                    case GameOperation.nop:
                        break;
                }
            }
            return accumulator;
        }
    }
}