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
            string name = "Carol";
            string description = "neighbor";
            string location = "upstate";
            Vendor newVendor = new Vendor(name, description, location);
            string name2 = "susie";
            string description2 = "cousin";
            string location2 = "upstate";
            Vendor newVendor2 = new Vendor(name2, description2, location2);
            List<Vendor> newList = new List<Vendor> { newVendor, newVendor2 };
            List<Vendor> result = Vendor.GetAll();

            CollectionAssert.AreEqual(newList, result);
        }

         [TestMethod]
        public void Find_ReturnsVendorList_Vendor()
        {
            string name = "Carol";
            string description = "neighbor";
            string location = "upstate";
            Vendor newVendor = new Vendor(name, description, location);
            string name2 = "susie";
            string description2 = "cousin";
            string location2 = "upstate";
            Vendor newVendor2 = new Vendor(name2, description2, location2);
            Vendor result = Vendor.Find(2);
            Assert.AreEqual(newVendor2, result);
            CollectionAssert.AreEqual(newList, result);
        }


    }

}