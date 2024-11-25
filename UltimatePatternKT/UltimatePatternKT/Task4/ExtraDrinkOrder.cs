using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltimatePatternKT.Task4
{
    public class ExtraDrinkOrder : IOrder
    {
        public int Price { get; set; }
        public string Description { get; set; }

        public ExtraDrinkOrder(IOrder order)
        {
            Price = order.Price + 50;
            Description = order.Description + " with an extra drink";
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
