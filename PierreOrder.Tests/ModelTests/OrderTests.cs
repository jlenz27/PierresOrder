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
            Order newOrder = new Order("test", "test", "test", 10);
            Assert.AreEqual(typeof(Order), newOrder.GetType());
        }
        [TestMethod]
        public void GetName_ReturnsName_String()
        {
            string name = "flour";
            Order newOrder = new Order(name, "test", "test", 10);
            string result = newOrder.Name;
            Assert.AreEqual(name, result);
        }

        [TestMethod]
        public void GetDescription_ReturnsDescription_String()
        {
            string name = "flour";
            string description = "2 bags";
            Order newOrder = new Order(name, description, "test", 10);
            string result = newOrder.Description;
            Assert.AreEqual(description, result);
        }

        [TestMethod]
        public void GetDate_ReturnsDate_string()
        {
            string name = "flour";
            string description = "2 bags";
            string date = "03-03-23";
            Order newOrder = new Order(name, description, date, 10);
            string result = newOrder.Date;
            Assert.AreEqual(date, result);
        }

        [TestMethod]
        public void GetPrice_ReturnsPrice_int()
        {
            string name = "flour";
            string description = "2 bags";
            string date = "03-03-23";
            int price = 10;
            Order newOrder = new Order(name, description, date, price);
            int result = newOrder.Price;
            Assert.AreEqual(price, result);
        }

        [TestMethod]
        public void GetAll_ReturnsEmptyList_ListOfOrders()
        {
            List<Order> newList = new List<Order> { };
            List<Order> result = Order.GetAll();
            CollectionAssert.AreEqual(newList, result);
        }

    }


}
