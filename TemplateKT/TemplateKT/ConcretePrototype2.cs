using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateKT
{
    public class ConcretePrototype2 : Prototype
    {
        public ConcretePrototype2(int id) : base(id)
        {
            Id = id;
        }
        public override Prototype Clone()
        {
            return new ConcretePrototype2(Id);
        }
    }
}
