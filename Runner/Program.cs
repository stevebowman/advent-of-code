using System;
using AdventOfCode;

namespace Runner
{
    public class Program
    {
        // ReSharper disable once UnusedParameter.Local
        static void Main(string[] args)
        {
            var result1 = Day5.RunPart1();
            Console.WriteLine("Day 5 Part 1: " + result1);

            var result2 = Day5.RunPart2();
            Console.WriteLine("Day 5 part 2: " + result2);

            Console.ReadLine();
        }
    }
}
