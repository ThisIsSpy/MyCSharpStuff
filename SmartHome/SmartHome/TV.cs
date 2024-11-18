using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome
{
    public class TV
    {
        private int _currentProgram;
        public bool IsTurnedOn { get; set; }
        public List<string> Programs { get; set; }
        public int CurrentProgram { get { return _currentProgram; } set { if (value < 0) { _currentProgram = 0; } else if (value > Programs.Count - 1) { _currentProgram = Programs.Count - 1; } else { _currentProgram = value; } } }

        public TV(bool isTurnedOn, List<string> programs)
        {
            IsTurnedOn = isTurnedOn;
            Programs = programs;
            CurrentProgram = 0;
        }

        public void SwitchTV(bool Switch)
        {
            IsTurnedOn = Switch;
        }
        public void TurnOnProgram(int program)
        {
            if(IsTurnedOn)
            {
                Console.WriteLine($"Program {Programs[program]} has been turned on");
                CurrentProgram = program;
            }
            else
            {
                Console.WriteLine("The TV is off, cannot turn on programs");
            }
        }
        public override string ToString()
        {
            return $"Is On: {IsTurnedOn}; Current Program: {Programs[CurrentProgram]}";
        }
    }
}
