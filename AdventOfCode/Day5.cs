using System;
using System.IO;
using System.Linq;

namespace AdventOfCode
{
    public static class Day5
    {
        public static string Run()
        {
            var numbers = File.ReadAllLines(Path.Combine(FileHelper.InputPath, "Day5.txt"))
                .Select(x => Convert.ToInt32(x)).ToArray();

            return "test";
        }
    }
}
