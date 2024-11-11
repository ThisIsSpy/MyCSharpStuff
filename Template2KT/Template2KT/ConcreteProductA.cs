using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template2KT
{
    public class ConcreteProductA : Product
    {
        private string _name;
        public override string Name { get { return _name; } set { _name = value; } }
        public int Age;
        public ConcreteProductA(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
