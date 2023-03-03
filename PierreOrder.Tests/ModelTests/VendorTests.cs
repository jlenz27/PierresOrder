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
            Vendor newVendor = new Vendor("test", "test", "test");
            Assert.AreEqual(typeof(Vendor), newVendor.GetType());
        }

        [TestMethod]
        public void GetName_ReturnsName_String()
        {
            string name = "Carol";
            Vendor newVendor = new Vendor(name, "test", "test");
            string result = newVendor.Name;
            Assert.AreEqual(name, result);
        }
        [TestMethod]
        public void GetDescrition_ReturnsDescription_String()
        {
            string name = "Carol";
            string description = "neighbor";
            Vendor newVendor = new Vendor(name, description, "test");
            string result = newVendor.Description;
            Assert.AreEqual(description, result);
        }
        [TestMethod]

        public void GetLocation_ReturnsLocation_String()
        {
            string name = "Carol";
            string description = "neighbor";
            string location = "upstate";
            Vendor newVendor = new Vendor(name, description, location);
            string result = newVendor.Location;
            Assert.AreEqual(location, result);
        }
    }

}