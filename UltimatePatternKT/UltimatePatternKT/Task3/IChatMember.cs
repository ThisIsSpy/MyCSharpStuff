using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltimatePatternKT.Task3
{
    public interface IChatMember
    {
        public void Send(string message);
        public void Recieve(string message);
    }
}
