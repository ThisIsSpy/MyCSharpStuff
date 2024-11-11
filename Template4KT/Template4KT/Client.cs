using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template4KT
{
    public class Client
    {
        public string Name;
        public Client(string name)
        {
            Name = name;
        }
        public string SayMyName()
        {
            Singleton inst = Singleton.GetInstance();
            return Name + inst.Surname;
        }
    }
}
