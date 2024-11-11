using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template2KT
{
    public class ConcreteCreatorB : Creator
    {
        public ConcreteCreatorB(string x, int y)
        {
            FactoryMethod(x, y);
        }
        public override Product FactoryMethod(string name, int quantity)
        {
            return new ConcreteProductB(name, quantity);
        }
    }
}
