using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltimatePatternKT.Task3
{
    public class Myself : IChatMember
    {
        public IChatMediator Mediator;

        public Myself(IChatMediator mediator)
        {
            Mediator = mediator;
        }

        public void Send(string message)
        {
            Console.WriteLine("Myself is sending a message");
            Mediator.BroadcastMessage(message);
        }
        public void Recieve(string message)
        {
            Console.WriteLine($"Myself has recieved your '{message}' message");
        }
    }
}
