// <copyright file="XmlBuilderTestsTest.cs">Copyright ©  2016</copyright>
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using XmlBuilderTests;

namespace XmlBuilderTests.Tests
{
    /// <summary>This class contains parameterized unit tests for XmlBuilderTests</summary>
    [PexClass(typeof(global::XmlBuilderTests.XmlBuilderTests))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class XmlBuilderTestsTest
    {
        /// <summary>Test stub for AddAttrTest()</summary>
        [PexMethod]
        public void AddAttrTestTest([PexAssumeUnderTest]global::XmlBuilderTests.XmlBuilderTests target)
        {
            target.AddAttrTest();
            // TODO: add assertions to method XmlBuilderTestsTest.AddAttrTestTest(XmlBuilderTests)
        }

        /// <summary>Test stub for AddTextTest()</summary>
        [PexMethod]
        public void AddTextTestTest([PexAssumeUnderTest]global::XmlBuilderTests.XmlBuilderTests target)
        {
            target.AddTextTest();
            // TODO: add assertions to method XmlBuilderTestsTest.AddTextTestTest(XmlBuilderTests)
        }

        /// <summary>Test stub for CloseTagTest()</summary>
        [PexMethod]
        public void CloseTagTestTest([PexAssumeUnderTest]global::XmlBuilderTests.XmlBuilderTests target)
        {
            target.CloseTagTest();
            // TODO: add assertions to method XmlBuilderTestsTest.CloseTagTestTest(XmlBuilderTests)
        }

        /// <summary>Test stub for FinishTest()</summary>
        [PexMethod]
        public void FinishTestTest([PexAssumeUnderTest]global::XmlBuilderTests.XmlBuilderTests target)
        {
            target.FinishTest();
            // TODO: add assertions to method XmlBuilderTestsTest.FinishTestTest(XmlBuilderTests)
        }

        /// <summary>Test stub for GetResultTest()</summary>
        [PexMethod]
        public void GetResultTestTest([PexAssumeUnderTest]global::XmlBuilderTests.XmlBuilderTests target)
        {
            target.GetResultTest();
            // TODO: add assertions to method XmlBuilderTestsTest.GetResultTestTest(XmlBuilderTests)
        }

        /// <summary>Test stub for OpenTagNullValueTest()</summary>
        [PexMethod]
        public void OpenTagNullValueTestTest([PexAssumeUnderTest]global::XmlBuilderTests.XmlBuilderTests target)
        {
            target.OpenTagNullValueTest();
            // TODO: add assertions to method XmlBuilderTestsTest.OpenTagNullValueTestTest(XmlBuilderTests)
        }

        /// <summary>Test stub for OpenTagTest()</summary>
        [PexMethod]
        public void OpenTagTestTest([PexAssumeUnderTest]global::XmlBuilderTests.XmlBuilderTests target)
        {
            target.OpenTagTest();
            // TODO: add assertions to method XmlBuilderTestsTest.OpenTagTestTest(XmlBuilderTests)
        }
    }
}
