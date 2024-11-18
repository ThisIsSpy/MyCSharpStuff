using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template5KT
{
    public class ConcreteStrategyB: IStrategy
    {
        public void Algorithm()
        {
            Console.WriteLine("the enemy is far away, switching to Sniper tactic");
        }
        public ConcreteStrategyB()
        {

        }
    }
}
