using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome
{
    public class Light
    {
        private int _brightness;
        public bool IsTurnedOn { get; set; }
        private int Brightness { get { return _brightness; } set { if (value > 10) { _brightness = 10; } else if (value < 0) { _brightness = 0; } else { _brightness = value; } } }
        public Color Color { get; set; }

        public Light(int brightness, bool isTurnedOn, Color color)
        {
            Brightness = brightness;
            IsTurnedOn = isTurnedOn;
            Color = color;
        }

        public void SwitchLight(bool Switch)
        {
            IsTurnedOn = Switch;
        }
        public void ChangeBrightness(int brightness)
        {
            Brightness = brightness;
        }
        public void ChangeColor(int color)
        {
            switch(color)
            {
                case 0:
                    Color = Color.Red;
                    break;
                case 1:
                    Color = Color.Green;
                    break;
                case 2:
                    Color = Color.Blue;
                    break;
                case 3:
                    Color = Color.Yellow;
                    break;
                default:
                    Color = Color.White;
                    break;
            }
        }
        public override string ToString()
        {
            return $"Is On: {IsTurnedOn}; Brightness: {Brightness}; Color: {Color};";
        }
    }
}
