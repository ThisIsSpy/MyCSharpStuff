using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template3KT
{
    public class Product
    {
        private List<object> parts;

        public Product()
        {
            parts = [];
        }
        public void Add(string part)
        {
            parts.Add(part);
        }
    }
}
