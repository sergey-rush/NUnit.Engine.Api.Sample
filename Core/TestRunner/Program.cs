using System;
using System.Collections.Generic;
using NUnit.Engine;

namespace TestRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            NUnitTestRunner runner = new NUnitTestRunner();

            TestRun testRun = runner.Perform("ActionLib.Tests.dll");
            List<TestCase> testCases = runner.GetTestCaseList(testRun);

            foreach (TestCase testCase in testCases)
            {
                Console.WriteLine("{0}: {1}", testCase.Name, testCase.Result);
            }

            Console.ReadLine();
        }
    }
}
