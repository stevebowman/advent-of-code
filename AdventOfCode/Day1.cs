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
                int thisNumber = numbers[i];

                int nextNumber;
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
            return null;
        }

        private static int[] ReadInput()
        {
            var data = File.ReadAllText(Path.Combine(FileHelper.InputPath, "Day1.txt"));
            return data.ToCharArray().Select(x => Convert.ToInt32(x.ToString())).ToArray();
        }
    }
}
