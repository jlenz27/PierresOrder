using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PierreOrder.Models;
using System;

namespace PierreOrder.Tests
{
    [TestClass]
    public class ItemTests
    {
        [TestMethod]
        public void ItemConstructor_CreatesInstanceOfItem_Item()
        {
            Order newOrder = new Order("test");
            Assert.AreEqual(typeof(Order), newOrder.GetType());
        }
        [TestMethod]
        public void GetName_ReturnsName_String()
        {
            string name = "flour";
            Order newOrder = new Order(name);
            string result = newOrder.Name;
            Assert.AreEqual(name, result);
        }

        [TestMethod]
        public void GetDescription_ReturnsDescription_String()
        {
            string name = "flour";
            string description = "2 bags";
            Order newOrder = new Order(name, description);
            string result = newOrder.Description;
            Assert.AreEqual(name, result);
        }
    }

}
