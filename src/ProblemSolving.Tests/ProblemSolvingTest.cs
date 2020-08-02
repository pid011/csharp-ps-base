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

        [TestMethod]
        public void Initialize() => new TestCase
        {
            CorrectOutput = "0"
        }.Run();

        [TestMethod, Timeout(TimeLimit)]
        public void TestCase1() => new TestCase
        {
            Input = "1 2",
            CorrectOutput = "3"
        }.Run();

        [TestMethod, Timeout(TimeLimit)]
        public void TestCase2() => new TestCase
        {
            Input = string.Join(" ", Enumerable.Range(1, 50)),
            CorrectOutput = "1275"
        }.Run();

        [TestMethod, Timeout(TimeLimit)]
        public void TestCase3() => new TestCase
        {
            Input = string.Join(" ", Enumerable.Range(1, 10000)),
            CorrectOutput = "50005000"
        }.Run();

        private struct TestCase
        {
            public string Input;
            public string CorrectOutput;

            public void Run()
            {
                using StringReader reader = new StringReader(Input ?? string.Empty);
                using StringWriter writer = new StringWriter();

                Console.SetIn(reader);
                Console.SetOut(writer);

                Program.Main();

                StringBuilder result = writer.GetStringBuilder();

                Assert.AreEqual(result.ToString().Trim(), CorrectOutput ?? string.Empty);
            }
        }
    }
}
