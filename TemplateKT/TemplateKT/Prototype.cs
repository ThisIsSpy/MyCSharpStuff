using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateKT
{
    public abstract class Prototype
    {
        public int Id;
        
        public Prototype(int id)
        {
            Id = id;
        }

        public abstract Prototype Clone();
    }
}
