using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltimatePatternKT.Task3
{
    public class Me : IChatMember
    {
        public IChatMediator Mediator;

        public Me(IChatMediator mediator)
        {
            Mediator = mediator;
        }

        public void Send(string message)
        {
            Console.WriteLine("Me is sending a message");
            Mediator.BroadcastMessage(message);
        }
        public void Recieve(string message)
        {
            Console.WriteLine($"Me has recieved your '{message}' message");
        }
    }
}
