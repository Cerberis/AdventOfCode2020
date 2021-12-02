using CommonCode.Extensions;
using System.Linq;

namespace AdventOfCode2020.Days
{
    internal class Day5Part2 : Day5
    {
        internal Day5Part2(string filePath) : base(filePath)
        {
        }

        internal override int Calculate()
        {
            var seatsTaken = new List<int>();

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
                seatsTaken.Add(CalculatedSeatId(rowSegments.highestRow, seatSegments.highestSeat));
            }


            return FindMissingSeat(seatsTaken.OrderBy(m => m).ToList());
        }

        int FindMissingSeat(List<int> takenSeats)
        {
            var str = string.Join("; ", takenSeats);
            var mySeat = new List<int>();
            for (int i = 1; i < takenSeats.Count-1; i++)
            {
                if (takenSeats[i - 1] + 1 == takenSeats[i]) 
                    if (takenSeats[i + 1] - 1 != takenSeats[i])
                        mySeat.Add(takenSeats[i]+1);
            }
            return mySeat.FirstOrDefault();
        }
    }
}