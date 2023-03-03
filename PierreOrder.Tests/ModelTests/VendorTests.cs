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
    }
}