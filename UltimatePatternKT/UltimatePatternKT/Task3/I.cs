using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltimatePatternKT.Task3
{
    public class I : IChatMember
    {
        public IChatMediator Mediator;

        public I(IChatMediator mediator)
        {
            Mediator = mediator;
        }

        public void Send(string message)
        {
            Console.WriteLine("I is sending a message");
            Mediator.BroadcastMessage(message);
        }
        public void Recieve(string message)
        {
            Console.WriteLine($"I has recieved your '{message}' message");
        }
    }
}
