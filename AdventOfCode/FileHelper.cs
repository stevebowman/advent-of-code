using System.IO;
using System.Reflection;

namespace AdventOfCode
{
    public static class FileHelper
    {
        public static string InputPath
        {
            get
            {
                var assembley = Assembly.GetExecutingAssembly();
                return Path.Combine(Path.GetDirectoryName(assembley.Location), "Input");
            }
        }
    }
}
