using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PierreOrder.Models;
using System;

namespace PierreOrder.Tests
{
    [TestClass]
    public class ItemTests : IDisposable
    {
        public void Dispose()
        {
            Order.ClearAll();
        }

        [TestMethod]
        public void ItemConstructor_CreatesInstanceOfItem_Item()
        {
            Order newOrder = new Order("test", "test", "test", "10", "test");
            Assert.AreEqual(typeof(Order), newOrder.GetType());
        }
        [TestMethod]
        public void GetName_ReturnsName_String()
        {
            string title = "flour";
            Order newOrder = new Order(title, "test", "test", "10", "test");
            string result = newOrder.Title;
            Assert.AreEqual(title, result);
        }

        [TestMethod]
        public void GetDescription_ReturnsDescription_String()
        {
            string title = "flour";
            string description = "2 bags";
            Order newOrder = new Order(title, description, description, description, description);
            string result = newOrder.Description;
            Assert.AreEqual(description, result);
        }

        [TestMethod]
        public void GetDate_ReturnsDate_string()
        {
            string title = "flour";
            string description = "2 bags";
            string date = "03-03-23";
            Order newOrder = new Order(title, description, date, "10", "test");
            string result = newOrder.Date;
            Assert.AreEqual(date, result);
        }

        [TestMethod]
        public void GetPrice_ReturnsPrice_int()
        {
            string title = "flour";
            string description = "2 bags";
            string date = "03-03-23";
            string price = "10";
            string vendorName = "alice";
            Order newOrder = new Order(title, description, date, price, vendorName);
            string result = newOrder.Price;
            Assert.AreEqual(price, result);
        }

        [TestMethod]
        public void GetAll_ReturnsEmptyList_ListOfOrders()
        {
            List<Order> newList = new List<Order> { };
            List<Order> result = Order.GetAll();
            CollectionAssert.AreEqual(newList, result);
        }

        [TestMethod]
        public void GetAll_ReturnsItems_ItemList()
        {
            string title = "flour Order";
            string description = "2 bags";
            string date = "03-03-23";
            string price = "10";
            string vendorName = "alice";

            Order newOrder1 = new Order(title, description, date, price, vendorName);
            string title2 = "Milk Order";
            string description2 = "4 gallons";
            string date2 = "03-01-23";
            string price2 = "15.00";
            string vendorName2 = "steph";

            Order newOrder2 = new Order(title2, description2, date2, price2, vendorName2);
            List<Order> newList = new List<Order> { newOrder1, newOrder2 };
            List<Order> result = Order.GetAll();

            CollectionAssert.AreEqual(newList, result);
        }

        [TestMethod]

        public void Find_ReturnsItemsID_Order()
        {
            string title = "flour Order";
            string description = "2 bags";
            string date = "03-03-23";
            string price = "10";
            string vendorName = "alice";
            Order newOrder1 = new Order(title, description, date, price, vendorName);
            string title2 = "Milk Order";
            string description2 = "4 gallons";
            string date2 = "03-01-23";
            string price2 = "15.00";
            string vendorName2 = "steph";

            Order newOrder2 = new Order(title2, description2, date2, price2, vendorName2);
            Order result = Order.Find(2);
            Assert.AreEqual(newOrder2, result);


        }


    }

}
