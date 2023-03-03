using System;
using System.Collections.Generic;

namespace PierreOrder.Models
{
    public class Order
    {
        public string Name { get; set; }
        public string Description {get; set; }

        public string Date {get; set; }

        public Order(string name, string description, string date)
        {
            Name = name;
            Description = description;
            Date = date;

        }



    }



}