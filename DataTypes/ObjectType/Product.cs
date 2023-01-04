using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes.ObjectType
{
    public class Product
    {
        public string Name { get; set; }
        public Double Price { get; set; }
        public String Category { get; set; }
        public Product(string name, double price, string category)
        {
            Name = name;
            Price = price;
            Category = category;
        }
    }
}
