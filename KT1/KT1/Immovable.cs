using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT1
{
    public class Immovable(float worth, float area): Property(worth)
    {
        public float Area = area;

        public override float TaxCalc()
        {
            if (Area < 100) return Worth / 500;
            else if (Area > 100 || Area < 300) return Worth / 350;
            else return Worth / 250;
        }
        public override string ToString()
        {
            return $"{GetType().Name}: Worth - {Worth}, Tax - {TaxCalc()}, Area - {Area}";
        }
        public float CostPerMSq()
        {
            return Worth / Area;
        }
    }
}
