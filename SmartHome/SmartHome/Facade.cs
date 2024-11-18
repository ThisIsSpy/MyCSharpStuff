using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome
{
    public class Facade
    {
        public Engine engine;
        public MusicPanel panel;

        public Facade(Engine engine, MusicPanel panel)
        {
            this.engine = engine;
            this.panel = panel;
        }

        public void TurnOnEngine()
        {
            engine.TurnOn();
        }
        public void TurnOffEngine()
        {
            engine.TurnOff();
        }
        public void TurnOnMusicPanel()
        {
            panel.TurnOn();
        }
        public void TurnOffMusicPanel()
        {
            panel.TurnOff();
        }
    }
}
