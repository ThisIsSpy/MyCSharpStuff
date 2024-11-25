using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltimatePatternKT.Task4
{
    public interface IOrder
    {
        public int Price { get; set; }
        public string Description { get; set; }
        public int GetPrice();
        public string GetDescription();
    }
}
