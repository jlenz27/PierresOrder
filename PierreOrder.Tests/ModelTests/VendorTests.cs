using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PierreOrder.Models;
using System;

namespace PierreOrder.Tests
{
    [TestClass]
    public class VendorTests
    {
     

        [TestMethod]
        public void ItemConstructor_CreatesInstanceOfItem_Item()
        {
            Vendor newVendor = new Vendor();
            Assert.AreEqual(typeof(Vendor), newVendor.GetType());
        }

         [TestMethod]
        public void GetName_ReturnsName_Stringg()
        {
            string name = "Carol";
            Vendor newVendor = new Vendor();
            string result = newVendor.Name;
            Assert.AreEqual(name, result);
        }
    }
}