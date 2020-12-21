using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NUnit.Engine;
using NUnit.Engine.Runners;

namespace TestRunner
{
    public class NUnitTestRunner
    {
        public NUnitTestRunner()
        {
            
        }

        public void Perform(string assemblyName)
        {
            ITestEventListener listener = new TestEventDispatcher();
            
            
            // Get an interface to the engine
            ITestEngine engine = TestEngineActivator.CreateInstance();

            // Create a simple test package - one assembly, no special settings
            TestPackage package = new TestPackage(assemblyName);

            // Get a runner for the test package
            ITestRunner runner = engine.GetRunner(package);

            // Run all the tests in the assembly
            XmlNode testResult = runner.Run(listener, TestFilter.Empty);

            string report = string.Empty;
            listener.OnTestEvent(report);

            var doc = new XmlDocument();
            var node = doc.ImportNode(testResult, true);
            doc.AppendChild(node);
            doc.Save("output.xml");

            
            using (TextReader sr = new StringReader(testResult.OuterXml))
            {
                var serializer = new XmlSerializer(typeof(TestRun));
                TestRun response = (TestRun)serializer.Deserialize(sr);
                Console.WriteLine(response);
            }

            Console.WriteLine(testResult.OuterXml);
        }
    }
}