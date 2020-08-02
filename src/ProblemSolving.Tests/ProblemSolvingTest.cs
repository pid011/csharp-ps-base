using System;
using System.IO;
using System.Linq;
using System.Text;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProblemSolving.Tests
{
    [TestClass]
    public class ProblemSolvingTests
    {
        private const int TimeLimit = 2000 + 5000;

        private struct TestCase
        {
            public StringBuilder Input;
            public StringBuilder CorrectOutput;

            public void Run()
            {
                using var reader = new StringReader(Input.ToString());
                using var writer = new StringWriter();

                Console.SetIn(reader);
                Console.SetOut(writer);

                Program.Main();

                StringBuilder result = writer.GetStringBuilder();

                Assert.AreEqual(result.ToString().Trim(), CorrectOutput.ToString());
            }
        }

        [TestMethod, Timeout(TimeLimit)]
        public void TestCase1() => new TestCase
        {
            Input = new StringBuilder("1 2"),
            CorrectOutput = new StringBuilder("3")
        }.Run();

        [TestMethod, Timeout(TimeLimit)]
        public void TestCase2() => new TestCase
        {
            Input = new StringBuilder(string.Join(" ", Enumerable.Range(1, 50))),
            CorrectOutput = new StringBuilder("1275")
        }.Run();

        [TestMethod, Timeout(TimeLimit)]
        public void TestCase3() => new TestCase
        {
            Input = new StringBuilder(string.Join(" ", Enumerable.Range(1, 10000))),
            CorrectOutput = new StringBuilder("50005000")
        }.Run();
    }
}
