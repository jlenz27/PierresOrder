using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PierreOrder.Models;
using System;

namespace PierreOrder.Tests
{
    [TestClass]
    public class VendorTests : IDisposable
    {
         public void Dispose()
        {
            Vendor.ClearAll();
        }



        [TestMethod]
        public void ItemConstructor_CreatesInstanceOfItem_Item()
        {
            Vendor newVendor = new Vendor("test", "test", "test");
            Assert.AreEqual(typeof(Vendor), newVendor.GetType());
        }

        [TestMethod]
        public void GetName_ReturnsName_String()
        {
            string vendorName = "Carol";
            Vendor newVendor = new Vendor(vendorName, "test", "test");
            string result = newVendor.Name;
            Assert.AreEqual(vendorName, result);
        }
        [TestMethod]
        public void GetDescrition_ReturnsDescription_String()
        {
            string vendorName = "Carol";
            string vendorDescription = "neighbor";
            Vendor newVendor = new Vendor(vendorName, vendorDescription, "test");
            string result = newVendor.Description;
            Assert.AreEqual(vendorDescription, result);
        }
        [TestMethod]

        public void GetLocation_ReturnsLocation_String()
        {
            string vendorName = "Carol";
            string vendorDescription = "neighbor";
            string vendorLocation = "upstate";
            Vendor newVendor = new Vendor(vendorName, vendorDescription, vendorLocation);
            string result = newVendor.Location;
            Assert.AreEqual(vendorLocation, result);
        }
        [TestMethod]
        public void GetAll_ReturnsEmptyList_ListOfVendors()
        {
            List<Vendor> newList = new List<Vendor> { };
            List<Vendor> result = Vendor.GetAll();
            CollectionAssert.AreEqual(newList, result);
        }

        [TestMethod]
        public void GetAll_ReturnsItems_ItemList()
        {
            string vendorName = "Carol";
            string vendorDescription = "neighbor";
            string vendorLocation = "upstate";
            Vendor newVendor = new Vendor(vendorName, vendorDescription, vendorLocation);
            string vendorName2 = "susie";
            string vendorDescription2 = "cousin";
            string vendorLocation2 = "upstate";
            Vendor newVendor2 = new Vendor(vendorName2, vendorDescription2, vendorLocation2);
            List<Vendor> newList = new List<Vendor> { newVendor, newVendor2 };
            List<Vendor> result = Vendor.GetAll();

            CollectionAssert.AreEqual(newList, result);
        }

         [TestMethod]
        public void Find_ReturnsVendorList_Vendor()
        {
            string vendorName = "Carol";
            string vendorDescription = "neighbor";
            string vendorLocation = "upstate";
            Vendor newVendor = new Vendor(vendorName, vendorDescription, vendorLocation);
            string vendorName2 = "susie";
            string vendorDescription2 = "cousin";
            string vendorLocation2 = "upstate";
            Vendor newVendor2 = new Vendor(vendorName2, vendorDescription2, vendorLocation2);
            Vendor result = Vendor.Find(2);
            Assert.AreEqual(newVendor2, result);
        }


    }

}