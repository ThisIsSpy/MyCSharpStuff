using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltimatePatternKT.Task3
{
    public class BigBrother : IChatMediator
    {
        public List<IChatMember> Members { get; set; }

        public BigBrother()
        {
            Members = new();
        }

        public void RegisterMember(IChatMember member)
        {
            Members.Add(member);
        }
        public void UnregisterMember(IChatMember member)
        {
            Members.Remove(member);
        }
        public void BroadcastMessage(string message)
        {
            foreach (IChatMember member in Members)
            {
                member.Recieve(message);
            }
        }
    }
}
