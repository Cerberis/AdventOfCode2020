using AdventOfCode2020.Enumerations;
using CommonCode.Extensions;

namespace AdventOfCode2020.Days
{
    internal abstract partial class Day8
    {
        public List<KeyValuePair<GameOperation, int>> ParsedData { get; set; }

        public Day8(string filePath)
        {
            ReadDataIntoModel(filePath);
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
            var operations = File.ReadAllLines(filePath);
            ParsedData = new List<KeyValuePair<GameOperation, int>>();
            foreach (var operation in operations)
            {
                ReadOperation(operation);
            }
        }

        void ReadOperation(string operation)
        {
            var splitOperation = operation.Split(' ');
            if (GameOperation.TryParse(splitOperation[0], out GameOperation gameOperation))
            {
                ParsedData.Add(new KeyValuePair<GameOperation, int>(gameOperation, splitOperation[1].ToInt()));
            }
        }

        protected bool CheckIfOperationUsedBefore(List<int> usedOperations, int operationIndex)
        {
            if (usedOperations.Contains(operationIndex))
                return true;

            usedOperations.Add(operationIndex);
            return false;
        }
    }
}