using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltimatePatternKT.Task4
{
    public class FastDeliveryOrder : IOrder
    {
        public int Price { get; set; }
        public string Description { get; set; }

        public FastDeliveryOrder(IOrder order)
        {
            Price = order.Price + 35;
            Description = order.Description + " with faster delivery";
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
