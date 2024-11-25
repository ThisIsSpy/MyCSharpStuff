using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltimatePatternKT.Task3
{
    public interface IChatMediator
    {
        public void RegisterMember(IChatMember chatMember);
        public void UnregisterMember(IChatMember chatMember);
        public void BroadcastMessage(string message);
    }
}
