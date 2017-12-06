using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AdventOfCode
{
    public static class Day6
    {
        public static string RunPart1()
        {
            var values = ReadInput();

            var stepCount = FindStepsToPreviouslySeenValue(values, out _);

            return stepCount.ToString();
        }

        public static string RunPart2()
        {
            var values = ReadInput();

            FindStepsToPreviouslySeenValue(values, out var stopState);

            var stepsToSeeItAgain = FindStepsToPreviouslySeenValue(stopState, out _);

            return stepsToSeeItAgain.ToString();
        }

        private static int FindStepsToPreviouslySeenValue(int[] values, out int[] stopState)
        {
            var previousStates = new List<int[]>();

            var stepCount = 0;
            while (!HasBeenSeenBefore(values, previousStates))
            {
                stepCount++;

                previousStates.Add((int[]) values.Clone());

                Redistribute(values);
            }

            stopState = (int[])values.Clone();

            return stepCount;
        }

        private static bool HasBeenSeenBefore(int[] state, IList<int[]> previousStates)
        {
            return previousStates.Any(prevState => prevState.SequenceEqual(state));
        }

        private static void Redistribute(int[] numbers)
        {
            // Which index has the most blocks?
            var maxValue = numbers.Max();
            var maxIndex = Array.IndexOf(numbers, maxValue);

            numbers[maxIndex] = 0;

            var index = maxIndex + 1;
            index = WrapIndex(numbers.Length, index);

            while (maxValue > 0)
            {
                numbers[index]++;
                maxValue--;
                index++;
                index = WrapIndex(numbers.Length, index);
            }
        }

        private static int WrapIndex(int arrayLength, int index)
        {
            return index > arrayLength - 1 ? 0 : index;
        }

        private static int[] ReadInput()
        {
            var data = File.ReadAllText(Path.Combine(FileHelper.InputPath, "Day6.txt"));
            return data.Split(',').Select(x => Convert.ToInt32(x)).ToArray();
        }
    }
}
