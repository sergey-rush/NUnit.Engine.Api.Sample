﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace TestRunner
{
    // 
    // This source code was auto-generated by xsd, Version=4.6.1055.0.
    // 

    [SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true)]
    [XmlRootAttribute("test-run", Namespace = "", IsNullable = false)]
    public class TestRun
    {
        private string commandlineField;

        private TestSuite[] testSuitesField;

        private string idField;

        private string nameField;

        private string fullnameField;

        private string runstateField;

        private string testcasecountField;

        private string resultField;

        private string totalField;

        private string passedField;

        private string failedField;

        private string inconclusiveField;

        private string skippedField;

        private string assertsField;

        private string engineversionField;

        private string clrversionField;

        private string starttimeField;

        private string endtimeField;

        private string durationField;


        //[XmlElementAttribute("command-line", Form = Xml.Schema.XmlSchemaForm.Unqualified)]
        [XmlElement("command-line")]
        public string CommandLine
        {
            get { return this.commandlineField; }
            set { this.commandlineField = value; }
        }


        //[XmlElementAttribute("test-suite")]
        [XmlElement("test-suite")]
        public TestSuite[] TestSuites
        {
            get { return this.testSuitesField; }
            set { this.testSuitesField = value; }
        }


        [XmlAttributeAttribute()]
        public string id
        {
            get { return this.idField; }
            set { this.idField = value; }
        }


        [XmlAttributeAttribute()]
        public string name
        {
            get { return this.nameField; }
            set { this.nameField = value; }
        }


        [XmlAttributeAttribute()]
        public string fullname
        {
            get { return this.fullnameField; }
            set { this.fullnameField = value; }
        }


        [XmlAttributeAttribute()]
        public string runstate
        {
            get { return this.runstateField; }
            set { this.runstateField = value; }
        }


        [XmlAttributeAttribute()]
        public string testcasecount
        {
            get { return this.testcasecountField; }
            set { this.testcasecountField = value; }
        }


        [XmlAttributeAttribute()]
        public string result
        {
            get { return this.resultField; }
            set { this.resultField = value; }
        }


        [XmlAttributeAttribute()]
        public string total
        {
            get { return this.totalField; }
            set { this.totalField = value; }
        }


        [XmlAttributeAttribute()]
        public string passed
        {
            get { return this.passedField; }
            set { this.passedField = value; }
        }


        [XmlAttributeAttribute()]
        public string failed
        {
            get { return this.failedField; }
            set { this.failedField = value; }
        }


        [XmlAttributeAttribute()]
        public string inconclusive
        {
            get { return this.inconclusiveField; }
            set { this.inconclusiveField = value; }
        }


        [XmlAttributeAttribute()]
        public string skipped
        {
            get { return this.skippedField; }
            set { this.skippedField = value; }
        }


        [XmlAttributeAttribute()]
        public string asserts
        {
            get { return this.assertsField; }
            set { this.assertsField = value; }
        }


        [XmlAttributeAttribute("engine-version")]
        public string engineversion
        {
            get { return this.engineversionField; }
            set { this.engineversionField = value; }
        }


        [XmlAttributeAttribute("clr-version")]
        public string clrversion
        {
            get { return this.clrversionField; }
            set { this.clrversionField = value; }
        }


        [XmlAttributeAttribute("start-time")]
        public string starttime
        {
            get { return this.starttimeField; }
            set { this.starttimeField = value; }
        }


        [XmlAttributeAttribute("end-time")]
        public string endtime
        {
            get { return this.endtimeField; }
            set { this.endtimeField = value; }
        }


        [XmlAttributeAttribute()]
        public string duration
        {
            get { return this.durationField; }
            set { this.durationField = value; }
        }
    }


    [SerializableAttribute()]
    [XmlRootAttribute("test-suite", Namespace = "", IsNullable = false)]
    public class TestSuite
    {
        [XmlElement("test-case")]
        public TestCase[] TestCases { get; set; }


        [XmlElement("test-suite")]
        public TestSuite[] NestedTestSuite { get; set; }


        [XmlElementAttribute("environment", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public TestEnvironment Environment { get; set; }


        [XmlArrayAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [XmlArrayItemAttribute("setting", typeof(TestSetting), Form = System.Xml.Schema.XmlSchemaForm.Unqualified,
            IsNullable = false)]
        public TestSetting[] Settings { get; set; }


        [XmlArrayAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [XmlArrayItemAttribute("property", typeof(TestProperties), Form = System.Xml.Schema.XmlSchemaForm.Unqualified,
            IsNullable = false)]
        public TestProperties[] Properties { get; set; }


        [XmlAttributeAttribute("type")]
        public string SuiteType { get; set; }


        [XmlAttributeAttribute("id")]
        public string Id { get; set; }


        [XmlAttributeAttribute("name")]
        public string Name { get; set; }


        [XmlAttributeAttribute("fullname")]
        public string FullName { get; set; }


        [XmlAttributeAttribute("classname")]
        public string ClassName { get; set; }


        [XmlAttributeAttribute("runstate")]
        public string RunState { get; set; }


        [XmlAttributeAttribute("testcasecount")]
        public string TestCaseCount { get; set; }


        [XmlAttributeAttribute("result")]
        public string Result { get; set; }


        [XmlAttributeAttribute("start-time")]
        public string StartTime { get; set; }


        [XmlAttributeAttribute("end-time")]
        public string EndTime { get; set; }


        [XmlAttributeAttribute("duration")]
        public string Duration { get; set; }


        [XmlAttributeAttribute("total")]
        public string Total { get; set; }


        [XmlAttributeAttribute("passed")]
        public string Passed { get; set; }


        [XmlAttributeAttribute("failed")]
        public string Failed { get; set; }


        [XmlAttributeAttribute("warnings")]
        public string Warnings { get; set; }


        [XmlAttributeAttribute("inconclusive")]
        public string Inconclusive { get; set; }


        [XmlAttributeAttribute("skipped")]
        public string Skipped { get; set; }


        [XmlAttributeAttribute("asserts")]
        public string Asserts { get; set; }
    }

    [SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true)]
    [XmlRootAttribute("test-case", Namespace = "", IsNullable = false)]
    public class TestCase
    {
        [XmlAttributeAttribute("id")] public string Id { get; set; }

        [XmlAttributeAttribute("name")] public string Name { get; set; }

        [XmlAttributeAttribute("fullname")] public string FullName { get; set; }

        [XmlAttributeAttribute("methodname")] public string MethodName { get; set; }

        [XmlAttributeAttribute("classname")] public string ClassName { get; set; }

        [XmlAttributeAttribute("runstate")] public string RunState { get; set; }

        [XmlAttributeAttribute("seed")] public string Seed { get; set; }

        [XmlAttributeAttribute("result")] public string Result { get; set; }

        [XmlAttributeAttribute("start-time")] public string StartTime { get; set; }

        [XmlAttributeAttribute("end-time")] public string EndTime { get; set; }

        [XmlAttributeAttribute("duration")] public string Duration { get; set; }

        [XmlAttributeAttribute("asserts")] public string Asserts { get; set; }
    }

    [SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true)]
    public class TestEnvironment
    {
        [XmlAttributeAttribute("framework-version")]
        public string FrameworkVersion { get; set; }

        [XmlAttributeAttribute("clr-version")] public string ClrVersion { get; set; }

        [XmlAttributeAttribute("os-version")] public string OsVersion { get; set; }

        [XmlAttributeAttribute("platform")] public string Platform { get; set; }

        [XmlAttributeAttribute("cwd")] public string Cwd { get; set; }

        [XmlAttributeAttribute("machine-name")]
        public string MachineName { get; set; }

        [XmlAttributeAttribute("user")] public string User { get; set; }

        [XmlAttributeAttribute("user-domain")] public string UserDomain { get; set; }

        [XmlAttributeAttribute("culture")] public string Culture { get; set; }

        [XmlAttributeAttribute("uiculture")] public string UiCulture { get; set; }

        [XmlAttributeAttribute("os-architecture")]
        public string OsArchitecture { get; set; }
    }

    [SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true)]
    public class TestSetting
    {

        private string nameField;

        private string valueField;


        [XmlAttributeAttribute()]
        public string name
        {
            get { return this.nameField; }
            set { this.nameField = value; }
        }


        [XmlAttributeAttribute()]
        public string value
        {
            get { return this.valueField; }
            set { this.valueField = value; }
        }
    }

    [SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true)]
    public class TestProperties
    {

        private string nameField;

        private string valueField;


        [XmlAttributeAttribute()]
        public string name
        {
            get { return this.nameField; }
            set { this.nameField = value; }
        }


        [XmlAttributeAttribute()]
        public string value
        {
            get { return this.valueField; }
            set { this.valueField = value; }
        }
    }
}