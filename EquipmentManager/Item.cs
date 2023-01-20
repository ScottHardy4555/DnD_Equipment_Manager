using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipmentManager
{
    internal class Item
    {
        public string Name { get; set; }
        public double Value { get; set; }
        public int Weight { get; set; }
        public string Description { get; set; }

        public Item(string name, double value, int weight, string description)
        {
            Name = name;
            Value = value;
            Weight = weight;
            Description = description;
        }
    }
}
