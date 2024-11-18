using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template5KT
{
    public class ConcreteStrategyA : IStrategy
    {
        public void Algorithm()
        {
            Console.WriteLine("the enemy is close, switching to Assault tactic");
        }
        public ConcreteStrategyA()
        {

        }
    }
}
