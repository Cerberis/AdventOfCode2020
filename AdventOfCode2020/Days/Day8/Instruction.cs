using AdventOfCode2020.Enumerations;

namespace AdventOfCode2020.Days
{
    public class Instruction
    {
        public GameOperation Operation { get; set; }
        public int Argument { get; set; }
        public bool IsExecuted { get; set; }
    }
}