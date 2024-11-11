using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template2KT
{
    public class ConcreteProductB : Product
    {
        private string _name;
        public override string Name {  get { return _name; } set { _name = value; } }
        public int Quantity;
        public ConcreteProductB(string name, int quantity)
        {
            Name = name;
            Quantity = quantity;
        }
    }
}
