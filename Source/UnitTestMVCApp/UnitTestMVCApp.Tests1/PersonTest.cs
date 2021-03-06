// <copyright file="PersonTest.cs">Copyright ©  2017</copyright>
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestMVCApp.Models;

namespace UnitTestMVCApp.Models.Tests
{
    /// <summary>This class contains parameterized unit tests for Person</summary>
    [PexClass(typeof(Person))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class PersonTest
    {
    }
}
