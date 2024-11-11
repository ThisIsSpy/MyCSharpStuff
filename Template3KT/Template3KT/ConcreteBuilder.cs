using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template3KT
{
    public class ConcreteBuilder : Builder
    {
        public ConcreteBuilder()
        {

        }
        public override void BuildPartA()
        {
            throw new NotImplementedException();
        }
        public override void BuildPartB()
        {
            throw new NotImplementedException();
        }
        public override void BuildPartC()
        {
            throw new NotImplementedException();
        }
        public override Product GetResult()
        {
            return new Product();
        }
    }
}
