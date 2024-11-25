using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltimatePatternKT.Task4
{
    public class PackagingOrder : IOrder
    {
        public int Price { get; set; }
        public string Description { get; set; }

        public PackagingOrder(IOrder order)
        {
            Price = order.Price + 20;
            Description = order.Description + " with packaging";
        }

        public int GetPrice()
        {
            return Price;
        }
        public string GetDescription()
        {
            return Description;
        }
    }
}
