using System;
using System.Collections.Generic;

namespace PierreOrder.Models
{
    public class Order
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Date { get; set; }

        public string Price { get; set; }

       private static List<Order> _instances = new List<Order> { };


        public Order(string name, string description, string date, string price)
        {
            Name = name;
            Description = description;
            Date = date;
            Price = price;
            //_instances.Add(this);
        }



        public static List<Order> GetAll()
        {
            return _instances;
        }

    }



}