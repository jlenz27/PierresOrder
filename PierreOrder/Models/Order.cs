using System;
using System.Collections.Generic;

namespace PierreOrder.Models
{
    public class Order
    {
    public int Id { get; }
    public string Title { get; set; }
    public string Details { get; set; }
    public string Date { get; set; }
    public string Price { get; set; }
    public string Description { get; set; }

        private static List<Order> _instances = new List<Order>{};

    public Order(string title, string details, string date, string price, string description)
    {
      Title = title;
      Details = details;
      Price = price;
      Date = date;
      Description = description;
      Id = _instances.Count;
      _instances.Add(this);
    }

      


        public static List<Order> GetAll()
    {
      return _instances;
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
    public static Order Find(int searchId)
    {
      return _instances[searchId -1];
    }
    
  }
}
