using System;
using System.Linq;

namespace ProblemSolving
{
    public static class Program
    {
        public static void Main()
        {
            Console.WriteLine(Console.ReadLine().Split().Sum(s => int.Parse(s)));

            //Console.WriteLine(Array.ConvertAll(Console.ReadLine().Split(), int.Parse).Sum());
        }
    }
}
