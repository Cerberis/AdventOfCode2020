using AdventOfCode2020.Enumerations;

namespace AdventOfCode2020.Days
{
    internal class Day8Part2 : Day8
    {
        internal Day8Part2(string filePath) : base(filePath)
        {
        }

        internal override int Calculate()
        {
            var accumulator = 0;

            ///Tried fixes index list
            var triedFixes = new List<int>();

            ///Is loop fixed
            var fixedBug = false;

            ///Did index was hit second time
            bool systemLooped = false;

            ///Is currently system trying fix
            bool tryingFix = false;


            while (fixedBug == false)
            {
                var usedOperations = new List<int>();
                accumulator = 0;
                for (int operationIndex = 0; operationIndex < ParsedData.Count; operationIndex++)
                {
                    if (CheckIfOperationUsedBefore(usedOperations, operationIndex))
                    {
                        systemLooped = true;
                        break;
                    }

                    //Acc
                    if (ParsedData[operationIndex].Key == GameOperation.acc)
                    {
                        if (!usedOperations.Contains(operationIndex))
                            usedOperations.Add(operationIndex);

                        accumulator += ParsedData[operationIndex].Value;
                    }
                    else if (!triedFixes.Contains(operationIndex) && !tryingFix)
                    {
                        //NOP
                        if (ParsedData[operationIndex].Key == GameOperation.jmp)
                        {
                            TryToFix(triedFixes, ref tryingFix, operationIndex);
                         }
                        //JMP
                        else if (ParsedData[operationIndex].Key == GameOperation.nop)
                        {
                            operationIndex += ParsedData[operationIndex].Value - ParsedData[operationIndex].Value;
                            TryToFix(triedFixes, ref tryingFix, operationIndex);
                            operationIndex--;
                        }
                    }
                    else if (ParsedData[operationIndex].Key == GameOperation.jmp)
                    {
                        if (!usedOperations.Contains(operationIndex))
                            usedOperations.Add(operationIndex);

                        operationIndex += ParsedData[operationIndex].Value-1;                        
                    }
                }

                if (systemLooped)
                {
                    systemLooped = false;
                    tryingFix = false;
                }
                else
                {
                    fixedBug = true;
                }
            }
            return accumulator;
        }

        private static void TryToFix( List<int> triedFixes, ref bool tryingFix, int operationIndex)
        {
            if (!tryingFix)
            {
                triedFixes.Add(operationIndex);
                tryingFix = true;
            }
        }
    }
}