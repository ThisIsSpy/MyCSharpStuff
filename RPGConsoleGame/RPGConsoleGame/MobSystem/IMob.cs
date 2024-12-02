using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGConsoleGame.MobSystem
{
    public interface IMob
    {
        public int MaxHP { get; set; }
        public int HP { get; set; }
        public int ATK { get; set; }
        public int CritChance { get; set; }
        public int DodgeChance { get; set; }

    }
}
