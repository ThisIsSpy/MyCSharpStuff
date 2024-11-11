using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateKT
{
    public class Client
    {
        public Client()
        {
            Operation();
        }
        private void Operation()
        {
            Random rnd = new Random();
            ConcretePrototype1 x = new(rnd.Next(10));
            ConcretePrototype2 y = (ConcretePrototype2)x.Clone();
            int xy = x.Id + y.Id;
            Console.WriteLine(xy);
        }
    }
}
