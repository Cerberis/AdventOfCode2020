namespace AdventOfCode2020.Days
{
    internal class Day5Part1 : Day5
    {
        
        internal Day5Part1(string filePath) : base(filePath)
        {
        }

        internal override int Calculate()
        {
            int highestSeatId = 0;

            foreach (var boardingPass in ParsedData)
            {
                (int lowestRow, int highestRow) rowSegments = new(0, 127);
                (int lowestSeat, int highestSeat) seatSegments = new(0, 7);
                if (boardingPass.Length != 10) continue;

                foreach (var boardingPassData in boardingPass)
                {
                    switch (boardingPassData)
                    {
                        case 'F':
                        case 'B':
                            rowSegments = CalculateSegment(rowSegments, boardingPassData);
                            break;
                        case 'L':
                        case 'R':
                            seatSegments = CalculateSegment(seatSegments, boardingPassData);
                            break;
                    }
                }
                var calculatedSeatId = CalculatedSeatId(rowSegments.highestRow, seatSegments.highestSeat);
                if (calculatedSeatId > highestSeatId)
                    highestSeatId = calculatedSeatId;
            }

            return highestSeatId;
        }       
    }
}