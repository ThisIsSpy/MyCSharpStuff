using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template2KT
{
    public class ConcreteCreatorA: Creator
    {
        public ConcreteCreatorA(string x, int y)
        {
            FactoryMethod(x, y);
        }
        public override Product FactoryMethod(string name, int age)
        {
            return new ConcreteProductA(name,age);
        }
    }
}
