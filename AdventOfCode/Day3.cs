using System;

namespace AdventOfCode
{
    public class Day3
    {
        public static string RunPart1()
        {
            // Which 'ring' are we in?
            // These are all squares of length 1, 3, 5 ...
            var squareSize = 1;
            while (Math.Pow(squareSize, 2) < Input)
            {
                squareSize = squareSize + 2;
            }

            // What are the numbers at the corners of the square. 
            // n^2, n^2 - n + 1 etc
            var corners = new int[4];
            corners[0] = (int)Math.Pow(squareSize, 2);
            corners[1] = corners[0] - squareSize + 1;
            corners[2] = corners[1] - squareSize + 1;
            corners[3] = corners[2] - squareSize + 1;

            // If you are on a corner, then you are n-1 steps from the centre.
            // We need to reduce that by the distance from the nearest corner
            // if you are not a corner, as that moves you closer to the centre.
            var nearestCorner = corners[0];
            var distanceToNearestCorner = Math.Abs(nearestCorner - Input);
            for (var i = 1; i <= 3; i++)
            {
                if (Math.Abs(corners[i] - Input) < Math.Abs(nearestCorner - Input))
                {
                    nearestCorner = corners[i];
                    distanceToNearestCorner = Math.Abs(nearestCorner - Input);
                }
            }

            var distanceToCentre = squareSize - 1 - distanceToNearestCorner;

            return distanceToCentre.ToString();
        }

        public static string RunPart2()
        {
            return null;
        }

        private static int Input => 325489;
    }
}
