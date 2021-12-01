using CommonCode.Extensions;

namespace AdventOfCode2020.Days
{
    internal abstract class Day1
    {
        public int SumToMake { get; set; }
        public int[] IntArray { get; set; }

        public Day1(int sumToMake)
        {
            SumToMake = sumToMake;
            IntArray = Array.Empty<int>();
        }

        internal abstract void Execute();

        internal int Calculate(int iterationTime)
        {
            return CalculateSum(Array.Empty<int>(), iterationTime);
        }

        int CalculateSum(int[] currentIntArray, int iterationTime)
        {
            var result = 0;
            var newIteration = iterationTime - 1;
            for (int i = 0; i < IntArray.Length; i++)
            {
                if (IntArray[i] + currentIntArray.Sum() == SumToMake)
                {
                    return currentIntArray.MultiplyAllValues() * IntArray[i];
                }

                if (newIteration > 0)
                {
                    var newCurrentArray = currentIntArray.CopyIntArrayWithNewValue(IntArray[i]);
                    result = CalculateSum(newCurrentArray, newIteration);
                }

                if (result > 0)
                {
                    break;
                }
            }

            return result;
        }
    }
}