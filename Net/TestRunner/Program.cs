using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using NUnit.Engine;

namespace TestRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            NUnitTestRunner runner = new NUnitTestRunner();

            TestRun testRun =  runner.Perform("SampleLib.Tests.dll");
            List<TestCase> testCases = runner.GetTestCaseList(testRun);

            Console.ReadLine();
        }
    }
}
