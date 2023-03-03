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
            Vendor newVendor = new Vendor("test");
            Assert.AreEqual(typeof(Vendor), newVendor.GetType());
        }

        [TestMethod]
        public void GetName_ReturnsName_String()
        {
            string name = "Carol";
            Vendor newVendor = new Vendor(name, "test");
            string result = newVendor.Name;
            Assert.AreEqual(name, result);
        }
        public void GetDescrition_ReturnsDescription_String()
        {
            string name = "Carol";
            string description = "neighbor";
            Vendor newVendor = new Vendor(name, description);
            string result = newVendor.Description;
            Assert.AreEqual(description, result);
        }
    }

}