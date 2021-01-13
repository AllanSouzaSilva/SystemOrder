using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace SistemaPedido.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public OrderItem OrderItem { get; set; }
        public Product() { }
        public Product(string  name, double price)
        {
            Name = name;
            Price = price;
        }
    }
}
