using System;
using System.Linq;

namespace ProblemSolving
{
    public static class Program
    {
        public static void Main() =>
            Console.WriteLine(
                (Console.ReadLine() ?? string.Empty)
                .Split()
                .Sum(s => s.Length == 0 ? 0 : int.Parse(s)));
    }
}
