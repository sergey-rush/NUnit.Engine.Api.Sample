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
            // Get an interface to the engine
            ITestEngine engine = TestEngineActivator.CreateInstance();

            // Create a simple test package - one assembly, no special settings
            TestPackage package = new TestPackage("SampleLib.Tests.dll");

            // Get a runner for the test package
            ITestRunner runner = engine.GetRunner(package);

            // Run all the tests in the assembly
            XmlNode testResult = runner.Run(null, TestFilter.Empty);

            Console.WriteLine(testResult.OuterXml);

            Console.ReadLine();
        }
    }
}
