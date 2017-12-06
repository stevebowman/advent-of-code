using System;

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

                        var result1 = type.GetMethod("RunPart1").Invoke(null, null);
                        Console.WriteLine($"Day {dayNumber} Part 1: {result1}");

                        var result2 = type.GetMethod("RunPart2").Invoke(null, null);
                        Console.WriteLine($"Day {dayNumber} Part 2: {result2}");

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
