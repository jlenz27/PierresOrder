using System;
using System.Collections.Generic;

namespace PierreOrder.Models
{
    public class Vendor
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public string Location { get; set; }

        private static List<Vendor> _instances = new List<Vendor> { };


        public Vendor(string name, string description, string location)
        {
            Name = name;
            Description = description;
            Location = location;


        }

        public static List<Vendor> GetAll()
        {
            return _instances;
        }

        public static void ClearAll()
        {
            _instances.Clear();
        }

    }
}