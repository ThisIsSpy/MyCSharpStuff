using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template2KT
{
    public abstract class Creator
    {
        public Creator()
        {

        }
        public abstract Product FactoryMethod(string x, int y);
    }
}
