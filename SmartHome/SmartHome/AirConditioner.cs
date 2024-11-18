using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome
{
    public class AirConditioner
    {
        public bool IsTurnedOn { get; set; }
        public int Temperature { get; set; }

        public AirConditioner(bool isTurnedOn, int temperature)
        {
            IsTurnedOn = isTurnedOn;
            Temperature = temperature;
        }

        public void SwitchAC(bool Switch)
        {
            IsTurnedOn = Switch;
        }
        public void SetTemperature(int temperature)
        {
            Temperature = temperature;
        }
        public override string ToString()
        {
            return $"Is On: {IsTurnedOn}; Temperature: {Temperature}";
        }
    }
}
