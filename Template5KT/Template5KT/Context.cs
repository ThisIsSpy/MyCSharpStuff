using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template5KT
{
    public class Context
    {
        public IStrategy ContextStrategy { get; set; }

        public Context(IStrategy contextStrategy)
        {
            ContextStrategy = contextStrategy;
        }
        public void ExecuteAlgorithm()
        {
            ContextStrategy.Algorithm();
        }
    }
}
