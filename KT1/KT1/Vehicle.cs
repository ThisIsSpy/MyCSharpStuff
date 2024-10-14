using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT1
{
    public class Vehicle(float worth, float engineVol): Property(worth)
    {
        public float EngineVol = engineVol;
        public override float TaxCalc()
        {
            return Worth * EngineVol / 3000;
        }
        public override string ToString()
        {
            return $"{GetType().Name}: Worth - {Worth}, Tax - {TaxCalc()}, Engine Volume - {EngineVol}";
        }
    }
}
