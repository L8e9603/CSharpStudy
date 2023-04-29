using System.Collections.Generic;

namespace LINQ
{
    public class OrderItem
    {
        public OrderItem()
        {

        }
        public OrderItem(long iD, string name, decimal price, uint quantity)
        {
            ID = iD;
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public long ID { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public uint Quantity { get; set; }
    }
}
