using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome
{
    public class SmartHome
    {
        public Light Light { get; set; }
        public TV TV { get; set; }
        public AirConditioner AC { get; set; }
        public MusicStation MusicStation { get; set; }

        public SmartHome(Light light, TV tv, AirConditioner ac, MusicStation musicStation)
        {
            Light = light;
            TV = tv;
            AC = ac;
            MusicStation = musicStation;
        }

        public void SetUpHome(int mode)
        {
            switch(mode)
            {
                case 0:
                    Light.SwitchLight(false);
                    TV.SwitchTV(false);
                    AC.SwitchAC(true);
                    AC.SetTemperature(20);
                    MusicStation.Switch(false);
                    break;
                case 1:
                    Light.SwitchLight(false);
                    TV.SwitchTV(true);
                    TV.TurnOnProgram(0);
                    AC.SwitchAC(false);
                    MusicStation.Switch(false);
                    break;
                case 2:
                    Light.SwitchLight(true);
                    Light.ChangeBrightness(8);
                    Light.ChangeColor(3);
                    TV.SwitchTV(false);
                    AC.SwitchAC(false);
                    MusicStation.Switch(true);
                    MusicStation.SetMusic(0);
                    break;
                default:
                    Light.SwitchLight(true);
                    Light.ChangeBrightness(10);
                    Light.ChangeColor(-1);
                    TV.SwitchTV(true);
                    TV.TurnOnProgram(0);
                    AC.SwitchAC(true);
                    AC.SetTemperature(24);
                    MusicStation.Switch(true);
                    MusicStation.SetMusic(0);
                    break;
            }
        }
    }
}
