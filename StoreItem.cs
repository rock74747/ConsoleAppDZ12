using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDZ12
{
    public class StoreItem : IStoreItem
    {
        public long ItemId { get; set; }
        public double Price { get; set;}
        public StoreItem (long itemId, double price) {
            ItemId = itemId;
            Price = price;
        }
    }

}
