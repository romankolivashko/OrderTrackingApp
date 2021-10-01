using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using VendorTracker.Models;
using System;

namespace VendorTracker.Tests
{
  [TestClass]
  public class VendorTests //: IDisposable
  {
    // public void Dispose()
    // {
    //   Vendor.ClearAll();
    // }

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("test vendor");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

   // [TestMethod]
  //  public void NameOfTest_WhatItDoes_WhatItReturn()
  //  {
      // Arrange

      // Act

      // Assert
   // }
    
  }
}






// using Microsoft.VisualStudio.TestTools.UnitTesting;
// using VendorTracker;

// namespace VendorTracker.Tests
// {
//   [TestClass]
//   public class ClassNameTests
//   {
//     [TestMethod]
//     public void NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue()
//     {
//       // any necessary logic to prep for test; instantiating new classes, etc.
//       Assert.AreEqual(EXPECTED RESULT, CODE TO TEST);
//     }
//   }
// }