using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dearlership.Models;

namespace Dearlership.Tests
{
  [TestClass]
  public class CarTests // : IDisposable
  {
    // public void Dispose()
    // {
    //   ClassName.ClearAll();
    // }

    [TestMethod]
    public void NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue()
    {
      // any necessary logic to prep for test; instantiating new classes, etc.
      Assert.AreEqual(EXPECTED RESULT, CODE TO TEST);
    }
  }
}