using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltimatePatternKT.Task4
{
    public class BaseOrder : IOrder
    {
        public int Price { get; set; } = 100;
        public string Description { get; set; } = "An order";
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
