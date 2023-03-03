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
       Order newOrder = new Order();
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

  }

}
