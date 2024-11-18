using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template6KT
{
    public class Originator
    {
        public string State { get; set; }

        public Memento CreateMemento()
        {
            return new Memento(State);
        }
        public Originator()
        {

        }
        public void SetMemento(Memento memento)
        {
            State = memento.State;
        }
    }
}
