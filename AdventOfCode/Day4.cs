using System;
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
            var phrases = ReadInput();

            // To check for anagrams, sort the characters in each word in order so that we just compare as strings 
            // to do the anagram check.
            foreach (var phrase in phrases)
            {
                for (var i = 0; i < phrase.Count(); i++)
                {
                    var word = phrase[i];
                    var charArray = word.ToCharArray();
                    Array.Sort(charArray);
                    phrase[i] = new string(charArray);
                }             
            }

            var validPhrases = phrases.Count(phrase => phrase.Count == phrase.Distinct().Count());

            return validPhrases.ToString();
        }

        private static List<List<string>> ReadInput()
        {
            var lines = File.ReadAllLines(Path.Combine(FileHelper.InputPath, "Day4.txt"));
            return lines.Select(line => line.Split(' ').ToList()).ToList();
        }
    }
}
