using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AdventOfCode
{
    public static class Day4
    {
        public static string RunPart1()
        {
            var phrases = ReadInput();

            var validPhrases = phrases.Count(phrase => phrase.Count == phrase.Distinct().Count());

            return validPhrases.ToString();
        }

        public static string RunPart2()
        {
            return null;
        }

        private static List<List<string>> ReadInput()
        {
            var lines = File.ReadAllLines(Path.Combine(FileHelper.InputPath, "Day4.txt"));
            return lines.Select(line => line.Split(' ').ToList()).ToList();
        }
    }
}
