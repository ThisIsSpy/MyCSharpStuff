using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template4KT
{
    public class Singleton
    {
        private static Singleton? singletonInstance;
        public string Surname = "Bean";

        public static Singleton GetInstance()
        {
            if(singletonInstance==null)
            {
                singletonInstance = new Singleton();
            }
            return singletonInstance;
        }
    }
}
