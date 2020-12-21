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

            runner.Perform("SampleLib.Tests.dll");

            Console.ReadLine();
        }
    }
}
