using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AdventOfCode
{
    public static class Day2
    {
        public static string RunPart1()
        {
            var rows = ReadInput();

            return null;
        }

        public static string RunPart2()
        {
            return null;
        }

        private static List<List<int>> ReadInput()
        {
            var rows = new List<List<int>>();

            var lines = File.ReadAllLines(Path.Combine(FileHelper.InputPath, "Day2.txt"));
            foreach (var line in lines)
            {
                const string sep = "\t";
                rows.Add(line.Split(sep.ToCharArray()).Select(x => Convert.ToInt32(x)).ToList());
            }

            return rows;
        }
    }
}
