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

            var checksum = rows.Aggregate(0, (current, row) => current + (row.Max() - row.Min()));

            return checksum.ToString();
        }

        public static string RunPart2()
        {
            var rows = ReadInput();

            var checksum = 0;
            foreach (var row in rows)
            {
                var answerFound = false;

                for (var i = 0; i < row.Count; i++)
                {
                    for (var j = 0; j < row.Count; j++)
                    {
                        if (j == i) continue;

                        if (row[i] % row[j] != 0) continue;

                        checksum = checksum + (row[i] / row[j]);
                        answerFound = true;
                        break;
                    }

                    if (answerFound)
                    {
                        break;
                    }
                }
            }

            return checksum.ToString();
        }

        private static IEnumerable<List<int>> ReadInput()
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
