using System;
using System.IO;
using System.Linq;

namespace AdventOfCode
{
    public static class Day5
    {
        public static string RunPart1()
        {
            var numbers = ReadInput();

            var highestArrayIndex = numbers.Length - 1;
            var location = 0;
            var stepCount = 0;

            while (location <= highestArrayIndex)
            {
                stepCount++;

                var jump = numbers[location];

                numbers[location]++;

                location = location + jump;
            }

            return stepCount.ToString();
        }

        public static string RunPart2()
        {
            var numbers = ReadInput();

            var highestArrayIndex = numbers.Length - 1;
            var location = 0;
            var stepCount = 0;

            while (location <= highestArrayIndex)
            {
                stepCount++;

                var jump = numbers[location];

                if (jump < 3)
                {
                    numbers[location]++;
                }
                else
                {
                    numbers[location]--;
                }

                location = location + jump;
            }

            return stepCount.ToString();
        }

        private static int[] ReadInput()
        {
            return File.ReadAllLines(Path.Combine(FileHelper.InputPath, "Day5.txt"))
                .Select(x => Convert.ToInt32(x)).ToArray();
        }
    }
}
