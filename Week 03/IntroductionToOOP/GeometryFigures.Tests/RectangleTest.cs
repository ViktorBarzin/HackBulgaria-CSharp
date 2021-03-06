// <copyright file="RectangleTest.cs">Copyright ©  2015</copyright>
using System;
using GeometryFigures;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GeometryFigures.Tests
{
    /// <summary>This class contains parameterized unit tests for Rectangle</summary>
    [PexClass(typeof(Rectangle))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class RectangleTest
    {
        /// <summary>Test stub for GetPerimeter()</summary>
        [PexMethod]
        internal double GetPerimeterTest([PexAssumeUnderTest]Rectangle target)
        {
            double result = target.GetPerimeter();
            return result;
            // TODO: add assertions to method RectangleTest.GetPerimeterTest(Rectangle)
        }
    }
}
