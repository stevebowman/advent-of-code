using System;
using System.IO;
using System.Linq;

namespace AdventOfCode
{
    public static class Day1
    {
        public static string RunPart1()
        {
            var numbers = ReadInput();

            var sum = 0;
            for (var i = 0; i < numbers.Length; i++)
            {
                var thisNumber = numbers[i];

                int nextNumber;

                // The next number after the last one is the first one.
                nextNumber = i < numbers.Length - 1 ? numbers[i + 1] : numbers[0];

                if (thisNumber == nextNumber)
                {
                    sum = sum + thisNumber;
                }
            }

            return sum.ToString();
        }

        public static string RunPart2()
        {
            var numbers = ReadInput();

            var jumpAhead = numbers.Length / 2;

            var sum = 0;
            for (var i = 0; i < numbers.Length; i++)
            {
                var thisNumber = numbers[i];

                var indexToCheck = i + jumpAhead;
     
                // Wrap the index for this circular list.
                if (indexToCheck > numbers.Length - 1)
                {
                    indexToCheck = indexToCheck - numbers.Length;
                }

                var nextNumber = numbers[indexToCheck];

                if (thisNumber == nextNumber)
                {
                    sum = sum + thisNumber;
                }
            }

            return sum.ToString();
        }

        private static int[] ReadInput()
        {
            var data = File.ReadAllText(Path.Combine(FileHelper.InputPath, "Day1.txt"));
            return data.ToCharArray().Select(x => Convert.ToInt32(x.ToString())).ToArray();
        }
    }
}
