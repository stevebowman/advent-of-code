using System;
using System.Diagnostics;

namespace Runner
{
    public class Program
    {
        // ReSharper disable once UnusedParameter.Local
        static void Main(string[] args)
        {
            try
            {
                bool quit = false;

                while (!quit)
                {
                    Console.WriteLine("Enter day number or Q to quit:");
                    var dayNumber = Console.ReadLine();

                    if (dayNumber.ToUpper() == "Q")
                    {
                        quit = true;
                    }
                    else
                    {
                        var type = Type.GetType($"AdventOfCode.Day{dayNumber},AdventOfCode", true);

                        var sw = new Stopwatch();
                        sw.Start();
                        var result1 = type.GetMethod("RunPart1").Invoke(null, null);
                        sw.Stop();
                        Console.WriteLine($"Day {dayNumber} Part 1: {result1} [took {sw.ElapsedMilliseconds} ms]");

                        sw.Reset();
                        sw.Start();
                        var result2 = type.GetMethod("RunPart2").Invoke(null, null);
                        sw.Stop();
                        Console.WriteLine($"Day {dayNumber} Part 2: {result2} [took {sw.ElapsedMilliseconds} ms]");

                        Console.WriteLine();
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
                Console.ReadLine();
            }
        }
    }
}
