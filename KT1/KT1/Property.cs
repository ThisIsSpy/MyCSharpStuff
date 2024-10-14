using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT1
{
    public abstract class Property (float worth)
    {
        public float Worth = worth;

        public virtual float TaxCalc()
        {
            return Worth;
        }
    }
}
